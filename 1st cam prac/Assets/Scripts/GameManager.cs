using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float startingSeconds = 900;
    private float secondsRemaining;
    public int lastPuzzleSolved = 0;
    public bool lightsOn;
    public Text myText;
    public bool inputtingText = false;

    public Vector3 lastCameraPos;
    public GameObject myCam;

    //private GameObject interact;
    public Canvas inventoryCanvas;


    void Start()
    {

        //interact = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (lightsOn)
        {
            lastPuzzleSolved = 2;
        }
        else if (!lightsOn && inventoryCanvas.GetComponent<Inventory>().inventorymap["Key"])
        {
            lastPuzzleSolved = 1;
        }
        else
        {
            lastPuzzleSolved = 0;
        }
        secondsRemaining = startingSeconds - Time.time;
        int minutes = Mathf.FloorToInt(secondsRemaining / 60);
        int seconds = Mathf.FloorToInt(secondsRemaining - (minutes * 60));
        if (seconds < 10)
        {
            myText.text = "Time remaining: " + minutes.ToString() + ":0" + seconds.ToString();
        }
        else
        {
            myText.text = "Time remaining: " + minutes.ToString() + ":" + seconds.ToString();
        }
        if (secondsRemaining <= 0)
        {
            LostGame();
        }

    }

    public void LostGame()
    {
        lastCameraPos = myCam.transform.position;
        SceneManager.LoadScene("Lose");
    }

}

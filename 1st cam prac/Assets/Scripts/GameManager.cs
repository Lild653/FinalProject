using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float startingSeconds = 900; 

    public int lastPuzzleSolved = 0;
    public bool lightsOn;
    public Text myText;
    public bool inputtingText = false;
    public GameObject myCam;
    public Canvas inventoryCanvas;
    public static Vector3 lastCameraPos;
    public static Quaternion lastCameraRot;
    public static float secondsRemaining;
    public GameObject pause1;
    public GameObject pause2;
    private float pauseTime;
    private System.Boolean paused;
    private float timeOffSet;
    private float timeSincePause = 0;
    private float totalPause = 0;
    System.Boolean wasPaused;
    private string[] hints;
    public Text myHints;
    private float time;
    public GameObject hintCanvas;

    void Start()
    {
        startingSeconds = 900;
        secondsRemaining = startingSeconds;
        myHints = hintCanvas.GetComponent<Text>();
        paused = false;
        wasPaused = false;
        timeOffSet = 0;
        pause1.SetActive(true);
        


        time = Time.time;
        hintCanvas.SetActive(false);
        hints = new string[5];
        hints[0] = "If only there was a way to unlock the lock";
        hints[1] = "Know your ABC's, not just your 123's";
        hints[2] = "I wonder if you ever found that note I left you";
        hints[3] = "Take a page out of Caesar's cryptography. The last sentence should help";
    }

    // Update is called once per frame
    void Update()
    {
        if (lightsOn && !inventoryCanvas.GetComponent<Inventory>().inventorymap["Letter"])
        {
            lastPuzzleSolved = 2;
        }
        else if (lightsOn && inventoryCanvas.GetComponent<Inventory>().inventorymap["Letter"])
        {
            lastPuzzleSolved = 3;
        }




        if (pause1.activeSelf == false && pause2.activeSelf == false) {
            if (wasPaused)
            {
                totalPause += timeSincePause;
                wasPaused = false;
            }


            secondsRemaining = startingSeconds - (Time.time - totalPause);
            paused = false;

        }
        else if (paused)
        {
            timeSincePause = Time.time - pauseTime;

            secondsRemaining = startingSeconds - pauseTime + totalPause;
            wasPaused = true;
        }
        else
        {
            pauseTime = Time.time;
            paused = true;
        }


        secondsRemaining = startingSeconds - Time.time;
        if (secondsRemaining <= 0)
        {
            LostGame();
        }
        else
        {
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
        }
        

        if(!inputtingText)
        {
            hintSystem();
        }
    }

    public void LostGame()
    {
        lastCameraPos = myCam.transform.position;
        lastCameraRot = myCam.transform.rotation;
        SceneManager.LoadScene("Lose");
    }

    public string WinTime()
    {
        int minutes = Mathf.FloorToInt(secondsRemaining / 60);
        int seconds = Mathf.FloorToInt(secondsRemaining - (minutes * 60));
        if (seconds < 10)
        {
            return minutes.ToString() + ":0" + seconds.ToString();
        }
        else
        {
            return minutes.ToString() + ":" + seconds.ToString();
        }
    }


    public void hintSystem()
    {

        if (Input.GetKey(KeyCode.H))
        {
            float lastPressed = Time.time;
            if (lastPressed - time > 0.2)
            {

                time = lastPressed;
                switch (lastPuzzleSolved)
                {
                    case 0:
                        myHints.text = hints[0];
                        
                        break;

                    case 1:
                        myHints.text = hints[1];
              
                        break;

                    case 2:
                        myHints.text = hints[2];

                        break;

                    case 3:
                        myHints.text = hints[3];

                        break;

                }
                hintCanvas.SetActive(!hintCanvas.activeSelf);
            }




        }
    }

    public Vector3 finalCameraPos()
    {
        return lastCameraPos;
    }

    public Quaternion finalCameraRot()
    {
        return lastCameraRot;
    }

}

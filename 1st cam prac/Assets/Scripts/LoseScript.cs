using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    private float startingSeconds = 5;
    public GameObject lostScreen;
    // Start is called before the first frame update
    void Start()
    {
        lostScreen.SetActive(false);
        print("here");
    }

    // Update is called once per frame
    void Update()
    {
        startingSeconds = startingSeconds - Time.deltaTime;
        //print(startingSeconds);
        if (startingSeconds <= 0)
        
        //if (Time.time <= 20.0)
        {
            lostScreen.SetActive(true);
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene("Demo");
    }

    public void Exit()
    {
        Debug.Log("EXITED GAME");
        Application.Quit();
    }
}

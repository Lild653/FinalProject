using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float startingSeconds = 245;
    private float secondsRemaining;
    public int lastPuzzleSolved = 0;
    public bool lightsOn;
    //private GameObject interact;


    void Start()
    {
        //interact = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        secondsRemaining = startingSeconds - Time.time;
        int minutes = Mathf.FloorToInt(secondsRemaining / 60);
        int seconds = Mathf.FloorToInt(secondsRemaining - (minutes * 60));
        if (seconds < 10)
        {
            //print("Time remaining: " + minutes.ToString() + ":0" + seconds.ToString());
        }
        else
        {
            //print("Time remaining: " + minutes.ToString() + ":" + seconds.ToString());
        }

    }
}

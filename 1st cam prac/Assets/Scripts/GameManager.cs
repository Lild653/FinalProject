using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float startingSeconds = 245;
    private float secondsRemaining;
    public Text myText;
    public int lastPuzzleSolved = 0;
    //private GameObject interact;


    void Start()
    {
        //interact = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        secondsRemaining = startingSeconds - Time.time;
        int cats = Mathf.FloorToInt(secondsRemaining / 60);
        int dogs = Mathf.FloorToInt(secondsRemaining - (cats * 60));
        if (dogs < 10)
        {
            myText.text = "Time remaining: " + cats.ToString() + ":0" + dogs.ToString();
        }
        else
        {
            myText.text = "Time remaining: " + cats.ToString() + ":" + dogs.ToString();
        }

    }
}

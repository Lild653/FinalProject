using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintStuff : MonoBehaviour
{
    //public GameObject hintDisplay = GameObject.FindGameObjectWithTag("NewHint");
    private string[] hints;
    public Text mytext;
    private int puzzleNumber;
    public GameObject gameManager;
    public float time;
    public GameObject hintCanvas; 


    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
        hintCanvas.SetActive(false);
        hints = new string[3];
        hints[0] = "Find key to unlock";
        hints[1] = "Know your ABC's";
        hints[2] = "Last sentence of letter";

        
    }

    // Update is called once per frame
    void Update()
    {
        puzzleNumber = gameManager.GetComponent<GameManager>().lastPuzzleSolved;

        if (Input.GetKey(KeyCode.H))
        {
            switch (puzzleNumber)
            {
                case 0:
                    mytext.text = hints[0];
                    break;

                case 1:
                    mytext.text = hints[1];
                    break;

                case 2:
                    mytext.text = hints[2];
                    break;

            }
            float lastPressed = Time.time;
            if (lastPressed - time > 0.1)
            {
                hintCanvas.SetActive(!hintCanvas.activeSelf);
                time = lastPressed;
            }
          
            

        }
        
      
         
        
    }
}

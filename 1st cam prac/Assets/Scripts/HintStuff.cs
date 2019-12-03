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


    // Start is called before the first frame update
    void Start()
    {
        
        gameObject.GetComponent<Text>().enabled = false;
        hints = new string[3];
        hints[0] = "Find key to unlock";
        hints[1] = "Know your ABC's";
        hints[2] = "Last sentence of letter";

        
    }

    // Update is called once per frame
    void Update()
    {
        puzzleNumber = gameManager.GetComponent<GameManager>().lastPuzzleSolved;
        if (Input.GetKeyDown(KeyCode.H))
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

            gameObject.GetComponent<Text>().enabled = true;

        }

        else if (Input.GetKeyUp(KeyCode.H))
        {
           gameObject.GetComponent<Text>().enabled = false;
        }
    }
}

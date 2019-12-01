using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintStuff : MonoBehaviour
{
    //public GameObject hintDisplay = GameObject.FindGameObjectWithTag("NewHint");
    private string[] hints;
    private Text mytext;
    private int cats = 0;
    public GameObject gameManager;


    // Start is called before the first frame update
    void Start()
    {
        cats = gameManager.GetComponent<GameManager>().lastPuzzleSolved;
        hints = new string[3];
        hints[0] = "Find kind to unlock";
        hints[1] = "Know your ABC's";
        hints[2] = "Last sentence of letter";

        
    }

    // Update is called once per frame
    void Update()
    {
        
    
       
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            switch (cats)
            {
                case 0:
                    mytext.text = hints[0];
                    break;

                case 1:
                    mytext.text = hints[0];
                    break;

                case 2:
                    mytext.text = hints[0];
                    break;

            }

            gameObject.GetComponent<Text>().enabled = true;

        }
        else
        {
            gameObject.GetComponent<Text>().enabled = true;
        }
        

        
        
    }
}

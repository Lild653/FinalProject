using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public Text instructionsText;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.SetActive(false);
        }
    }


    public void LetterInstructions()
    {
        instructionsText.text = "You have found the letter! Press 'L' to open and close the letter at any point.";
        gameObject.SetActive(true);
    }

    public void BoxInstructions()
    {
        instructionsText.text = "You found the wires! Point the reticle at a wire and press 'A' to change the color. Get the correct color pattern to turn the lights on.";
        gameObject.SetActive(true);
    }
}

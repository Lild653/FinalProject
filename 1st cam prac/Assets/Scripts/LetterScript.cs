using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterScript : MonoBehaviour
{
    public GameObject letterCanvas;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        letterCanvas.SetActive(false);
        //letterCanvas.GetChild<Text>().SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            letterCanvas.SetActive(true);
            if (gameManager.GetComponent<GameManager>().lightsOn == true)
            {
                //set text active too
            }
        }
    }
}

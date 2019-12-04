using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterScript : MonoBehaviour
{
    public GameObject letterCanvas;
    public GameObject gameManager;
    public Text letterText;
    // Start is called before the first frame update
    void Start()
    {
        letterCanvas.SetActive(false);
        //letterCanvas.GetChild<Text>().SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L) && !gameManager.GetComponent<GameManager>().inputtingText)
        {
            letterCanvas.SetActive(true);
            if (gameManager.GetComponent<GameManager>().lightsOn == true)
            {
                letterText.text = "YoU thought you could get away with betraying me, but you won't. AFter the grounds flood you will die, all evidence will Go away, and no one will ever know what Ive done. As one final quest, Ive given you some opportunities to escape. I dont think you can figuRe it out, but Id jUST love to see you die trying. A mere door stands between you and your freedom. Its locked, of course. crack the code within three tries and youll escape. Fail, and you will meet your untimely fate. Dont worry-- Ill give you a +2 to your own funeral. The clock is ticking.";
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadLock : MonoBehaviour
{
    public GameObject door;             
    public InputField textField;
    public GameObject screen;
    public GameObject gameManager;
    public Text explanationText;
    public AudioClip wrongPassword;
    public AudioClip correct;

    private string password = "whistle";
    private string hintTrigger = "ufgqrjc";
    private int numTries = 3;
    private AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(false);
        myAudioSource = GetComponent<AudioSource>();
    }


    public void EnterInput()
    {
        if (numTries > 0)
        {
            gameManager.GetComponent<GameManager>().inputtingText = true;
            screen.SetActive(true);
            var eventListener = new InputField.SubmitEvent();
            eventListener.AddListener(PasswordEntered);
            textField.onEndEdit = eventListener;
        }
        
    }

    void Unlock()
    {
        door.GetComponent<FinalDoorScript>().OpenDoor();

    }

    void PasswordEntered(string myuserInput)
    {
        if(myuserInput.Equals(password))
        {
            AudioClip clip = correct;
            myAudioSource.PlayOneShot(correct);
            screen.SetActive(false);
            Unlock();
        }
        else
        {
            AudioClip clip = wrongPassword;
            myAudioSource.PlayOneShot(clip);
            if (myuserInput.Equals(hintTrigger))
            {
                explanationText.text = "You're getting warmer. Hint 3 could be of use...";
            }
            numTries--;
            if (numTries == 0)
            {
                gameManager.GetComponent<GameManager>().LostGame();
            }
            string newText = "ENTER PASSWORD TO UNLOCK DOOR. YOU HAVE " + numTries;
            if (numTries == 1)
            {
                newText += " TRY REMAINING.";
            }
            else
            {
                newText += " TRIES REMAINING";
            }
            explanationText.text = newText;
        }
    }
}

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

    private string password = "whistle";
    private string hintTrigger = "ufgqrjc";
    private int numTries = 3;

    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(false);
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
            screen.SetActive(false);
            Unlock();
        }
        else
        {
            if (myuserInput.Equals(hintTrigger))
            {
                print("You're getting warmer. Hint 3 could be of use...");
            }
            numTries--;
            print("Password is incorrect. You have " + numTries + " remaining.");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadLock : MonoBehaviour
{
    public GameObject door;             //GameObject that is currently in "locked" state
    public GameObject textFieldObject;
    public InputField textField;

    private string password = "ABCD";
    private string userInput = "";
    private int numTries = 3;
    // Start is called before the first frame update
    void Start()
    {
        textFieldObject.SetActive(false);
        //var eventListener = new InputField.SubmitEvent();
        //eventListener.AddListener(PasswordEntered);
        //textField.onEndEdit = eventListener;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit cast = new RaycastHit();
            System.Boolean objectHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out cast);    
            if (objectHit)
            {
                if (cast.transform.gameObject.name == "Keypad" && numTries > 0)     //check that user clicked on keypad
                {
                    textFieldObject.SetActive(true);
                    var eventListener = new InputField.SubmitEvent();
                    eventListener.AddListener(PasswordEntered);
                    textField.onEndEdit = eventListener;
                    userInput = textField.text;
                    //if (Input.GetKeyDown(KeyCode.KeypadEnter))
                    //{
                    //    if (userInput.Equals(password))
                    //    {
                    //        Unlock();
                    //    }
                    //    else
                    //    {
                    //        numTries--;
                    //        print("Password is incorrect. You have " + numTries + " remaining.");
                    //    }
                    //}
                }
            }
        }
        
    }

    void Unlock()
    {
        print("Unlocked!");
        //delete door
        //Instantiate new open door
    }

    void PasswordEntered(string userInput)
    {
        if(userInput.Equals(password))
        {
            Unlock();
        }
        else
        {
            numTries--;
            print("Password is incorrect. You have " + numTries + " remaining.");
        }
    }
}

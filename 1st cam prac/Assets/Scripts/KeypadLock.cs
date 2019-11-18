using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadLock : MonoBehaviour
{
    public GameObject door;             //GameObject that is currently in "locked" state

    private string password = "ABCD";
    private string userInput = "";
    // Start is called before the first frame update
    void Start()
    {
        
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
                if (cast.transform.gameObject.name == "Keypad")     //check that user clicked on keypad
                {
                    //set up display of user's typing
                    userInput += Input.inputString;
                    print(userInput);
                    if (Input.GetKeyDown(KeyCode.KeypadEnter))
                    {
                        if (userInput.Equals(password))
                        {
                            Unlock();
                        }
                        else
                        {
                            print("Password is incorrect.");
                        }
                    }
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
}

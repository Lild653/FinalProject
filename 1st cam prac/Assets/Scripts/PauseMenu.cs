using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu1;
    public Canvas inventoryCanvas;
    public float time;
    public GameObject pauseMenu2;
    //public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu1.SetActive(false);
        pauseMenu2.SetActive(false);
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.P))
        {
            float lastPressed = Time.time;
            if (lastPressed - time > .1)
            {
                if (inventoryCanvas.GetComponent<Inventory>().inventorymap["Letter"])
                {
                    pauseMenu2.SetActive(!pauseMenu2.activeSelf);
                    time = lastPressed;
                }
                else
                {
                    pauseMenu1.SetActive(!pauseMenu1.activeSelf);
                    time = lastPressed;
                }
            }


        }

        
    }
}

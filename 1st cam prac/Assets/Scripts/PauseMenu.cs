using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public float time;
    //public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.P))
        {
            float lastPressed = Time.time;
            if (lastPressed - time > 1)
            {
                pauseMenu.SetActive(!pauseMenu.activeSelf);
                time = lastPressed;
            }

        }

        
    }
}

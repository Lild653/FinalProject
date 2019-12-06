using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public Canvas pauseMenu;
    //public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pauseMenu.enabled && Input.GetKey(KeyCode.P))
        {
            pauseMenu.enabled = true;

        }

        if (pauseMenu.enabled)
        {
            if (Input.GetKey(KeyCode.P))
            {
                pauseMenu.enabled = false;
            }
        }
    }
}

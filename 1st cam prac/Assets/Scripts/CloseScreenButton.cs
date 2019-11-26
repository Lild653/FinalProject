using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseScreenButton : MonoBehaviour
{
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Close()
    {
        screen.SetActive(false);
    }
}

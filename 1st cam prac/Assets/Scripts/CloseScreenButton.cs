using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseScreenButton : MonoBehaviour
{
    public GameObject screen;

    public void Close()
    {
        screen.SetActive(false);
    }
}

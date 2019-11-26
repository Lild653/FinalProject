using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorScript : MonoBehaviour
{
    Animator openDoorAnimate;

    private void Start()
    {
        openDoorAnimate = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        openDoorAnimate.SetTrigger("OpenDoor");
    }
}

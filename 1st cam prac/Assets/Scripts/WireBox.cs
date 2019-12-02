﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBox : MonoBehaviour
{
    Animator unlockBoxAnimate;
    public GameObject locked;
    public GameObject unlocked;
    // Start is called before the first frame update
    void Start()
    {
        unlocked.SetActive(false);
        unlockBoxAnimate = GetComponent<Animator>();
    }

    public void Unlock()
    {
        locked.SetActive(false);
        unlocked.SetActive(true);
        unlockBoxAnimate.SetTrigger("UnlockBox");
    }
}

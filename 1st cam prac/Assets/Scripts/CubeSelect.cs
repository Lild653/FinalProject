﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSelect : MonoBehaviour


{
    //public GameObject iteme;
    public Canvas interactive;
    public Canvas inventoryCanvas;
    public GameObject key;
    public GameObject[] Pickupitems;
    private RaycastHit vision;


    // Start is called before the first frame update
    void Start()
    {
        interactive.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {


        //System.Boolean objetoHit = Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3((0.5f) * Screen.width, (0.5f)* Screen.height,0)), out vision);

        ArrayList newList = new ArrayList();
        foreach (GameObject items in Pickupitems)
        {
            newList.Add(items);
        }

        foreach (GameObject currObject in Pickupitems)
        {
            if (Vector3.Angle(transform.forward, currObject.transform.position - transform.position) < 15 && Math.Abs(currObject.transform.position.z-transform.position.z)<2.5)
            {
                interactive.enabled = true;
                if (Input.GetKey(KeyCode.F))
                {
                    if (currObject.CompareTag("Interact"))
                    {
                        if (currObject.name.Equals("UnlockBoxParent") && inventoryCanvas.GetComponent<Inventory>().inventorymap["Key"])
                        {
                            currObject.GetComponent<WireBox>().Unlock();
                        }
                        if (currObject.name.Equals("Plate") || currObject.name.Equals("lock_1_open") && inventoryCanvas.GetComponent<Inventory>().inventorymap["Key"])
                        {
                            currObject.GetComponentInParent<WireBox>().Unlock();
                        }
                        if (currObject.name.Equals("Sofa"))
                        {
                            newList.Remove(currObject);
                            key.GetComponent<Animator>().SetTrigger("CollectKey");
                            inventoryCanvas.GetComponent<Inventory>().OnCollect(key);
                            Pickupitems = new GameObject[newList.Count];
                            for (int i = 0; i < newList.Count; i++)
                            {
                                Pickupitems[i] = (UnityEngine.GameObject)newList[i];
                            }
                        }
                    }

                    else if (currObject.CompareTag("Pickup"))
                    {
                        newList.Remove(currObject);
                        inventoryCanvas.GetComponent<Inventory>().OnCollect(currObject);

                        Pickupitems = new GameObject[newList.Count];
                        for (int i = 0; i < newList.Count; i++)
                        {
                            Pickupitems[i] = (UnityEngine.GameObject)newList[i];
                        }
                    }


                }
            }
        


        }

    }
}
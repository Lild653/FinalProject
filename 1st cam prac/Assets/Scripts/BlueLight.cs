using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLight : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject [] wireWatch;
    private Color [] properColors;

    private new Color renderer;
    

    void Start()
    {

       // wireWatch = new GameObject[2];
        properColors = new Color[8];
        properColors[0] = Color.red;
        properColors[1] = Color.magenta;
        properColors[2] = Color.yellow;
        properColors[3] = Color.green;
        properColors[4] = Color.cyan;
        properColors[5] = Color.grey;
        properColors[6] = Color.blue;
        properColors[7] = Color.black;
    }

    
    private System.Boolean ColorChecker()
    {
        for (int i = 0; i < wireWatch.Length; i++)
        {
            renderer = wireWatch[i].GetComponent<Renderer>().material.color;
            Mathf.FloorToInt(renderer.a);
            if (Mathf.FloorToInt(renderer.a) != Mathf.FloorToInt(properColors[i].a) || Mathf.FloorToInt(renderer.g) != Mathf.FloorToInt(properColors[i].g))
            { 
                return false;
            }
            if(Mathf.FloorToInt(renderer.b) != Mathf.FloorToInt(properColors[i].b) || Mathf.FloorToInt(renderer.r) != Mathf.FloorToInt(properColors[i].r))
            {
                return false;
            }
        }
        return true;

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] helper = GameObject.FindGameObjectsWithTag("Lights");
        if (ColorChecker())
        {
            foreach(GameObject girly in helper)
            {
                girly.GetComponentInChildren<Light>().enabled = true;
                //girly.GetComponent<
            }
            
        }
        else
        {
            foreach (GameObject girly in helper)
            {
                girly.GetComponentInChildren<Light>().enabled = false;
            }
        }

        
        
    }
}

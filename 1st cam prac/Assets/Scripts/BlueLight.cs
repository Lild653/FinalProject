using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLight : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject [] wireWatch;
    public GameObject gameManager;
    public GameObject letter;
    public Light myLight;
    public AudioClip lightsOn;
    private Color [] properColors;
    private new Color renderer;
    private AudioSource myAudioSource;
    

    void Start()
    {

        properColors = new Color[5];
        properColors[0] = Color.cyan;
        properColors[1] = Color.magenta;
        properColors[2] = Color.yellow;
        properColors[3] = Color.red;
        properColors[4] = Color.green;
        myAudioSource = GetComponent<AudioSource>();
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
            foreach(GameObject lightBulb in helper)
            {
                lightBulb.GetComponentInChildren<Light>().enabled = true;
                
               
            }
            myLight.GetComponent<Flashlight>().TurnOff();
            letter.GetComponent<LetterScript>().BluelightLetter();
            AudioClip clip = lightsOn;
            gameManager.GetComponent<GameManager>().lightsOn = true;
            //myAudioSource.PlayOneShot(clip);
        }
        else
        {
            foreach (GameObject lightBulb in helper)
            {
                lightBulb.GetComponentInChildren<Light>().enabled = false;
            }
        }

        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiring : MonoBehaviour
{
    // Start is called before the first frame update
    private ArrayList tempColor = new ArrayList();
    private Renderer renderer = new Renderer();
    
    void Start()
    {
        renderer = gameObject.GetComponent<MeshRenderer>();
        tempColor.Add(gameObject.GetComponent<Renderer>().material.color);
        tempColor.Add(Color.red);
        tempColor.Add(Color.magenta);
        tempColor.Add(Color.HSVToRGB(255, 255, 0));
        tempColor.Add(Color.HSVToRGB(46, 139, 87));
        tempColor.Add(Color.blue);
        tempColor.Add(Color.HSVToRGB(75, 130, 0));
        tempColor.Add(Color.HSVToRGB(128, 0, 128));
        tempColor.Add(Color.black);
        
    }


    private void OnMouseEnter()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Renderer>().material.color = (UnityEngine.Color)tempColor[1];
            int i = tempColor.IndexOf(gameObject.GetComponent<Renderer>().material.color);
            Debug.Log("Cowgirl");
            if (i < tempColor.Count) 
            {
                gameObject.GetComponent<Renderer>().material.color = (UnityEngine.Color)tempColor[i+1];
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = (UnityEngine.Color)tempColor[0];
            }

        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLight : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject [] wireWatch;
    private Color [] properColors;
    private System.Boolean cats = true;

    void Start()
    {
        wireWatch = new GameObject[2];
        properColors = new Color[2];
        properColors[0] = Color.red;
        properColors[1] = Color.green;
       // properColors[2] = Color.black;

        
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i=0; i < wireWatch.Length; i++){
            Debug.Log(wireWatch.Length);
            if(wireWatch[i].GetComponent<Renderer>().material.color != properColors[i])
            {
                cats = false;
            }
        }

        if(cats == true)
        {
            Debug.Log("Mouse");
        }
        
        
    }
}

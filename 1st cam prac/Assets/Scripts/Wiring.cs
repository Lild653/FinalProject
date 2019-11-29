using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiring : MonoBehaviour
{
    // Start is called before the first frame update
    private ArrayList tempColor = new ArrayList();
    public int i = 0;
    public float distance;
    public System.Boolean dragging;
    private RaycastHit mouseLocal;

    void Start()
    {
        
        tempColor.Add(Color.red);
        tempColor.Add(Color.magenta);
        tempColor.Add(Color.yellow);
        tempColor.Add(Color.green);
        tempColor.Add(Color.cyan);



        tempColor.Add(Color.grey);
        tempColor.Add(Color.blue);
        tempColor.Add(Color.black);
        
    }

    


   
   
    /*
    private void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }
    private void OnMouseUp()
    {
        dragging = false;
    }
    */

    private void Update()
    {
    
        System.Boolean objeto = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out mouseLocal);
        if (objeto && mouseLocal.collider.gameObject == gameObject && Input.GetKeyDown(KeyCode.A)) 
        {

            if (i ==0)
            {
               
                gameObject.GetComponent<Renderer>().material.color = (UnityEngine.Color)tempColor[i];
                i += 1;

            }
            else if (i < tempColor.Count)
            {
                gameObject.GetComponent<Renderer>().material.color = (UnityEngine.Color)tempColor[i];
                i += 1;
            }
            else
            {
                
                gameObject.GetComponent<Renderer>().material.color = (UnityEngine.Color)tempColor[0];
                i = 1;
            }
          

        }
        /*
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
        */
    }


}

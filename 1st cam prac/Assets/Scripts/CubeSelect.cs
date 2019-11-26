using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSelect : MonoBehaviour


{

    public Canvas interactive;
    private RaycastHit vision;
   
    // Start is called before the first frame update
    void Start()
    {
        interactive.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.red, 80f);
       

        System.Boolean objetoHit = Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3((0.5f) * Screen.width, (0.5f)* Screen.height,0)), out vision);

        
        if (objetoHit)
        {
            if (vision.collider.tag == "Cube")
            {
                interactive.enabled = true;

                //interactive.enabled=true;
                Debug.Log("Press F to pick up");
                if (Input.GetKey(KeyCode.F))
                {

                    Destroy(vision.collider.gameObject);
                }
            }
            else
            {
                interactive.enabled = false;
            }






        }
        else
        {
            interactive.enabled = false;
        }
        

    }
        
    }


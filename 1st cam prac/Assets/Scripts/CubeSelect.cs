using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSelect : MonoBehaviour


{

    public Canvas interactive;
    public Canvas inventoryCanvas;
    private RaycastHit vision;
   
    // Start is called before the first frame update
    void Start()
    {
        interactive.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        
       

        System.Boolean objetoHit = Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3((0.5f) * Screen.width, (0.5f)* Screen.height,0)), out vision);
        
        
        if (objetoHit)
        {
            //if (vision.collider.tag == "Pickup")
            if(vision.collider.CompareTag("Pickup"))
            {

                print("Press F");
                interactive.enabled=true;
                if (Input.GetKey(KeyCode.F))
                {

                    Destroy(vision.collider.gameObject);
                    inventoryCanvas.GetComponent<Inventory>().OnCollect(vision.collider.gameObject);
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


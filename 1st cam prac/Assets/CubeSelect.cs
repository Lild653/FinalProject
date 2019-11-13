using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit cats = new RaycastHit();
            System.Boolean objectHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out cats);



            if (objectHit)
            {
        
                Debug.Log("Hit " + cats.transform.gameObject.name);
                if (cats.transform.gameObject.tag == "Cube")
                {
                    Debug.Log("It's working!");
                    Destroy(cats.transform.gameObject);
                  
                }
                else
                {
                    Debug.Log("nopz");
                }
            }
            else
            {
                Debug.Log("No hit");
            }
        }
        }
    }


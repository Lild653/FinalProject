using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSelect : MonoBehaviour


{
    //public GameObject iteme;
    public Canvas interactive;
    public Canvas inventoryCanvas;
    private RaycastHit vision;
    public GameObject[] Pickupitems;

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

        foreach (GameObject cats in Pickupitems)
        {
            if (Vector3.Angle(transform.forward, cats.transform.position - transform.position) < 15)
            {
                interactive.enabled = true;
                int dogs = newList.IndexOf(cats);
                if (Input.GetKey(KeyCode.F)) {
                    newList.Remove(cats);
                   
                    inventoryCanvas.GetComponent<Inventory>().OnCollect(cats);

                    Pickupitems = new GameObject[newList.Count];
                    for(int i= 0;i<newList.Count;i++) 
                    {
                        Pickupitems[i] = (UnityEngine.GameObject)newList[i];
                    }
                    

                    }
            }


        }



        /*
        if (objetoHit)
        {
            //if (vision.collider.tag == "Pickup")
            if(vision.collider.CompareTag("Pickup"))
            {

                print("Press F to pick up");
                interactive.enabled=true;
                if (Input.GetKey(KeyCode.F))
                {

                    Destroy(vision.collider.gameObject);
                    inventoryCanvas.GetComponent<Inventory>().OnCollect(vision.collider.gameObject);
                }
            }
            if (vision.collider.CompareTag("Interact"))
            {
                if (Input.GetKey(KeyCode.F))
                {
                    print("Press F to interact");
                    if (vision.collider.name.Equals("UnlockBoxParent") && inventoryCanvas.GetComponent<Inventory>().inventorymap["Key"])
                    {
                        vision.collider.GetComponent<WireBox>().Unlock();
                    }
                    if (vision.collider.name.Equals("Plate") || vision.collider.name.Equals("lock_1_open") && inventoryCanvas.GetComponent<Inventory>().inventorymap["Key"]) {
                        vision.collider.GetComponentInParent<WireBox>().Unlock();
                    }
                    //if (vision.collider.name.Equals("Bed"))
                    //{
                        
                    //}
                }
                
            }
          
            else
            {
                interactive.enabled = false;
            }



  



        else
        {
            interactive.enabled = false;
        }

      */
     

    }
}


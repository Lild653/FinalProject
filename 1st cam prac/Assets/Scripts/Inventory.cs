using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    public GameObject[] images;
    public Dictionary<string, bool> inventorymap;
    public GameObject myLight;
    public GameObject instructions;

    // Start is called before the first frame update
    void Start()
    {
        
        inventorymap = new Dictionary<string, bool>();
        foreach(GameObject obj in images)
        {
            obj.SetActive(false);
            inventorymap.Add(obj.name, false);
        }
        
    

    }

   
    public void OnCollect(GameObject myObject)
    {
        for (int i = 0; i < images.Length; i++)
        {
            if (images[i].name.Equals(myObject.name))
            {
                images[i].SetActive(true);
                if (myObject.name.Equals("Flashlight"))
                {
                    myLight.GetComponent<Flashlight>().TurnOn();
                }
                if (myObject.name.Equals("Letter"))
                {
                    instructions.GetComponent<Instructions>().LetterInstructions();
                }
            }
        }
        inventorymap[myObject.name] = true;
        Destroy(myObject);
    }

}

   
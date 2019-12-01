using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //public GameObject image1;
    //public GameObject image2;
    //public GameObject image3;
    //public GameObject image4;
    //public GameObject image5;
    public GameObject[] images;
    public Dictionary<string, bool> inventorymap;
    public GameObject myLight;

    // Start is called before the first frame update
    void Start()
    {
        //image1.SetActive(false);//set to true to add it to 
        //image2.SetActive(false);
        //image3.SetActive(false);
        //image4.SetActive(false);
        //image5.SetActive(false);
        inventorymap = new Dictionary<string, bool>();
        foreach(GameObject obj in images)
        {
            obj.SetActive(false);
            inventorymap.Add(obj.name, false);
        }
        
        //inventorymap.Add("FlashLight", false);
        //inventorymap.Add("Key", false);
        //inventorymap.Add("Lock", false);
        //inventorymap.Add("Letter", false);
        //inventorymap.Add("WireBox", false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void OnCollectFlashLight() //public bc I think another script might call it
    //{
    //    image1.SetActive(true);
    //}

    //public void OnCollectKey()
    //{
    //    image2.SetActive(true);
    //}

    //public void OnCollectLock()
    //{
    //    image3.SetActive(true);
    //}

    //public void OnCollectLetter()
    //{
    //    image4.SetActive(true);
    //}

    //public void OnCollectWireBox()
    //{
    //    image5.SetActive(true);
    //}

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
            }
        }
        inventorymap.Add(myObject.name, true);
        Destroy(myObject);
    }

}

    //logic for ewhn an item is collected
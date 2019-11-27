using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public Dictionary<string, bool> inventorymap;

    // Start is called before the first frame update
    void Start()
    {
        image1.SetActive(false);//set to true to add it to 
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        image5.SetActive(false);

        inventorymap = new Dictionary<string, bool>();
        inventorymap.Add("FlashLight", false);
        inventorymap.Add("Key", false);
        inventorymap.Add("FlashLight", false);
        inventorymap.Add("Lock", false);
        inventorymap.Add("WireBox", false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollectFlashLight() //public bc I think another script might call it
    {
        image1.SetActive(true);
    }

    public void OnCollectKey()
    {
        image2.SetActive(true);
    }

    public void OnCollectLock()
    {
        image3.SetActive(true);
    }

    public void OnCollectLetter()
    {
        image4.SetActive(true);
    }

    public void OnCollectWireBox()
    {
        image5.SetActive(true);
    }

}

    //logic for ewhn an item is collected
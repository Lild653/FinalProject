using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = gameObject.GetComponent<Light>();
        myLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = GetComponentInParent<Camera>().transform.position;
    }

    public void TurnOn()
    {
        myLight.enabled = true;
    }
}

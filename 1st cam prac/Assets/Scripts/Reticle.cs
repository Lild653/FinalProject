using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reticle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] wires;
    private RaycastHit sightLine;
    private Color startingColor;

    void Start()
    {
        gameObject.GetComponent<RectTransform>().position.Set(.5f * Screen.width, .5f * Screen.height, 0);
        startingColor = gameObject.GetComponent<Image>().color;

    }

    void Update()
    {
        System.Boolean objeto = Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(.5f * Screen.width, .5f * Screen.height, 0)), out sightLine);
        
        if(objeto && sightLine.collider.CompareTag("Wires"))
        {
            gameObject.GetComponent<Image>().color = Color.yellow;
        }
        else
        {
            gameObject.GetComponent<Image>().color = startingColor;
        }
        }
    }



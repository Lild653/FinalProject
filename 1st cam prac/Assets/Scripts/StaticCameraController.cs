using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCameraController : MonoBehaviour
{

    //public Camera myCamera;
    public Vector3 offset;
    public Vector3 defaultCameraPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //cameraPosition = myCamera.transform.pos
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 targetPosition = Input.mousePosition;
            transform.position = targetPosition + offset;
        }
    }
}

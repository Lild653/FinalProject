using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorfall : MonoBehaviour
{

    private RaycastHit mouseLocal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.Boolean objeto = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out mouseLocal);

        if(mouseLocal.collider!=null && mouseLocal.collider.gameObject==gameObject && Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }

    }
}

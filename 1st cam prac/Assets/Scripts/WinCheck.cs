using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCheck : MonoBehaviour
{
    void Update()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Won"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Win");
        }
    }
}

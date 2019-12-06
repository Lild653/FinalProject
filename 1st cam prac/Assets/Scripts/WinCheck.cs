using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCheck : MonoBehaviour
{
    void Update()
    {
		if (other.collider.CompareTag("Won"))
		{
			Destroy(other.gameObject);
			SceneManager.LoadScene("Win");
		}
	}
}

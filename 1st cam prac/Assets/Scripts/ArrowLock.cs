using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLock : MonoBehaviour
{

	private float sensitivityX = 5F;
	private float sensitivityY = 5F;

	private float minimumX = -180F;
	private float maximumX = 180;

	private float minimumY = -30F;
	private float maximumY = 30F;


	float rotationY = 0F;
	// Start is called before the first frame update
	void Start()
    {
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.A))
		{
			//float rotationX = transform.localEulerAngles+ Input.GetAxis("Horizontal") * sensitivityX;
			transform.Rotate(0, Input.GetAxis("Horizontal") * sensitivityX, 0);

		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0, (Input.GetAxis("Horizontal") * sensitivityX), 0);
		}
		if (Input.GetKey(KeyCode.S))
		{
			//float rotationX = transform.localEulerAngles - Input.GetAxis("Horizontal") * sensitivityX;
			rotationY += Input.GetAxis("Vertical") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

			transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
			//transform.Rotate(Input.GetAxis("Vertical") * sensitivityY, 0, 0);
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			//float rotationX = transform.localEulerAngles - Input.GetAxis("Horizontal") * sensitivityX;
			rotationY += Input.GetAxis("Vertical") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

			transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
			//transform.Rotate(Input.GetAxis("Vertical") * sensitivityY, 0, 0);
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
 
	public Canvas inventoryCanvas;
	public GameObject key;
	public GameObject[] Pickupitems;
	public GameObject gameManager;
	public AudioClip objectCollected;

	private RaycastHit vision;
	private AudioSource myAudioSource;

	// Start is called before the first frame update
	void Start()
	{
	
		myAudioSource = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update()
	{


		//System.Boolean objetoHit = Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3((0.5f) * Screen.width, (0.5f)* Screen.height,0)), out vision);

		ArrayList newList = new ArrayList();
		foreach (GameObject items in Pickupitems)
		{
			newList.Add(items);
		}

		foreach (GameObject currObject in Pickupitems)
		{
			if (Vector3.Angle(transform.forward, currObject.transform.position - transform.position) < 15 && Math.Abs(currObject.transform.position.z - transform.position.z) < 3)
			{
		
				if (Input.GetKey(KeyCode.F) && !gameManager.GetComponent<GameManager>().inputtingText)
				{

					if (currObject.CompareTag("Interact"))
					{
						if (currObject.name.Equals("UnlockBoxParent") && inventoryCanvas.GetComponent<Inventory>().inventorymap["Key"])
						{
							currObject.GetComponent<WireBox>().Unlock();
						}
                        if ((currObject.name.Equals("Plate") || currObject.name.Equals("lock_1_open")) && inventoryCanvas.GetComponent<Inventory>().inventorymap["Key"])
                        {
                            currObject.GetComponentInParent<WireBox>().Unlock();
                        }
						if (currObject.name.Equals("Sofa"))
						{

							key.GetComponent<Animator>().SetTrigger("CollectKey");
							newList.Remove(key);
							newList.Remove(currObject);
							AudioClip clip = objectCollected;
							myAudioSource.PlayOneShot(clip);
							inventoryCanvas.GetComponent<Inventory>().OnCollect(key);
							Pickupitems = new GameObject[newList.Count];
							for (int i = 0; i < newList.Count; i++)
							{
								Pickupitems[i] = (UnityEngine.GameObject)newList[i];
							}

						}
						if (currObject.name.Equals("Keypad"))
						{
							currObject.GetComponent<KeypadLock>().EnterInput();
						}
						if (currObject.name.Equals("Door"))
						{
							currObject.GetComponentInChildren<KeypadLock>().EnterInput();
						}
					}

					else if (currObject.CompareTag("Pickup"))
					{
						newList.Remove(currObject);
						AudioClip clip = objectCollected;
						myAudioSource.PlayOneShot(clip);
						inventoryCanvas.GetComponent<Inventory>().OnCollect(currObject);

						Pickupitems = new GameObject[newList.Count];
						for (int i = 0; i < newList.Count; i++)
						{
							Pickupitems[i] = (UnityEngine.GameObject)newList[i];
						}

					}


				}
			}



		}

	}
}

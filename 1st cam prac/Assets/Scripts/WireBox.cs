using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBox : MonoBehaviour
{
    Animator unlockBoxAnimate;
    public GameObject locked;
    public GameObject unlocked;
    public GameObject gameManager;
    public AudioClip unlockClip;
    public GameObject instructions;

    private AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        unlocked.SetActive(false);
        unlockBoxAnimate = GetComponent<Animator>();
        myAudioSource = GetComponent<AudioSource>();
    }

    public void Unlock()
    {
        gameManager.GetComponent<GameManager>().lastPuzzleSolved = 0;
        locked.SetActive(false);
        AudioClip clip = unlockClip;
        unlocked.SetActive(true);
        myAudioSource.PlayOneShot(clip);
        unlockBoxAnimate.SetTrigger("UnlockBox");
        instructions.GetComponent<Instructions>().BoxInstructions();
    }
}

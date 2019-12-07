using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    private float startingSeconds = 5;
    public GameObject lostScreen;
    public GameObject myCam;
    public GameObject gameManager;
    public AudioClip flood;
    public AudioClip lost;

    private AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        lostScreen.SetActive(false);
        myCam.transform.rotation = gameManager.GetComponent<GameManager>().finalCameraRot();
        myCam.transform.position = gameManager.GetComponent<GameManager>().finalCameraPos();
        AudioClip clip = flood;
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.clip = clip;
        myAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        startingSeconds = startingSeconds - Time.deltaTime;
        //print(startingSeconds);
        if (startingSeconds <= 0)
        
        //if (Time.time <= 20.0)
        {
            //myAudioSource.Stop();
            myAudioSource.clip = lost;
            //myAudioSource.Play();
            lostScreen.SetActive(true);
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene("Demo");
    }

    public void Exit()
    {
        Debug.Log("EXITED GAME");
        Application.Quit();
    }
}

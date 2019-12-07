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
    public AudioSource floodSource;
    public AudioSource lostSource;
    // Start is called before the first frame update
    void Start()
    {
        lostScreen.SetActive(false);
        myCam.transform.rotation = gameManager.GetComponent<GameManager>().finalCameraRot();
        myCam.transform.position = gameManager.GetComponent<GameManager>().finalCameraPos();
        AudioClip clip = flood;
        floodSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        startingSeconds = startingSeconds - Time.deltaTime;
        //print(startingSeconds);
        if (startingSeconds <= 0)
        
        //if (Time.time <= 20.0)
        {
            floodSource.Stop();
            lostSource.Play();
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

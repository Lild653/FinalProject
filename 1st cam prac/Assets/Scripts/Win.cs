using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text time;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        time.text = "with " + gameManager.GetComponent<GameManager>().WinTime() + " minutes left";
    }

    // Update is called once per frame
    void Update()
    {
        
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

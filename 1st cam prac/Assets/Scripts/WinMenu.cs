using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
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
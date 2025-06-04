using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("CutScene1");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

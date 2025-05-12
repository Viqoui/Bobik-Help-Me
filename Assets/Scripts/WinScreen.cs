using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public GameObject gameWonUI;
    void Start()
    {
        gameWonUI.SetActive(false);
        Time.timeScale = 1f;
    }

   
    void Update()
    {
        
    }

    public void Win()
    {
        gameWonUI.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MeinMenu()
    {
        SceneManager.LoadScene(0);
    }
}

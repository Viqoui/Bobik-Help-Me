using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverlvl3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lvl3()
    {
        SceneManager.LoadScene("lvl3");
    }
    public void lvl1()
    {
        SceneManager.LoadScene("1level");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}


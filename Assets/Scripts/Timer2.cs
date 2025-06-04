using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    private Scene scena;
    public AudioManager audioManager;



    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            scena = SceneManager.GetActiveScene();
            SceneManager.LoadSceneAsync("cs3BAD");
            
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int secounds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, secounds);
        
        if (remainingTime < 10)
        {
            audioManager.PlaySFX(audioManager.timer);
            timerText.color = Color.red;
        }
    }
}

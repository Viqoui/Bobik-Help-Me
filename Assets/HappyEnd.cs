using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HappyEnd : MonoBehaviour

{
    public GameObject theend;
    public GameObject end;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
        StartCoroutine(Wait1());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(6f);

        theend.SetActive(true);
        
    }
    IEnumerator Wait1()
    {

        yield return new WaitForSeconds(26f);

        end.SetActive(true);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void lobby()
    {
        SceneManager.LoadScene("MainMenu");
    }
}


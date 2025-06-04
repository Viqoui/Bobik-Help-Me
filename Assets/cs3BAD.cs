using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cs32BAD : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1.7f);


        SceneManager.LoadSceneAsync("lvl3");
    }
}
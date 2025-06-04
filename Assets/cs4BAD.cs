using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cs4BAD : MonoBehaviour
{
    // Start is called before the first frame update
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

        yield return new WaitForSeconds(3.1f);


        SceneManager.LoadSceneAsync("lvl5");
    }
}

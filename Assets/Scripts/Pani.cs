using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pani : MonoBehaviour
{
    bool playerIsClose;
    [SerializeField] Kwiat kwiat;
    [SerializeField] Kwiat1 kwiat1;
    [SerializeField] Kwiat2 kwiat2;
    [SerializeField] Kwiat3 kwiat3;
    public GameObject dobre;
    public GameObject dobre2;
    public GameObject dobre3;
    public GameObject zle;
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && kwiat.Pod == true)
        {
            kwiat.Obj2.SetActive(false);
            dobre.SetActive(true);
            StartCoroutine(czk());
        }
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && kwiat1.Pod1 == true)
        {
            kwiat.Obj2.SetActive(false);
            zle.SetActive(true);
            StartCoroutine(LOL());
        }
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && kwiat2.Pod2 == true)
        {
            kwiat.Obj2.SetActive(false);
            zle.SetActive(true);
            StartCoroutine(LOL());
        }
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && kwiat3.Pod3 == true)
        {
            kwiat.Obj2.SetActive(false);
            zle.SetActive(true);
            StartCoroutine(LOL());
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            e.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            e.SetActive(false);
        }
    }
    IEnumerator LOL()
    {
        yield return new WaitForSeconds(2);
        zle.SetActive(false);
        SceneManager.LoadScene("cs4BAD");

    }
    IEnumerator czk()
    {
        yield return new WaitForSeconds(3);
        dobre2.SetActive(true);
        yield return new WaitForSeconds(3);
        dobre2.SetActive(false);
        dobre3.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("HappyEnd");

    }
}

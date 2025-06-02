using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KotNPC : MonoBehaviour
{
    private bool playerIsClose;
    private bool readyLOL;
    public bool szukanie;
    public bool zakonczone;
    private bool ol;
    public GameObject kot1;
    public GameObject kot2;
    public GameObject BOBIK1;
    public GameObject BOBIK2;
    
    public GameObject Kot3;
    public GameObject nowosc;
    public GameObject Objective;
    public GameObject Objective1;
    public GameObject Objective2;
    

    [SerializeField] Krzak krzak;
    [SerializeField] wadliwykrzak wk;
    [SerializeField] wadliwykrzak1 wk1;
    [SerializeField] wadliwykrzak2 wk2;
    [SerializeField] wadliwykrzak3 wk3;
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {
        readyLOL = true;
        zakonczone = false;
        ol = true;
        szukanie = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && readyLOL == true && krzak.kotowraca == false)
        {
            readyLOL = false;
            BOBIK1.SetActive(true);
            Objective.SetActive(false); 
        }



        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && krzak.kotowraca == true && ol == true)
        {
            kot2.SetActive(true);
            krzak.Panel2.SetActive(false);
            ol = false;
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
    public void close1()
    {
        kot1.SetActive(false);
        kot2.SetActive(true);
        
    }

    public void close2()
    {   
        BOBIK1.SetActive(false);
        Kot3.SetActive(true);
        StartCoroutine(czk());
    }
    public void close3()
    {
        nowosc.SetActive(false);
        BOBIK2.SetActive(true);
    }
    public void close4()
    {
        BOBIK2.SetActive(false);
        szukanie = true;
        Objective1.SetActive(true);
    }
    public void close11()
    {
        kot2.SetActive(false);
        zakonczone = true;
        Objective2.SetActive(true);
    }
    IEnumerator czk()
    {
        yield return new WaitForSeconds(3);
        Kot3.SetActive(false);
        nowosc.SetActive(true);

    }

}


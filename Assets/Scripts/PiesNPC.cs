using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PiesNPC : MonoBehaviour
{
    private bool playerIsClose;
    private bool readyLOL;
    public bool szukanie;
    public bool zakonczone;
    private bool ol;

    public GameObject dialog;
    public GameObject dialog2;
    public GameObject BOBIK1;
    public GameObject BOBIK2;
    public GameObject Pies3;

    public GameObject Objective;
    public GameObject Objective1;
    public GameObject Objective2;
    public GameObject Objective3;   
    public GameObject Objective4;

    [SerializeField] SkrzynkaNaListy SkrzyniaNaListy;
    [SerializeField] WadliwaSkrzynkaNaListy wk;
    [SerializeField] WadliwaSkrzynkaNaListy wk1;
    [SerializeField] WadliwaSkrzynkaNaListy wk2;
    [SerializeField] WadliwaSkrzynkaNaListy wk3;
    public bool ogrodzenie;
    // Start is called before the first frame update
    void Start()
    {
        readyLOL = true;
        szukanie = false;
        zakonczone = false;
        ogrodzenie = true;
        ol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && readyLOL == true && SkrzyniaNaListy.kotowraca == false)
        {
            readyLOL = false;
            BOBIK1.SetActive(true);
            Objective.SetActive(false);
            ogrodzenie = false;

        }
        else if (playerIsClose == false)
        {
            
        }



        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && SkrzyniaNaListy.kotowraca == true && ol == true)
        {
            dialog.SetActive(true);
            SkrzyniaNaListy.Panel2.SetActive(false);
            ol = false;
        }
        else if (playerIsClose == false)
        {

        } 
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;         
        }
    }
    public void close1()
    {
        dialog.SetActive(false);
        dialog2.SetActive(true);
        
    }

    public void close2()
    {   
        BOBIK1.SetActive(false);
        Pies3.SetActive(true);
    }
    public void close3()
    {
        Pies3.SetActive(false);
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
        dialog2.SetActive(false);
        zakonczone = true;
        Objective2.SetActive(true);
    }

}
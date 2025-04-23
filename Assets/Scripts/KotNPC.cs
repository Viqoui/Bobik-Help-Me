using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KotNPC : MonoBehaviour
{
    private bool playerIsClose;
    private bool readyLOL;
    public bool szukanie;
    public bool zakonczone;
    public GameObject dialog;
    public GameObject dialog2;
    public GameObject BOBIK1;
    public GameObject BOBIK2;
    public GameObject Kot3;
    [SerializeField] Krzak krzak;
    [SerializeField] wadliwykrzak wk;
    [SerializeField] wadliwykrzak1 wk1;
    [SerializeField] wadliwykrzak2 wk2;
    [SerializeField] wadliwykrzak3 wk3;
    // Start is called before the first frame update
    void Start()
    {
        readyLOL = true;
        szukanie = false;
        zakonczone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && readyLOL == true && krzak.kotowraca == false)
        {
            readyLOL = false;
            BOBIK1.SetActive(true);
            
        }
        else if (playerIsClose == false)
        {
            
        }



        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && krzak.kotowraca == true)
        {
            dialog.SetActive(true);
            krzak.Panel2.SetActive(false);
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
        Kot3.SetActive(true);
    }
    public void close3()
    {
        Kot3.SetActive(false);
        BOBIK2.SetActive(true);
    }
    public void close4()
    {
        BOBIK2.SetActive(false);
        szukanie = true;
    }
    public void close11()
    {
        dialog2.SetActive(false);
        zakonczone = true;
    }

}


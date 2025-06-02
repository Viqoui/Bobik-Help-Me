using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting;

public class Krzak : MonoBehaviour
{
    public GameObject Panel;
    public GameObject e;
    public GameObject Panel2;
    private bool playerIsClose;
    public bool kotowraca;
    public bool kolejnybool;
    [SerializeField] KotNPC kotNPC;
    public bool enotworking;
    void Start()
    {
        kotowraca = false;
        kolejnybool = false;
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && kolejnybool == false && kotNPC.szukanie == true)
        {
            Panel.SetActive(true);
            Panel2.SetActive(true);
            kotowraca = true;
            kolejnybool = true;
            kotNPC.Objective1.SetActive(false);
            enotworking = true;
        }
        else if (playerIsClose == false)
        {
            Panel.SetActive(false); 
        }
    }


    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            
        }


        if (other.CompareTag("Player") && kotNPC.szukanie == true && enotworking == false)
        {

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
        Panel.SetActive(false);
        
    }
}

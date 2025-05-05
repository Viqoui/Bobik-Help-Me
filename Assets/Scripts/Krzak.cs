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
    public GameObject Panel2;
    private bool playerIsClose;
    public bool kotowraca;
    public bool kolejnybool;
    [SerializeField] KotNPC kotNPC;
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
        Panel.SetActive(false);
        
    }
}

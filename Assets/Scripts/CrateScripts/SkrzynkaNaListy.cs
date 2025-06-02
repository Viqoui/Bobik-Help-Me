using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting;

public class SkrzynkaNaListy : MonoBehaviour
{
  public GameObject Panel;
    public GameObject Panel2;
    public GameObject e;
    private bool playerIsClose;
    public bool kotowraca;
    public bool kolejnybool;
    [SerializeField] PiesNPC piesNPC;
    void Start()
    {
        kotowraca = false;
        kolejnybool = false;
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && kolejnybool == false && piesNPC.szukanie == true)
        {
            Panel.SetActive(true);
            Panel2.SetActive(true);
            kotowraca = true;
            kolejnybool = true;
            piesNPC.Objective1.SetActive(false);
            piesNPC.szukanie = false;
        }
        else if (playerIsClose == false)
        {
            Panel.SetActive(false);
            
        }
    }


    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && piesNPC.szukanie == true)
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
        Panel.SetActive(false);
        
    }
}

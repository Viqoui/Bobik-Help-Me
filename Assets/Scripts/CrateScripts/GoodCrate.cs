using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting;

public class GoodCrate : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
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
  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (//playerIsClose == true && kolejnybool == false && piesNPC.szukanie == true &&//
            other.CompareTag("Player"))
        {
            Panel.SetActive(true);
            Panel2.SetActive(true);
            //kotowraca = true;
            //kolejnybool = true;
            //piesNPC.Objective1.SetActive(false);
            playerIsClose = true;
        }
        else if (playerIsClose == false)
        {
            Panel.SetActive(false);
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

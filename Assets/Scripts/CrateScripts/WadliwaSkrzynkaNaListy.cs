using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting;

public class WadliwaSkrzynkaNaListy : MonoBehaviour
{
public GameObject PanelNIE;
    public GameObject e;
    private bool playerIsClose1;
    [SerializeField] SkrzynkaNaListy SkrzyniaNalisty;
    [SerializeField] PiesNPC piesNPC;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose1 == true && SkrzyniaNalisty.kotowraca == false && piesNPC.szukanie == true)
        {
            PanelNIE.SetActive(true);
        }
        else if (playerIsClose1 == false)
        {
            PanelNIE.SetActive(false);
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && piesNPC.szukanie == true)
        {
            playerIsClose1 = true;
            e.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose1 = false;
            e.SetActive(false);

        }
    }

    public void close1()
    {
        PanelNIE.SetActive(false);
    }
}

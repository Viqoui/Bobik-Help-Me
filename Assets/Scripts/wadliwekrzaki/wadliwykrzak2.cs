using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting;


public class wadliwykrzak2 : MonoBehaviour
{
    public GameObject PanelNIE;
    public GameObject e;
    private bool playerIsClose1;
    [SerializeField] Krzak krzak;
    [SerializeField] KotNPC kot;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose1 == true && krzak.kotowraca == false && kot.szukanie == true)
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
        if (other.CompareTag("Player"))
        {
            playerIsClose1 = true;

        }

        {
            if (other.CompareTag("Player") && kot.szukanie == true && krzak.enotworking == false)
            {
                playerIsClose1 = true;
                e.SetActive(true);
            }

        }





    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose1 = false;
            e.SetActive(false);

        }
    }
    void close1()
    {
        PanelNIE.SetActive(false);
    }
}
    

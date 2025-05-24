using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;


public class Ziomeklvl1 : MonoBehaviour
{
    public bool playerIsClose;
    private bool dialogend;
    public GameObject popo;
    public KotNPC npc;
    // Start is called before the first frame update
    void Start()
    {
        dialogend = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && dialogend == true && npc.zakonczone == true)
        {
            SceneManager.LoadScene("2level");
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
        
        npc.Objective2.SetActive(false);

    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Kosz : MonoBehaviour
{
    bool playerIsClose;
    public GameObject kosz;
    public GameObject Objective4;
    public bool znalezione;
    [SerializeField] Kasjer kasjer;
    bool lol;
    // Start is called before the first frame update
    void Start()
    {
        lol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && kasjer.atm == true && lol)
        {
            
            kasjer.OB3.SetActive(false);
            Objective4.SetActive(true);
            kosz.SetActive(true);
            znalezione = true;
            lol = false;
        }
        else if (playerIsClose == false && znalezione == true)
        {
            kosz.SetActive(false);
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

}

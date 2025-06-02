using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Kosz2 : MonoBehaviour
{
    bool playerIsClose;
    public GameObject kosz;
    public GameObject e;

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
            kosz.SetActive(true);
            
            
            
            lol = false;
        }
        else if (playerIsClose == false)
        {
            kosz.SetActive(false);
            e.SetActive(true);
        }
    }





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
        if (other.CompareTag("Player") && kasjer.atm == true && lol == true)
        {
            playerIsClose = true;
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
}

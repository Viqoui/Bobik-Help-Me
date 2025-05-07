using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Kosz5 : MonoBehaviour
{
    bool playerIsClose;
    public GameObject kosz;
    
   
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

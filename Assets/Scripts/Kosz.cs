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
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {
        lol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && kasjer.atm == true && lol == true)
        {
            
            kasjer.OB3.SetActive(false);
            Objective4.SetActive(true);
            kosz.SetActive(true);
            lol = false;
            StartCoroutine(p());
            znalezione = true;
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
    IEnumerator p()
    {
        yield return new WaitForSeconds(2f);
        kosz.SetActive(false);
    }
}


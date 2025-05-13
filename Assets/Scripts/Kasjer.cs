using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Kasjer : MonoBehaviour
{
    bool playerIsClose;
    bool poczatek;
    public bool atm;
    public bool ready;
    public GameObject Text1B;
    public GameObject Text1K;
    public GameObject Text2K;
    public GameObject Text2B; 
    public GameObject Text3B;
    public GameObject Text3K;
    public GameObject Text4K;
    public GameObject OB;
    public GameObject OB1;
    public GameObject OB2;
    public GameObject OB3;
    public GameObject KoncowyKasjer;
    [SerializeField] Karma karma;
    [SerializeField] Kosz kosz;
    // Start is called before the first frame update
    void Start()
    {
        poczatek = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && poczatek)
        {
            OB.SetActive(false);
            Text1B.SetActive(true);
            poczatek=false;
        }


        if (karma.KarmaZebrana == true)
        {
            OB1.SetActive(false);
            OB2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && karma.KarmaZebrana)
        {
            OB2.SetActive(false);
            Text2K.SetActive(true);
            karma.KarmaZebrana = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && kosz.znalezione)
        {
            KoncowyKasjer.SetActive(true);
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

    public void close()
    {
        Text1B.SetActive(false);
        Text1K.SetActive(true);
    }
    public void close1()
    {
        Text1K.SetActive(false);
        OB1.SetActive(true);
        ready = true;
    }

    public void close2()
    {
        Text2K.SetActive(false);
        Text2B.SetActive(true);
    }
    public void close3()
    {
        Text2B.SetActive(false);
        Text3K.SetActive(true);
    }
    public void close4()
    {
        Text3K.SetActive(false);
        Text4K.SetActive(true);
    }
    public void close5()
    {
        Text4K.SetActive(false);
        OB3.SetActive(true);
        atm = true;
    }
    public void close6()
    {
        KoncowyKasjer.SetActive(false);
        kosz.Objective4.SetActive(false);
        Text3B.SetActive(true);

    }
    public void close7()
    {
        SceneManager.LoadScene("lvl5");
    }
}

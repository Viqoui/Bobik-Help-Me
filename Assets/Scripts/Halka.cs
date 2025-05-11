using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;
using UnityEngine.SceneManagement;

public class Halka : MonoBehaviour
{
    bool playerIsClose;
    [SerializeField] Pilka pilka;
    [SerializeField] Pilka1 pilka1;
    [SerializeField] Pilka2 pilka2;
    [SerializeField] Pilka3 pilka3;
    public GameObject dobre;
    public GameObject zle;
    public GameObject halka;
    public GameObject halka1;
    public GameObject halka2;
    public GameObject bobik;
    public GameObject Objective;
    public bool kwiatki;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && pilka.Pod == true && kwiatki == false)
        { 
            pilka.Obj2.SetActive(false);
            dobre.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && pilka1.Pod1 == true && kwiatki == false)
        {
            pilka.Obj2.SetActive(false);
            zle.SetActive(true);
            StartCoroutine(LOL());
        }
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && pilka2.Pod2 == true && kwiatki == false)
        {
            pilka.Obj2.SetActive(false);
            zle.SetActive(true);
            StartCoroutine(LOL());
        }
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && pilka3.Pod3 == true && kwiatki == false)
        {
            pilka.Obj2.SetActive(false);
            zle.SetActive(true);
            StartCoroutine(LOL());
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
    IEnumerator LOL()
    {
        yield return new WaitForSeconds(2);
        zle.SetActive(false);
        SceneManager.LoadScene("GameOver5lvl");

    }

    public void close()
    {
        dobre.SetActive(false);
        halka.SetActive(true);
    }
    public void close1()
    {
        halka.SetActive(false);
        halka1.SetActive(true);
    }
    public void close2()
    {
        halka1.SetActive(false);
        halka2.SetActive(true);
    }
    public void close3()
    {
        halka2.SetActive(false);
        bobik.SetActive(true);
    }
    public void close4()
    {
        bobik.SetActive(false);
        Objective.SetActive(true);
        kwiatki = true;
    }
}

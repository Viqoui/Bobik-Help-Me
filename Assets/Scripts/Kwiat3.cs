using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kwiat3 : MonoBehaviour
{
    bool playerIsClose;
    [SerializeField] Halka halka;
    public GameObject Obj2;
    public GameObject roz;
    public bool Pod3;
    [SerializeField] Kwiat kwiat;
    [SerializeField] Kwiat1 kwiat1;
    [SerializeField] Kwiat2 kwiat2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && kwiat1.Pod1 == false && kwiat.Pod == false && kwiat2.Pod2 == false && halka.kwiatki)
        {
            halka.Objective.SetActive(false); Obj2.SetActive(true);
            roz.SetActive(true);
            Pod3 = true;
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
        roz.SetActive(false);
        gameObject.SetActive(false);

    }
}

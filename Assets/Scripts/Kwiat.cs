using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kwiat : MonoBehaviour
{
    bool playerIsClose;
    
    public GameObject Obj2;
    public GameObject roz;
    public GameObject e;
    public bool Pod;
    [SerializeField] Kwiat1 kwiat1;
    [SerializeField] Kwiat2 kwiat2;
    [SerializeField] Kwiat3 kwiat3;
    [SerializeField] Halka halka;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && kwiat1.Pod1 == false && kwiat2.Pod2 == false && kwiat3.Pod3 == false && halka.kwiatki)
        {
            halka.Objective.SetActive(false); Obj2.SetActive(true);
            roz.SetActive(true);
            Pod = true;
            StartCoroutine(LOL());


        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && halka.kwiatki)
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

        }
    }
    IEnumerator LOL()
    {
        yield return new WaitForSeconds(2);
        roz.SetActive(false);
        gameObject.SetActive(false);

    }
}

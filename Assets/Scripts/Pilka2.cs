using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilka2 : MonoBehaviour
{
    bool playerIsClose;
    public GameObject Obj1;
    public GameObject Obj2;
    public GameObject roz;
    [SerializeField] Pilka pilka;
    [SerializeField] Pilka1 pilka1;
    [SerializeField] Pilka3 pilka3;
    public bool Pod2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose == true && pilka1.Pod1 == false && pilka.Pod == false && pilka3.Pod3 == false)
        {
            Obj1.SetActive(false);
            Obj2.SetActive(true);
            roz.SetActive(true);
            Pod2 = true;
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

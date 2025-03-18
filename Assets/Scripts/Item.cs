using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    GameObject item;
    public bool isPickedUp;
    // Start is called before the first frame update
    void Start()
    {
        isPickedUp = false;
        Debug.Log(isPickedUp);
    }

    // Update is called oncSe per frameSS
    void Update()
    {
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            isPickedUp = true;
            gameObject.SetActive(false);
            Debug.Log("Wr�� do ziomka!");
        }
    }


}


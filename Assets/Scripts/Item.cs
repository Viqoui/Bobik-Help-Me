using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    GameObject item;
    [SerializeField] GameObject text;
    public bool isPickedUp;
    public NPC npc;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        isPickedUp = false;
        Debug.Log(isPickedUp);
    }

    // Update is called oncSe per frameSS
    void Update()
    {
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && npc.canPickUp == true) 
        {
            isPickedUp = true;
            gameObject.SetActive(false);
            Debug.Log("Wróæ do ziomka!");
            text.SetActive(true);
        }
    }
        public void close()
        {
            text.SetActive(false);
        }


}


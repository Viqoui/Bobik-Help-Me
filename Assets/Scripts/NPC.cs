using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject panelDialogu;
    public TMP_Text tekstDialogu;
    public string[] dialog;
    private int index;
    public float wordSpeed;
    public bool playerIsClose;
    public GameObject contButton;
    public Item item;


    private void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerIsClose) 
        {
            if(panelDialogu.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                panelDialogu.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if(tekstDialogu.text == dialog[index])
        {
            contButton.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && item.isPickedUp == true)
        {
            Debug.Log("123");
        }
    }

    public void zeroText()
    {
        tekstDialogu.text = "";
        index = 0;
        panelDialogu.SetActive(false);
        
    }

    IEnumerator Typing()
    {
        foreach(char letter in dialog[index].ToCharArray())
        {
            tekstDialogu.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {

        contButton.SetActive(false);

        if(index < dialog.Length - 1) 
        {
            index++;
            tekstDialogu.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
            
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
            zeroText();
        }
    }
}

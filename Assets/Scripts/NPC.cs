using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting;

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
    public bool dialogEnd;
    public GameObject panelOddania;
    public bool dialogEnd1;
    public WinScreen winScreenManager; 

    void Start()
    {
        dialogEnd = false;
        dialogEnd1 = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerIsClose && dialogEnd == false) 
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

        if (Input.GetKeyDown(KeyCode.E) && item.isPickedUp == true && dialogEnd1 == false)
        {
            panelOddania.SetActive(true);
        }
        
        if (dialogEnd1 == true)
        {
            winScreenManager.Win();
            Time.timeScale = 0f;
        }
    }
    public void close1()
    {
        panelOddania.SetActive(false);
        dialogEnd1 = true;
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
            dialogEnd = true;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class NPC : MonoBehaviour
{
    public GameObject panelDialogu;
    public TMP_Text tekstDialogu;
    public string[] dialog;
    private int index;
    public float wordSpeed;
    private bool playerIsClose;
    public GameObject contButton;
    public Item item;
    private bool dialogEnd;
    public GameObject panelOddania;
    private bool dialogEnd1;
    public GameObject objective;
    public bool canPickUp;
    

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
                objective.SetActive(false);
                panelDialogu.SetActive(true);
                StartCoroutine(Typing());
                


            }
        }



        if (Input.GetKeyDown(KeyCode.E) && item.isPickedUp == true && dialogEnd1 == false && playerIsClose == true)
        {
            panelOddania.SetActive(true);
        }
        
        if (dialogEnd1 == true)
        {
            StartCoroutine(lol());
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

        
        

        if (index < dialog.Length - 1) 
        {
            index++;
            tekstDialogu.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
            dialogEnd = true;
            canPickUp = true;
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

    IEnumerator lol()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("1level");
    }
}

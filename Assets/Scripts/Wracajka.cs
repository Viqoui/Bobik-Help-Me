using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wracajka : MonoBehaviour
{
    [SerializeField] PiesNPC npc;
    bool playerIsClose;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (npc.zakonczone == true)
        {
            GetComponent<Collider>().isTrigger = true;
        }
        if(playerIsClose == true)
        {
            SceneManager.LoadScene("lvl3");
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
}

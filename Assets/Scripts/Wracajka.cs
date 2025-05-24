using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
=======
using UnityEngine.SceneManagement;
>>>>>>> Stashed changes

public class Wracajka : MonoBehaviour
{
    [SerializeField] PiesNPC npc;
<<<<<<< Updated upstream
=======
    bool playerIsClose1;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
    }
}
=======
        if (playerIsClose1 == true)
        {
            SceneManager.LoadScene("lvl3");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose1 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose1 = false;

        }
    }

}
>>>>>>> Stashed changes

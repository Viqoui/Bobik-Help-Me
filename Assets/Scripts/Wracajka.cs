using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wracajka : MonoBehaviour
{
    [SerializeField] PiesNPC npc;
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
    }
}

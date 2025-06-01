using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karma : MonoBehaviour
{
    public bool KarmaZebrana;
    [SerializeField] Kasjer kasjer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && kasjer.ready)
        {
            gameObject.SetActive(false);
            KarmaZebrana = true;
        }
    }
}

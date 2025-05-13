using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class PlayerMovement : MonoBehaviour
{
    private Item item;

    public Rigidbody theRB;
    public float moveSpeed, jumpForce;
    private Vector2 moveInput;

    public LayerMask whatIsGround;
    public Transform groundPoint;
    private bool isGrounded;
    public AudioManager audioManager;


    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        item = GetComponent<Item>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        

        theRB.velocity = new Vector3(moveInput.x * moveSpeed, theRB.velocity.y, moveInput.y * moveSpeed);

        RaycastHit hit;
        if(Physics.Raycast(groundPoint.position, Vector3.down, out hit, .1f, whatIsGround))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            theRB.velocity += new Vector3(0f, jumpForce, 0f);
            audioManager.PlaySFX(audioManager.jump);
        }

        if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (moveInput.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            audioManager.PlaySFX(audioManager.walk);
        }








    }

    //private void Awake()
   // {
        //audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
   // }
}

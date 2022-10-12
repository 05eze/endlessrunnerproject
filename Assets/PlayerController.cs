using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundchecker;
    public LayerMask whatIsGround;

    float maxSpeed = 8.0f;
    bool isOnGround = false;

    //Create a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;
    private object groundChecker;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 12.0f;
        } else
        {
            maxSpeed = 8.0f;
        }

        //Create a 'float' that will be equal to the players horizontal input
        //float movementValueX = Input.GetAxis("Horizontal");

        float movementValueX = 1.0f;
        //Change the X velocity of the Rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movementValueX * maxSpeed, playerObject.velocity.y);

        //Check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundchecker.transform.position, 1.0f, whatIsGround);

        Debug.Log(Physics2D.OverlapCircle(groundchecker.transform.position, 1.0f, whatIsGround));

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, 600.0f));
        }
    }
}

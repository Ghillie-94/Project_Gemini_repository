using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variables
    public float movementForceTurn = 7f;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
        ourRigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") *movementForceTurn, Input.GetAxis("Vertical") *movementForceTurn);

        //use rigidbody to find current vertical & horizontal speed
        float currentSpeedV = ourRigidbody.velocity.y;
        float currentSpeedH = ourRigidbody.velocity.x;

        // get animator component that will be used for setting animation
        Animator ourAnimator = GetComponent<Animator>();

        // tell animator what the speed is
        ourAnimator.SetFloat("speedV", currentSpeedV);

        

       
        //condition: when the player presses D key...
        /*if (Input.GetKey(KeyCode.D))
        {
            //Action: apply a force (move the player)    
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            //Add a force to the rigidbody to move our player
            ourRigidbody.AddForce(Vector2.right * movementForceTurn);

        }

        //condition: when the player presses A key...
        if (Input.GetKey(KeyCode.A))
        {
            //Action: apply a force (move the player)    
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            //Add a force to the rigidbody to move our player
            ourRigidbody.AddForce(Vector2.left * movementForceTurn);

        }
        //condition: when the player presses W key...
        if (Input.GetKey(KeyCode.W))
        {
            //Action: apply a force (move the player)    
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            //Add a force to the rigidbody to move our player
            ourRigidbody.AddForce(Vector2.up * movementForceTurn);

        }
        //condition: when the player presses S key...
        if (Input.GetKey(KeyCode.S))
        {
            //Action: apply a force (move the player)    
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            //Add a force to the rigidbody to move our player
            ourRigidbody.AddForce(Vector2.down * movementForceTurn);

        }*/

    }
}

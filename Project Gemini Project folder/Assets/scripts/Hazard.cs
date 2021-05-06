using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    // built in unity function for handling collisions
    // this function will be called when another object bumps 
    // into the one that this script is attatched to
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        // get the object we collided with
        Collider2D objectWeCollidedWith = collisionData.collider;

        // get the player health script attatched to that object(if there is one)
        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

        // check if we actually found a player health script on the object we collided with
        // This if statement is true if the player variable is NOT null (aka empty)
        if (player != null)
        {
            // this means there WAS a playerhealth script attatched to the object we bumped into
            // which means this object is indeed the player

            //therfore perform our action
            player.Kill();

        }
    }
    
    
}

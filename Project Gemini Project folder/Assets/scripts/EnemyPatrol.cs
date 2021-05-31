using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    
    // public variables
    public float forceStrength; //how fast we move
    public Vector2[] patrolPoints; //patrol points we will move to
    public float stopDistance; // how close we get before moving to next patrol point

    // private variables 
    private Rigidbody2D ourRigidbody; // the rigidbody on this object used to move to
    private int currentPoint = 0; // Index of the current point we are moving toward




    // Awake is called when the script is first loaded
    void Awake()
    {
        // Get the rigidbody attached to this object for movement
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // How far are we from our target?
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        // if we are closer to our target than our mininum distance...
        if (distance <= stopDistance)
        {
            //then update to the next target
            currentPoint = currentPoint + 1;

            // if we've gone past the end of our list....
            // if our current point index is equal or bigger than
            // the length pf our list
            if (currentPoint >= patrolPoints.Length)
            {
                // then loop back to the start 
                //by setting the current index to 0
                currentPoint = 0;
            }
        }



        // Move in the direction of our target

        //get the direction we should move in
        // Subtracting the current position from the target position (B-A)
        // and normalize direction
        Vector2 direction = (patrolPoints[currentPoint] - (Vector2)transform.position).normalized;

        // move in the correct direction with the set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}

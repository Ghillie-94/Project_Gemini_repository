using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRktAI : MonoBehaviour
{
    // Public variables
    //exposed for editing in the unity editor
    public float forceStrength; //how hard the script pushes the
                                //enemy aka how fast the enemy moves
    public Vector2 direction; // what direction the enemy should move in

    // Private variables
    // not visible in editor 
    // used for tracking data while the game is running
    private Rigidbody2D ourRigidbody; //the container for the Rigidbody2D
                                      // attached to this object

    //Awake is called when the script is first loaded
    void Awake()
    {
        //get and store the rigidbody that will be used for movement
        ourRigidbody = GetComponent<Rigidbody2D>();

        //ensure vector is one unit 
        //normalise our direction
        //normalise changes it to be length 1, so we can multiply
        // it by our speed/force later
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        // move in the correct direction with the set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}

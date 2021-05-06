using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // This function is NOT built into unity!
    // It will only be called manually by our own code
    // It must be marked public so other scripts can access it.
    public void Kill()
    {
        //This will destroy the game object that this script is attatched to.
        Destroy(gameObject);
    }
}

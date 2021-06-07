using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
   public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        DoExplosion();
    }

    // ACTION: fire a projectile
    public void DoExplosion()
    {
        
        //clone the projectile
        //declare a variable to hold the cloned object
        GameObject clonedProjectile;
        // Use Instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        //position the projectile on the player... tranform is the location of the script (the player object)
        clonedProjectile.transform.position = transform.position; //optional: add an offset (use a public variable)

        


    }
}

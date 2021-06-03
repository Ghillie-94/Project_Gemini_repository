﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire01 : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;
    public float cooldownTimer;

    private float timer = 2f;
    

   

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            FireProjectile();
            timer = 2f;
        }

    }

    // ACTION: fire a projectile
    public void FireProjectile()
    {
        

        
        //clone the projectile
        //declare a variable to hold the cloned object
        GameObject clonedProjectile;
        // Use Instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        //position the projectile on the player... tranform is the location of the script (the player object)
        clonedProjectile.transform.position = transform.position; //optional: add an offset (use a public variable)

        //fire in a direction
        //declare a variable to hold the cloned obeject's rigidbody
        Rigidbody2D projectileRigidbody;
        //get the rigidbody from our cloned projectile and store it
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        // Set the velocity on the rigidbody to the editor setting
        projectileRigidbody.velocity = projectileVelocity;


    }
}

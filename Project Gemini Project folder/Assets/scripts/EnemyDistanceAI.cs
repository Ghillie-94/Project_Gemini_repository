using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistanceAI : MonoBehaviour
{
    //public variables (editable in unity and accessible to other scripts)
    public float distanceForDecision; //how close the player must be to change behaviour
    public Transform target;

    // Private variables 
    private EnemyPatrol patrolBehaviour;
    private EnemyChase chaseBehaviour;


    // awake is called when the script loads
    void Awake()
    {
        //get the behaviours so we can turn them off and on
        patrolBehaviour = GetComponent<EnemyPatrol>();
        chaseBehaviour = GetComponent<EnemyChase>();

        // Turn off the chase behaviour to start with
        chaseBehaviour.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // How far are we from our target?
        float distance = ((Vector2)target.position - (Vector2)transform.position).magnitude;

        //if we are closer to our target than our minimum distance...
        if (distance <= distanceForDecision)
        {
            //Disable patrol and enable chasing 
            patrolBehaviour.enabled = false;
            chaseBehaviour.enabled = true;
        }
    }
}

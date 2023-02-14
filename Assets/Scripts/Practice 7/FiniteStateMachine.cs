using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachine : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float patrolSpeed = 2f;
    public float chaseSpeed = 5f;

    private int currentPatrolPoint = 0;
    public Transform targetObject;
    private bool chasing = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(chasing)
        {
            Chase();
        }
        else
        {
            Patrol();
        }
    }

    void Patrol()
    {
        // Move towards the current patrol point
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolPoint].position, patrolSpeed * Time.deltaTime);
        // if we've reached the current patrol point, move on to the next one
        if (Vector3.Distance(transform.position, patrolPoints[currentPatrolPoint].position) < 1f)
        {
            currentPatrolPoint = (currentPatrolPoint + 1) % patrolPoints.Length;
        }

        // Check if the player is within sight
        Vector3 direction = targetObject.position - transform.position;
        RaycastHit hit;
        if(Physics.Raycast(transform.position, direction, out hit, 5f))
        {
            if(hit.collider !=null && hit.collider.CompareTag("Player"))
            {
                chasing= true;
            }
        }
        // Use debug drawline to simulate the line 
        Debug.DrawLine(transform.position, transform.position + direction.normalized * 5f, Color.red);

    }

    void Chase()
    {
        // Move toward the player
        transform.position = Vector3.MoveTowards(transform.position,targetObject.position, chaseSpeed * Time.deltaTime);


        // Check if the player has escaped and then return to the patrol point
        if(Vector3.Distance(transform.position, patrolPoints[currentPatrolPoint].position) > 6f)
        {
            chasing = false;
        }
    }
}

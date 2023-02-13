using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachine : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float patrolSpeed;
    public float chaseSpeed;

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
        
    }

    void Patrol()
    {
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolPoint].position, patrolSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, patrolPoints[currentPatrolPoint].position) < 0.2f)
        {
            currentPatrolPoint = (currentPatrolPoint + 1) % patrolPoints.Length;
        }
    }

    void Chase()
    {

    }
}

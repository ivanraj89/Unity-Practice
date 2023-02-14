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
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolPoint].position, patrolSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, patrolPoints[currentPatrolPoint].position) < 0.2f)
        {
            currentPatrolPoint = (currentPatrolPoint + 1) % patrolPoints.Length;
        }

        Vector3 direction = targetObject.position - transform.position;
        RaycastHit hit;
        if(Physics.Raycast(transform.position, direction, out hit, 5f))
        {
            if(hit.transform == CompareTag("Player"))
            {
                chasing= true;
            }
        }
        Debug.DrawLine(transform.position, transform.position + direction.normalized * 5f, Color.red);

    }

    void Chase()
    {
        transform.position = Vector3.MoveTowards(transform.position,targetObject.position, chaseSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, targetObject.position) > 10f)
        {
            chasing = false;
        }
    }
}

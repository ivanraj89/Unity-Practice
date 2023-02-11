using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAIMove : MonoBehaviour
{
    float speed = 2f;
    float distFromPlayer = 10;

    public GameObject player;

    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Vector3.Distance(transform.position, playerTransform.position);

        if (currentDistance < distFromPlayer) 
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }

        
    }
}

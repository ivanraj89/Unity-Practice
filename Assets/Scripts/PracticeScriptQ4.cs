using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeScriptQ4 : MonoBehaviour
{
    //Create a script that allows a game object to jump when the player presses the space bar.

    [SerializeField]
    private float jumpForce = 50f;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }
    }
}

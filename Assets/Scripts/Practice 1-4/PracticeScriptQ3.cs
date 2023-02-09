using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeScriptQ3 : MonoBehaviour
{
    //Create a script to that changes the color of a game object when it is clicked

    [SerializeField]
    private Color cubeColor;
    [SerializeField]
    private Renderer rd;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            rd.material.color = Random.ColorHSV();
        }
    }
}

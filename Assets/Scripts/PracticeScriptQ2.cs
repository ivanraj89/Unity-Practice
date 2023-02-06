using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PracticeScriptQ2 : MonoBehaviour
{
    private Vector3 mousePos;
    [SerializeField] float offset = 3f;

    //Create script that makes a game object follow the mouse button 

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
            mousePos = Input.mousePosition;
            mousePos.z = offset;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
    }
}

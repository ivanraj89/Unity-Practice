using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice4 : MonoBehaviour
{
    public class Train
    {
        private readonly int speed;

        public Train()
        {
            speed = 10;
        }

        public int Speed
        {
            get { return speed; }

        }
    }

    private void Start()
    {
        Train train1 = new Train();
        Debug.Log("Your constant value is " + train1.Speed);
    }
}

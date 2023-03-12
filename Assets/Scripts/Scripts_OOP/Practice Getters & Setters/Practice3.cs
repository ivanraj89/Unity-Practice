using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice3 : MonoBehaviour
{
    public class Car : MonoBehaviour
    {
        private Vector3 m_Position;

        public Vector3 Position
        {
            get { return transform.position}
            set { transform.position = value; }
        }
    }

}

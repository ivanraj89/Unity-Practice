using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor_Practice : MonoBehaviour
{
    class Rectangle
    {
        private float width;
        private float height;

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public void Area()
        {
            Debug.Log("Area of rectangle is " + width * height);
        }
    }

    private void Start()
    {
        Rectangle rectangleArea = new Rectangle(5, 3);
        rectangleArea.Area();
    }

}

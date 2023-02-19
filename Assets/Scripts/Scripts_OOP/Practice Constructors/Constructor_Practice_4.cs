using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor_Practice_4 : MonoBehaviour
{
    class Car
    {
        private string make;
        private int model;
        private int year;

        public Car(string make, int model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        
        public void CarDetails()
        {
            Debug.Log("Your car model and make is " + make + " " + model + " " + year );
        }

    }

    private void Start()
    {
        Car testCar = new Car("Volvo", 2, 2023);
        testCar.CarDetails();
    }
    
    
}

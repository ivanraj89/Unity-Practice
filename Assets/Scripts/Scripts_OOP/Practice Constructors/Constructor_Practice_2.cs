using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Constructor_Practice_2 : MonoBehaviour
{
    class Person
    {
        private string firstName;
        private string lastName;
        private float age;

        public Person(string firstName, string lastName, float age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void Identity()
        {
            Debug.Log("Your name is " + firstName + " " + lastName + " and your age is " + age);
        }
    }

    private void Start()
    {
        Person personIdentity = new Person("Ivan", "raj", 34);
        personIdentity.Identity();
    }
}

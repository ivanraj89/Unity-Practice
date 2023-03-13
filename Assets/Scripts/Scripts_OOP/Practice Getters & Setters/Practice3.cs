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
            get { return transform.position; }
            set { transform.position = value; }
        }

        public Car(Vector3 m_Position)
        {
            this.Position = m_Position;
        } 

    }

    private void Start()
    {   
        //Error message on trying Car car1 = new Car(transform.position);
        //The reason you received the message 
        //You are trying to create a MonoBehaviour using the 'new' keyword. 
        //This is not allowed. MonoBehaviours can only be added using AddComponent()" 
        //is because you tried to create a new instance of your Car class using the new keyword. 
        //Since Car is a subclass of MonoBehaviour, it must be added to a game object as a component 
        //using the AddComponent() method, and not created using new.

        Car car1 = gameObject.AddComponent<Car>(); 
        Vector3 newLocation = new Vector3(0, 1, 0);
        car1.Position = newLocation;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;

public class Practice1 : MonoBehaviour
{
    public int humanHealth;
    class Human
    {
        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Health cannot be below zero");
                }
                else
                {
                    health = value;
                }
            }
        }

        public Human(int health)
        {
            this.Health = health;
        }


    }

    private void Start()
    {

        Human ivan = new Human(humanHealth);

        Debug.Log(ivan.Health);
    }
}

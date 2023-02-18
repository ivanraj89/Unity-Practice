using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor_Practice_3 : MonoBehaviour
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int year;

        public Book(string title, string author, int pages, int year)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.year = year;
        }

        public void bookDetails()
        {
            Debug.Log("The title, author and pages of the book is " + title + " " + author + " " + pages);
        }

        public void randomStuff()
        {
            float stuff = pages * year;
            Debug.Log("Answer is " + stuff);    
        }
    }

    private void Start()
    {
        Book randomBook = new Book("Requiem", "IvanRaj", 40, 50);
        //randomBook.randomStuff();
        randomBook.bookDetails();
    }

}

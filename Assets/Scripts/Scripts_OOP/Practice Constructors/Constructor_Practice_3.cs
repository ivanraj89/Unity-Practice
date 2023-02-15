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

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public void bookDetails()
        {
            Debug.Log("The title, author and pages of the book is " + title + " " + author + " " + pages);
        }
    }

    private void Start()
    {
        Book randomBook = new Book("Requiem", "IvanRaj", 40);
        randomBook.bookDetails();
    }

}

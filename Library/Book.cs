

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Library
{
    public class Book
    {
        private string title;
        private string author;
        private string genre;
        private int ISBN;
        private int year;
        private string publisher;
        private static int bookCount = 0;

        public Book() {
            this.title = string.Empty;
            this.author = string.Empty;
            this.genre = string.Empty;
            this.year = 0;
            this.publisher = string.Empty;
            this.ISBN = bookCount++;
        }
        public Book(string title, string author, string genre, int year, string publisher)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.ISBN = bookCount++;
            this.year = year;
            this.publisher = publisher;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int ISBn
        {
            get { return ISBN; }
            private set { ISBN = value; }
        }
        public int Year{
            get {  return year; } 
            set { year = value;}
            }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public static int BookCount
        {
            get { return bookCount; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book Genre: {Genre}");
            Console.WriteLine($"Book ISBN: {ISBn}");
            Console.WriteLine($"Book Year:{Year}");
            Console.WriteLine($"Book Publisher: {Publisher}");
        }
    }
}

﻿namespace Pop_AlexandruCristian_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
       // public string Author { get; set; }
        public decimal Price { get; set; }

        public Author Author { get; set; }
        public int AuthorID { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

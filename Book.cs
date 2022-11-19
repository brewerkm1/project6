using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    internal class Book
    {
        string Title { get; set; } 
        string Author { get; set; }
        int Pages { get; set; }
        string Publisher { get; set; }

        public void Print(string Title, string Author, int Pages, string Publisher)
        {
            Console.WriteLine("Title: " + Title + "\nAuthor: " + Author + "\nPages: " + Pages + "\nPublisher: " + Publisher);
        }
    }
}

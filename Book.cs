using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public struct Book
    {
        public string Title;          
        public string Author;          
        public int YearOfPublication;  
        public int Pages;              

        
        public Book(string title, string author, int yearOfPublication, int pages)
        {
            Title = title;
            Author = author;
            YearOfPublication = yearOfPublication;
            Pages = pages;
        }

   
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: " + Title);
            Console.WriteLine($"Автор: " + Author);
            Console.WriteLine($"Год издания: " + YearOfPublication);
            Console.WriteLine($"Количество страниц: " + Pages);
            Console.WriteLine(); 
        }
    }
}

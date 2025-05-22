using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество книг: ");
            int n = int.Parse(Console.ReadLine());
            Book[] books = new Book[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВвод информации о книге {i + 1}:");
                Console.Write("Введите название книги: ");
                string title = Console.ReadLine();
                Console.Write("Введите Ф.И.О. автора: ");
                string author = Console.ReadLine();
                Console.Write("Введите год издания: ");
                int yearOfPublication = int.Parse(Console.ReadLine());
                Console.Write("Введите количество страниц: ");
                int pages = int.Parse(Console.ReadLine());
                books[i] = new Book(title, author, yearOfPublication, pages);
            }
            Console.WriteLine("\nИнформация о всех книгах:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }

            Console.ReadLine(); 
        }
    }
}

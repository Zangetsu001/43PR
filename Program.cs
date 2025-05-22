using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите модель ноутбука: ");
            string model = Console.ReadLine();
            Console.Write("Введите производителя ноутбука: ");
            string manufacturer = Console.ReadLine();

            double price;
            while (true)
            {
                Console.Write("Введите цену ноутбука: ");
                if (double.TryParse(Console.ReadLine(), out price) && price > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите корректную цену.");
                }
            }
            Notebook notebook = new Notebook(model, manufacturer, price);
            notebook.DisplayInfo();
            Console.Read();

        }
    }
}

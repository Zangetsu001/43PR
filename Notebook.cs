using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public struct Notebook
    {
        public string Model;
        public string Manufacturer;
        public double Price;
        public Notebook(string model, string manufacturer, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Цена: " + Price);
        }
    }
}

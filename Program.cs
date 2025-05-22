using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            Console.WriteLine("Изменено");
        }
        static void StructTaker(MyStruct myStruct)
        {
            Console.WriteLine("Изменено");
        }
        static void Main(string[] args)
        {
            MyClass classInstance = new MyClass();
            classInstance.change = "Не изменено";
            MyStruct structInstance = new MyStruct();
            structInstance.change = "Не изменено";
            ClassTaker(classInstance);
            StructTaker(structInstance);
            Console.WriteLine($"Класс: " +  classInstance.change);
            Console.WriteLine($"Стурктура: " +  structInstance.change);
            Console.Read();
        }
    }
}

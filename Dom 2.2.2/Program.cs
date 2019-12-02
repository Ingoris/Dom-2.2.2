using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom_2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Название товара: ");
            string name = Console.ReadLine();
            Console.Write("Количество : ");
            double quantity = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Единицы измерения (кг): ");
            string number = Console.ReadLine();
            Console.Write("Цена : ");
            double price = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Название товара {0}, \nКоличество  {1}, \nЕдиницы измерения (кг)  {2}, \nЦена {3}", name.ToUpper(), quantity, number.ToLower(), price);
            Console.ReadKey(); 
        }
    }
}

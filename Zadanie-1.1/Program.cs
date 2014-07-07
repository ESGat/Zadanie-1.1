using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление площади круга при известной длине окружности. ");
            Console.WriteLine("Программа работает с натуральными числами и десятичными дробями ");
            Console.WriteLine("(для ввода десятичной дроби воспользуйтесь запятой). ");
            Console.Write("Введите длину окружности: ");
            Double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь круга равна: {0}", l * l / (4 * 3.14));
            Console.WriteLine("Нажмите любую клавишу, если хотите выйти");
            Console.ReadKey();
        }
    }
}

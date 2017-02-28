using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            double k,b;
            Console.WriteLine("Задайте прямую y=kx+b");
            Console.WriteLine("Введите коэффициенты: ");
            k = Program.Catch();
            b = Program.Catch();
            var a = new Line(k, b);
            Console.WriteLine("Задайте вторую прямую y=kx+b");
            Console.WriteLine("Введите коэффициенты: ");
            k = Program.Catch();
            b = Program.Catch();
            var a1 = new Line(k, b);
            var c = Operation.intersection(a, a1);
            Point.print(c);
            Console.ReadKey();
        }
        public static double Catch()
        {
            double a = 0;
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка, данные могут быть только числа.");
                Console.WriteLine("Попробуйте ввести еще раз!");
                a = double.Parse(Console.ReadLine());
            }
            return a;
        }
    }
}

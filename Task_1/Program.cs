using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = LengthOfCircle;
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Длинна окружности: {myDelegate(r)} ");
            myDelegate = SquareOfCircle;
            Console.WriteLine($"Площадь круга: {myDelegate(r)} ");
            myDelegate = VolumeOfSphere;
            Console.WriteLine($"Объем шара: {myDelegate(r)} ");
            Console.ReadKey();
        }

        static double LengthOfCircle(double r)
        {
            return 2 * Math.PI * r;
        }
        static double SquareOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static double VolumeOfSphere(double r)
        {
            return 4 / 3 * Math.PI * Math.Pow(r, 3);
        }

    }
}

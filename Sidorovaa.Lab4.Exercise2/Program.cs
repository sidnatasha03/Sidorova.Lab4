using System;

namespace Sidorova.Lab4.Exercise2
{
    class Program
    {

        static double Method1(double k)
        {
            double s = Math.Pow(k, Math.E) / 50;
            return s;
        }

        static double Method2(double k)
        {

            if (k == 1)
            {
                return Method1(k);
            }
            else
            {
                return Method1(k) * Method2(k - 1);
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double s = Method2(n);

            Console.WriteLine(s);

        }
    }
}
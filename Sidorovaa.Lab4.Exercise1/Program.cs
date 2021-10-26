using System;

namespace Sidorova.Lab4.Exercise1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Выберете, с чем будет работать метод: int, double, char?");
            string a;

            a = Console.ReadLine();

            switch (a)
            {
                case "int":
                    Console.WriteLine("Введите х: ");
                    int xi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите y: ");
                    int yi = Convert.ToInt32(Console.ReadLine());
                    int m = Form1(xi, yi);
                    Console.WriteLine(m);

                    break;
            }

            switch (a)
            {
                case "double":
                    Console.WriteLine("Введите х: ");
                    double xd = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите y: ");
                    double yd = double.Parse(Console.ReadLine());
                    double m = Form2(xd, yd);
                    Console.WriteLine(m);

                    break;
            }

            switch (a)
            {
                case "char":
                    Console.WriteLine("Введите х: ");
                    char xc = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Введите y: ");
                    char yc = char.Parse(Console.ReadLine());
                    char m = Form3(xc, yc);
                    Console.WriteLine(m);

                    break;
            }

            static int Form1(int x, int y)
            {
                int x1 = (int)Math.Pow(x, 3);
                int y1 = Math.Abs(y + 13);

                if (x1 > y1)
                {
                    return x1;
                }

                else
                {
                    return y1;
                }

            }

            static double Form2(double x, double y)
            {
                double x1 = Math.Pow(x, 3);
                double y1 = Math.Abs(y + 13);

                if (x1 > y1)
                {
                    return x1;
                }

                else
                {
                    return y1;
                }

            }


            static char Form3(char x, char y)
            {
                char x1 = (char)Math.Pow(x, 3);
                char y1 = (char)Math.Abs(y + 13);

                if (x1 > y1)
                {
                    return x1;
                }

                else
                {
                    return y1;
                }

            }
        }
    }
}
using System;

namespace ConsoleApplication1
{
    class Program
    {

        private static double F(double a, double b, double c, double x)
        {
            if (x < 0 && b != 0)
            {
                return a * x * x + b;
            }
            else if (x > 0 && b == 0)
            {

                return (x - a) / (x - c);
            }
            else
            {
                return x / c;
            }
        }

        private static int F(int a, int b, int c, int x, ref bool error)
        {
            error = false;
            if (x < 0 && b != 0)
                return a * x * x + b;
            if (x > 0 && b == 0)
            {
                // здесь может проблема №1
                if (x - c != 0)
                    return (x - a) / (x - c);
                else
                    error = true;
            }
            // здесь может проблема №2
            if (c != 0)
                return x / c;
            else
                error = true;

            return 0;
        }

        private static int FN(int a, int b, int c, int x)
        {
            if (x < 0 && b != 0)
                return a * x * x + b;
            if (x > 0 && b == 0)
                return (x - a) / (x - c);
            return x / c;
        }

        static void Main()
        {
            // ввод с клавиатуры X1, X2
            // ввод с клавиатуры a, b, c
            // ввод с клавиатуры dX (шаг)

            double X1 = 0; // начальный Х
            double X2 = 10; // конечный Х
            double dX = 0.05; // шаг Х
            double x;
            const double a = 1;
            const double b = 2;
            const double c = 3;
            var error = false;

            // X1 = 0, 0.1, 0.2, 0.3, ... 9.8, 9.9, X2 = 10


            // int f = F(1, 2, 0, -3, ref error);
            //
            // if (error)
            // {
            //     Console.WriteLine("Возникла ошибка при вычислениях, делить на 0 нельзя!");
            // }
            // else
            // {
            //     Console.WriteLine($"F = {f}");
            // }

            try
            {
                Console.Write($"F = { FN(1, 2, 0, -3) } ");
            }
            catch
            {
                Console.WriteLine("Возникла ошибка при вычислениях, делить на 0 нельзя!");
            }

            // x = X1;
            // while (x < X2)
            // {
            //     Console.WriteLine($"x = {x:0.00},\t F = {F(a, b, c, x):0.###}"); // F => печать в консоль
            //     x += dX; // x = x + dX;
            // }
            
        }
    }
}
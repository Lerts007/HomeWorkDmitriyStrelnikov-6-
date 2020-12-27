using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    public delegate double Function(double x);
 
    class Plot
    {
        public int min;
        public int max;
        public double[] MyArray;

        public void lenght()
        {
            int min, max;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Введите длину отрезка." +
                "\nМинимальное значение min = ");
            while (!int.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Введите целое число!");
                Console.Write("Минимальное значение min = ");
            }
            this.min = min;

            Console.Write("Максимальное значение max = "); 
            while (!int.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("Введите целое число!");
                Console.Write("Максимальное значение max = ");
            }
            this.max = max;
            Console.WriteLine();
            Console.ResetColor();

        }

        public double f(double x) { return 5 * x * x; }

        public double g(double x) { return 2 * Math.Sin(x); }

        public double y(double x) { return x * x * Math.Tan(x); }

        public void Enter(Function fanc)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            double[] MyArray = new double[max - min + 1];

            int j = 0;
            for (int x = min; x <= max; x++)
            {
                double a = fanc(x);
                Console.WriteLine($"{x,3} | {a: 0.00}");
                MyArray[j] = a;
                j++;

            }

            this.MyArray = MyArray;

            Console.WriteLine();
            Console.ResetColor();

        }
        public void Array(out double[] arr)
        {
            arr = this.MyArray;
        }

        public void MinZnach()
        {
            var b = new Load(MyArray);
            double ResMin;
            b.Output(out ResMin);


            Console.WriteLine($"\nМинимальное значение функции: {ResMin: 0.00}\n");

        }
    }
}

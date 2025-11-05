using System;

namespace LinearAndPolynomial
{
    
    class LinearFunction
    {
        protected double a1;
        protected double a0;

        
        public virtual void SetCoefficients()
        {
            Console.Write("Введіть коефіцієнт a1: ");
            a1 = double.Parse(Console.ReadLine());
            Console.Write("Введіть коефіцієнт a0: ");
            a0 = double.Parse(Console.ReadLine());
        }

        public virtual void DisplayCoefficients()
        {
            Console.WriteLine($"Лінійна функція: f(x) = {a1}x + {a0}");
        }

       
        public virtual double Calculate(double x)
        {
            return a1 * x + a0;
        }
    }

    
    class Polynomial : LinearFunction
    {
        protected double a2, a3, a4;

        
        public override void SetCoefficients()
        {
            Console.Write("Введіть коефіцієнт a4: ");
            a4 = double.Parse(Console.ReadLine());
            Console.Write("Введіть коефіцієнт a3: ");
            a3 = double.Parse(Console.ReadLine());
            Console.Write("Введіть коефіцієнт a2: ");
            a2 = double.Parse(Console.ReadLine());
            Console.Write("Введіть коефіцієнт a1: ");
            a1 = double.Parse(Console.ReadLine());
            Console.Write("Введіть коефіцієнт a0: ");
            a0 = double.Parse(Console.ReadLine());
        }

        public override void DisplayCoefficients()
        {
            Console.WriteLine($"Многочлен: f(x) = {a4}x^4 + {a3}x^3 + {a2}x^2 + {a1}x + {a0}");
        }


        public override double Calculate(double x)
        {
            return a4 * Math.Pow(x, 4) + a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + a1 * x + a0;
        }
    }

    internal static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           
            LinearFunction linear = new LinearFunction();
            Console.WriteLine("=== ЛІНІЙНА ФУНКЦІЯ ===");
            linear.SetCoefficients();
            linear.DisplayCoefficients();

           
            Polynomial poly = new Polynomial();
            Console.WriteLine("\n=== МНОГОЧЛЕН ===");
            poly.SetCoefficients();
            poly.DisplayCoefficients();

            Console.Write("\nВведіть значення x: ");
            double x = double.Parse(Console.ReadLine());

            
            Console.WriteLine($"\nЗначення лінійної функції в точці x={x}: {linear.Calculate(x)}");
            Console.WriteLine($"Значення многочлена в точці x={x}: {poly.Calculate(x)}");
        }
    }
}

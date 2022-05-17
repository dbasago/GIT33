using System;

namespace Apuntesclase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercici 4 
            //Solucio y=Ax2+Bx+C
            double a, b, c, x1, x2;
            Console.WriteLine("Algoritme que utilitza la formula general");
            Console.WriteLine("");
            Console.WriteLine("Quin valor te A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quin valor te B:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quin valor te C:");
            c = Convert.ToDouble(Console.ReadLine());

            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;

            Console.WriteLine("El valor de x1 és:" + x1);
            Console.WriteLine("El valor de x2 és:" + x2);
        }
    }
}

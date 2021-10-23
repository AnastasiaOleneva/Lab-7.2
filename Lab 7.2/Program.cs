using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            double V, S;
            calcCube(a, out V, out S);
            Console.ReadKey();
        }


        static void calcCube(int a, out double V, out double S) 
        {
            Console.WriteLine("Введите высоту ребра куба");
            a = Convert.ToInt32(Console.ReadLine());
            V = Math.Pow(a,3);
            Console.WriteLine("Объем куба равен {0}",V);
            S = 6 * Math.Pow(a,2);
            Console.WriteLine("Площадь куба равна {0}", S);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radius_V
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            float S;
            double V;

            Console.Write("Введите площадь поверхности шара   ");//Вывод-ввод
            S = float.Parse(Console.ReadLine());
            Console.WriteLine();

            radius = Math.Sqrt(S / (4 * Math.PI));//Расчет радиуса

            Console.WriteLine("Радиус шара равен  ");          
            Console.WriteLine(radius);
            Console.WriteLine();

            V = (4 / 3) * Math.Pow(radius, 3) * Math.PI;//Расчет объема шара

            Console.WriteLine("Объем шара ");
            Console.WriteLine(V);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            var current1 = new List<int>();
            Console.WriteLine("Введите количество элементов в первой последовательности");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы последовательности");
            for (int i = 0; i < n; i++)
            {
                current1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var current2 = new List<int>();
            Console.WriteLine("Введите количество элементов во второй последовательности");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы последовательности");
            for (int i = 0; i < n; i++)
            {
                current2.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var another1 = current1.Select(s => new { g = s, last = s % 10 });
            var another2 = current2.Select(s => new { l = s, last = s % 10 });
            var another = from z in another1
                          join b in another2
                               on z.last equals b.last
                          select (z.g+"-"+b.l);
       Console.WriteLine("Отсортированная последовательность: ");
            foreach (var i in another)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();

        }
    }
}

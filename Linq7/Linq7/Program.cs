using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k1 ,k2;
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
            Console.WriteLine("Введите параметр для первой последовательности");
            k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите параметр для второй последовательности");
            k2 = Convert.ToInt32(Console.ReadLine());
            var another1 = from z in current1
                          where z>k1
                          select z;
            var another2 = from z in current2
                           where z < k2
                           select z;
            another1 = another1.Concat(another2);
            another1=another1.OrderBy(s=>s);
            Console.WriteLine("Отсортированная последовательность: ");
            foreach (int i in another1)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
            Console.WriteLine("Отсортированная последовательность: ");
            foreach (int i in another1)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

    }
}

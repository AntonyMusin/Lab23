using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static int GetFact(int N)
        {
            int fact = 1;
            if (N != 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    fact *= i;
                }
            }
            return fact;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число большее 0");
            int N = Convert.ToInt32(Console.ReadLine());
            GetFactAsync(N);
            Console.WriteLine($"Факториал N ={GetFact(N)}") ;
            Console.WriteLine("Метод Main закончил работу");
            Console.ReadKey();
        }
        static async Task<int> GetFactAsync(int N)
        {
            Console.WriteLine("Метод GetFactAsync начал свою работу");
            int result = await Task.Run(() => GetFact(N));
            Console.WriteLine("Метод  GetFactAsync окончил работу");
            return result;
        }
    }
}

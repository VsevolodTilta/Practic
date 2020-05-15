using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
	class Program
	{
        public static int recursion(int n, int m)
        {
            if ( n == 0)
            {
                return m + 1;
            }
            else if (n != 0 && m == 0)
            {
                return recursion(n - 1, 1);
            }
            else
            {
                return recursion(n - 1, recursion(n, m - 1));
            }
        }
        static void Main(string[] args)
		{
            try
            {
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите m: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Функция Аккермана = " + recursion(n, m));
            }
            catch
            {
                Console.WriteLine("Неверные данные");
            }
            Console.ReadKey();
        }
	}
}

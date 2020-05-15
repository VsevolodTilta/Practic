using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        public static void Foo(int n)
        {
            if (n > 0)
            {
                Console.Write("{0} ", n);
                Foo(n - 1);
            }
        }
        public static void Main()
        {
            try
            {
                Console.Write("Введите N: ");
                int n = int.Parse(Console.ReadLine());
                Foo(n);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Неверные данные");
            }
        }
    }
        
}

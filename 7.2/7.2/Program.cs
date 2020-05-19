using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите осмысленное сообщения: ");
                string s = Console.ReadLine();
                Console.Write("Введите символ: ");
                char x = Convert.ToChar(Console.ReadLine());
                string p = "Удалены те слова которые заканчиваются на заданный символ {0}: {1}";
                string[] mass = s.Split(' ', ',', '.', '-', '!', '?');
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i].EndsWith(x.ToString()))
                    {
                        Console.WriteLine(p, x, mass[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Неверные данные");
            }
            Console.ReadLine();
        }
    }
}

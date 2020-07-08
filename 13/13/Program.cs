using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13
{
    abstract class Trans
    {
        public string model;
        public string number;
        public double speed;
        public double liftPower;

        public Trans(string m, string numb, double s, double lif_pow, bool b = false)
        {
            model = m;
            number = numb;
            speed = s;
            liftPower = lif_pow;
        }

        public abstract void Print();
    }
    class Moto : Trans
    {
        public bool kolyaska;
        public Moto(string m, double s, string numb, double lif_pow, bool kol)
            : base(m, numb, s, lif_pow)
        {
            kolyaska = kol;
            if (kol == false)
                liftPower = 0;
            else
                liftPower = lif_pow;
        }
        public override void Print()
        {
            Console.WriteLine("Фирма: {0} \nМаксимальная скорость {1} \nНомер: {2} \nГрузоподьемность: {3} \nНаличие коляски: {4}", model, speed, number, liftPower, kolyaska);
            Console.WriteLine();
        }
    }

    class Legko : Trans
    {
        public Legko(string m, double s, string numb, double lif_pow)
            : base(m, numb, s, lif_pow) { }
        public override void Print()
        {
            Console.WriteLine("Фирма: {0} \nМаксимальная скорость {1} \nНомер: {2} \nГрузоподьемность: {3} ", model, speed, number, liftPower);
            Console.WriteLine();
        }
    }

    class Gruzovie : Trans
    {
        public bool pricep;
        public Gruzovie(string m, double s, string numb, double lif_pow, bool pric)
            : base(m, numb, s, lif_pow)
        {
            pricep = pric;
            if (pricep == true)
                liftPower *= 2;
        }
        public override void Print()
        {
            Console.WriteLine("Фирма: {0} \nМаксимальная скорость {1} \nНомер: {2} \nГрузоподьемность: {3} \nНаличие прицепа: {4}", model, speed, number, liftPower, pricep);
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] strAss = File.ReadAllLines("Text.txt");
            Trans[] mas = new Trans[strAss.Length];
			for (int i = 0; i < mas.Length; i++)
			{
                string[] anal = strAss[i].Split(';');
				switch (anal[0])
				{
                    case "Moto":
						{
                            mas[i] = new Moto(anal[1], double.Parse(anal[2]), anal[3], double.Parse(anal[4]), bool.Parse(anal[5]));
                            break;
						}
                    case "Legko":
                        {
                            mas[i] = new Legko(anal[1], double.Parse(anal[2]), anal[3], double.Parse(anal[4]));
                            break;
                        }
                    case "Gruzovie":
                        {
                            mas[i] = new Gruzovie(anal[1], double.Parse(anal[2]), anal[3], double.Parse(anal[4]), bool.Parse(anal[5]));
                            break;
                        }
                }                 
			}
            for (int i = 0; i < mas.Length; i++)
                mas[i].Print();
			Console.Write("Введите грузоподъемность: ");
            int gruz = int.Parse(Console.ReadLine());
            for (int i = 0; i < mas.Length; i++)
            {
                if (gruz <= mas[i].liftPower)
                    mas[i].Print();
            }
            
            Console.ReadKey();
        }
    }
}

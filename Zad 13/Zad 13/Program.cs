using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_13
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

        public abstract void Print(RichTextBox ok);
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
        public override void Print(RichTextBox ok)
        {
            ok.Text += $"Фирма: {model} \nМаксимальная скорость {speed} \nНомер: {number} \nГрузоподьемность: {liftPower} \nНаличие коляски: {kolyaska} \n";
        }
    }

    class Legko : Trans
    {
        public Legko(string m, double s, string numb, double lif_pow)
            : base(m, numb, s, lif_pow) { }
        public override void Print(RichTextBox ok)
        {
           ok.Text += $"Фирма: {model} \nМаксимальная скорость {speed} \nНомер: {number} \nГрузоподьемность: {liftPower} \n";
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
        public override void Print(RichTextBox ok)
        {
            ok.Text += $"Фирма: {model} \nМаксимальная скорость {speed} \nНомер: {number} \nГрузоподьемность: {liftPower} \nНаличие прицепа: {pricep} \n";
        }

    }
    static class Program
	{

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}

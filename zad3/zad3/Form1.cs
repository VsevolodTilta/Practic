using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3
{
	public partial class Form1 : Form
	{
		static double fx(double x)
		{
			return Math.Cos(2 * x) + Math.Sin(x - 3);
		}

		static void f(double x, out double y)
		{
			if (Math.Abs(x) <= 0.1)
				y = Math.Pow(x, 3) - 0.1;
			else if (Math.Abs(x) >= 0.1)
				y = 0.2 * x - 0.1;
			else
				y = Math.Pow(x, 3) + 0.1;
		}

		static double f(double x)
		{
			double y;
			if (Math.Abs(x) <= 0.1)
				y = Math.Pow(x, 3) - 0.1;
			else if (Math.Abs(x) >= 0.1)
				y = 0.2 * x - 0.1;
			else
				y = Math.Pow(x, 3) + 0.1;
			return y;
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBox1.Text);
				double b = double.Parse(textBox2.Text);
				label3.Text = fx(a) < fx(b) ? "Наибольшее число a" : "Наибольшее число b";
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBox3.Text);
				double b = double.Parse(textBox4.Text);
				double h = double.Parse(textBox5.Text);

				for (double i = a; i <= b; i += h)
				{
					richTextBox1.Text += "f(" + i + ")" + " = " + f(i);
				}
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBox6.Text);
				double b = double.Parse(textBox7.Text);
				double h = double.Parse(textBox8.Text);

				for (double i = a; i <= b; i += h)
				{
					richTextBox2.Text += "f(" + i + ")" + " = " + f(i) + "\n";
				}

				for (double i = a; i <= b; i += h)
				{
					double y;
					f(i, out y);
					richTextBox2.Text += "f(" + i + ")" + " = " + y;
				}
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}
	}
}

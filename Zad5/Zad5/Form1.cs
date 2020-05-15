﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static double f(double x)
		{
			try
			{
				if (x == -1) throw new Exception();
				else
					return Math.Sqrt(5 - Math.Pow(x, 3));
			}
			catch
			{
				throw;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBox1.Text);
				double b = double.Parse(textBox2.Text);
				double h = double.Parse(textBox3.Text);
				for (double i = 0; i <= b; i += h)
					try
					{
						label4.Text += ("y(" + i + ")" + "=" + f(i) + "\n");
					}
					catch
					{
						label4.Text += ("y(" + i + ")" + "=" + "error" + "\n");
					}
			}
			catch (FormatException)
			{
				MessageBox.Show("Неверный формат ввода данных");
			}
			catch
			{
				MessageBox.Show("Неизвестная ошибка");
			}
		}
	}
}

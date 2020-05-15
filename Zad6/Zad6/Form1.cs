using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//Задание 1.1
		int[] Mass()
		{
			int n = int.Parse(textBox1.Text);
			int[] mass = new int[n];
			Random rand = new Random();
			for (int i = 0; i < mass.Length; i++)
			{
				mass[i] = rand.Next(0, 10);
			}
			return mass;
		}

		void Print(int[] mass)
		{
			for (int i = 0; i < mass.Length; i++)
			{
				label2.Text += (mass[i] + " ");
			}

		}

		void Change(int[] mass)
		{
			int numb = int.Parse(textBox2.Text);
			for (int i = 0; i < mass.Length; i++)
			{
				if (mass[i] > numb)
					mass[i] = (int)mass[i] * 2;

				label4.Text += mass[i] + " ";
			}
		}
		//Задание 1.2
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int[] Massive = Mass();
				label2.Text = "Исходный массив: ";
				Print(Massive);
				label4.Text = "Измененный массив: ";
				Change(Massive);
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}

		int[,] Mass1()
		{
			int n = int.Parse(textBox3.Text);
			int m = int.Parse(textBox4.Text);
			int[,] mass = new int[n, m];
			Random rand = new Random();

			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					mass[i, j] = rand.Next(0, 10);
				}
			}
			return mass;
		}

		void Print(int[,] mass)
		{
			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					richTextBox1.Text += mass[i, j] + " ";
				}
				richTextBox1.Text += "\n";
			}
		}

		void Change(int[,] mass)
		{
			int numb = int.Parse(textBox5.Text);
			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					if (mass[i, j] > numb)
						mass[i, j] = (int)mass[i, j] * 2;
					richTextBox1.Text += mass[i, j] + " ";
				}
				richTextBox1.Text += "\n";
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			int[,] Massive = Mass1();
			richTextBox1.Text += "Исходный массив" + "\n";
			Print(Massive);
			richTextBox1.Text += "Исходный массив" + "\n";
			Change(Massive);
		}

		//Задание 2
		int[] Mass2()
		{
			int n = int.Parse(textBox6.Text);
			int[] mass = new int[n];
			Random rand = new Random();

			for (int i = 0; i < mass.Length; i++)
			{
				mass[i] = rand.Next(0, 10);
			}
			return mass;
		}

		void Print1(int[] mass)
		{
			for (int i = 0; i < mass.Length; i++)
			{
				richTextBox2.Text +=  mass[i] + " ";
			}
		}


		int Max(int[] mass)
		{
			int max = 0;
			int indexMax = 0;
			for (int i = 0; i < mass.Length; i++)
			{
				if (mass[i] > max)
				{
					indexMax = i;
					max = mass[i];
				}
			}
			return indexMax;
		}

		void Change1(int[] mass, int index)
		{
			int buffer = mass[index];
			mass[index] = mass[0];
			mass[0] = buffer;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				int[] Massive = Mass2();
				richTextBox2.Text += "Исходный массив: ";
				Print1(Massive);
				int indexMax = Max(Massive);
				richTextBox2.Text += "Максимальный элемент: " + Massive[indexMax] + "\n";
				richTextBox2.Text += "Измененный массив: ";
				Change1(Massive, indexMax);
				Print1(Massive);
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}
		//Задание 3
		int[,] Mass3()
		{
			int n = int.Parse(textBox7.Text);
			int m = int.Parse(textBox8.Text);
			int[,] mass = new int[n, m];
			Random rand = new Random();

			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					mass[i, j] = rand.Next(0, 10);
				}
			}
			return mass;
		}
		int[] Vect()
		{
			int n = int.Parse(textBox9.Text);
			int[] vector = new int[n];
			Random rand = new Random();
			for (int q = 0; q < vector.Length; q++)
			{
				vector[q] = rand.Next(0, 10);
			}
			return vector;
		}

		void PrintMass(int[,] mass)
		{
			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					richTextBox3.Text += mass[i, j] + " ";
				}
				richTextBox3.Text += "\n";
			}
		}

		void PrintVectr(int[] vector)
		{

			for (int q = 0; q < vector.Length; q++)
			{
				richTextBox3.Text +=vector[q] + " ";
			}
			richTextBox3.Text += "\n";
		}

		int[,] decision(int[,] mass, int[] vector)
		{
			int[,] result = new int[mass.GetLength(0), mass.GetLength(1)];
			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					result[i, j] += mass[i, j] * vector[i];
					richTextBox3.Text +=result[i, j] + " ";
				}
				richTextBox3.Text += "\n";
			}
			return result;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				int[,] Massive = Mass3();
				int[] Vector = Vect();
				richTextBox3.Text += "Исходный массив: " + "\n";
				PrintMass(Massive);
				richTextBox3.Text += "Исходный вектор: " + "\n";
				PrintVectr(Vector);
				richTextBox3.Text += "Перемноженный вектор на массив: " + "\n";
				decision(Massive, Vector);
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
			
		}
	}
}

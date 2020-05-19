using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            try
            {
                string input = textBox1.Text;
                int ind = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input.Substring(i, 1) != " ")
                        ind++;
                }
                label2.Text = ($"{ind} букв в строке");
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
                string s = textBox2.Text;
                char x = Convert.ToChar(textBox3.Text);
                string[] mass = s.Split(' ', ',', '.', '-', '!', '?');
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i].EndsWith(x.ToString()))
                    {
                        richTextBox1.Text += $"Удалены те слова которые заканчиваются на заданный символ {x}: {mass[i]}";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}

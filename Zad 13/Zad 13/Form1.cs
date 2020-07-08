using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zad_13
{

    public partial class Form1 : Form
	{
        Trans[] mas;

        public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            try
            {
                int gruz = int.Parse(textBox1.Text);
                for (int i = 0; i < mas.Length; i++)
                {
                    if (gruz <= mas[i].liftPower)
                        mas[i].Print(richTextBox2);
                }
            }
			catch
			{
                MessageBox.Show("Неверные данные");
			}
        }

		private void Form1_Load(object sender, EventArgs e)
		{
            string[] strAss = File.ReadAllLines("Text.txt");
            mas = new Trans[strAss.Length];
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
                mas[i].Print(richTextBox1);
        }
	}
}

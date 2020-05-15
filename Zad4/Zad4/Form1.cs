using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad4
{
	public partial class Form1 : Form
	{
        public Form1()
		{   
			InitializeComponent();

		}
        public static int recursion(int n, int m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if (n != 0 && m == 0)
            {
                return recursion(n- 1, 1);
            }
            else
            {
                return recursion(n - 1, recursion(n, m - 1));
            }
        }
        private void button1_Click(object sender, EventArgs e)
		{
            try
            {
                int n = int.Parse(textBox1.Text);
                int m = int.Parse(textBox2.Text);

                label3.Text = "Функция Аккермана = " + recursion(n, m);
            }
            catch
            {
                MessageBox.Show("Неверные данные");
            }
        }

        public void Foo(int n)
        {
            if (n > 0)
            {
                label5.Text += n + " "; 
                Foo(n - 1);
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox3.Text);
            Foo(n);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessons
{
	public partial class Lesson4 : Form
	{
		public Lesson4()
		{
            InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
            int result = 0;
            try
            {
                result = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                label1.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                statusStrip1.Items[0].Text = ex.Message;
            }
            catch
            {
                label1.Text = "Неизвестная ошибка!";
            }
        }

		private void statusStrip1_MouseClick(object sender, MouseEventArgs e)
		{
                MessageBox.Show("Сlicked status bar");
        }

		private void statusStrip1_Resize(object sender, EventArgs e)
		{
            statusStrip1.Items[0].Width = statusStrip1.Width - 200;
        }
	}
}

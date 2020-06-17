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
	public partial class Lesson3 : Form
	{
		public Lesson3()
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
	}
}

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
	public partial class Lesson11 : Form
	{
		public Lesson11()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            
            Size sz = SystemInformation.PrimaryMonitorSize;
            richTextBox1.Text += sz + "\n";

            String cn = SystemInformation.ComputerName;
            richTextBox1.Text += cn + "\n";

            int k = SystemInformation.MouseButtons;
            richTextBox1.Text += k + "\n";

            Font f = SystemInformation.MenuFont;
            String fn = f.Name;
            richTextBox1.Text += f.Name + "\n";

            bool b = SystemInformation.Network;
            richTextBox1.Text += b + "\n";

            String un = SystemInformation.UserName;
            richTextBox1.Text += un + "\n";

            int w = SystemInformation.VerticalScrollBarWidth;
            richTextBox1.Text += w + "\n";

        }
	}
}

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
	public partial class Lesson8 : Form
	{
		public Lesson8()
		{
			InitializeComponent();
		}

		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string s = ((ToolStripMenuItem)sender).Text;
			MessageBox.Show(s);
		}

		public int num = 0;

		private void button1_Click(object sender, System.EventArgs e)
		{
			num++;
			ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
			mi.Click += this.ToolStripMenuItem1_Click;

			toolStripMenuItem1.DropDownItems.Add(mi);
		}
	}
}

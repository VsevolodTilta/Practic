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
	public partial class Lesson31 : Form
	{
		public Lesson31()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			saveFileDialog1.InitialDirectory = "C:\tmp";
			saveFileDialog1.Filter = "abc files (*.abs)|*.abs|All files|*.*";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string fileName = saveFileDialog1.FileName;
			}

		}
	}
}

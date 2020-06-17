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
	public partial class Lesson9 : Form
	{
		public Lesson9()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{ 
			ContextMenuStrip cms = new ContextMenuStrip();
			cms.Items.AddRange(new ToolStripItem[]
			{
				this.cutToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.pasteToolStripMenuItem,
			});

			this.ContextMenuStrip = cms;
		}
	}
}

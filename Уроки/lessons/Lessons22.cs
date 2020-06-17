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
	public partial class Lessons22 : Form
	{
		public Lessons22()
		{
			InitializeComponent();
		}

		private void Lessons22_Load(object sender, EventArgs e)
		{
			linkLabel1.Links[0].LinkData = "https://microsoft.com";
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}
	}
}

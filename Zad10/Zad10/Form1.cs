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

namespace Zad10
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
				richTextBox1.Text = " ";
				Directory.Delete("c:\\temp", true);
				if (!Directory.Exists("c:\\temp"))
				{
					Directory.CreateDirectory("c:\\temp");
				}
				Directory.CreateDirectory("c:\\temp\\K1");
				Directory.CreateDirectory("c:\\temp\\K2");
				StreamWriter sw = new StreamWriter("c:\\temp\\K1\\t1.txt");
				sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
				sw.Close();
				sw = new StreamWriter("c:\\temp\\K1\\t2.txt");
				sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
				sw.Close();
				sw = new StreamWriter("c:\\temp\\K2\\t3.txt");
				StreamReader sr = new StreamReader("c:\\temp\\K1\\t1.txt");
				sw.WriteLine(sr.ReadToEnd());
				sr.Close();
				sr = new StreamReader("c:\\temp\\K1\\t2.txt");
				sw.WriteLine(sr.ReadToEnd());
				sr.Close();
				sw.Close();
				File.Move("c:\\temp\\K1\\t2.txt", "c:\\temp\\K2\\t2.txt");
				File.Copy("c:\\temp\\K1\\t1.txt", "c:\\temp\\K2\\t1.txt");
				Directory.Move("c:\\temp\\K2", "c:\\temp\\ALL");
				Directory.Delete("c:\\temp\\K1", true);
				DirectoryInfo dinf = new DirectoryInfo("c:\\temp\\ALL");
				FileInfo[] finf = dinf.GetFiles();
				foreach (FileInfo fi in finf)
				{
					richTextBox1.Text += fi.FullName.ToString() + "\n" + fi.Attributes.ToString();
				}
			}
			catch	
			{
				MessageBox.Show("Неверные данные");
			}
		}
	}
}

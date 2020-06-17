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
	public partial class Lesson21 : Form
	{
		public Lesson21()
		{
			InitializeComponent();
		}
		

		private void button1_Click(object sender, EventArgs e)
		{
			Type t = Type.GetType("lessons." + textBox1.Text);
			ISomeInterface w = (ISomeInterface)Activator.CreateInstance(t);
			w.SomeMethod();


		}
	}
	public interface ISomeInterface
	{
		void SomeMethod();
	}
	public class Class1 : ISomeInterface
	{
		public void SomeMethod()
		{
			System.Windows.Forms.MessageBox.Show("Class1");
		}
	}

	public class Class2 : ISomeInterface
	{
		public void SomeMethod()
		{
			System.Windows.Forms.MessageBox.Show("Class2");
		}
	}
}

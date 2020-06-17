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
	public partial class Lesson17 : Form
	{
		public Lesson17()
		{
			InitializeComponent();
		}

		private void Lesson17_Load(object sender, EventArgs e)
		{
			// Перебираем все элементы на форме.
			foreach (Control c in Controls)
			{
				// Если элемент есть потомок класса ButtonBase,
				if (c is ButtonBase)
				{
					// то применяем стиль Системы.
					((ButtonBase)c).FlatStyle = FlatStyle.System;

				}
			}
		}
	}
}

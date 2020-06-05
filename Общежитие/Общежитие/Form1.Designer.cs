namespace Общежитие
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.общежитиеDataSet = new Общежитие.ОбщежитиеDataSet();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.ExitFromProgr = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lgotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ResettlementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.общежитиеDataSet;
			this.bindingSource1.Position = 0;
			// 
			// общежитиеDataSet
			// 
			this.общежитиеDataSet.DataSetName = "ОбщежитиеDataSet";
			this.общежитиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1,
            this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(157, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitFromProgr});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
			this.toolStripDropDownButton1.Text = "Файл";
			// 
			// ExitFromProgr
			// 
			this.ExitFromProgr.Name = "ExitFromProgr";
			this.ExitFromProgr.Size = new System.Drawing.Size(109, 22);
			this.ExitFromProgr.Text = "Выход";
			this.ExitFromProgr.Click += new System.EventHandler(this.ExitFromProgr_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomToolStripMenuItem,
            this.lgotToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.ResettlementToolStripMenuItem,
            this.CallToolStripMenuItem,
            this.ReportToolStripMenuItem});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(69, 22);
			this.toolStripDropDownButton2.Text = "Таблицы";
			// 
			// roomToolStripMenuItem
			// 
			this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
			this.roomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.roomToolStripMenuItem.Text = "Комнаты";
			this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
			// 
			// lgotToolStripMenuItem
			// 
			this.lgotToolStripMenuItem.Name = "lgotToolStripMenuItem";
			this.lgotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.lgotToolStripMenuItem.Text = "Льготы";
			this.lgotToolStripMenuItem.Click += new System.EventHandler(this.lgotToolStripMenuItem_Click);
			// 
			// studentToolStripMenuItem
			// 
			this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
			this.studentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.studentToolStripMenuItem.Text = "Студенты";
			this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click_1);
			// 
			// ResettlementToolStripMenuItem
			// 
			this.ResettlementToolStripMenuItem.Name = "ResettlementToolStripMenuItem";
			this.ResettlementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ResettlementToolStripMenuItem.Text = "Расселение";
			this.ResettlementToolStripMenuItem.Click += new System.EventHandler(this.ResettlementToolStripMenuItem_Click);
			// 
			// CallToolStripMenuItem
			// 
			this.CallToolStripMenuItem.Name = "CallToolStripMenuItem";
			this.CallToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.CallToolStripMenuItem.Text = "Запросы";
			this.CallToolStripMenuItem.Click += new System.EventHandler(this.CallToolStripMenuItem_Click);
			// 
			// ReportToolStripMenuItem
			// 
			this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
			this.ReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ReportToolStripMenuItem.Text = "Отчет";
			this.ReportToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(157, 39);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private ОбщежитиеDataSet общежитиеDataSet;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem ExitFromProgr;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lgotToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ResettlementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CallToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
	}
}


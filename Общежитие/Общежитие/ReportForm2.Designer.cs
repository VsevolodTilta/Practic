namespace Общежитие
{
	partial class ReportForm2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.ОбщежитиеDataSet = new Общежитие.ОбщежитиеDataSet();
			this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.StudentTableAdapter = new Общежитие.ОбщежитиеDataSetTableAdapters.StudentTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.ОбщежитиеDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.StudentBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "Общежитие.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(2, -1);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.Size = new System.Drawing.Size(633, 365);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// ОбщежитиеDataSet
			// 
			this.ОбщежитиеDataSet.DataSetName = "ОбщежитиеDataSet";
			this.ОбщежитиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// StudentBindingSource
			// 
			this.StudentBindingSource.DataMember = "Student";
			this.StudentBindingSource.DataSource = this.ОбщежитиеDataSet;
			// 
			// StudentTableAdapter
			// 
			this.StudentTableAdapter.ClearBeforeFill = true;
			// 
			// ReportForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 363);
			this.Controls.Add(this.reportViewer1);
			this.Name = "ReportForm2";
			this.Text = "Отчеты";
			this.Load += new System.EventHandler(this.ReportForm2_Load);
			((System.ComponentModel.ISupportInitialize)(this.ОбщежитиеDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource StudentBindingSource;
		private ОбщежитиеDataSet ОбщежитиеDataSet;
		private ОбщежитиеDataSetTableAdapters.StudentTableAdapter StudentTableAdapter;
	}
}
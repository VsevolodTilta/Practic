namespace Общежитие
{
	partial class CallForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonFullInfo = new System.Windows.Forms.RadioButton();
			this.radioButtonInfo = new System.Windows.Forms.RadioButton();
			this.radioButtonFloor = new System.Windows.Forms.RadioButton();
			this.radioButtonGroup = new System.Windows.Forms.RadioButton();
			this.radioButtonPO = new System.Windows.Forms.RadioButton();
			this.buttonCall = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 165);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(774, 194);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonPO);
			this.groupBox1.Controls.Add(this.radioButtonGroup);
			this.groupBox1.Controls.Add(this.radioButtonFloor);
			this.groupBox1.Controls.Add(this.radioButtonInfo);
			this.groupBox1.Controls.Add(this.radioButtonFullInfo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(334, 147);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выберите запрос";
			// 
			// radioButtonFullInfo
			// 
			this.radioButtonFullInfo.AutoSize = true;
			this.radioButtonFullInfo.Location = new System.Drawing.Point(6, 29);
			this.radioButtonFullInfo.Name = "radioButtonFullInfo";
			this.radioButtonFullInfo.Size = new System.Drawing.Size(192, 17);
			this.radioButtonFullInfo.TabIndex = 0;
			this.radioButtonFullInfo.TabStop = true;
			this.radioButtonFullInfo.Text = "Полная информация о студентах";
			this.radioButtonFullInfo.UseVisualStyleBackColor = true;
			// 
			// radioButtonInfo
			// 
			this.radioButtonInfo.AutoSize = true;
			this.radioButtonInfo.Location = new System.Drawing.Point(6, 52);
			this.radioButtonInfo.Name = "radioButtonInfo";
			this.radioButtonInfo.Size = new System.Drawing.Size(272, 17);
			this.radioButtonInfo.TabIndex = 1;
			this.radioButtonInfo.TabStop = true;
			this.radioButtonInfo.Text = "Краткая информация о студентах (ФИО, группа)";
			this.radioButtonInfo.UseVisualStyleBackColor = true;
			// 
			// radioButtonFloor
			// 
			this.radioButtonFloor.AutoSize = true;
			this.radioButtonFloor.Location = new System.Drawing.Point(6, 98);
			this.radioButtonFloor.Name = "radioButtonFloor";
			this.radioButtonFloor.Size = new System.Drawing.Size(218, 17);
			this.radioButtonFloor.TabIndex = 2;
			this.radioButtonFloor.TabStop = true;
			this.radioButtonFloor.Text = "№ комнат расположенных на 3 этаже";
			this.radioButtonFloor.UseVisualStyleBackColor = true;
			// 
			// radioButtonGroup
			// 
			this.radioButtonGroup.AutoSize = true;
			this.radioButtonGroup.Location = new System.Drawing.Point(6, 75);
			this.radioButtonGroup.Name = "radioButtonGroup";
			this.radioButtonGroup.Size = new System.Drawing.Size(321, 17);
			this.radioButtonGroup.TabIndex = 3;
			this.radioButtonGroup.TabStop = true;
			this.radioButtonGroup.Text = "Список групп, студенты которых проживают в общежитии";
			this.radioButtonGroup.UseVisualStyleBackColor = true;
			// 
			// radioButtonPO
			// 
			this.radioButtonPO.AutoSize = true;
			this.radioButtonPO.Location = new System.Drawing.Point(6, 121);
			this.radioButtonPO.Name = "radioButtonPO";
			this.radioButtonPO.Size = new System.Drawing.Size(291, 17);
			this.radioButtonPO.TabIndex = 4;
			this.radioButtonPO.TabStop = true;
			this.radioButtonPO.Text = "Список студентов, которые обучаются в группах ПО";
			this.radioButtonPO.UseVisualStyleBackColor = true;
			// 
			// buttonCall
			// 
			this.buttonCall.Location = new System.Drawing.Point(561, 18);
			this.buttonCall.Name = "buttonCall";
			this.buttonCall.Size = new System.Drawing.Size(110, 40);
			this.buttonCall.TabIndex = 2;
			this.buttonCall.Text = "Выполнить запрос";
			this.buttonCall.UseVisualStyleBackColor = true;
			this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(677, 18);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(109, 40);
			this.buttonClear.TabIndex = 3;
			this.buttonClear.Text = "Очистить";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// CallForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(799, 377);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCall);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CallForm";
			this.Text = "Запросы";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonPO;
		private System.Windows.Forms.RadioButton radioButtonGroup;
		private System.Windows.Forms.RadioButton radioButtonFloor;
		private System.Windows.Forms.RadioButton radioButtonInfo;
		private System.Windows.Forms.RadioButton radioButtonFullInfo;
		private System.Windows.Forms.Button buttonCall;
		private System.Windows.Forms.Button buttonClear;
	}
}
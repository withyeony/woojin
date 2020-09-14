namespace View
{
	partial class StandardTextModal
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Change = new System.Windows.Forms.Button();
			this.tb_Value = new System.Windows.Forms.TextBox();
			this.lbl_Value = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(40, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "기존 명칭";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(191, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "변경 명칭";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btn_Close);
			this.panel1.Controls.Add(this.btn_Change);
			this.panel1.Controls.Add(this.tb_Value);
			this.panel1.Controls.Add(this.lbl_Value);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(5, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(363, 240);
			this.panel1.TabIndex = 6;
			// 
			// btn_Close
			// 
			this.btn_Close.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.btn_Close.Location = new System.Drawing.Point(162, 191);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(95, 44);
			this.btn_Close.TabIndex = 10;
			this.btn_Close.Text = "취소";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Change
			// 
			this.btn_Change.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.btn_Change.Location = new System.Drawing.Point(263, 191);
			this.btn_Change.Name = "btn_Change";
			this.btn_Change.Size = new System.Drawing.Size(95, 44);
			this.btn_Change.TabIndex = 9;
			this.btn_Change.Text = "변경";
			this.btn_Change.UseVisualStyleBackColor = true;
			this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
			// 
			// tb_Value
			// 
			this.tb_Value.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.tb_Value.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.tb_Value.Location = new System.Drawing.Point(164, 80);
			this.tb_Value.Name = "tb_Value";
			this.tb_Value.Size = new System.Drawing.Size(154, 33);
			this.tb_Value.TabIndex = 8;
			// 
			// lbl_Value
			// 
			this.lbl_Value.AutoSize = true;
			this.lbl_Value.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.lbl_Value.Location = new System.Drawing.Point(40, 83);
			this.lbl_Value.Name = "lbl_Value";
			this.lbl_Value.Size = new System.Drawing.Size(95, 25);
			this.lbl_Value.TabIndex = 7;
			this.lbl_Value.Text = "기존 명칭";
			this.lbl_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StandardTextModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(373, 250);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StandardTextModal";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "StandardTextModal";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Change;
		private System.Windows.Forms.TextBox tb_Value;
		private System.Windows.Forms.Label lbl_Value;
	}
}
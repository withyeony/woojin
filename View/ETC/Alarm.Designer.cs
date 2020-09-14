namespace View
{
	partial class Alarm
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
			this.Btn_Confirm_1 = new System.Windows.Forms.Button();
			this.lbl_Content_1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Confirm_1
			// 
			this.Btn_Confirm_1.BackColor = System.Drawing.Color.SlateGray;
			this.Btn_Confirm_1.FlatAppearance.BorderSize = 0;
			this.Btn_Confirm_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Confirm_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Btn_Confirm_1.ForeColor = System.Drawing.SystemColors.Control;
			this.Btn_Confirm_1.Location = new System.Drawing.Point(92, 97);
			this.Btn_Confirm_1.Margin = new System.Windows.Forms.Padding(0);
			this.Btn_Confirm_1.Name = "Btn_Confirm_1";
			this.Btn_Confirm_1.Size = new System.Drawing.Size(97, 37);
			this.Btn_Confirm_1.TabIndex = 3;
			this.Btn_Confirm_1.Text = "확인";
			this.Btn_Confirm_1.UseVisualStyleBackColor = false;
			this.Btn_Confirm_1.Click += new System.EventHandler(this.Btn_Confirm_1_Click);
			// 
			// lbl_Content_1
			// 
			this.lbl_Content_1.Font = new System.Drawing.Font("Calibri", 13F);
			this.lbl_Content_1.Location = new System.Drawing.Point(12, 9);
			this.lbl_Content_1.Name = "lbl_Content_1";
			this.lbl_Content_1.Size = new System.Drawing.Size(238, 72);
			this.lbl_Content_1.TabIndex = 2;
			this.lbl_Content_1.Text = "sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";
			this.lbl_Content_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Alarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 169);
			this.Controls.Add(this.Btn_Confirm_1);
			this.Controls.Add(this.lbl_Content_1);
			this.Name = "Alarm";
			this.Text = "Alarm";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Btn_Confirm_1;
		private System.Windows.Forms.Label lbl_Content_1;
	}
}
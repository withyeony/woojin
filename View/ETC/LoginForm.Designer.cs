namespace View
{
    partial class LoginForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_PassWord = new System.Windows.Forms.TextBox();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Location = new System.Drawing.Point(28, 280);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(251, 1);
			this.panel2.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Location = new System.Drawing.Point(28, 210);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(251, 1);
			this.panel1.TabIndex = 14;
			// 
			// btn_Login
			// 
			this.btn_Login.BackColor = System.Drawing.Color.SkyBlue;
			this.btn_Login.FlatAppearance.BorderSize = 0;
			this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Login.ForeColor = System.Drawing.SystemColors.Window;
			this.btn_Login.Location = new System.Drawing.Point(163, 310);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(91, 34);
			this.btn_Login.TabIndex = 13;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = false;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.SkyBlue;
			this.btn_Exit.FlatAppearance.BorderSize = 0;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btn_Exit.ForeColor = System.Drawing.SystemColors.Window;
			this.btn_Exit.Location = new System.Drawing.Point(49, 310);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(91, 34);
			this.btn_Exit.TabIndex = 12;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 10.2F);
			this.label1.Location = new System.Drawing.Point(25, 228);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "PassWord";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 10.2F);
			this.label2.Location = new System.Drawing.Point(25, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "ID Code";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tb_PassWord
			// 
			this.tb_PassWord.BackColor = System.Drawing.SystemColors.Control;
			this.tb_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_PassWord.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_PassWord.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tb_PassWord.Location = new System.Drawing.Point(28, 258);
			this.tb_PassWord.Name = "tb_PassWord";
			this.tb_PassWord.PasswordChar = '*';
			this.tb_PassWord.Size = new System.Drawing.Size(251, 20);
			this.tb_PassWord.TabIndex = 9;
			// 
			// tb_ID
			// 
			this.tb_ID.BackColor = System.Drawing.SystemColors.Control;
			this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_ID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_ID.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tb_ID.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tb_ID.Location = new System.Drawing.Point(28, 191);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(251, 20);
			this.tb_ID.TabIndex = 8;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 373);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_PassWord);
			this.Controls.Add(this.tb_ID);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_PassWord;
		private System.Windows.Forms.TextBox tb_ID;
	}
}
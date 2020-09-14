namespace View
{
	partial class PartView
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
            this.cb_division = new System.Windows.Forms.ComboBox();
            this.txt_column = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_quality = new System.Windows.Forms.TextBox();
            this.txt_standard = new System.Windows.Forms.TextBox();
            this.txt_ename = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_partdelete = new System.Windows.Forms.Button();
            this.btn_partmodify = new System.Windows.Forms.Button();
            this.btn_partadd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dgvRefresh = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_Part = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_code = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Part)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_division
            // 
            this.cb_division.FormattingEnabled = true;
            this.cb_division.Location = new System.Drawing.Point(1539, 151);
            this.cb_division.Name = "cb_division";
            this.cb_division.Size = new System.Drawing.Size(250, 20);
            this.cb_division.TabIndex = 91;
            // 
            // txt_column
            // 
            this.txt_column.Location = new System.Drawing.Point(1539, 428);
            this.txt_column.Name = "txt_column";
            this.txt_column.Size = new System.Drawing.Size(250, 21);
            this.txt_column.TabIndex = 90;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(1539, 391);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(250, 21);
            this.txt_number.TabIndex = 89;
            // 
            // txt_quality
            // 
            this.txt_quality.Location = new System.Drawing.Point(1539, 350);
            this.txt_quality.Name = "txt_quality";
            this.txt_quality.Size = new System.Drawing.Size(250, 21);
            this.txt_quality.TabIndex = 88;
            // 
            // txt_standard
            // 
            this.txt_standard.Location = new System.Drawing.Point(1539, 307);
            this.txt_standard.Name = "txt_standard";
            this.txt_standard.Size = new System.Drawing.Size(250, 21);
            this.txt_standard.TabIndex = 87;
            // 
            // txt_ename
            // 
            this.txt_ename.Location = new System.Drawing.Point(1539, 267);
            this.txt_ename.Name = "txt_ename";
            this.txt_ename.Size = new System.Drawing.Size(250, 21);
            this.txt_ename.TabIndex = 86;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(1539, 229);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(250, 21);
            this.txt_name.TabIndex = 85;
            // 
            // btn_partdelete
            // 
            this.btn_partdelete.Location = new System.Drawing.Point(1684, 507);
            this.btn_partdelete.Name = "btn_partdelete";
            this.btn_partdelete.Size = new System.Drawing.Size(105, 105);
            this.btn_partdelete.TabIndex = 83;
            this.btn_partdelete.Text = "삭제";
            this.btn_partdelete.UseVisualStyleBackColor = true;
            this.btn_partdelete.Click += new System.EventHandler(this.btn_partdelete_Click);
            // 
            // btn_partmodify
            // 
            this.btn_partmodify.Location = new System.Drawing.Point(1550, 507);
            this.btn_partmodify.Name = "btn_partmodify";
            this.btn_partmodify.Size = new System.Drawing.Size(105, 105);
            this.btn_partmodify.TabIndex = 82;
            this.btn_partmodify.Text = "수정";
            this.btn_partmodify.UseVisualStyleBackColor = true;
            this.btn_partmodify.Click += new System.EventHandler(this.btn_partmodify_Click);
            // 
            // btn_partadd
            // 
            this.btn_partadd.Location = new System.Drawing.Point(1421, 507);
            this.btn_partadd.Name = "btn_partadd";
            this.btn_partadd.Size = new System.Drawing.Size(105, 105);
            this.btn_partadd.TabIndex = 81;
            this.btn_partadd.Text = "추가";
            this.btn_partadd.UseVisualStyleBackColor = true;
            this.btn_partadd.Click += new System.EventHandler(this.btn_partadd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 12F);
            this.label10.Location = new System.Drawing.Point(1422, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 80;
            this.label10.Text = "비고";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F);
            this.label9.Location = new System.Drawing.Point(1422, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F);
            this.label8.Location = new System.Drawing.Point(1422, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 78;
            this.label8.Text = "재질";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F);
            this.label7.Location = new System.Drawing.Point(1422, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "규격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F);
            this.label6.Location = new System.Drawing.Point(1422, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "품목명2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(1422, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = "품목명1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(1422, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "품목코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(1422, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "구분";
            // 
            // btn_dgvRefresh
            // 
            this.btn_dgvRefresh.Location = new System.Drawing.Point(1378, 814);
            this.btn_dgvRefresh.Name = "btn_dgvRefresh";
            this.btn_dgvRefresh.Size = new System.Drawing.Size(211, 45);
            this.btn_dgvRefresh.TabIndex = 72;
            this.btn_dgvRefresh.Tag = "";
            this.btn_dgvRefresh.Text = "새로고침";
            this.btn_dgvRefresh.UseVisualStyleBackColor = true;
            this.btn_dgvRefresh.Click += new System.EventHandler(this.btn_dgvRefresh_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1615, 814);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(211, 45);
            this.btn_close.TabIndex = 71;
            this.btn_close.Tag = "부품 정보";
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dgv_Part
            // 
            this.dgv_Part.AllowUserToAddRows = false;
            this.dgv_Part.AllowUserToDeleteRows = false;
            this.dgv_Part.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Part.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgv_Part.Location = new System.Drawing.Point(21, 32);
            this.dgv_Part.Name = "dgv_Part";
            this.dgv_Part.ReadOnly = true;
            this.dgv_Part.RowTemplate.Height = 23;
            this.dgv_Part.Size = new System.Drawing.Size(1311, 827);
            this.dgv_Part.TabIndex = 92;
            this.dgv_Part.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Part_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1421, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "부품정보";
            // 
            // cb_code
            // 
            this.cb_code.FormattingEnabled = true;
            this.cb_code.Location = new System.Drawing.Point(1539, 189);
            this.cb_code.Name = "cb_code";
            this.cb_code.Size = new System.Drawing.Size(250, 20);
            this.cb_code.TabIndex = 94;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "번호";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "구분";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "품목코드";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "품목명1";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "품목명2";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "규격";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "재질";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "수량";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "비고";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // PartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 883);
            this.Controls.Add(this.cb_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Part);
            this.Controls.Add(this.cb_division);
            this.Controls.Add(this.txt_column);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_quality);
            this.Controls.Add(this.txt_standard);
            this.Controls.Add(this.txt_ename);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_partdelete);
            this.Controls.Add(this.btn_partmodify);
            this.Controls.Add(this.btn_partadd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_dgvRefresh);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartView";
            this.Text = "PartView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Part)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.ComboBox cb_division;
        private System.Windows.Forms.TextBox txt_column;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_quality;
        private System.Windows.Forms.TextBox txt_standard;
        private System.Windows.Forms.TextBox txt_ename;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_partdelete;
        private System.Windows.Forms.Button btn_partmodify;
        private System.Windows.Forms.Button btn_partadd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dgvRefresh;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView dgv_Part;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}
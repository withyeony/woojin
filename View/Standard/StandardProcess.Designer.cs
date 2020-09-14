namespace View
{
	partial class StandardProcess
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnl_View = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_DP_Close = new System.Windows.Forms.Button();
			this.pnl_DBMS = new System.Windows.Forms.Panel();
			this.DP_Color2 = new System.Windows.Forms.Button();
			this.DP_Color1 = new System.Windows.Forms.Button();
			this.DP_DFName = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_DP_Apply = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lbl_DetailProcess = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.DP_Name = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.pnl_DBMS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_View
			// 
			this.pnl_View.AutoScroll = true;
			this.pnl_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_View.Location = new System.Drawing.Point(12, 54);
			this.pnl_View.Name = "pnl_View";
			this.pnl_View.Padding = new System.Windows.Forms.Padding(10);
			this.pnl_View.Size = new System.Drawing.Size(1083, 856);
			this.pnl_View.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Gainsboro;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.Location = new System.Drawing.Point(12, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(1083, 43);
			this.label9.TabIndex = 5;
			this.label9.Text = "표준 공정";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Gainsboro;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(1101, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(775, 43);
			this.label3.TabIndex = 30;
			this.label3.Text = "상세 공정";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(1500, 805);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(185, 105);
			this.button3.TabIndex = 32;
			this.button3.Text = "박새로이";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(1691, 805);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(185, 105);
			this.button2.TabIndex = 31;
			this.button2.Tag = "표준 공정";
			this.button2.Text = "닫기";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(1500, 694);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(185, 105);
			this.button1.TabIndex = 34;
			this.button1.Text = "저장";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.button4.Location = new System.Drawing.Point(1691, 694);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(185, 105);
			this.button4.TabIndex = 33;
			this.button4.Tag = "사원 정보";
			this.button4.Text = "메인 공정 추가";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btn_DP_Close);
			this.panel1.Controls.Add(this.pnl_DBMS);
			this.panel1.Controls.Add(this.lbl_DetailProcess);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_Delete);
			this.panel1.Controls.Add(this.btn_Update);
			this.panel1.Controls.Add(this.btn_Add);
			this.panel1.Controls.Add(this.dataGridView2);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(1101, 55);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(775, 612);
			this.panel1.TabIndex = 35;
			// 
			// btn_DP_Close
			// 
			this.btn_DP_Close.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.btn_DP_Close.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_DP_Close.Location = new System.Drawing.Point(342, 461);
			this.btn_DP_Close.Name = "btn_DP_Close";
			this.btn_DP_Close.Size = new System.Drawing.Size(95, 44);
			this.btn_DP_Close.TabIndex = 34;
			this.btn_DP_Close.Text = "닫기";
			this.btn_DP_Close.UseVisualStyleBackColor = true;
			this.btn_DP_Close.Click += new System.EventHandler(this.btn_DP_Close_Click);
			// 
			// pnl_DBMS
			// 
			this.pnl_DBMS.Controls.Add(this.DP_Name);
			this.pnl_DBMS.Controls.Add(this.DP_Color2);
			this.pnl_DBMS.Controls.Add(this.DP_Color1);
			this.pnl_DBMS.Controls.Add(this.DP_DFName);
			this.pnl_DBMS.Controls.Add(this.label10);
			this.pnl_DBMS.Controls.Add(this.label11);
			this.pnl_DBMS.Controls.Add(this.btn_DP_Apply);
			this.pnl_DBMS.Controls.Add(this.label12);
			this.pnl_DBMS.Controls.Add(this.label13);
			this.pnl_DBMS.Location = new System.Drawing.Point(13, 509);
			this.pnl_DBMS.Margin = new System.Windows.Forms.Padding(10);
			this.pnl_DBMS.Name = "pnl_DBMS";
			this.pnl_DBMS.Padding = new System.Windows.Forms.Padding(5);
			this.pnl_DBMS.Size = new System.Drawing.Size(745, 89);
			this.pnl_DBMS.TabIndex = 33;
			// 
			// DP_Color2
			// 
			this.DP_Color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DP_Color2.Location = new System.Drawing.Point(488, 47);
			this.DP_Color2.Name = "DP_Color2";
			this.DP_Color2.Size = new System.Drawing.Size(144, 26);
			this.DP_Color2.TabIndex = 40;
			this.DP_Color2.UseVisualStyleBackColor = true;
			this.DP_Color2.Click += new System.EventHandler(this.DP_Color1_Click);
			// 
			// DP_Color1
			// 
			this.DP_Color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DP_Color1.Location = new System.Drawing.Point(329, 46);
			this.DP_Color1.Name = "DP_Color1";
			this.DP_Color1.Size = new System.Drawing.Size(144, 26);
			this.DP_Color1.TabIndex = 39;
			this.DP_Color1.UseVisualStyleBackColor = true;
			this.DP_Color1.Click += new System.EventHandler(this.DP_Color1_Click);
			// 
			// DP_DFName
			// 
			this.DP_DFName.BackColor = System.Drawing.Color.Gainsboro;
			this.DP_DFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DP_DFName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DP_DFName.Location = new System.Drawing.Point(11, 46);
			this.DP_DFName.Name = "DP_DFName";
			this.DP_DFName.Size = new System.Drawing.Size(144, 26);
			this.DP_DFName.TabIndex = 37;
			this.DP_DFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Gainsboro;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(488, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 26);
			this.label10.TabIndex = 36;
			this.label10.Text = "작업 공정";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Gainsboro;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label11.Location = new System.Drawing.Point(329, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(144, 26);
			this.label11.TabIndex = 35;
			this.label11.Text = "공정 계획";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_DP_Apply
			// 
			this.btn_DP_Apply.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.btn_DP_Apply.Location = new System.Drawing.Point(642, 8);
			this.btn_DP_Apply.Name = "btn_DP_Apply";
			this.btn_DP_Apply.Size = new System.Drawing.Size(95, 64);
			this.btn_DP_Apply.TabIndex = 14;
			this.btn_DP_Apply.Text = "적용";
			this.btn_DP_Apply.UseVisualStyleBackColor = true;
			this.btn_DP_Apply.Click += new System.EventHandler(this.btn_DP_Apply_Click);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Gainsboro;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.Location = new System.Drawing.Point(170, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(144, 26);
			this.label12.TabIndex = 34;
			this.label12.Text = "상세 공정";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Gainsboro;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.Location = new System.Drawing.Point(11, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(144, 26);
			this.label13.TabIndex = 33;
			this.label13.Text = "표준 공정";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_DetailProcess
			// 
			this.lbl_DetailProcess.BackColor = System.Drawing.Color.Gainsboro;
			this.lbl_DetailProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_DetailProcess.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbl_DetailProcess.Location = new System.Drawing.Point(398, 10);
			this.lbl_DetailProcess.Name = "lbl_DetailProcess";
			this.lbl_DetailProcess.Size = new System.Drawing.Size(355, 26);
			this.lbl_DetailProcess.TabIndex = 32;
			this.lbl_DetailProcess.Text = "상세 공정";
			this.lbl_DetailProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Gainsboro;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(11, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 26);
			this.label1.TabIndex = 31;
			this.label1.Text = "표준 공정 목록";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_Delete.Location = new System.Drawing.Point(215, 461);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(95, 44);
			this.btn_Delete.TabIndex = 12;
			this.btn_Delete.Text = "삭 제";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.btn_Update.Location = new System.Drawing.Point(114, 461);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(95, 44);
			this.btn_Update.TabIndex = 11;
			this.btn_Update.Text = "수 정";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
			this.btn_Add.Location = new System.Drawing.Point(13, 461);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(95, 44);
			this.btn_Add.TabIndex = 10;
			this.btn_Add.Text = "추 가";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeColumns = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView2.Location = new System.Drawing.Point(398, 39);
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersWidth = 5;
			this.dataGridView2.RowTemplate.Height = 30;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(360, 397);
			this.dataGridView2.TabIndex = 2;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
			// 
			// Column9
			// 
			this.Column9.HeaderText = "No";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Visible = false;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "표준 공정";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.FillWeight = 109.7409F;
			this.Column5.HeaderText = "상세 공정";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.FillWeight = 60F;
			this.Column6.HeaderText = "공정계획";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column7
			// 
			this.Column7.FillWeight = 60F;
			this.Column7.HeaderText = "작업 공정";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.Location = new System.Drawing.Point(11, 39);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 5;
			this.dataGridView1.RowTemplate.Height = 30;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(360, 397);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Column1
			// 
			this.Column1.FillWeight = 75.10267F;
			this.Column1.HeaderText = "고유번호";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.FillWeight = 166.8943F;
			this.Column2.HeaderText = "공정명";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.FillWeight = 70F;
			this.Column3.HeaderText = "공정계획";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column4
			// 
			this.Column4.FillWeight = 70F;
			this.Column4.HeaderText = "작업공정";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// DP_Name
			// 
			this.DP_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DP_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DP_Name.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
			this.DP_Name.FormattingEnabled = true;
			this.DP_Name.Items.AddRange(new object[] {
            "번호",
            "직급",
            "부서",
            "이름"});
			this.DP_Name.Location = new System.Drawing.Point(170, 47);
			this.DP_Name.Name = "DP_Name";
			this.DP_Name.Size = new System.Drawing.Size(144, 28);
			this.DP_Name.TabIndex = 35;
			// 
			// StandardProcess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1888, 945);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pnl_View);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StandardProcess";
			this.Load += new System.EventHandler(this.StandardProcess_Load);
			this.panel1.ResumeLayout(false);
			this.pnl_DBMS.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnl_View;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Label lbl_DetailProcess;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnl_DBMS;
		private System.Windows.Forms.Button DP_Color2;
		private System.Windows.Forms.Button DP_Color1;
		private System.Windows.Forms.Label DP_DFName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btn_DP_Apply;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button btn_DP_Close;
		private System.Windows.Forms.ComboBox DP_Name;
	}
}
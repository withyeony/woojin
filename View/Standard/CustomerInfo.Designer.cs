namespace View
{
    partial class CustomerInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_company = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_member = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_customer_searchbox = new System.Windows.Forms.TextBox();
            this.cb_customer_Select = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_textbox_reset = new System.Windows.Forms.Button();
            this.txt_company_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_company_delete = new System.Windows.Forms.Button();
            this.btn_company_modify = new System.Windows.Forms.Button();
            this.btn_company_add = new System.Windows.Forms.Button();
            this.cb_company_Transaction = new System.Windows.Forms.ComboBox();
            this.cb_company_group = new System.Windows.Forms.ComboBox();
            this.txt_company_fax = new System.Windows.Forms.TextBox();
            this.txt_company_number = new System.Windows.Forms.TextBox();
            this.txt_company_ceo = new System.Windows.Forms.TextBox();
            this.txt_company_name = new System.Windows.Forms.TextBox();
            this.txt_company_code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_textbox_reset_m = new System.Windows.Forms.Button();
            this.btn_dgvRefresh = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_member_delete = new System.Windows.Forms.Button();
            this.txt_member_etc = new System.Windows.Forms.TextBox();
            this.btn_member_modify = new System.Windows.Forms.Button();
            this.txt_member_part = new System.Windows.Forms.TextBox();
            this.btn_member_add = new System.Windows.Forms.Button();
            this.txt_member_name = new System.Windows.Forms.TextBox();
            this.cb_member_code = new System.Windows.Forms.ComboBox();
            this.txt_member_email = new System.Windows.Forms.TextBox();
            this.txt_member_fax = new System.Windows.Forms.TextBox();
            this.txt_member_number = new System.Windows.Forms.TextBox();
            this.txt_member_position = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_company
            // 
            this.dgv_company.AllowUserToAddRows = false;
            this.dgv_company.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_company.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_company.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_company.Location = new System.Drawing.Point(29, 24);
            this.dgv_company.Name = "dgv_company";
            this.dgv_company.ReadOnly = true;
            this.dgv_company.RowTemplate.Height = 23;
            this.dgv_company.Size = new System.Drawing.Size(1255, 439);
            this.dgv_company.TabIndex = 0;
            this.dgv_company.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_company_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "업체코드";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "업체구분";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "업체명";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "대표자명";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "주소";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "전화번호";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "팩스번호";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "거래유무";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // dgv_member
            // 
            this.dgv_member.AllowUserToAddRows = false;
            this.dgv_member.AllowUserToDeleteRows = false;
            this.dgv_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_member.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dgv_member.Location = new System.Drawing.Point(29, 494);
            this.dgv_member.Name = "dgv_member";
            this.dgv_member.ReadOnly = true;
            this.dgv_member.RowTemplate.Height = 23;
            this.dgv_member.Size = new System.Drawing.Size(1255, 362);
            this.dgv_member.TabIndex = 1;
            this.dgv_member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_member_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Location = new System.Drawing.Point(472, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 59);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(290, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "검색어";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(65, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "항목";
            // 
            // txt_customer_searchbox
            // 
            this.txt_customer_searchbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_customer_searchbox.Location = new System.Drawing.Point(163, 48);
            this.txt_customer_searchbox.Multiline = true;
            this.txt_customer_searchbox.Name = "txt_customer_searchbox";
            this.txt_customer_searchbox.Size = new System.Drawing.Size(303, 33);
            this.txt_customer_searchbox.TabIndex = 5;
            // 
            // cb_customer_Select
            // 
            this.cb_customer_Select.BackColor = System.Drawing.SystemColors.Window;
            this.cb_customer_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_customer_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_customer_Select.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_customer_Select.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_customer_Select.FormattingEnabled = true;
            this.cb_customer_Select.ItemHeight = 25;
            this.cb_customer_Select.Items.AddRange(new object[] {
            "업체 구분",
            "업체 코드",
            "업체명",
            "대표자명",
            "주소",
            "전화번호",
            "FAX"});
            this.cb_customer_Select.Location = new System.Drawing.Point(25, 48);
            this.cb_customer_Select.Name = "cb_customer_Select";
            this.cb_customer_Select.Size = new System.Drawing.Size(132, 33);
            this.cb_customer_Select.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_textbox_reset);
            this.panel1.Controls.Add(this.txt_company_address);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_company_delete);
            this.panel1.Controls.Add(this.btn_company_modify);
            this.panel1.Controls.Add(this.btn_company_add);
            this.panel1.Controls.Add(this.cb_company_Transaction);
            this.panel1.Controls.Add(this.cb_company_group);
            this.panel1.Controls.Add(this.txt_company_fax);
            this.panel1.Controls.Add(this.txt_company_number);
            this.panel1.Controls.Add(this.txt_company_ceo);
            this.panel1.Controls.Add(this.txt_company_name);
            this.panel1.Controls.Add(this.txt_company_code);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1844, 459);
            this.panel1.TabIndex = 10;
            // 
            // btn_textbox_reset
            // 
            this.btn_textbox_reset.Location = new System.Drawing.Point(1712, 415);
            this.btn_textbox_reset.Name = "btn_textbox_reset";
            this.btn_textbox_reset.Size = new System.Drawing.Size(90, 23);
            this.btn_textbox_reset.TabIndex = 32;
            this.btn_textbox_reset.Text = "내용 지우기";
            this.btn_textbox_reset.UseVisualStyleBackColor = true;
            this.btn_textbox_reset.Click += new System.EventHandler(this.btn_textbox_reset_Click);
            // 
            // txt_company_address
            // 
            this.txt_company_address.Location = new System.Drawing.Point(1397, 287);
            this.txt_company_address.Name = "txt_company_address";
            this.txt_company_address.Size = new System.Drawing.Size(285, 21);
            this.txt_company_address.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F);
            this.label2.Location = new System.Drawing.Point(1307, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "주소";
            // 
            // btn_company_delete
            // 
            this.btn_company_delete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
            this.btn_company_delete.Location = new System.Drawing.Point(1712, 319);
            this.btn_company_delete.Name = "btn_company_delete";
            this.btn_company_delete.Size = new System.Drawing.Size(90, 90);
            this.btn_company_delete.TabIndex = 29;
            this.btn_company_delete.Text = "업체 정보 \r\n삭제";
            this.btn_company_delete.UseVisualStyleBackColor = true;
            this.btn_company_delete.Click += new System.EventHandler(this.btn_company_delete_Click);
            // 
            // btn_company_modify
            // 
            this.btn_company_modify.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
            this.btn_company_modify.Location = new System.Drawing.Point(1712, 223);
            this.btn_company_modify.Name = "btn_company_modify";
            this.btn_company_modify.Size = new System.Drawing.Size(90, 90);
            this.btn_company_modify.TabIndex = 28;
            this.btn_company_modify.Text = "업체 정보\r\n수정";
            this.btn_company_modify.UseVisualStyleBackColor = true;
            this.btn_company_modify.Click += new System.EventHandler(this.btn_company_modify_Click);
            // 
            // btn_company_add
            // 
            this.btn_company_add.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
            this.btn_company_add.Location = new System.Drawing.Point(1712, 127);
            this.btn_company_add.Name = "btn_company_add";
            this.btn_company_add.Size = new System.Drawing.Size(90, 90);
            this.btn_company_add.TabIndex = 27;
            this.btn_company_add.Text = "업체 정보 \r\n추가";
            this.btn_company_add.UseVisualStyleBackColor = true;
            this.btn_company_add.Click += new System.EventHandler(this.btn_company_add_Click);
            // 
            // cb_company_Transaction
            // 
            this.cb_company_Transaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_company_Transaction.FormattingEnabled = true;
            this.cb_company_Transaction.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cb_company_Transaction.Location = new System.Drawing.Point(1397, 401);
            this.cb_company_Transaction.Name = "cb_company_Transaction";
            this.cb_company_Transaction.Size = new System.Drawing.Size(285, 20);
            this.cb_company_Transaction.TabIndex = 26;
            // 
            // cb_company_group
            // 
            this.cb_company_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_company_group.FormattingEnabled = true;
            this.cb_company_group.Location = new System.Drawing.Point(1397, 175);
            this.cb_company_group.Name = "cb_company_group";
            this.cb_company_group.Size = new System.Drawing.Size(285, 20);
            this.cb_company_group.TabIndex = 25;
            // 
            // txt_company_fax
            // 
            this.txt_company_fax.Location = new System.Drawing.Point(1397, 365);
            this.txt_company_fax.Name = "txt_company_fax";
            this.txt_company_fax.Size = new System.Drawing.Size(285, 21);
            this.txt_company_fax.TabIndex = 23;
            // 
            // txt_company_number
            // 
            this.txt_company_number.Location = new System.Drawing.Point(1397, 326);
            this.txt_company_number.Name = "txt_company_number";
            this.txt_company_number.Size = new System.Drawing.Size(285, 21);
            this.txt_company_number.TabIndex = 22;
            // 
            // txt_company_ceo
            // 
            this.txt_company_ceo.Location = new System.Drawing.Point(1397, 251);
            this.txt_company_ceo.Name = "txt_company_ceo";
            this.txt_company_ceo.Size = new System.Drawing.Size(285, 21);
            this.txt_company_ceo.TabIndex = 21;
            // 
            // txt_company_name
            // 
            this.txt_company_name.Location = new System.Drawing.Point(1397, 213);
            this.txt_company_name.Name = "txt_company_name";
            this.txt_company_name.Size = new System.Drawing.Size(285, 21);
            this.txt_company_name.TabIndex = 20;
            // 
            // txt_company_code
            // 
            this.txt_company_code.Location = new System.Drawing.Point(1397, 141);
            this.txt_company_code.Name = "txt_company_code";
            this.txt_company_code.Size = new System.Drawing.Size(285, 21);
            this.txt_company_code.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13F);
            this.label8.Location = new System.Drawing.Point(1307, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "거래유무";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13F);
            this.label7.Location = new System.Drawing.Point(1307, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "FAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F);
            this.label6.Location = new System.Drawing.Point(1307, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F);
            this.label5.Location = new System.Drawing.Point(1307, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "대표자명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F);
            this.label4.Location = new System.Drawing.Point(1307, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "업체명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F);
            this.label3.Location = new System.Drawing.Point(1307, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "그룹 업체";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F);
            this.label1.Location = new System.Drawing.Point(1307, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "업체 코드";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.cb_customer_Select);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.txt_customer_searchbox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(1274, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 100);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_textbox_reset_m);
            this.panel2.Controls.Add(this.btn_dgvRefresh);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_member_delete);
            this.panel2.Controls.Add(this.txt_member_etc);
            this.panel2.Controls.Add(this.btn_member_modify);
            this.panel2.Controls.Add(this.txt_member_part);
            this.panel2.Controls.Add(this.btn_member_add);
            this.panel2.Controls.Add(this.txt_member_name);
            this.panel2.Controls.Add(this.cb_member_code);
            this.panel2.Controls.Add(this.txt_member_email);
            this.panel2.Controls.Add(this.txt_member_fax);
            this.panel2.Controls.Add(this.txt_member_number);
            this.panel2.Controls.Add(this.txt_member_position);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(16, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1844, 382);
            this.panel2.TabIndex = 11;
            // 
            // btn_textbox_reset_m
            // 
            this.btn_textbox_reset_m.Location = new System.Drawing.Point(1712, 296);
            this.btn_textbox_reset_m.Name = "btn_textbox_reset_m";
            this.btn_textbox_reset_m.Size = new System.Drawing.Size(90, 23);
            this.btn_textbox_reset_m.TabIndex = 33;
            this.btn_textbox_reset_m.Text = "내용 지우기";
            this.btn_textbox_reset_m.UseVisualStyleBackColor = true;
            this.btn_textbox_reset_m.Click += new System.EventHandler(this.btn_textbox_reset_m_Click);
            // 
            // btn_dgvRefresh
            // 
            this.btn_dgvRefresh.Location = new System.Drawing.Point(1274, 326);
            this.btn_dgvRefresh.Name = "btn_dgvRefresh";
            this.btn_dgvRefresh.Size = new System.Drawing.Size(280, 45);
            this.btn_dgvRefresh.TabIndex = 48;
            this.btn_dgvRefresh.Tag = "";
            this.btn_dgvRefresh.Text = "새로고침";
            this.btn_dgvRefresh.UseVisualStyleBackColor = true;
            this.btn_dgvRefresh.Click += new System.EventHandler(this.btn_dgvRefresh_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1557, 326);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(280, 45);
            this.btn_close.TabIndex = 47;
            this.btn_close.Tag = "거래처 정보";
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_member_delete
            // 
            this.btn_member_delete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
            this.btn_member_delete.Location = new System.Drawing.Point(1712, 200);
            this.btn_member_delete.Name = "btn_member_delete";
            this.btn_member_delete.Size = new System.Drawing.Size(90, 90);
            this.btn_member_delete.TabIndex = 32;
            this.btn_member_delete.Text = "담당자 정보 \r\n삭제";
            this.btn_member_delete.UseVisualStyleBackColor = true;
            this.btn_member_delete.Click += new System.EventHandler(this.btn_member_delete_Click);
            // 
            // txt_member_etc
            // 
            this.txt_member_etc.Location = new System.Drawing.Point(1397, 285);
            this.txt_member_etc.Name = "txt_member_etc";
            this.txt_member_etc.Size = new System.Drawing.Size(285, 21);
            this.txt_member_etc.TabIndex = 46;
            // 
            // btn_member_modify
            // 
            this.btn_member_modify.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
            this.btn_member_modify.Location = new System.Drawing.Point(1712, 104);
            this.btn_member_modify.Name = "btn_member_modify";
            this.btn_member_modify.Size = new System.Drawing.Size(90, 90);
            this.btn_member_modify.TabIndex = 31;
            this.btn_member_modify.Text = "담당자 정보\r\n수정";
            this.btn_member_modify.UseVisualStyleBackColor = true;
            this.btn_member_modify.Click += new System.EventHandler(this.btn_member_modify_Click);
            // 
            // txt_member_part
            // 
            this.txt_member_part.Location = new System.Drawing.Point(1397, 100);
            this.txt_member_part.Name = "txt_member_part";
            this.txt_member_part.Size = new System.Drawing.Size(285, 21);
            this.txt_member_part.TabIndex = 45;
            // 
            // btn_member_add
            // 
            this.btn_member_add.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
            this.btn_member_add.Location = new System.Drawing.Point(1712, 8);
            this.btn_member_add.Name = "btn_member_add";
            this.btn_member_add.Size = new System.Drawing.Size(90, 90);
            this.btn_member_add.TabIndex = 30;
            this.btn_member_add.Text = "담당자 정보 \r\n추가";
            this.btn_member_add.UseVisualStyleBackColor = true;
            this.btn_member_add.Click += new System.EventHandler(this.btn_member_add_Click);
            // 
            // txt_member_name
            // 
            this.txt_member_name.Location = new System.Drawing.Point(1397, 62);
            this.txt_member_name.Name = "txt_member_name";
            this.txt_member_name.Size = new System.Drawing.Size(285, 21);
            this.txt_member_name.TabIndex = 44;
            // 
            // cb_member_code
            // 
            this.cb_member_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_member_code.FormattingEnabled = true;
            this.cb_member_code.Location = new System.Drawing.Point(1397, 26);
            this.cb_member_code.Name = "cb_member_code";
            this.cb_member_code.Size = new System.Drawing.Size(285, 20);
            this.cb_member_code.TabIndex = 43;
            // 
            // txt_member_email
            // 
            this.txt_member_email.Location = new System.Drawing.Point(1397, 250);
            this.txt_member_email.Name = "txt_member_email";
            this.txt_member_email.Size = new System.Drawing.Size(285, 21);
            this.txt_member_email.TabIndex = 39;
            // 
            // txt_member_fax
            // 
            this.txt_member_fax.Location = new System.Drawing.Point(1397, 211);
            this.txt_member_fax.Name = "txt_member_fax";
            this.txt_member_fax.Size = new System.Drawing.Size(285, 21);
            this.txt_member_fax.TabIndex = 38;
            // 
            // txt_member_number
            // 
            this.txt_member_number.Location = new System.Drawing.Point(1397, 176);
            this.txt_member_number.Name = "txt_member_number";
            this.txt_member_number.Size = new System.Drawing.Size(285, 21);
            this.txt_member_number.TabIndex = 37;
            // 
            // txt_member_position
            // 
            this.txt_member_position.Location = new System.Drawing.Point(1397, 138);
            this.txt_member_position.Name = "txt_member_position";
            this.txt_member_position.Size = new System.Drawing.Size(285, 21);
            this.txt_member_position.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13F);
            this.label11.Location = new System.Drawing.Point(1307, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "비고";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 13F);
            this.label12.Location = new System.Drawing.Point(1307, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 22);
            this.label12.TabIndex = 33;
            this.label12.Text = "E-Mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 13F);
            this.label13.Location = new System.Drawing.Point(1307, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 22);
            this.label13.TabIndex = 32;
            this.label13.Text = "FAX";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 13F);
            this.label14.Location = new System.Drawing.Point(1307, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 31;
            this.label14.Text = "전화번호";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 13F);
            this.label15.Location = new System.Drawing.Point(1307, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 22);
            this.label15.TabIndex = 30;
            this.label15.Text = "직위";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 13F);
            this.label16.Location = new System.Drawing.Point(1307, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 22);
            this.label16.TabIndex = 29;
            this.label16.Text = "부서";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 13F);
            this.label17.Location = new System.Drawing.Point(1307, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 22);
            this.label17.TabIndex = 28;
            this.label17.Text = "담당자명";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 13F);
            this.label18.Location = new System.Drawing.Point(1307, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 22);
            this.label18.TabIndex = 27;
            this.label18.Text = "업체 코드";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "업체번호";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "담당자명";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "부서";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "직위";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "전화번호";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "팩스번호";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "이메일";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "비고";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "StaticNo";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 883);
            this.Controls.Add(this.dgv_member);
            this.Controls.Add(this.dgv_company);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInfo";
            this.Text = "CustomerInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_company;
        private System.Windows.Forms.DataGridView dgv_member;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_customer_searchbox;
        private System.Windows.Forms.ComboBox cb_customer_Select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_company_Transaction;
        private System.Windows.Forms.ComboBox cb_company_group;
        private System.Windows.Forms.TextBox txt_company_fax;
        private System.Windows.Forms.TextBox txt_company_number;
        private System.Windows.Forms.TextBox txt_company_ceo;
        private System.Windows.Forms.TextBox txt_company_name;
        private System.Windows.Forms.TextBox txt_company_code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_company_delete;
        private System.Windows.Forms.Button btn_company_modify;
        private System.Windows.Forms.Button btn_company_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_member_delete;
        private System.Windows.Forms.TextBox txt_member_etc;
        private System.Windows.Forms.Button btn_member_modify;
        private System.Windows.Forms.TextBox txt_member_part;
        private System.Windows.Forms.Button btn_member_add;
        private System.Windows.Forms.TextBox txt_member_name;
        private System.Windows.Forms.ComboBox cb_member_code;
        private System.Windows.Forms.TextBox txt_member_email;
        private System.Windows.Forms.TextBox txt_member_fax;
        private System.Windows.Forms.TextBox txt_member_number;
        private System.Windows.Forms.TextBox txt_member_position;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txt_company_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_dgvRefresh;
        private System.Windows.Forms.Button btn_textbox_reset;
        private System.Windows.Forms.Button btn_textbox_reset_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
    }
}
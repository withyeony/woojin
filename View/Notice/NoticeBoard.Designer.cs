namespace View
{
    partial class NoticeBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Notice_List = new System.Windows.Forms.DataGridView();
            this.btn_write = new System.Windows.Forms.Button();
            this.pnl_read = new System.Windows.Forms.Panel();
            this.pnl_modify = new System.Windows.Forms.Panel();
            this.btn_modify_check = new System.Windows.Forms.Button();
            this.btn_modify_cancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modify_content = new System.Windows.Forms.TextBox();
            this.modify_title = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hen_no = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.read_content = new System.Windows.Forms.TextBox();
            this.pnl_write = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_write_content = new System.Windows.Forms.TextBox();
            this.txt_write_title = new System.Windows.Forms.TextBox();
            this.btn_write_check = new System.Windows.Forms.Button();
            this.btn_write_cancel = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.read_title = new System.Windows.Forms.Label();
            this.read_write = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_Notice_Select = new System.Windows.Forms.ComboBox();
            this.txt_searchbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notice_List)).BeginInit();
            this.pnl_read.SuspendLayout();
            this.pnl_modify.SuspendLayout();
            this.pnl_write.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Notice_List
            // 
            this.dgv_Notice_List.AllowUserToAddRows = false;
            this.dgv_Notice_List.AllowUserToDeleteRows = false;
            this.dgv_Notice_List.AllowUserToResizeColumns = false;
            this.dgv_Notice_List.AllowUserToResizeRows = false;
            this.dgv_Notice_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Notice_List.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Notice_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Notice_List.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("돋움체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Notice_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Notice_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Notice_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Notice_List.Location = new System.Drawing.Point(33, 35);
            this.dgv_Notice_List.Name = "dgv_Notice_List";
            this.dgv_Notice_List.ReadOnly = true;
            this.dgv_Notice_List.RowHeadersWidth = 5;
            this.dgv_Notice_List.RowTemplate.Height = 23;
            this.dgv_Notice_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Notice_List.Size = new System.Drawing.Size(910, 798);
            this.dgv_Notice_List.TabIndex = 0;
            this.dgv_Notice_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Notice_List_CellClick);
            // 
            // btn_write
            // 
            this.btn_write.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_write.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_write.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_write.Location = new System.Drawing.Point(1770, 857);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(96, 53);
            this.btn_write.TabIndex = 1;
            this.btn_write.Text = "글쓰기";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // pnl_read
            // 
            this.pnl_read.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_read.Controls.Add(this.panel3);
            this.pnl_read.Controls.Add(this.pnl_write);
            this.pnl_read.Controls.Add(this.read_write);
            this.pnl_read.Controls.Add(this.pnl_modify);
            this.pnl_read.Controls.Add(this.read_title);
            this.pnl_read.Controls.Add(this.panel2);
            this.pnl_read.Controls.Add(this.panel1);
            this.pnl_read.Controls.Add(this.label5);
            this.pnl_read.Controls.Add(this.label4);
            this.pnl_read.Controls.Add(this.label3);
            this.pnl_read.Controls.Add(this.lbl_hen_no);
            this.pnl_read.Controls.Add(this.btn_delete);
            this.pnl_read.Controls.Add(this.btn_modify);
            this.pnl_read.Controls.Add(this.read_content);
            this.pnl_read.Location = new System.Drawing.Point(956, 35);
            this.pnl_read.Name = "pnl_read";
            this.pnl_read.Size = new System.Drawing.Size(910, 798);
            this.pnl_read.TabIndex = 2;
            // 
            // pnl_modify
            // 
            this.pnl_modify.Controls.Add(this.btn_modify_check);
            this.pnl_modify.Controls.Add(this.btn_modify_cancel);
            this.pnl_modify.Controls.Add(this.panel4);
            this.pnl_modify.Controls.Add(this.panel5);
            this.pnl_modify.Controls.Add(this.label6);
            this.pnl_modify.Controls.Add(this.label7);
            this.pnl_modify.Controls.Add(this.label8);
            this.pnl_modify.Controls.Add(this.modify_content);
            this.pnl_modify.Controls.Add(this.modify_title);
            this.pnl_modify.Location = new System.Drawing.Point(31, 149);
            this.pnl_modify.Name = "pnl_modify";
            this.pnl_modify.Size = new System.Drawing.Size(796, 631);
            this.pnl_modify.TabIndex = 17;
            this.pnl_modify.Visible = false;
            // 
            // btn_modify_check
            // 
            this.btn_modify_check.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_modify_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify_check.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_modify_check.Location = new System.Drawing.Point(477, 575);
            this.btn_modify_check.Name = "btn_modify_check";
            this.btn_modify_check.Size = new System.Drawing.Size(96, 53);
            this.btn_modify_check.TabIndex = 24;
            this.btn_modify_check.Text = "수정";
            this.btn_modify_check.UseVisualStyleBackColor = false;
            this.btn_modify_check.Click += new System.EventHandler(this.btn_modify_check_Click);
            // 
            // btn_modify_cancel
            // 
            this.btn_modify_cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_modify_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_modify_cancel.Location = new System.Drawing.Point(334, 575);
            this.btn_modify_cancel.Name = "btn_modify_cancel";
            this.btn_modify_cancel.Size = new System.Drawing.Size(96, 53);
            this.btn_modify_cancel.TabIndex = 23;
            this.btn_modify_cancel.Text = "취소";
            this.btn_modify_cancel.UseVisualStyleBackColor = false;
            this.btn_modify_cancel.Click += new System.EventHandler(this.btn_modify_cancel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(136, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 1);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(137, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 1);
            this.panel5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("돋움체", 12F);
            this.label6.Location = new System.Drawing.Point(51, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "내용";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("돋움체", 12F);
            this.label7.Location = new System.Drawing.Point(35, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "작성자";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("돋움체", 12F);
            this.label8.Location = new System.Drawing.Point(51, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "제목";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_content
            // 
            this.modify_content.BackColor = System.Drawing.SystemColors.Control;
            this.modify_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modify_content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modify_content.Font = new System.Drawing.Font("돋움체", 11F);
            this.modify_content.Location = new System.Drawing.Point(138, 157);
            this.modify_content.Multiline = true;
            this.modify_content.Name = "modify_content";
            this.modify_content.Size = new System.Drawing.Size(643, 446);
            this.modify_content.TabIndex = 17;
            // 
            // modify_title
            // 
            this.modify_title.BackColor = System.Drawing.SystemColors.Control;
            this.modify_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modify_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modify_title.Font = new System.Drawing.Font("돋움체", 11F);
            this.modify_title.Location = new System.Drawing.Point(140, 38);
            this.modify_title.Multiline = true;
            this.modify_title.Name = "modify_title";
            this.modify_title.Size = new System.Drawing.Size(643, 33);
            this.modify_title.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(167, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(168, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 1);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움체", 12F);
            this.label5.Location = new System.Drawing.Point(82, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "내용";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움체", 12F);
            this.label4.Location = new System.Drawing.Point(66, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "작성자";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움체", 12F);
            this.label3.Location = new System.Drawing.Point(82, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "제목";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_hen_no
            // 
            this.lbl_hen_no.AutoSize = true;
            this.lbl_hen_no.Location = new System.Drawing.Point(829, 605);
            this.lbl_hen_no.Name = "lbl_hen_no";
            this.lbl_hen_no.Size = new System.Drawing.Size(41, 12);
            this.lbl_hen_no.TabIndex = 9;
            this.lbl_hen_no.Text = "label3";
            this.lbl_hen_no.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(785, 740);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(97, 40);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_modify.Location = new System.Drawing.Point(682, 740);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(97, 40);
            this.btn_modify.TabIndex = 5;
            this.btn_modify.Text = "수정";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // read_content
            // 
            this.read_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.read_content.Cursor = System.Windows.Forms.Cursors.Default;
            this.read_content.Font = new System.Drawing.Font("돋움체", 11F);
            this.read_content.Location = new System.Drawing.Point(169, 306);
            this.read_content.Multiline = true;
            this.read_content.Name = "read_content";
            this.read_content.ReadOnly = true;
            this.read_content.Size = new System.Drawing.Size(643, 446);
            this.read_content.TabIndex = 3;
            // 
            // pnl_write
            // 
            this.pnl_write.Controls.Add(this.label2);
            this.pnl_write.Controls.Add(this.label1);
            this.pnl_write.Controls.Add(this.txt_write_content);
            this.pnl_write.Controls.Add(this.txt_write_title);
            this.pnl_write.Controls.Add(this.btn_write_check);
            this.pnl_write.Controls.Add(this.btn_write_cancel);
            this.pnl_write.Location = new System.Drawing.Point(0, 0);
            this.pnl_write.Name = "pnl_write";
            this.pnl_write.Size = new System.Drawing.Size(910, 798);
            this.pnl_write.TabIndex = 3;
            this.pnl_write.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "내용";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "제목";
            // 
            // txt_write_content
            // 
            this.txt_write_content.Location = new System.Drawing.Point(153, 325);
            this.txt_write_content.Multiline = true;
            this.txt_write_content.Name = "txt_write_content";
            this.txt_write_content.Size = new System.Drawing.Size(643, 314);
            this.txt_write_content.TabIndex = 3;
            // 
            // txt_write_title
            // 
            this.txt_write_title.Location = new System.Drawing.Point(153, 265);
            this.txt_write_title.Multiline = true;
            this.txt_write_title.Name = "txt_write_title";
            this.txt_write_title.Size = new System.Drawing.Size(643, 33);
            this.txt_write_title.TabIndex = 2;
            // 
            // btn_write_check
            // 
            this.btn_write_check.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_write_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_write_check.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_write_check.Location = new System.Drawing.Point(510, 719);
            this.btn_write_check.Name = "btn_write_check";
            this.btn_write_check.Size = new System.Drawing.Size(97, 58);
            this.btn_write_check.TabIndex = 1;
            this.btn_write_check.Text = "확인";
            this.btn_write_check.UseVisualStyleBackColor = false;
            this.btn_write_check.Click += new System.EventHandler(this.btn_write_check_Click);
            // 
            // btn_write_cancel
            // 
            this.btn_write_cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_write_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_write_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_write_cancel.Location = new System.Drawing.Point(364, 719);
            this.btn_write_cancel.Name = "btn_write_cancel";
            this.btn_write_cancel.Size = new System.Drawing.Size(97, 58);
            this.btn_write_cancel.TabIndex = 0;
            this.btn_write_cancel.Text = "취소";
            this.btn_write_cancel.UseVisualStyleBackColor = false;
            this.btn_write_cancel.Click += new System.EventHandler(this.btn_write_cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_close.Location = new System.Drawing.Point(33, 857);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 53);
            this.btn_close.TabIndex = 4;
            this.btn_close.Tag = "공지사항";
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "번호";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "제목";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "작성자";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 30F;
            this.Column4.HeaderText = "날짜";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "내용";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // read_title
            // 
            this.read_title.AutoSize = true;
            this.read_title.Location = new System.Drawing.Point(169, 188);
            this.read_title.Name = "read_title";
            this.read_title.Size = new System.Drawing.Size(65, 12);
            this.read_title.TabIndex = 18;
            this.read_title.Text = "read_title";
            // 
            // read_write
            // 
            this.read_write.AutoSize = true;
            this.read_write.Location = new System.Drawing.Point(169, 251);
            this.read_write.Name = "read_write";
            this.read_write.Size = new System.Drawing.Size(65, 12);
            this.read_write.TabIndex = 19;
            this.read_write.Text = "read_write";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_searchbox);
            this.panel3.Controls.Add(this.cb_Notice_Select);
            this.panel3.Location = new System.Drawing.Point(31, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 129);
            this.panel3.TabIndex = 20;
            // 
            // cb_Notice_Select
            // 
            this.cb_Notice_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Notice_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Notice_Select.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_Notice_Select.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_Notice_Select.FormattingEnabled = true;
            this.cb_Notice_Select.ItemHeight = 25;
            this.cb_Notice_Select.Items.AddRange(new object[] {
            "제목",
            "글내용"});
            this.cb_Notice_Select.Location = new System.Drawing.Point(68, 65);
            this.cb_Notice_Select.Name = "cb_Notice_Select";
            this.cb_Notice_Select.Size = new System.Drawing.Size(125, 33);
            this.cb_Notice_Select.TabIndex = 1;
            // 
            // txt_searchbox
            // 
            this.txt_searchbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_searchbox.Location = new System.Drawing.Point(269, 65);
            this.txt_searchbox.Multiline = true;
            this.txt_searchbox.Name = "txt_searchbox";
            this.txt_searchbox.Size = new System.Drawing.Size(303, 33);
            this.txt_searchbox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "항목";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "검색어";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Location = new System.Drawing.Point(629, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 73);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // NoticeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 922);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_read);
            this.Controls.Add(this.dgv_Notice_List);
            this.Controls.Add(this.btn_write);
            this.Font = new System.Drawing.Font("돋움체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoticeBoard";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notice_List)).EndInit();
            this.pnl_read.ResumeLayout(false);
            this.pnl_read.PerformLayout();
            this.pnl_modify.ResumeLayout(false);
            this.pnl_modify.PerformLayout();
            this.pnl_write.ResumeLayout(false);
            this.pnl_write.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Notice_List;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Panel pnl_read;
        private System.Windows.Forms.TextBox read_content;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Panel pnl_write;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_write_content;
        private System.Windows.Forms.TextBox txt_write_title;
        private System.Windows.Forms.Button btn_write_check;
        private System.Windows.Forms.Button btn_write_cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hen_no;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_modify;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox modify_content;
        private System.Windows.Forms.TextBox modify_title;
        private System.Windows.Forms.Button btn_modify_check;
        private System.Windows.Forms.Button btn_modify_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label read_title;
        private System.Windows.Forms.Label read_write;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_searchbox;
        private System.Windows.Forms.ComboBox cb_Notice_Select;
    }
}
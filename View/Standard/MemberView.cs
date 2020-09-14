using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
	public partial class MemberView : Form, IBasicForm
	{
		private Member _LoginInfo;
		private BasicForm _Mother;
		private MemberController _MemberController;
		private Member _SelectedData;

		private Boolean _NoCheck;
		private Boolean _IdCheck;

		public MemberView(Member member, BasicForm form )
		{
			InitializeComponent();
			_Mother = form;
			_LoginInfo = member;
			_SelectedData = new Member();
			_MemberController = new MemberController();
			this.dataGridView1.Font = new Font("Tahoma", 10, FontStyle.Regular);


			GetMemberList();

			ComboBoxSet();
			_SelectedData.No = (int)dataGridView1.Rows[0].Cells[0].Value;
			_SelectedData.Rank = dataGridView1.Rows[0].Cells[1].Value.ToString();
			_SelectedData.Part = dataGridView1.Rows[0].Cells[2].Value.ToString();
			_SelectedData.Name = dataGridView1.Rows[0].Cells[3].Value.ToString();
			_SelectedData.Id = dataGridView1.Rows[0].Cells[4].Value.ToString();
			_SelectedData.Phone = dataGridView1.Rows[0].Cells[5].Value.ToString();
			_SelectedData.Email = dataGridView1.Rows[0].Cells[6].Value.ToString();
			_SelectedData.Birthday = dataGridView1.Rows[0].Cells[7].Value.ToString();
			_SelectedData.Longevity = dataGridView1.Rows[0].Cells[8].Value.ToString();

			SetSelectData();

		}

		private void ComboBoxSet()
		{
			cb_Add_Part.Items.Clear();
			cb_Add_Rank.Items.Clear();
			cb_Update_Part.Items.Clear();
			cb_Update_Rank.Items.Clear();

			List<String> list = _MemberController.GetDefualtCode("rankofmember");
			if (list != null)
			{
				foreach (string str in list) { cb_Add_Rank.Items.Add(str); }
				foreach (string str in list) { cb_Update_Rank.Items.Add(str); }
				list.Clear();

			}
			list = _MemberController.GetDefualtCode("departmentofmember");
			if (list != null)
			{
				foreach (string str in list) { cb_Add_Part.Items.Add(str); }
				foreach (string str in list) { cb_Update_Part.Items.Add(str); }
				list.Clear();
			}
		}

		public Form SetForm()
		{
			return this;
		}

		private void GetMemberList()
		{

			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;

			dataGridView1.Rows.Clear();

			List<Member> Members = new List<Member>();
			Members = _MemberController.GetMemberList();

			if (Members is null)
			{
				;
			}
			else
			{
				foreach (Member mem in Members)
				{
					dataGridView1.Rows.Add(mem.No, mem.Rank, mem.Part, mem.Name, mem.Id, mem.Phone, mem.Email, mem.Birthday, mem.Longevity, DdayCheck(mem.Longevity));
				}
			}
		}


		private String DdayCheck(String Longevity)
		{
			string value = "";
			if (Longevity.Equals("0"))
			{
				value = Longevity;
			}
			else
			{
				TimeSpan ts = DateTime.Now - DateTime.Parse(Longevity);

				string str = ts.ToString();
				string[] spStr = str.Split('.');
				value = spStr[0];
			}
			return value;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			cb_Add_Rank.SelectedIndex  = - 1;
			cb_Add_Part.SelectedIndex  = - 1;

			for (int i = 0; i < this.label_6.Controls.Count; i++)
			{
				if ((Button)label_6.Controls[i] == btn && label_6.Controls[i].BackColor == System.Drawing.SystemColors.Control)
				{


					label_6.Controls[i].BackColor = System.Drawing.SystemColors.GradientInactiveCaption;

					if (label_6.Controls[i] == btn_Add)
					{
						_IdCheck = false;
						_NoCheck = false;

						tb_Add_No.ReadOnly = false;
						tb_Add_ID.ReadOnly = false;

						tb_Add_ID.Text = "";
						tb_Add_No.Text = "";
						tb_Add_Pw.Text = "";
						tb_Add_Name.Text = "";
						tb_Add_Number.Text = "";
						tb_Add_Email.Text = "";

						dtp_Add_Birthday.Value = DateTime.Now;
						dtp_Add_Longevity.Value = DateTime.Now;


						SetSelectPanel(pnl_Add);
					}
					if (label_6.Controls[i] == btn_Update)
					{
						SetSelectPanel(pnl_Update);
						SetUpdateData();
					}
					if (label_6.Controls[i] == btn_Delete)
					{
						SetSelectPanel(pnl_Select);
						btn_Delete_Apply.Visible = true;
						lbl_DataSelect.Text = "Data Delete";
					}
				}
				else
				{
					label_6.Controls[i].BackColor = System.Drawing.SystemColors.Control;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cb_SelectBox.SelectedIndex == -1)
			{

			}
			else
			{
				String value = cb_SelectBox.SelectedItem.ToString();

				string result = "";
				switch (value)
				{

					case "번호":
						result = "No";
						break;

					case "부서":
						result = "Part";

						break;
					case "직급":
						result = "Rank";

						break;
					case "이름":
						result = "Name";

						break;
				}


				dataGridView1.Rows.Clear();

				List<Member> Members = new List<Member>();
				Members = _MemberController.FindData(result, tb_SelectData.Text);

				if (Members is null)
				{
					;
				}
				else
				{
					foreach (Member mem in Members)
					{
						dataGridView1.Rows.Add(mem.No, mem.Rank, mem.Part, mem.Name, mem.Id, mem.Phone, mem.Email, mem.Birthday, mem.Longevity, DdayCheck(mem.Longevity), mem.PassWord);
					}

					btn_Delete_Apply.Visible = false;
					lbl_DataSelect.Text = "Data Select";

					_SelectedData.No = (int)dataGridView1.Rows[0].Cells[0].Value;
					_SelectedData.Rank = dataGridView1.Rows[0].Cells[1].Value.ToString();
					_SelectedData.Part = dataGridView1.Rows[0].Cells[2].Value.ToString();
					_SelectedData.Name = dataGridView1.Rows[0].Cells[3].Value.ToString();
					_SelectedData.Id = dataGridView1.Rows[0].Cells[4].Value.ToString();
					_SelectedData.Phone = dataGridView1.Rows[0].Cells[5].Value.ToString();
					_SelectedData.Email = dataGridView1.Rows[0].Cells[6].Value.ToString();
					_SelectedData.Birthday = dataGridView1.Rows[0].Cells[7].Value.ToString();
					_SelectedData.Longevity = dataGridView1.Rows[0].Cells[8].Value.ToString();

					SetSelectData();

					SetSelectPanel(pnl_Select);
				}
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Delete_Apply.Visible = false;
			lbl_DataSelect.Text = "Data Select";
			DataGridView dgv = (DataGridView)sender;

			if (dgv.SelectedRows.Count != 0)
			{
				DataGridViewRow dr = dgv.SelectedRows[0];

				if (dr.Cells[0].Value is null)
				{
					;
				}
				else
				{
					_SelectedData.No = (int)dr.Cells[0].Value;
					_SelectedData.Rank = dr.Cells[1].Value.ToString();
					_SelectedData.Part = dr.Cells[2].Value.ToString();
					_SelectedData.Name = dr.Cells[3].Value.ToString();
					_SelectedData.Id = dr.Cells[4].Value.ToString();
					_SelectedData.Phone = dr.Cells[5].Value.ToString();
					_SelectedData.Email = dr.Cells[6].Value.ToString();
					_SelectedData.Birthday = dr.Cells[7].Value.ToString();
					_SelectedData.Longevity = dr.Cells[8].Value.ToString();
				}
			}
			SetSelectData();

			SetSelectPanel(pnl_Select);

			for (int i = 0; i < this.label_6.Controls.Count; i++)
			{
				 label_6.Controls[i].BackColor = System.Drawing.SystemColors.Control ;
			}
		}
		private void SetSelectData()
		{
			lbl_No.Text = _SelectedData.No.ToString();
			lbl_Rank.Text = _SelectedData.Rank;
			lbl_Part.Text = _SelectedData.Part;
			lbl_Name.Text = _SelectedData.Name;
			lbl_ID.Text = _SelectedData.Id;
			lbl_Number.Text = _SelectedData.Phone;
			lbl_Email.Text = _SelectedData.Email;
			lbl_Birthday.Text = _SelectedData.Birthday;
			lbl_Longevity.Text = _SelectedData.Longevity;
		}
		private void SetSelectPanel(Panel pnl) 
		{
			pnl.BringToFront();

		}
		private void SetUpdateData()
		{
			tb_Update_No.Text = _SelectedData.No.ToString();
			cb_Update_Rank.Text = _SelectedData.Rank;
			cb_Update_Part.Text = _SelectedData.Part;
			tb_Update_Name.Text = _SelectedData.Name;
			tb_Update_ID.Text = _SelectedData.Id;
			tb_Update_Number.Text = _SelectedData.Phone;
			tb_Update_Email.Text = _SelectedData.Email;
			dtp_Update_Birthday.Text = _SelectedData.Birthday;
			dtp_Update_Longevity.Text = _SelectedData.Longevity;
		}

		private void DataPanelClose(object sender, EventArgs e)
		{
			DataPanelReset(); ;
		}
		private void DataPanelReset()
		{
			SetSelectPanel(pnl_Select);

			btn_Delete_Apply.Visible = false;
			lbl_DataSelect.Text = "Data Select";
		}
		private void button5_Click(object sender, EventArgs e)
		{
			Member member = new Member();

			member.No = Convert.ToInt32(tb_Update_No.Text);
			member.Rank = cb_Update_Rank.Text;
			member.Part = cb_Update_Part.Text;
			member.Name = tb_Update_Name.Text;
			member.Id = tb_Update_ID.Text;
			member.Phone = tb_Update_Number.Text;
			member.Email = tb_Update_Email.Text;
			member.Birthday = dtp_Update_Birthday.Text;
			member.Longevity = dtp_Update_Longevity.Text;


			_MemberController.UpdateMember(member);
			GetMemberList();
			Reset();
			DataPanelReset();
			SetAlarm("사원 정보 수정이 완료 되었습니다.");
			
		}
		private void Reset()
		{
			tb_Update_No.Text = "";
			cb_Update_Rank.Text = 		"";
			cb_Update_Part.Text = 		"";
			tb_Update_Name.Text = 		"";
			tb_Update_ID.Text = 		"";
			tb_Update_Number.Text = 	"";
			tb_Update_Email.Text = 		"";
			dtp_Update_Birthday.Text = 	"";
			dtp_Update_Longevity.Text =	"";

			tb_Add_No.Text = "";
			cb_Add_Rank.Text = "";
			cb_Add_Part.Text = "";
			tb_Add_Pw.Text = "";
			tb_Add_Name.Text = "";
			tb_Add_ID.Text = "";
			tb_Add_Number.Text = "";
			tb_Add_Email.Text = "";
			dtp_Add_Birthday.Text = "";
			dtp_Add_Longevity.Text = "";


			lbl_No.Text = "";
			lbl_Rank.Text = "";
			lbl_Part.Text = "";
			lbl_Name.Text = "";
			lbl_ID.Text = "";
			lbl_Number.Text = "";
			lbl_Email.Text = "";
			lbl_Birthday.Text = "";
			lbl_Longevity.Text = "";

			_SelectedData.No = (int)dataGridView1.Rows[0].Cells[0].Value;
			_SelectedData.Rank = dataGridView1.Rows[0].Cells[1].Value.ToString();
			_SelectedData.Part = dataGridView1.Rows[0].Cells[2].Value.ToString();
			_SelectedData.Name = dataGridView1.Rows[0].Cells[3].Value.ToString();
			_SelectedData.Id = dataGridView1.Rows[0].Cells[4].Value.ToString();
			_SelectedData.Phone = dataGridView1.Rows[0].Cells[5].Value.ToString();
			_SelectedData.Email = dataGridView1.Rows[0].Cells[6].Value.ToString();
			_SelectedData.Birthday = dataGridView1.Rows[0].Cells[7].Value.ToString();
			_SelectedData.Longevity = dataGridView1.Rows[0].Cells[8].Value.ToString();
		}

		private void SetAlarm(String str)
		{
			Alarm alarm = new Alarm(str);
			alarm.ShowDialog();
		}

		private void btn_Delete_Apply_Click(object sender, EventArgs e)
		{
			_MemberController.DeleteMember(_SelectedData.No);
		
			GetMemberList();
			Reset();
			DataPanelReset();
			SetAlarm("사원 정보 삭제가 완료 되었습니다.");
		}

		private void tb_Add_No_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
			{
				e.Handled = true;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			GetMemberList();

			ComboBoxSet();
			_SelectedData.No = (int)dataGridView1.Rows[0].Cells[0].Value;
			_SelectedData.Rank = dataGridView1.Rows[0].Cells[1].Value.ToString();
			_SelectedData.Part = dataGridView1.Rows[0].Cells[2].Value.ToString();
			_SelectedData.Name = dataGridView1.Rows[0].Cells[3].Value.ToString();
			_SelectedData.Id = dataGridView1.Rows[0].Cells[4].Value.ToString();
			_SelectedData.Phone = dataGridView1.Rows[0].Cells[5].Value.ToString();
			_SelectedData.Email = dataGridView1.Rows[0].Cells[6].Value.ToString();
			_SelectedData.Birthday = dataGridView1.Rows[0].Cells[7].Value.ToString();
			_SelectedData.Longevity = dataGridView1.Rows[0].Cells[8].Value.ToString();

			SetSelectData();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			String str = btn.Tag.ToString();
			_Mother.RemoveTab(str);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (tb_Add_No.Text.Length > 0)
			{
				_NoCheck = _MemberController.CheckData("No", tb_Add_No.Text);
				String str = "이미 존재하는 번호 입니다.";
				if (_NoCheck)
				{
					tb_Add_No.ReadOnly = true;
					str = "사용가능한 번호입니다.";
				}
				SetAlarm(str);
			}

		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (tb_Add_Name.Text.Length > 0)
			{
				_IdCheck = _MemberController.CheckData("ID", "'" + tb_Add_ID.Text + "'");
				String str = "이미 존재하는 ID 입니다.";
				if (_IdCheck)
				{
					tb_Add_ID.ReadOnly = true;
					str = "사용가능한 ID 입니다.";
				}
				SetAlarm(str);
			}
		
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (_IdCheck && _NoCheck)
			{

				Member member = new Member();
				member.No = Convert.ToInt32(tb_Add_No.Text);
				member.Rank = cb_Add_Rank.SelectedItem.ToString();
				member.Part = cb_Add_Part.SelectedItem.ToString();
				member.PassWord = tb_Add_Pw.Text;
				member.Name = tb_Add_Name.Text;
				member.Id = tb_Add_ID.Text;
				member.Phone = tb_Add_Number.Text;
				member.Email = tb_Add_Email.Text;
				member.Birthday = dtp_Add_Birthday.Text;
				member.Longevity = dtp_Add_Longevity.Text;


				_MemberController.AddMember(member);

				GetMemberList();
				Reset();
				DataPanelReset();
				SetAlarm("사원 정보 추가가 완료 되었습니다.");
			}
			else
			{
				SetAlarm("중복확인이 필요합니다.");
			}
		}
	}
}

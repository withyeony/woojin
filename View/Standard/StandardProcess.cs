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
using System.Web.UI;
using System.Windows.Forms;

namespace View
{
	public partial class StandardProcess : Form, IBasicForm
	{
		private Member _LoginInfo;
		private BasicForm _Mother;
		private StandardProcessController _StandardProcessController;

		private StandardProcessModel _SPM;
		private DetailProcess _DP;
		public StandardProcess(Member member, BasicForm form)
		{
			InitializeComponent();
			_LoginInfo = member;
			_Mother = form;

			_DP = new DetailProcess();
			_SPM = new StandardProcessModel();

			_StandardProcessController = new StandardProcessController();

			ResetData();
			//처음에 생성될때
		}
		public Form SetForm()
		{
			return this;
		}
		public void SetAlarm(String str)
		{
			Alarm alarm = new Alarm(str);
			alarm.ShowDialog();
		}
		private void MakeUCProcess(List<StandardProcessModel> list)
		{
			foreach(StandardProcessModel spm in list)
			{
				UCStandardProcess ucsp = new UCStandardProcess(this);

				ucsp.SPM = spm;
				ucsp.Tag = spm.No;
				pnl_View.Controls.Add(ucsp);
				ucsp.Visible = true;
				ControllerSorting();
			}
		}
		private void MakeDefaultProcess(List<StandardProcessModel> list)
		{
			foreach (StandardProcessModel sp in list)
			{
				dataGridView1.Rows.Add(sp.No, sp.Name);
			}
			foreach (DataGridViewRow dgvr in dataGridView1.Rows)
			{
				foreach (StandardProcessModel sp in list)
				{
					if ((int)dgvr.Cells[0].Value == sp.No)
					{
						dgvr.Cells[2].Style.BackColor = Color.FromArgb(Convert.ToInt32(sp.Color1));
						dgvr.Cells[3].Style.BackColor = Color.FromArgb(Convert.ToInt32(sp.Color2));
						dgvr.Cells[2].Style.SelectionBackColor = Color.FromArgb(Convert.ToInt32(sp.Color1));
						dgvr.Cells[3].Style.SelectionBackColor = Color.FromArgb(Convert.ToInt32(sp.Color2));

					}
				}
			}
			_SPM.No = (int)dataGridView1.Rows[0].Cells[0].Value;
			_SPM.Name = dataGridView1.Rows[0].Cells[1].Value.ToString();
			_SPM.Color1 = dataGridView1.Rows[0].Cells[2].Style.BackColor.ToArgb().ToString();
			_SPM.Color2 = dataGridView1.Rows[0].Cells[3].Style.BackColor.ToArgb().ToString();
		}
		private void MakeDetailtProcess(List<DetailProcess> list)
		{
			foreach (DetailProcess dp in list)
			{
				dataGridView2.Rows.Add(dp.StaticNo, dp.DFName, dp.Name);
			}
			foreach (DataGridViewRow dgvr in dataGridView2.Rows)
			{
				foreach (DetailProcess dp in list)
				{
					if ((int)dgvr.Cells[0].Value == dp.StaticNo)
					{
						dgvr.Cells[3].Style.BackColor = Color.FromArgb(Convert.ToInt32(dp.Color1));
						dgvr.Cells[4].Style.BackColor = Color.FromArgb(Convert.ToInt32(dp.Color2));
						dgvr.Cells[3].Style.SelectionBackColor = Color.FromArgb(Convert.ToInt32(dp.Color1));
						dgvr.Cells[4].Style.SelectionBackColor = Color.FromArgb(Convert.ToInt32(dp.Color2));
					}
				}
			}

			_DP.StaticNo      = (int)dataGridView2.Rows[0].Cells[0].Value;
			_DP.DFName        = dataGridView2.Rows[0].Cells[1].Value.ToString();
			_DP.Name		  = dataGridView2.Rows[0].Cells[2].Value.ToString();
			_DP.Color1        = dataGridView2.Rows[0].Cells[3].Style.BackColor.ToArgb().ToString();
			_DP.Color2        = dataGridView2.Rows[0].Cells[4].Style.BackColor.ToArgb().ToString();

		}
	
	
		internal int GetCount()
		{
			return pnl_View.Controls.Count;
		}

		internal void ChangeSPM(StandardProcessModel sPM, String Location)
		{
			if (Location.Equals("Up"))
			{
				for (int i = 0; i < this.pnl_View.Controls.Count; i++)
				{
					UCStandardProcess ucsp = (UCStandardProcess)pnl_View.Controls[i];
					if(ucsp.SPM.Sort == sPM.Sort && ucsp.SPM.No != sPM.No)
					{
						ucsp.SPM.Sort += 1;
						ucsp.SetData();
					}
				}
			}
			if (Location.Equals("Down"))
			{
				for (int i = 0; i < this.pnl_View.Controls.Count; i++)
				{
					UCStandardProcess ucsp = (UCStandardProcess)pnl_View.Controls[i];
					if (ucsp.SPM.Sort == sPM.Sort && ucsp.SPM.No != sPM.No)
					{
						ucsp.SPM.Sort -= 1;
						ucsp.SetData();
					}
				}
			}
			ControllerSorting();
		}

		internal void ChangeDelete(StandardProcessModel sPM)
		{
			_StandardProcessController.DeleteStandardProcess(sPM);
			ResetData();
		}

		private void ControllerSorting()
		{
			pnl_View.VerticalScroll.Value = 0;
			for (int i = 0; i < this.pnl_View.Controls.Count; i++)
			{
				UCStandardProcess ucsp = (UCStandardProcess)pnl_View.Controls[i];
				ucsp.Location = new Point(10, (ucsp.SPM.Sort - 1) * 100);
			}
		}


		private void ResetData()
		{
			pnl_View.Controls.Clear();
			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();
			List<StandardProcessModel> list = _StandardProcessController.GetStandardProcess();

			if (list is null)
			{
				;
			}
			else
			{
				MakeUCProcess(list);
				MakeDefaultProcess(list);
			}
			ComboBoxSet();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			StandardProcessModel NewSPM = new StandardProcessModel();

			NewSPM.Name = "새로운 공정";
			NewSPM.Color1 = "0";
			NewSPM.Color2 = "0";
			NewSPM.Sort = pnl_View.Controls.Count + 1;

			_StandardProcessController.AddStandardProcess(NewSPM);

			ResetData();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			String str = btn.Tag.ToString();
			_Mother.RemoveTab(str);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ResetData();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<StandardProcessModel> SPMs = new List<StandardProcessModel>();
			for (int i = 0; i < this.pnl_View.Controls.Count; i++)
			{

				UCStandardProcess ucsp = (UCStandardProcess)pnl_View.Controls[i];

				SPMs.Add(ucsp.SPM);
			}
			_StandardProcessController.UpdateStandardProcess(SPMs);

			ResetData();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_3ea_Init();
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
					_SPM.No = (int)dr.Cells[0].Value;
					_SPM.Name = dr.Cells[1].Value.ToString();

				}
			}
			ShowDetailProcess();
		}
		private void ShowDetailProcess()
		{
			dataGridView2.Rows.Clear();
			List<DetailProcess> list = _StandardProcessController.DetailProcessList(_SPM.No);
			if (list is null)
			{
				;
			}
			else
			{
				MakeDetailtProcess(list);
			}

		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if (_DP.StaticNo != 0 || (_SPM.No > 0 && btn.Name.Equals("btn_Add"))) 
			{
				btn_3ea_Init();

				if (btn.BackColor != System.Drawing.Color.White)
				{
					btn.BackColor = System.Drawing.Color.White;
					pnl_DBMS.Visible = true;
					SetDPData();
				}
			}
		
		}
		private void SetDPData()
		{
			btn_DP_Close.Visible = true;
			if(btn_Add.BackColor == System.Drawing.Color.White)
			{
			
				DP_DFName.Tag = (int)_SPM.No;
				DP_DFName.Text = _SPM.Name.ToString();

				btn_DP_Apply.Tag = 1; 
			}
			else if(btn_Update.BackColor == System.Drawing.Color.White)
			{
				DP_DFName.Tag = _DP.StaticNo;
				DP_DFName.Text = _DP.DFName;
				DP_Name.Text = _DP.Name;
				DP_Color1.BackColor = Color.FromArgb(Convert.ToInt32(_DP.Color1));
				DP_Color2.BackColor = Color.FromArgb(Convert.ToInt32(_DP.Color2));

				btn_DP_Apply.Tag = 2;
			}
			else
			{
				DP_DFName.Tag = _DP.StaticNo;
				DP_DFName.Text = _DP.DFName;
				DP_Name.Text = _DP.Name;
				DP_Color1.BackColor = Color.FromArgb(Convert.ToInt32(_DP.Color1));
				DP_Color2.BackColor = Color.FromArgb(Convert.ToInt32(_DP.Color2));
				DP_Name.Enabled = false;
				btn_DP_Apply.Tag = 3;
			}
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
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
					_DP.StaticNo = (int)dr.Cells[0].Value;
					_DP.DFName = dr.Cells[1].Value.ToString();
					_DP.Name =   dr.Cells[2].Value.ToString();
					_DP.Color1 = dr.Cells[3].Style.BackColor.ToArgb().ToString();
					_DP.Color2 = dr.Cells[4].Style.BackColor.ToArgb().ToString();

					btn_3ea_Init();
				}
			}
		}

		private void btn_3ea_Init()
		{
			pnl_DBMS.Visible = false;
			btn_DP_Close.Visible = false;
			btn_Add.BackColor = System.Drawing.SystemColors.Control;
			btn_Update.BackColor = System.Drawing.SystemColors.Control;
			btn_Delete.BackColor = System.Drawing.SystemColors.Control;

			DP_DFName.Tag =  0;
			DP_DFName.Text = "";
			DP_Name.Text =  "";
			DP_Color1.BackColor = System.Drawing.SystemColors.Control;
			DP_Color2.BackColor = System.Drawing.SystemColors.Control;

			DP_Name.Enabled = true;
		}

		private void StandardProcess_Load(object sender, EventArgs e)
		{
			pnl_DBMS.Visible = false;
		}

		private void DP_Color1_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;

			ColorDialog cd = new ColorDialog();

			if (cd.ShowDialog() == DialogResult.OK)
				btn.BackColor = cd.Color;

			if (btn.Name.Equals("DP_Color1")) { _DP.Color1 = cd.Color.ToArgb().ToString(); }
			if (btn.Name.Equals("DP_Color2")) { _DP.Color2 = cd.Color.ToArgb().ToString(); }

		}

		private void btn_DP_Close_Click(object sender, EventArgs e)
		{
			btn_3ea_Init();
		}

		private void btn_DP_Apply_Click(object sender, EventArgs e)
		{
			 Button btn = (Button)sender;

			 DetailProcess dp = new DetailProcess();

			switch ((int)btn.Tag)
			{

				case 1:
					dp.No = (int)DP_DFName.Tag;
					dp.DFName = DP_DFName.Text;
					dp.Name = DP_Name.Text;
					dp.Color1 = DP_Color1.BackColor.ToArgb().ToString();
					dp.Color2 = DP_Color2.BackColor.ToArgb().ToString();

					_StandardProcessController.DP_Add(dp);
					break;
					//추가 수정 삭제 에서 데이터 받아오는거 로컬 데이터에서 부터 시작되는거 확인하고 시행할것
				case 2:  //update
					dp.StaticNo = (int)DP_DFName.Tag;
					dp.DFName = DP_DFName.Text;
					dp.Name = DP_Name.Text;
					dp.Color1 = DP_Color1.BackColor.ToArgb().ToString();
					dp.Color2 = DP_Color2.BackColor.ToArgb().ToString();

					_StandardProcessController.DP_Update(dp);
					break;
				case 3:

					dp.StaticNo = (int)DP_DFName.Tag;

					_StandardProcessController.DP_Delete(dp.StaticNo);
					break;
			}// switch

			//페이지 초기화
			ShowDetailProcess();
			btn_3ea_Init();
			SetAlarm("상세 일정이 적용되었습니다.");
		}

		private void ComboBoxSet()
		{
			DP_Name.Items.Clear();

			List<String> list = _StandardProcessController.GetDefualtCode("defaultdetailprocess");
			if (list != null)
			{
				foreach (string str in list) { DP_Name.Items.Add(str); }
			}
			DP_Name.SelectedIndex = 1;
		}
	}
}

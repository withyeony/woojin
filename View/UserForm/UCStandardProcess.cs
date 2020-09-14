using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace View
{
	public partial class UCStandardProcess : UserControl
	{
		private StandardProcess _StandardProcess;
		private StandardProcessModel _spm;
		public UCStandardProcess(StandardProcess form)
		{
			InitializeComponent();
			_StandardProcess = form;
			_spm = new StandardProcessModel();
		}

		public StandardProcessModel SPM
		{
			get
			{
				return _spm;
			}
			set
			{
				_spm = value;
				SetData();
			}
		}
		public void SetData()
		{
			this.Tag = SPM.No;
			this.lbl_Name.Text = SPM.Name;
			this.btn_Color_1.BackColor = Color.FromArgb(Convert.ToInt32(SPM.Color1));
			this.btn_Color_2.BackColor = Color.FromArgb(Convert.ToInt32(SPM.Color2));
			this.lbl_Sort.Text = SPM.Sort.ToString();
		}

		private void ShowColor(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			ColorDialog cd = new ColorDialog();

			if (cd.ShowDialog() == DialogResult.OK)
				btn.BackColor = cd.Color;

			if (btn.Name.Equals("btn_Color_1")) SPM.Color1 = cd.Color.ToArgb().ToString();
			if (btn.Name.Equals("btn_Color_2")) SPM.Color2 = cd.Color.ToArgb().ToString();

			SetData();
		}

		private void lbl_Name_Click(object sender, EventArgs e)
		{
			Label lbl = (Label)sender;
			StandardTextModal stm = new StandardTextModal(this, SPM);
			stm.ShowDialog();
		}
		public void GetData(StandardProcessModel spm)
		{
			SPM = spm;
		}

		// 표준공정 sort순서 위 아래로 변경하는거부터 하면됨 >_< 0904 1시
		private void btn_Up_Click(object sender, EventArgs e)
		{
			if(SPM.Sort != 1)
			{
				SPM.Sort = SPM.Sort - 1;
				_StandardProcess.ChangeSPM(SPM, "Up");
			}
			SetData();
		}

		private void btn_Down_Click(object sender, EventArgs e)
		{
			if (SPM.Sort != _StandardProcess.GetCount())
			{
				SPM.Sort = SPM.Sort + 1;
				_StandardProcess.ChangeSPM(SPM, "Down");
			}
			SetData();
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			_StandardProcess.ChangeDelete(SPM);
		}
	}
}

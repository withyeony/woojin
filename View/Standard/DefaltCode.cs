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
	public partial class DefaultCode : Form, IBasicForm
	{
		private Member _LoginInfo;
		private BasicForm _Mother;
		private DefaultCodeController _DefaultCodeController;

		public DefaultCode(Member member, BasicForm form)
		{
			InitializeComponent();
			_LoginInfo = member;
			_Mother = form;
			_DefaultCodeController = new DefaultCodeController();

			dc_rankofmember.SetForm = this;
			dc_rankofmember.SetList = _DefaultCodeController.GetList("rankofmember");


			dc_departmentofmember.SetForm = this;
			dc_departmentofmember.SetList = _DefaultCodeController.GetList("departmentofmember");


			dc_brandofmachine.SetForm = this;
			dc_brandofmachine.SetList = _DefaultCodeController.GetList("brandofmachine");


			dc_purposeofmachine.SetForm = this;
			dc_purposeofmachine.SetList = _DefaultCodeController.GetList("purposeofmachine");



			dc_groupofcustomer.SetForm = this;
			dc_groupofcustomer.SetList = _DefaultCodeController.GetList("groupofcustomer");


			dc_defaultdetailprocess.SetForm = this;
			dc_defaultdetailprocess.SetList = _DefaultCodeController.GetList("defaultdetailprocess");

			dc_divisionofproduct.SetForm = this;
			dc_divisionofproduct.SetList = _DefaultCodeController.GetList("divisionofproduct");

			dc_groupofproduct.SetForm = this;
			dc_groupofproduct.SetList = _DefaultCodeController.GetList("groupofproduct");
		}

		public Form SetForm()
		{
			return this;
		}

		internal void SetSelectDivision(string name, string type)
		{
			_DefaultCodeController.SelectCode = type;       //디비명
			_DefaultCodeController.SelectCodeName = name;   //이름

			lbl_SelectDivision.Text = name;
			lbl_SelectDivision.Tag = type;
		}
		internal void SetValue(DefaultType dt, string Name)
		{
			if (lbl_SelectDivision.Text.Equals(Name))
			{
				_DefaultCodeController.SelectValue = dt;
				lbl_SelectValue.Text = dt.Value;

				lbl_No.Text = dt.No.ToString();
				lbl_Value.Text = dt.Value;
				lbl_Sort.Text = dt.Sort.ToString();
			}
		}
		internal void ResetValue()
		{
			ResetView();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (lbl_SelectValue.Text.Length == 0)
			{
				SetAlarm("선택된 값이 없습니다.");
			}
			else
			{
				List<DefaultType> list = _DefaultCodeController.Delete();
				string name = "dc_" + _DefaultCodeController.SelectCode;

				Control ctrl = pnl_View.Controls[name];
				UCDefaultCode ucDf = (UCDefaultCode)ctrl;

				ucDf.UpdateList = list;
				ResetView();
				SetAlarm("삭제 완료!");
			}

		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (lbl_SelectValue.Text.Length == 0)
			{
				SetAlarm("선택된 값이 없습니다.");
			}
			else
			{
				if (_DefaultCodeController.DuplicateCheck(tb_Update.Text))
				{
					SetAlarm("중복된 데이터 입니다.");
				}
				else
				{
					List<DefaultType> list = _DefaultCodeController.Update(tb_Update.Text);
					string name = "dc_" + _DefaultCodeController.SelectCode;

					Control ctrl = pnl_View.Controls[name];
					UCDefaultCode ucDf = (UCDefaultCode)ctrl;

					ucDf.UpdateList = list;
					ResetView();
					SetAlarm("수정 완료!");
				}
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (lbl_SelectDivision.Text.Length == 0 || tb_Add.Text.Length == 0)
			{
				SetAlarm("선택된 값이 없습니다.");
			}
			else
			{
				if (_DefaultCodeController.DuplicateCheck(tb_Update.Text))
				{
					SetAlarm("중복된 데이터 입니다.");
				}
				else
				{
					List<DefaultType> list = _DefaultCodeController.Add(tb_Add.Text);
					string name = "dc_" + _DefaultCodeController.SelectCode;

					Control ctrl = pnl_View.Controls[name];
					UCDefaultCode ucDf = (UCDefaultCode)ctrl;

					ucDf.UpdateList = list;
					ResetView();
					SetAlarm("추가 완료!");
				}
			}
		}
		private void ResetView()
		{
			lbl_SelectValue.Text = "";
			lbl_No.Text = "";
			lbl_Value.Text = "";
			lbl_Sort.Text = "";
			tb_Add.Text = "";
			tb_Update.Text = "";

			_DefaultCodeController.SelectValue = null;
		}
		public void SetAlarm(String str)
		{
			Alarm alarm = new Alarm(str);
			alarm.ShowDialog();
		}

		private void btn_Up_Click(object sender, EventArgs e)
		{
			if (lbl_SelectValue.Text.Length == 0)
			{
				SetAlarm("선택된 값이 없습니다.");
			}
			else
			{
				if (_DefaultCodeController.SelectValue.Sort != 1)
				{
					List<DefaultType> list = _DefaultCodeController.SortUp();
					string name = "dc_" + _DefaultCodeController.SelectCode;

					Control ctrl = pnl_View.Controls[name];
					UCDefaultCode ucDf = (UCDefaultCode)ctrl;

					ucDf.UpdateList = list;
					ResetView();
				}
			}
		}
		private void btn_Down_Click(object sender, EventArgs e)
		{
			if (lbl_SelectValue.Text.Length == 0)
			{
				SetAlarm("선택된 값이 없습니다.");
			}
			else
			{
				if (_DefaultCodeController.SelectValue.Sort != _DefaultCodeController.ValueCount())
				{
					List<DefaultType> list = _DefaultCodeController.SortDown();
					string name = "dc_" + _DefaultCodeController.SelectCode;

					Control ctrl = pnl_View.Controls[name];
					UCDefaultCode ucDf = (UCDefaultCode)ctrl;

					ucDf.UpdateList = list;
					ResetView();
				}
			}
		}
		private void label5_Click(object sender, EventArgs e)
		{
			dc_rankofmember.UpdateList = _DefaultCodeController.Reset("rankofmember");
			dc_departmentofmember.UpdateList = _DefaultCodeController.Reset("departmentofmember");

			ResetView();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Label btn = (Label)sender;
			String str = btn.Tag.ToString();
			_Mother.RemoveTab(str);
		}

	}
}

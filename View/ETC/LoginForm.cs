using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controller;
using Model;

namespace View
{
	public partial class LoginForm : Form, ILoginForm
	{

		private LoginFormCtl _LoginFormCtrl;
		public LoginForm()
		{
			InitializeComponent();

			_LoginFormCtrl = new LoginFormCtl(this);
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			if(tb_ID.Text.Length != 0 || tb_PassWord.Text.Length != 0){
				if (_LoginFormCtrl.TextBoxCheck(ID, PassWord))
				{
					_LoginFormCtrl.LoginCheck(ID, PassWord);
				}
			}
		}

		public String ID
		{
			get { return this.tb_ID.Text; }
		}
		public string PassWord
		{
			get { return this.tb_PassWord.Text; }
		}

		public void SetAlarm(String contnent)
		{
			Alarm alarm = new Alarm(contnent);
			alarm.ShowDialog();
		}


		public void CloseForm()
		{
			this.Close();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			CloseForm();
		}

		public void ResultOk()
		{
			((BasicForm)(this.Owner)).LoginInfo = LoginData;
			this.DialogResult = DialogResult.OK;
		}
		private Member _LoginData;
		public Member LoginData
		{
			get { return _LoginData; }
			set
			{
				_LoginData = value;
			}
		}

		private void btn_Login_Click_1(object sender, EventArgs e)
		{
			if (tb_ID.Text.Length != 0 || tb_PassWord.Text.Length != 0)
			{
				if (_LoginFormCtrl.TextBoxCheck(ID, PassWord))
				{
					_LoginFormCtrl.LoginCheck(ID, PassWord);
				}
			}
		}

		private void btn_Exit_Click_1(object sender, EventArgs e)
		{
			CloseForm();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WooJinDataBase;
using Model;
using System.Globalization;
using Controller;

namespace Controller
{
	public class LoginFormCtl
	{
		private ILoginForm _form;
		public LoginFormCtl(ILoginForm from) {
			_form = from;
		}
		public Boolean TextBoxCheck(string ID, string PassWord)
		{
			Boolean check = false;

			if (ID.Length != 0 && PassWord.Length != 0) check = true;

			return check;
		}
		public void LoginCheck(string id, string pw){
			DataBase dataBase = DataBase.Instance;
			Member member = dataBase.IdCheck(id, pw); //로그인 정보

			if(member is null)
			{
				_form.SetAlarm("로그인 정보가 올바르지 않습니다.");
			}
			else
			{
				//	_form.CloseForm();
				_form.LoginData = member;
				_form.ResultOk();
			}
		}


		
	}
}

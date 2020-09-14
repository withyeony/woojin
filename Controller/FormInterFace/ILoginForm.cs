using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public interface ILoginForm
	{
		void SetAlarm(String Content);

		void CloseForm();

		void ResultOk();

		Member LoginData { get; set; }
	}
}

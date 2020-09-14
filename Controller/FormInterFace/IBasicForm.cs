using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
	public	interface IBasicForm
	{
		Form SetForm();

		FormWindowState  WindowState { get; set; }
		bool TopLevel { get; set; } 

		void Show();
	}
}

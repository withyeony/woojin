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
	public partial class PartView : Form, IBasicForm
	{
		private Member _LoginInfo;
		private BasicForm _Mother;
		public PartView(Member member, BasicForm form)
		{
			InitializeComponent();
			_LoginInfo = member;
			_Mother = form;
		}

		public Form SetForm()
		{
			return this;
		}
	}
}

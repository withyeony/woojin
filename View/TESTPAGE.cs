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
	public partial class TESTPAGE : Form, IBasicForm
	{
		private Controller.Class1 _c;
		private Member _LoginInfo;
		private BasicForm _Mother;
		public TESTPAGE(Member member, BasicForm form)
		{
			InitializeComponent();
			_LoginInfo = member;
			_Mother = form;
			_c = new Controller.Class1();

		}
		public Form SetForm()
		{
			return this;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			List<Model.Class1> list = _c.getList();

			if (list is null)
			{
				;
			}
			else
			{
				foreach (Model.Class1 od in list)
				{
					dataGridView1.Rows.Add(od.value1, od.value2, od.value3, od.value4, od.value5);

				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			List<Model.Class1> list = _c.getListAll();

			if (list is null)
			{
				;
			}
			else
			{
				foreach (Model.Class1 od in list)
				{
					dataGridView1.Rows.Add(od.value1, od.value2, od.value3, od.value4, od.value5);

				}
			}
		}
	}
}

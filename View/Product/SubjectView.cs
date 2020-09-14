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
	public partial class SubjectView : Form, IBasicForm
	{
		private Member _LoginInfo;
		private BasicForm _Mother;
		private SubjectController _SubjectController;

		private String _SelectedOrder;
		private Boolean _AllSerchOrder;
		private Boolean _AllSerchSubject;
		public SubjectView(Member member, BasicForm form)
		{
			InitializeComponent();
			_LoginInfo = member;
			_Mother = form;
			_SubjectController = new SubjectController();
			_SelectedOrder = "";
		}

		public Form SetForm()
		{
			return this;
		}

		private void SubjectView_Load(object sender, EventArgs e)
		{
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;

			dataGridView2.AllowUserToResizeColumns = false;
			dataGridView2.AllowUserToResizeRows = false;
			DataGridReset();

			_AllSerchOrder = _AllSerchSubject = false;
		}

		private void DataGridReset()
		{
			List<Orders> orders = new List<Orders>();

			orders = _SubjectController.GetOrders();
			if (orders is null)
			{
				;
			}
			else
			{
				foreach (Orders od in orders)
				{
					if (orders.Count == 1) _SelectedOrder = od.ProductNo;
					if (_AllSerchOrder || !(od.State.Equals("완료")))
						dataGridView1.Rows.Add(od.ProductNo, od.CarType, od.ProductName, od.Material, od.DiliveryDate, od.Customer, od.CustomerMember, od.ETC);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cb_SelectBox.SelectedIndex != -1)
			{
				String value = cb_SelectBox.SelectedItem.ToString();

				string result = "";
				switch (value)
				{
					case "금형 번호":
						result = "ProductNo";
						break;

					case "차종":
						result = "CarType";
						break;

					case "품명":
						result = "ProductName";
						break;

					case "재질":
						result = "Material";
						break;

					case "고객사":
						result = "Customer";
						break;

					case "담당자":
						result = "CustomerMember";
						break;

					case "비고":
						result = "ETC";
						break;
				}


				dataGridView1.Rows.Clear();
				dataGridView2.Rows.Clear();

				List<Orders> orders = new List<Orders>();
				orders = _SubjectController.FindData(result, tb_SelectData.Text);

				if (orders is null)
				{
					;
				}
				else
				{
					foreach (Orders od in orders)
					{
						if (orders.Count == 1) _SelectedOrder = od.ProductNo;
						dataGridView1.Rows.Add(od.ProductNo, od.CarType, od.ProductName, od.Material, od.DiliveryDate, od.Customer, od.CustomerMember, od.ETC);

					}
				}
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.SelectedRows.Count != 0)	_SelectedOrder = dgv.SelectedRows[0].Cells[0].Value.ToString();

		//	List<Sub _SubjectController.GetSubjectList(_SelectedOrder);



			///subject model 만들고 subject grid띄우기 작업부터 하면됨 할일
		}

	}
}

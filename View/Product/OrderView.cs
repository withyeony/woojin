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
	public partial class OrderView : Form, IBasicForm
	{
		private Member _LoginInfo;
		private BasicForm _Mother;
		private OrderController _OrderController;
		private Orders _SelectedData;
		private List<Customer> _Customers;
		private List<CustomerMember> _CMs;
		private Boolean _ProductNoCheck;
		public OrderView(Member member, BasicForm form)
		{
			InitializeComponent();
			_LoginInfo = member;
			_Mother = form;
			_SelectedData = new Orders();
			_Customers = new List<Customer>();
			_CMs = new List<CustomerMember>();
			_OrderController = new OrderController();
		}

		public Form SetForm()
		{
			return this;
		}

		private void GetOrderList()
		{

			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;

			dataGridView2.AllowUserToResizeColumns = false;
			dataGridView2.AllowUserToResizeRows = false;

			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();

			List<Orders> orders = new List<Orders>();

			orders = _OrderController.GetOrders();
			if (orders is null)
			{
				;
			}
			else
			{
				foreach (Orders od in orders)
				{
					if (od.State.Equals("완료"))
						dataGridView2.Rows.Add(od.ProductNo, od.State, od.CarType, od.ProductName, od.Material, od.DueDate, od.DiliveryDate, od.RealDate, od.FinalData, od.Designer, od.CAM, od.MB_Data, od.Worker, od.Customer, od.CustomerMember, od.ETC);
					else	dataGridView1.Rows.Add(od.ProductNo, od.State, od.CarType, od.ProductName, od.Material, od.DueDate, od.DiliveryDate, od.RealDate, od.FinalData, od.Designer, od.CAM, od.MB_Data, od.Worker, od.Customer, od.CustomerMember, od.ETC);

				}
			}
		}

		private void OrderView_Load(object sender, EventArgs e)
		{
			GetOrderList();
			ComboBoxSet();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Delete_Apply.Visible = false;
			lbl_DataSelect.Text = "Data Select";
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
					_SelectedData.ProductNo = dr.Cells[0].Value.ToString();
					_SelectedData.State = dr.Cells[1].Value.ToString();
					_SelectedData.CarType = dr.Cells[2].Value.ToString();
					_SelectedData.ProductName = dr.Cells[3].Value.ToString();
					_SelectedData.Material = dr.Cells[4].Value.ToString();
					_SelectedData.DueDate = dr.Cells[5].Value.ToString();
					_SelectedData.DiliveryDate = dr.Cells[6].Value.ToString();
					_SelectedData.RealDate = dr.Cells[7].Value.ToString();
					_SelectedData.FinalData = dr.Cells[8].Value.ToString();
					_SelectedData.Designer = dr.Cells[9].Value.ToString();
					_SelectedData.CAM = dr.Cells[10].Value.ToString();
					_SelectedData.MB_Data = dr.Cells[11].Value.ToString();
					_SelectedData.Worker = dr.Cells[12].Value.ToString();
					_SelectedData.Customer = dr.Cells[13].Value.ToString();
					_SelectedData.CustomerMember = dr.Cells[14].Value.ToString();
					_SelectedData.ETC = dr.Cells[15].Value.ToString();
				}
			}
			SetSelectData();
			SetSelectPanel(pnl_Select);
			for (int i = 0; i < this.label_6.Controls.Count; i++)
			{
				label_6.Controls[i].BackColor = System.Drawing.SystemColors.Control;
			}
		}
		private void SetSelectPanel(Panel pnl)
		{
			pnl.BringToFront();

		}
		private void SetSelectData()
		{
			lbl_ProductNo.Text = _SelectedData.ProductNo;
			lbl_State.Text = _SelectedData.State;
			lbl_CarType.Text = _SelectedData.CarType;
			lbl_ProductName.Text = _SelectedData.ProductName;
			lbl_Material.Text = _SelectedData.Material;
			lbl_DueDate.Text = _SelectedData.DueDate;
			lbl_DilivertDate.Text = _SelectedData.DiliveryDate;
			lbl_RealDate.Text = _SelectedData.RealDate;
			lbl_FinalData.Text = _SelectedData.FinalData;
			lbl_Designer.Text = _SelectedData.Designer;
			lbl_Cam.Text = _SelectedData.CAM;
			lbl_MB.Text = _SelectedData.MB_Data;
			lbl_Wortker.Text = _SelectedData.Worker;
			lbl_Customer.Text = _SelectedData.Customer;
			lbl_CM.Text = _SelectedData.CustomerMember;
			lbl_ETC.Text = _SelectedData.ETC;
		}
		private void SetUpdateData()
		{//업데이트에 값 넣어주기
			tb_Update_ProductNo.Text = _SelectedData.ProductNo;
			tb_Update_CarType.Text = _SelectedData.CarType;
			tb_Update_ProductName.Text = _SelectedData.ProductName;
			tb_Update_Material.Text = _SelectedData.Material;
			dtp_Update_DilivertDate.Text = _SelectedData.DiliveryDate;
			dtp_Update_RealDate.Text = _SelectedData.RealDate;
			dtp_Update_Final.Text = _SelectedData.FinalData;
			cb_Update_Designer.Text = _SelectedData.Designer;
			cb_Update_Cam.Text = _SelectedData.CAM;
			dtp_Update_MB.Text = _SelectedData.MB_Data;
			cb_Update_Worker.Text = _SelectedData.Worker;
			cb_Update_Customer.Text = _SelectedData.Customer;
			cb_Update_CM.Text = _SelectedData.CustomerMember;
			tb_Update_ETC.Text = _SelectedData.ETC;
		}
		private void ComboBoxSet()
		{
			cb_Add_Cam.Items.Clear();
			cb_Add_Customer.Items.Clear();
			cb_Add_Designer.Items.Clear();
			cb_Add_Worker.Items.Clear();

			cb_Update_Cam.Items.Clear(); 
			cb_Update_Customer.Items.Clear();
			cb_Update_Designer.Items.Clear();
			cb_Update_Worker.Items.Clear();

	
			//1 = CAM팀
			//2 = 설계팀
			//3 = 생산팀
			//4 = 공정자
			
			//
			List<String> list = _OrderController.GetMemberPart(1);
			if (list != null)
			{
				foreach (string str in list) 
				{ 
					cb_Add_Cam.Items.Add(str); 
					cb_Update_Cam.Items.Add(str); 
				}
				list.Clear();

			}
			list = _OrderController.GetMemberPart(2);
			if (list != null)
			{
				foreach (string str in list) 
				{
					cb_Add_Designer.Items.Add(str);
					cb_Update_Designer.Items.Add(str); 
				}
				list.Clear();
			}
			list = _OrderController.GetMemberPart(3);
			if (list != null)
			{
				foreach (string str in list) 
				{
					cb_Add_Worker.Items.Add(str); 
					cb_Update_Worker.Items.Add(str);
				}
				list.Clear();
			}

			if(_Customers.Count > 0) _Customers.Clear();
			if (_CMs.Count > 0) _CMs.Clear();

			_Customers = _OrderController.GetCustomers();
			_CMs = _OrderController.GetCustomerMembers();

			if (_Customers.Count > 0)
			{
				foreach (Customer customer in _Customers) 
				{
					cb_Add_Customer.Items.Add(customer.Name);
					cb_Update_Customer.Items.Add(customer.Name);
				}
			}
		}
		private void AddReset()
		{
			_ProductNoCheck = false;

			tb_Add_ProductNo.ReadOnly = false;

			tb_Add_CarType.Text = "";
			tb_Add_ETC.Text = "";
			tb_Add_Material.Text = "";
			tb_Add_ProductName.Text = "";
			tb_Add_ProductNo.Text = "";

			cb_Add_Cam.SelectedIndex = -1;
			cb_Add_CM.SelectedIndex = -1;
			cb_Add_Customer.SelectedIndex = -1;
			cb_Add_Designer.SelectedIndex = -1;
			cb_Add_Worker.SelectedIndex = -1;

			dtp_Add_DilivertDate.Value = DateTime.Now;
			dtp_Add_DueDate.Value = DateTime.Now;
			dtp_Add_Final.Value = DateTime.Now;
			dtp_Add_MB.Value = DateTime.Now;
			dtp_Add_RealDate.Value = DateTime.Now;
		}
		private void UpdateReset()
		{
			tb_Update_CarType.Text = "";
			tb_Update_ETC.Text = "";
			tb_Update_Material.Text = "";
			tb_Update_ProductName.Text = "";
			tb_Update_ProductNo.Text = "";

			cb_Update_Cam.SelectedIndex = -1;
			cb_Update_CM.SelectedIndex = -1;
			cb_Update_Customer.SelectedIndex = -1;
			cb_Update_Designer.SelectedIndex = -1;
			cb_Update_Worker.SelectedIndex = -1;

			dtp_Update_DilivertDate.Value = DateTime.Now;
			dtp_Update_DueDate.Value = DateTime.Now;
			dtp_Update_Final.Value = DateTime.Now;
			dtp_Update_MB.Value = DateTime.Now;
			dtp_Update_RealDate.Value = DateTime.Now;
		}
		private void btn_Add_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			cb_Add_Cam.SelectedIndex = -1;
			cb_Add_CM.SelectedIndex = -1;
			cb_Add_Customer.SelectedIndex = -1;
			cb_Add_Designer.SelectedIndex = -1;
			cb_Add_Worker.SelectedIndex = -1;

			for (int i = 0; i < this.label_6.Controls.Count; i++)
			{
				if ((Button)label_6.Controls[i] == btn && label_6.Controls[i].BackColor == System.Drawing.SystemColors.Control)
				{


					label_6.Controls[i].BackColor = System.Drawing.SystemColors.GradientInactiveCaption;

					if (label_6.Controls[i] == btn_Add)
					{
						AddReset();
						SetSelectPanel(pnl_Add);
					}
					if (label_6.Controls[i] == btn_Update)
					{
						SetSelectPanel(pnl_Update);
						SetUpdateData();
					}
					if (label_6.Controls[i] == btn_Delete)
					{
						SetSelectPanel(pnl_Select);
						btn_Delete_Apply.Visible = true;
						lbl_DataSelect.Text = "Data Delete";
					}
				}
				else
				{
					label_6.Controls[i].BackColor = System.Drawing.SystemColors.Control;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			String str = btn.Tag.ToString();
			_Mother.RemoveTab(str);
		}

		private void SelectCustomer_ComboBox(object sender, EventArgs e)
		{
			ComboBox cb = (ComboBox)sender;
			if (cb.Text.Length != 0)
			{
				String value = cb.SelectedItem.ToString();
				cb_Add_CM.Enabled = true;
				cb_Update_CM.Enabled = true;

				Customer cm = new Customer();
				foreach (Customer cms in _Customers)
				{
					if (cms.Name == value)
					{
						cm = cms;
						break;
					}
				}//업체 찾기
				cb_Add_CM.Items.Clear();
				cb_Update_CM.Items.Clear();

				//해당 업체와 같은 번호를 가진 담당자 찾기
				foreach (CustomerMember mems in _CMs)
				{
					if (mems.No == cm.No)
					{
						cb_Add_CM.Items.Add(mems.Name);
						cb_Update_CM.Items.Add(mems.Name);
					}
				}
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if(tb_Add_ProductNo.Text.Length > 0)
			{

			
			_ProductNoCheck = _OrderController.CheckData( tb_Add_ProductNo.Text);
			String str = "이미 존재하는 번호 입니다.";
			if (_ProductNoCheck)
			{
				tb_Add_ProductNo.ReadOnly = true;
				str = "사용가능한 번호입니다.";
			}
			SetAlarm(str);
			}
		}
		private void SetAlarm(String str)
		{
			Alarm alarm = new Alarm(str);
			alarm.ShowDialog();
		}

		private void button12_Click(object sender, EventArgs e)
		{

			if (_ProductNoCheck)
			{
				Orders order = new Orders();

				order.CarType = tb_Add_CarType.Text;
				order.ETC = tb_Add_ETC.Text;
				order.Material = tb_Add_Material.Text;
				order.ProductName = tb_Add_ProductName.Text;
				order.ProductNo = tb_Add_ProductNo.Text;

				if (cb_Add_Cam.SelectedIndex == -1) order.CAM = "";
				else order.CAM = cb_Add_Cam.SelectedItem.ToString();

				if (cb_Add_CM.SelectedIndex == -1) order.CustomerMember = "";
				else order.CustomerMember = cb_Add_CM.SelectedItem.ToString();

				if (cb_Add_Customer.SelectedIndex == -1) order.Customer = "";
				else order.Customer = cb_Add_Customer.SelectedItem.ToString();

				if (cb_Add_Designer.SelectedIndex == -1) order.Designer = "";
				else order.Designer = cb_Add_Designer.SelectedItem.ToString();

				if (cb_Add_Worker.SelectedIndex == -1) order.Worker = "";
				else order.Worker = cb_Add_Worker.SelectedItem.ToString();

				order.DiliveryDate = dtp_Add_DilivertDate.Text;
				order.DueDate = dtp_Add_DueDate.Text;
				order.FinalData = dtp_Add_Final.Text;
				order.MB_Data = dtp_Add_MB.Text;
				order.RealDate = dtp_Add_RealDate.Text;

				_OrderController.AddOrder(order);

				GetOrderList();
				AddReset();
				DataPanelReset();
				SetAlarm("수주 정보 추가가 완료 되었습니다.");
			}
			else
			{
				SetAlarm("제번 중복확인이 필요합니다.");
			}

			
		}
		private void DataPanelReset()
		{
			SetSelectPanel(pnl_Select);

			btn_Delete_Apply.Visible = false;
			lbl_DataSelect.Text = "Data Select";
		}

		private void btn_Delete_Apply_Click(object sender, EventArgs e)
		{
			_OrderController.DeleteOrder(_SelectedData.ProductNo);

			GetOrderList();
			SelectReset();
			DataPanelReset();
			SetAlarm("수주 정보 삭제가 완료 되었습니다.");
		}

		private void SelectReset()
		{
			lbl_ProductNo.Text = "";
			lbl_State.Text = "";
			lbl_CarType.Text = "";
			lbl_ProductName.Text = "";
			lbl_Material.Text = "";
			lbl_DueDate.Text = "";
			lbl_DilivertDate.Text = "";
			lbl_RealDate.Text = "";
			lbl_FinalData.Text = "";
			lbl_Designer.Text = "";
			lbl_Cam.Text = "";
			lbl_MB.Text = "";
			lbl_Wortker.Text = "";
			lbl_Customer.Text = "";
			lbl_CM.Text = "";
			lbl_ETC.Text = "";


			_SelectedData.ProductNo = dataGridView1.Rows[1].Cells[0].Value.ToString();
			_SelectedData.State = dataGridView1.Rows[1].Cells[1].Value.ToString();
			_SelectedData.CarType = dataGridView1.Rows[1].Cells[2].Value.ToString();
			_SelectedData.ProductName = dataGridView1.Rows[1].Cells[3].Value.ToString();
			_SelectedData.Material = dataGridView1.Rows[1].Cells[4].Value.ToString();
			_SelectedData.DueDate = dataGridView1.Rows[1].Cells[5].Value.ToString();
			_SelectedData.DiliveryDate = dataGridView1.Rows[1].Cells[6].Value.ToString();
			_SelectedData.RealDate = dataGridView1.Rows[1].Cells[7].Value.ToString();
			_SelectedData.FinalData = dataGridView1.Rows[1].Cells[8].Value.ToString();
			_SelectedData.Designer = dataGridView1.Rows[1].Cells[9].Value.ToString();
			_SelectedData.CAM = dataGridView1.Rows[1].Cells[10].Value.ToString();
			_SelectedData.MB_Data = dataGridView1.Rows[1].Cells[11].Value.ToString();
			_SelectedData.Worker = dataGridView1.Rows[1].Cells[12].Value.ToString();
			_SelectedData.Customer = dataGridView1.Rows[1].Cells[13].Value.ToString();
			_SelectedData.CustomerMember = dataGridView1.Rows[1].Cells[14].Value.ToString();
			_SelectedData.ETC = dataGridView1.Rows[1].Cells[15].Value.ToString();
		}
		private void Reset()
		{
			AddReset();
			UpdateReset();
			SelectReset();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Orders order = new Orders();

			order.CarType = tb_Update_CarType.Text;
			order.ETC = tb_Update_ETC.Text;
			order.Material = tb_Update_Material.Text;
			order.ProductName = tb_Update_ProductName.Text;
			order.ProductNo = tb_Update_ProductNo.Text;

			if (cb_Update_Cam.SelectedIndex == -1) order.CAM = "";
			else order.CAM = cb_Update_Cam.SelectedItem.ToString();

			if (cb_Update_CM.SelectedIndex == -1) order.CustomerMember = "";
			else order.CustomerMember = cb_Update_CM.SelectedItem.ToString();

			if (cb_Update_Customer.SelectedIndex == -1) order.Customer = "";
			else order.Customer = cb_Update_Customer.SelectedItem.ToString();

			if (cb_Update_Designer.SelectedIndex == -1) order.Designer = "";
			else order.Designer = cb_Update_Designer.SelectedItem.ToString();

			if (cb_Update_Worker.SelectedIndex == -1) order.Worker = "";
			else order.Worker = cb_Update_Worker.SelectedItem.ToString();

			order.DiliveryDate = dtp_Update_DilivertDate.Text;
			order.DueDate = dtp_Update_DueDate.Text;
			order.FinalData = dtp_Update_Final.Text;
			order.MB_Data = dtp_Update_MB.Text;
			order.RealDate = dtp_Update_RealDate.Text;

			_OrderController.UpdateOrder(order);

			GetOrderList();
			UpdateReset();
			DataPanelReset();
			SetAlarm("수주 정보 수정이 완료 되었습니다.");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cb_SelectBox.SelectedIndex == -1)
			{

			}
			else
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
				orders = _OrderController.FindData(result, tb_SelectData.Text);

				if (orders is null)
				{
					;
				}
				else
				{
					foreach (Orders od in orders)
					{
						if (od.State.Equals("완료"))
							dataGridView2.Rows.Add(od.ProductNo, od.State, od.CarType, od.ProductName, od.Material, od.DueDate, od.DiliveryDate, od.RealDate, od.FinalData, od.Designer, od.CAM, od.MB_Data, od.Worker, od.Customer, od.CustomerMember, od.ETC);
						else dataGridView1.Rows.Add(od.ProductNo, od.State, od.CarType, od.ProductName, od.Material, od.DueDate, od.DiliveryDate, od.RealDate, od.FinalData, od.Designer, od.CAM, od.MB_Data, od.Worker, od.Customer, od.CustomerMember, od.ETC);

					}

					btn_Delete_Apply.Visible = false;
					lbl_DataSelect.Text = "Data Select";

					_SelectedData.ProductNo = dataGridView1.Rows[0].Cells[0].Value.ToString();
					_SelectedData.State = dataGridView1.Rows[0].Cells[1].Value.ToString();
					_SelectedData.CarType = dataGridView1.Rows[0].Cells[2].Value.ToString();
					_SelectedData.ProductName = dataGridView1.Rows[0].Cells[3].Value.ToString();
					_SelectedData.Material = dataGridView1.Rows[0].Cells[4].Value.ToString();
					_SelectedData.DueDate = dataGridView1.Rows[0].Cells[5].Value.ToString();
					_SelectedData.DiliveryDate = dataGridView1.Rows[0].Cells[6].Value.ToString();
					_SelectedData.RealDate = dataGridView1.Rows[0].Cells[7].Value.ToString();
					_SelectedData.FinalData = dataGridView1.Rows[0].Cells[8].Value.ToString();
					_SelectedData.Designer = dataGridView1.Rows[0].Cells[9].Value.ToString();
					_SelectedData.CAM = dataGridView1.Rows[0].Cells[10].Value.ToString();
					_SelectedData.MB_Data = dataGridView1.Rows[0].Cells[11].Value.ToString();
					_SelectedData.Worker = dataGridView1.Rows[0].Cells[12].Value.ToString();
					_SelectedData.Customer = dataGridView1.Rows[0].Cells[13].Value.ToString();
					_SelectedData.CustomerMember = dataGridView1.Rows[0].Cells[14].Value.ToString();
					_SelectedData.ETC = dataGridView1.Rows[0].Cells[15].Value.ToString();

					SetSelectData();

					SetSelectPanel(pnl_Select);
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			GetOrderList();
			Reset();
		}
	}
}

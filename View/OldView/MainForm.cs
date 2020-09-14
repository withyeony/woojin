using Controller;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace View
{
	public partial class MainForm : Form, IMainForm, IProductForm

	{
		private Orders _SelectedOrder;
		private Member _LoginInfo;

		private StandardController _StandardController;
		private ProductController _ProductController;


		// datagridview.tag data type change 
		// 0은 machine
		// 1은 member
		public Member LoginInfo
		{
			get { return _LoginInfo; }
			set { _LoginInfo = value; }
		}
		public MainForm()
		{
			InitializeComponent();

			_StandardController = new StandardController(this);
			_ProductController = new ProductController(this);
			_SelectedOrder = new Orders();

			initallize();

		}
		private void initallize()
		{
			DefualtCode();
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Hide();

			LoginForm loginForm = new LoginForm();

			if (loginForm.ShowDialog(this) != DialogResult.OK)
			{
				Application.Exit();
			}
			else
			{
				this.Show();
			}
		}
		private void PageInitialize()
		{
			this.tlb_0_0.Dock = System.Windows.Forms.DockStyle.None;
			this.pnl_splitter.Dock = System.Windows.Forms.DockStyle.None;
			this.pnl_0_1.Dock = System.Windows.Forms.DockStyle.None;
			this.pnl_7.Dock = System.Windows.Forms.DockStyle.None;


			tlb_0_0.Visible = false;
			pnl_0_1.Visible = false;
			pnl_7.Visible = false;
			pnl_splitter.Visible = false;
			pnl_right.Width = 300;
		}
		private void SubPageInitialize(String PageName, Panel pnl)
		{
			//0 : 설비정보 pnl_right_Machine
			//1 : 사원정보 pnl_right_Member
			//2 : 공지사항 pnl_rignt_Notice
			//3 : 수주 출하 정보 pnl_right_Order
			//4 : 부품 정보 pnl_right_Pruduct
			lbl_right_head.Text = PageName;

			pnl_right_Machine.Visible = false;
			pnl_right_Member.Visible = false;

			pnl.Visible = true;
			pnl.Dock = System.Windows.Forms.DockStyle.Fill;
			pnl.BringToFront();
		}
		private void ButtomPanelInitialize(int tag)
		{
			this.pnl_Buttom.Visible = false;

			if (tag != 0)
			{
				this.pnl_Buttom.Visible = true;
				for (int i = 0; i < this.pnl_Buttom.Controls.Count; i++)
				{
					if (Convert.ToInt32(pnl_Buttom.Controls[i].Tag) == tag)
					{
						pnl_Buttom.Controls[i].Visible = true;
						//1 표준 공정
					}
					else
					{
						pnl_Buttom.Controls[i].Visible = false;
					}
				}
			}
		}
		private void ProcessSet()
		{
			pnl_0_1.Controls.Clear();
			List<Process> list = _StandardController.getProcessList();

			if (list is null)
			{
				;
			}
			else
			{
				foreach (Process process in list)
				{
/*					StandardProcess sp = new StandardProcess(this);
					sp.ProcessData = process;

					sp.Dock = System.Windows.Forms.DockStyle.Top;
					sp.Tag = process.No;
					pnl_0_1.Controls.Add(sp);

					sp.Visible = true;*/
				}
			}

		}
		private void ComboBoxInitallize()
		{
			//콤보박스
			cb_Member_Rank.Items.Clear();
			cb_Member_Add_Rank.Items.Clear();

			cb_Member_Part.Items.Clear();
			cb_Member_Add_Part.Items.Clear();

			cb_Machine_Brand.Items.Clear();
			cb_Machine_Brand_Add.Items.Clear();
			cb_Machine_Main.Items.Clear();
			cb_Machine_Main_Add.Items.Clear();
			cb_Machine_Sub.Items.Clear();
			cb_Machine_Sub_Add.Items.Clear();
			cb_Machine_Use.Items.Clear();
			cb_Machine_Use_Add.Items.Clear();

			cb_Cutomer_Divistion.Items.Clear();
			cb_Cutomer_Group.Items.Clear();
			cb_Cutomer_Use.Items.Clear();

			cb_CM_Code.Items.Clear();

			cb_Order_Customer.Items.Clear();

			cb_CM_Code.Items.Clear();
			cb_Order_Customer.Items.Clear();
			cb_Order_Customer_Up.Items.Clear();
			cb_Order_Designer.Items.Clear();
			cb_Order_Designer_Up.Items.Clear();
			cb_Order_CAM.Items.Clear();
			cb_Order_CAM_Up.Items.Clear();
			cb_Order_Worker.Items.Clear();
			cb_Order_Worker_Up.Items.Clear();



			List<String> list = _StandardController.getDefualtCode("rankofmember");
			if (list != null)
			{
				foreach (string str in list) { cb_Member_Rank.Items.Add(str); }
				foreach (string str in list) { cb_Member_Add_Rank.Items.Add(str); }
				list.Clear();

			}
			list = _StandardController.getDefualtCode("departmentofmember");
			if (list != null)
			{
				foreach (string str in list) { cb_Member_Part.Items.Add(str); }
				foreach (string str in list) { cb_Member_Add_Part.Items.Add(str); }
				list.Clear();
			}
			
			list = _StandardController.getDefualtCode("brandofmachine");
			if (list != null)
			{
				foreach (string str in list) { cb_Machine_Brand.Items.Add(str); }
				foreach (string str in list) { cb_Machine_Brand_Add.Items.Add(str); }
				list.Clear();
			}
			cb_Machine_Use.Items.Add("Y");
			cb_Machine_Use.Items.Add("N");
			cb_Machine_Use_Add.Items.Add("Y");
			cb_Machine_Use_Add.Items.Add("N");

			
			list = _StandardController.getMemberList();
			if (list != null)
			{
				foreach (string str in list) { cb_Machine_Main.Items.Add(str); }
				foreach (string str in list) { cb_Machine_Main_Add.Items.Add(str); }
				foreach (string str in list) { cb_Machine_Sub.Items.Add(str); }
				foreach (string str in list) { cb_Machine_Sub_Add.Items.Add(str); }

				list.Clear();
			}
			
			list = _StandardController.getDefualtCode("divisionofcustomer");
			if (list != null)
			{
				foreach (string str in list) { cb_Cutomer_Divistion.Items.Add(str); }
				list.Clear();

			}
			list = _StandardController.getDefualtCode("groupofcustomer");
			if (list != null)
			{
				foreach (string str in list) { cb_Cutomer_Group.Items.Add(str); }
				list.Clear();

			}
			cb_Cutomer_Use.Items.Add("Y");
			cb_Cutomer_Use.Items.Add("N");

			list = _StandardController.getCustomerList();
			if (list != null)
			{
				foreach (string str in list) { cb_CM_Code.Items.Add(str); }
				list.Clear();
			}

			list = _ProductController.getCustomList();  //원청 업체만 가져오기
			if (list != null)
			{
				foreach (string str in list) { cb_Order_Customer.Items.Add(str); }
				foreach (string str in list) { cb_Order_Customer_Up.Items.Add(str); }
				list.Clear();
			}
			list = _ProductController.getMemberPartList("설계팀");  
			if (list != null)
			{
				foreach (string str in list) { cb_Order_Designer.Items.Add(str); }
				foreach (string str in list) { cb_Order_Designer_Up.Items.Add(str); }
				list.Clear();
			}
			list = _ProductController.getMemberPartList("CAM팀");
			if (list != null)
			{
				foreach (string str in list) { cb_Order_CAM.Items.Add(str); }
				foreach (string str in list) { cb_Order_CAM_Up.Items.Add(str); }
				list.Clear();
			}
			list = _ProductController.getMemberPartList("작업자팀");
			if (list != null)
			{
				foreach (string str in list) { cb_Order_Worker.Items.Add(str); }
				foreach (string str in list) { cb_Order_Worker_Up.Items.Add(str); }
				list.Clear();
			}

		}
		private void ComboBoxInitallizeSub()
		{
			cb_Order_CM.Items.Clear();

			List<String> list = _ProductController.getSelectMemberOfCustom(cb_Order_Customer.SelectedItem.ToString());
			if (list != null)
			{
				foreach (string str in list) { cb_Order_CM.Items.Add(str); }
				list.Clear();

			}
		}
		//-------------------------------------------------------------------------------------------
		//Interface 
		//-------------------------------------------------------------------------------------------
		//IProcess
		public void DeleteProcess(int no)
		{
			for (int i = 0; i < this.pnl_0_1.Controls.Count; i++)//전체갯수
			{
				if ((int)pnl_0_1.Controls[i].Tag == no)
				{
					pnl_0_1.Controls[i].Dispose();
					break;
				}
			}
			ProcessSet();
		}
		//IMain
		public void SetAlarm(String contnent)
		{
			Alarm alarm = new Alarm(contnent);
			alarm.ShowDialog();
		}
		public void ResultOk()
		{
			tb_Member_Add_Code.Text = "";
			tb_Member_Add_Name.Text = "";
			tb_Member_Add_PW.Text = "";
			cb_Member_Add_Rank.SelectedItem = -1;
			tb_Member_Add_Phone.Text = "";
			tb_Member_Add_Email.Text = "";
		}
		public void OrderSetInitilze()
		{
			btn_right_Order_Update.Tag = null;
			btn_right_Order_Delete.Tag = null;

			tb_Order_ProductNo.Text = "";
			tb_Order_CarType.Text = "";
			tb_Order_ProductName.Text = "";
			tb_Order_Material.Text = "";
			dtp_Order_Dilivery.Value = DateTime.Now;
			dtp_Order_DueDate.Value = DateTime.Now;
			tb_Order_FinalData.Text = "";
			cb_Order_Designer.Text = "";
			cb_Order_CAM.Text = "";
			tb_Order_MB_Data.Text = "";
			cb_Order_Worker.Text = "";
			cb_Order_CM.Text = "";
			cb_Order_Customer.Text = "";
			tb_Order_ETC.Text ="";


			tb_Order_ProductNo_Up.Text = "";
			tb_Order_CarType_Up.Text = "";
			tb_Order_ProductName_Up.Text = "";
			tb_Order_Material_Up.Text = "";
			dtp_Order_Dilivery_Up.Value = DateTime.Now;
			dtp_Order_DueDate_Up.Value = DateTime.Now;
			tb_Order_FinalData_Up.Text = "";
			cb_Order_Designer_Up.Text = "";
			cb_Order_CAM_Up.Text = "";
			tb_Order_MB_Data_Up.Text = "";
			cb_Order_Worker_Up.Text = "";
			tb_Order_CM_Up.Text = "";
			cb_Order_Customer_Up.Text = "";
			tb_Order_ETC_Up.Text = "";
		}
		public void StandardSetSelectDataMember(Member member)
		{
			tb_Member_Name.Text = member.Name;
			cb_Member_Rank.Text = member.Rank;
			cb_Member_Part.Text = member.Part;

			dtp_Member_JD.Value = DateTime.ParseExact(member.Longevity, "yyyy-MM-dd", null);
			dtp_Member_BD.Value = DateTime.ParseExact(member.Birthday, "yyyy-MM-dd", null);

			tb_Member_Phone.Text = member.Phone;
			tb_Member_Email.Text = member.Email;

			btn_Default_Member_Delete.Tag = member.No;
			btn_Default_Member_Update.Tag = member.No;
		}
		public void StandardSetSelectDataMachine(Machine machine)
		{


			tb_Machine_Name.Text = machine.Name;
			cb_Machine_Main.Text = machine.Supervisor;
			cb_Machine_Sub.Text = machine.Subordinate;
			cb_Machine_Brand.Text = machine.Manufact;
			dtp_Machine_Buy.Text = machine.Buy;
			tb_Machine_IP.Text = machine.IP;
			cb_Machine_Use.Text = machine.Use;

			btn_Default_Machine_Delete.Tag = machine.No;
			btn_Default_Machine_Update.Tag = machine.No;
		}
		public void StandardSetSelectDataCustomer(Customer customer)
		{

			tb_Cutomer_No.Text = customer.No.ToString();
			cb_Cutomer_Group.Text = customer.CGroup;
			tb_Cutomer_Name.Text = customer.Name;
			tb_Cutomer_CEO.Text = customer.CEO;
			tb_Cutomer_Number.Text = customer.Number;
			tb_Cutomer_Fax.Text = customer.Fax;
			cb_Cutomer_Use.Text = customer.Transaction;

			btn_Default_Custommer_Update.Tag = customer.No;
			btn_Default_Custommer_Delete.Tag = customer.No;

			//customer member select 하는부분

			dgv_left_DGV_Sub.Rows.Clear();
			List<CustomerMember> cms = new List<CustomerMember>();
			cms = _StandardController.GetCustomerMembers(customer.No);

			if (cms is null)
			{

			}
			else
			{
				foreach (CustomerMember cm in cms)
				{
					//여기다가 
					dgv_left_DGV_Sub.Rows.Add(cm.No, cm.Name, cm.Part, cm.Rank, cm.Number, cm.Fax, cm.Email, cm.ETC);
				}
			}
			cb_CM_Code.Text = customer.No.ToString();

		}
		public void StandardSetSelectDataCustomerMember(CustomerMember cm)
		{
			cb_CM_Code.Text = cm.No.ToString();
			tb_CM_Name.Text = cm.Name;
			tb_CM_Part.Text = cm.Part;
			tb_CM_Rank.Text = cm.Rank;
			tb_CM_Number.Text = cm.Number;
			tb_CM_Fax.Text = cm.Fax;
			tb_CM_Email.Text = cm.Email;
			tb_CM_ETC.Text = cm.ETC;

			btn_Default_Custommer_Member_Delete.Tag = cm.StaticNo;
			btn_Default_Custommer_Member_Update.Tag = cm.StaticNo;

		}
		public void resetMemberTable()
		{
			tb_Member_Name.Text = "";
			cb_Member_Rank.Text = "";

			dtp_Member_JD.Value = DateTime.Now;
			dtp_Member_BD.Value = DateTime.Now;

			tb_Member_Phone.Text = "";
			tb_Member_Email.Text = "";

			btn_Default_Member_Delete.Tag = null;
			btn_Default_Member_Update.Tag = null;
		}
		public void resetMachineTable()
		{
			tb_Machine_Name.Text = "";
			cb_Machine_Main.Text = "";
			cb_Machine_Sub.Text = "";
			cb_Machine_Brand.Text = "";

			dtp_Machine_Buy.Value = DateTime.Now;

			tb_Machine_IP.Text = "";
			cb_Machine_Use.Text = "";

			btn_Default_Machine_Delete.Tag = null;
			btn_Default_Machine_Update.Tag = null;
		}
		public void resetCustomerTable()
		{
			tb_Cutomer_No.Text = "";
			cb_Cutomer_Divistion.Text = "";
			cb_Cutomer_Group.Text = "";
			tb_Cutomer_Name.Text = "";
			tb_Cutomer_CEO.Text = "";
			tb_Cutomer_Number.Text = "";
			tb_Cutomer_Fax.Text = "";
			cb_Cutomer_Use.Text = "";

			cb_CM_Code.Text = "";
			tb_CM_Name.Text = "";
			tb_CM_Rank.Text = "";
			tb_CM_Part.Text = "";
			tb_CM_Number.Text = "";
			tb_CM_Fax.Text = "";
			tb_CM_Email.Text = "";
			tb_CM_ETC.Text = "";

			btn_Default_Custommer_Delete.Tag = null;
			btn_Default_Custommer_Update.Tag = null;

			btn_Default_Custommer_Member_Update.Tag = null;
			btn_Default_Custommer_Member_Delete.Tag = null;
		}
		//-------------------------------------------------------------------------------------------
		private String DdayCheck(String Longevity)
		{
			string value = "";
			if (Longevity.Equals("0"))
			{
				value = Longevity;
			}
			else
			{
				TimeSpan ts = DateTime.Now - DateTime.Parse(Longevity);

				string str = ts.ToString();
				string[] spStr = str.Split('.');
				value = spStr[0];
			}
			return value;
		}
		private void DefualtCode()
		{
			lb_Customer_Division.Items.Clear();
			lb_Customer_Group.Items.Clear();
			lb_Machine_Buy.Items.Clear();
			lb_Member_Department.Items.Clear();
			lb_Member_Rank.Items.Clear();

			List<String> list = _StandardController.getDefualtCode("rankofmember");
			if (list != null)
			{
				foreach (string str in list) { lb_Member_Rank.Items.Add(str); }
			}
			list = _StandardController.getDefualtCode("departmentofmember");
			if (list != null)
			{
				foreach (string str in list) { lb_Member_Department.Items.Add(str); }
			}
			list = _StandardController.getDefualtCode("divisionofcustomer");
			if (list != null)
			{
				foreach (string str in list) { lb_Customer_Division.Items.Add(str); }
			}
			list = _StandardController.getDefualtCode("groupofcustomer");
			if (list != null)
			{
				foreach (string str in list) { lb_Customer_Group.Items.Add(str); }
			}
			list = _StandardController.getDefualtCode("brandofmachine");
			if (list != null)
			{
				foreach (string str in list) { lb_Machine_Buy.Items.Add(str); }
			}

			ComboBoxInitallize();
		}
		private void MainBtnClick(object sender, EventArgs e)
		{
			Button button = (Button)sender;

			button.BackColor = SystemColors.ControlDark;
			for (int i = 0; i < this.pnl_Main.Controls.Count; i++)
			{
				if (pnl_Main.Controls[i].Name != button.Name)
				{
					pnl_Main.Controls[i].BackColor = SystemColors.Control;
				}
			}
			for (int i = 0; i < this.pnl_Top_Sub.Controls.Count; i++)
			{
				if (pnl_Top_Sub.Controls[i].Tag == button.Tag)
				{
					pnl_Top_Sub.Controls[i].Visible = true;
				}
				else
				{
					pnl_Top_Sub.Controls[i].Visible = false;
				}
			}
			if (Convert.ToInt32(button.Tag) == 7)
			{
				NoticeInitalize();
			}
			else
			{
				pnl_Top_Sub.Visible = true;

				dgv_left_DGV.Visible = true;
				dgv_left_DGV_Sub.Visible = true;
				pnl_7.Visible = false;

			}

		}
		private void DefualtClick(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			TextBox tb = new TextBox();
			string value = "";
			if (btn.Tag.ToString().Equals(tb_Customer_Divition.Tag))
			{
				value = btn.Tag.ToString();
				tb = tb_Customer_Divition;
			}
			if (btn.Tag.ToString().Equals(tb_Customer_Group.Tag))
			{
				value = btn.Tag.ToString();
				tb = tb_Customer_Group;
			}
			if (btn.Tag.ToString().Equals(tb_Member_Department.Tag))
			{
				value = btn.Tag.ToString();
				tb = tb_Member_Department;

			}
			if (btn.Tag.ToString().Equals(tb_Member_Rank.Tag))
			{
				value = btn.Tag.ToString();
				tb = tb_Member_Rank;
			}
			if (btn.Tag.ToString().Equals(tb__Machine_Buy.Tag))
			{
				value = btn.Tag.ToString();
				tb = tb__Machine_Buy;
			}
			if (tb.Text.Length == 0)
				MessageBox.Show("입력값이 올바르지 않습니다.");
			else
				_StandardController.AddDefualtCode(btn.Tag.ToString(), tb.Text);


			DefualtCode();
		}
		private void btn_Sub_0_0_Click(object sender, EventArgs e)
		{
			PageInitialize();
			this.tlb_0_0.Dock = System.Windows.Forms.DockStyle.Fill;
			tlb_0_0.Visible = true;

			ButtomPanelInitialize(0);
		}
		private void btn_Sub_0_1_Click(object sender, EventArgs e)
		{
			PageInitialize();
			pnl_0_1.Visible = true;
			this.pnl_0_1.Dock = System.Windows.Forms.DockStyle.Fill;
			ButtomPanelInitialize(1);
			ProcessSet();
		}
		private void btn_Sub_0_2_Click(object sender, EventArgs e)
		{
			PageInitialize();
			this.pnl_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			pnl_splitter.Visible = true;

			dgv_left_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_left_DGV.AllowUserToResizeColumns = false;
			dgv_left_DGV.AllowUserToResizeRows = false;

			dgv_left_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
			dgv_left_DGV_Sub.Visible = false;

			dgv_left_DGV.Rows.Clear();

			dgv_left_DGV.Tag = 0;  // 0은 machine
			Column9.Visible = true;
			Column10.Visible = true;
			Column11.Visible = true;
			Column12.Visible = false;
			Column13.Visible = false;
			Column14.Visible = false;
			Column16.Visible = false;
			Column17.Visible = false;


			Column1.HeaderText = "번호";
			Column2.HeaderText = "장비명";
			Column3.HeaderText = "구분";
			Column4.HeaderText = "관리자(정)";
			Column5.HeaderText = "관리자(부)";
			Column6.HeaderText = "브렌드명";
			Column7.HeaderText = "구입일자";
			Column8.HeaderText = "IP";
			Column9.HeaderText = "사용유무";

			Column10.Visible = false;
			Column11.Visible = false;
			Column12.Visible = false;
			Column13.Visible = false;
			Column14.Visible = false;
			Column16.Visible = false;
			Column17.Visible = false;

			ButtomPanelInitialize(0);


			List<Machine> machines = new List<Machine>();
			machines = _StandardController.GetMachines();

			if (machines is null)
			{

			}
			else
			{
				foreach (Machine mac in machines)
				{
					dgv_left_DGV.Rows.Add(mac.No, mac.Name, "할일", mac.Supervisor, mac.Subordinate, mac.Manufact, mac.Buy, mac.IP, mac.Use);
				}
			}

			SubPageInitialize("설비 정보", pnl_right_Machine);

		}
		private void btn_Sub_0_3_Click(object sender, EventArgs e)
		{
			PageInitialize();
			this.pnl_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			pnl_splitter.Visible = true;

			dgv_left_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_left_DGV.AllowUserToResizeColumns = false;
			dgv_left_DGV.AllowUserToResizeRows = false;

			dgv_left_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
			dgv_left_DGV_Sub.Visible = false;

			dgv_left_DGV.Rows.Clear();

			dgv_left_DGV.Tag = 1;
			Column9.Visible = true;
			Column10.Visible = true;
			Column11.Visible = true;
			Column12.Visible = false;
			Column13.Visible = false;
			Column14.Visible = false;
			Column16.Visible = false;
			Column17.Visible = false;

			Column1.HeaderText = "번호";
			Column2.HeaderText = "이름";
			Column3.HeaderText = "생일";
			Column4.HeaderText = "직급";
			Column5.HeaderText = "부서";
			Column6.HeaderText = "전화번호";
			Column7.HeaderText = "이메일";
			Column8.HeaderText = "근속일수";
			Column9.HeaderText = "입사일";

			Column10.Visible = false;
			Column11.Visible = false;
			Column12.Visible = false;
			Column13.Visible = false;
			Column14.Visible = false;
			Column16.Visible = false;
			Column17.Visible = false;

			ButtomPanelInitialize(0);

			List<Member> members = new List<Member>();
			members = _StandardController.GetMembers();

			if (members is null)
			{

			}
			else
			{
				foreach (Member mem in members)
				{
					//여기다가 
					dgv_left_DGV.Rows.Add(mem.No, mem.Name, mem.Birthday, mem.Rank, mem.Part, mem.Phone, mem.Email, DdayCheck(mem.Longevity), mem.Longevity);
				}
			}

			SubPageInitialize("사원 정보", pnl_right_Member);

		}
		private void btn_Sub_0_4_Click(object sender, EventArgs e)
		{
			PageInitialize();
			this.pnl_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			pnl_splitter.Visible = true;
			dgv_left_DGV.Height = 450;
			dgv_left_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_left_DGV.AllowUserToResizeColumns = false;
			dgv_left_DGV.AllowUserToResizeRows = false;

			dgv_left_DGV.Dock = System.Windows.Forms.DockStyle.Top;

			dgv_left_DGV_Sub.Visible = true;
			dgv_left_DGV_Sub.Dock = System.Windows.Forms.DockStyle.Fill;


			dgv_left_DGV_Sub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_left_DGV_Sub.AllowUserToResizeColumns = false;
			dgv_left_DGV_Sub.AllowUserToResizeRows = false;


			dgv_left_DGV.Rows.Clear();

			dgv_left_DGV.Tag = 2;
			Column9.Visible = true;
			Column10.Visible = true;
			Column11.Visible = true;
			Column12.Visible = false;
			Column13.Visible = false;
			Column14.Visible = false;
			Column16.Visible = false;
			Column17.Visible = false;

			Column1.HeaderText = "업체코드";
			Column2.HeaderText = "업체구분";
			Column3.HeaderText = "그룹업체";
			Column4.HeaderText = "업체명";
			Column5.HeaderText = "대표자명";
			Column6.HeaderText = "전화번호";
			Column7.HeaderText = "펙스번호";
			Column8.HeaderText = "거래유무";

			Column9.Visible = false;
			Column10.Visible = false;
			Column11.Visible = false;
			Column12.Visible = false;
			Column13.Visible = false;
			Column14.Visible = false;
			Column16.Visible = false;
			Column17.Visible = false;

			ButtomPanelInitialize(0);

			List<Customer> customers = new List<Customer>();
			customers = _StandardController.GetCustomers();

			if (customers is null)
			{

			}
			else
			{
				foreach (Customer cus in customers)
				{
					dgv_left_DGV.Rows.Add(cus.No, "", cus.CGroup, cus.Name, cus.CEO, cus.Number, cus.Fax, cus.Transaction);
				}
			}

			dgv_left_DGV_Sub.Rows.Clear();


			dataGridViewTextBoxColumn1.HeaderText = "업체번호";
			dataGridViewTextBoxColumn2.HeaderText = "담당자명";
			dataGridViewTextBoxColumn3.HeaderText = "부서";
			dataGridViewTextBoxColumn4.HeaderText = "직위";
			dataGridViewTextBoxColumn5.HeaderText = "전화번호";
			dataGridViewTextBoxColumn6.HeaderText = "펙스번호";
			dataGridViewTextBoxColumn7.HeaderText = "이메일";
			dataGridViewTextBoxColumn8.HeaderText = "비고";


			ButtomPanelInitialize(0);



			SubPageInitialize("업체 정보", pnl_right_Customer);
		}
		private void DefualtDeleteClick(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			ListBox lb = new ListBox();

			if (btn.Tag.ToString().Equals(lb_Customer_Division.Tag)) lb = lb_Customer_Division;
			if (btn.Tag.ToString().Equals(lb_Customer_Group.Tag)) lb = lb_Customer_Group;
			if (btn.Tag.ToString().Equals(lb_Machine_Buy.Tag)) lb = lb_Machine_Buy;
			if (btn.Tag.ToString().Equals(lb_Member_Department.Tag)) lb = lb_Member_Department;
			if (btn.Tag.ToString().Equals(lb_Member_Rank.Tag)) lb = lb_Member_Rank;


			if (lb.SelectedIndices.Count > 0)
			{
				_StandardController.DeleteDefualtCode(btn.Tag.ToString(), lb.SelectedItem.ToString());
			}
			else MessageBox.Show("입력값이 올바르지 않습니다.");

			DefualtCode();
		}
		private void btn_Default_Machine_Add_Click(object sender, EventArgs e)
		{
			if (pnl_right_Machine_Add.Visible)
			{
				pnl_right_Machine_Add.Visible = false;
			}
			else
			{
				pnl_right_Machine_Add.Visible = true;
			}
		}
		private void btn_Default_Member_Add_Click(object sender, EventArgs e)
		{
			if (pnl_right_Member_Add.Visible)
			{
				pnl_right_Member_Add.Visible = false;
			}
			else
			{
				pnl_right_Member_Add.Visible = true;
			}
		}
		private void btn_Default_Member_Add_Apply_Click(object sender, EventArgs e)
		{

			//빈값 확인하기
			if (tb_Member_Add_Code.Text.Length == 0)
			{
				MessageBox.Show("사원번호를 입력해주세요.");
			}
			else
			{
				Member newMember = new Member();
				newMember.Id = tb_Member_Add_Code.Text;
				newMember.Name = tb_Member_Add_Name.Text;
				newMember.PassWord = tb_Member_Add_PW.Text;
				newMember.Rank = cb_Member_Add_Rank.SelectedItem.ToString();
				newMember.Part = cb_Member_Add_Part.SelectedItem.ToString();
				newMember.Longevity = dtp_Member_Add_JD.Text;
				newMember.Birthday = dtp_Member_Add_BD.Text;
				newMember.Phone = tb_Member_Add_Phone.Text;
				newMember.Email = tb_Member_Add_Email.Text;


				if (_StandardController.OverlapCheck("member", newMember.No))
				{
					newMember.No = _StandardController.MemberCnt() + 1;
					_StandardController.AddMember(newMember);
				}
				else
				{
					MessageBox.Show("이미 존재하는 사원번호입니다.");
				}

			}
			ComboBoxInitallize();
			this.btn_Sub_0_3_Click(sender, e);
		}
		private void pnl_left_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			DataGridView dgv = (DataGridView)sender;

			if (dgv.SelectedRows.Count != 0)
			{
				DataGridViewRow dr = dgv_left_DGV.SelectedRows[0];

				if (dr.Cells[0].Value is null)
				{
					;
				}
				else
				{
					String selectNo = dr.Cells[0].Value.ToString();
					_StandardController.FindGridData(Convert.ToInt32(dgv_left_DGV.Tag), selectNo);
				}
			}

			
		}
		private void dgv_left_DGV_Sub_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			DataGridView dgv = (DataGridView)sender;

			if(dgv.SelectedRows.Count != 0)
			{
				DataGridViewRow dr = dgv.SelectedRows[0];
				if (dr.Cells[1].Value is null || dr.Cells[3].Value is null)
				{
					;
				}
				else
				{
					string name = dr.Cells[1].Value.ToString();
					string rank = dr.Cells[3].Value.ToString();
					_StandardController.FindGridData(Convert.ToInt32(dgv_left_DGV_Sub.Tag), name, rank);
				}
			}
		}
		private void btn_Default_Member_Update_Click(object sender, EventArgs e)
		{
			//빈값 check
			_StandardController.UpdateMember(Convert.ToInt32(btn_Default_Member_Update.Tag), tb_Member_Name.Text, cb_Member_Rank.Text, cb_Member_Part.Text, dtp_Member_JD.Text.ToString(), dtp_Member_BD.Text.ToString(), tb_Member_Phone.Text, tb_Member_Email.Text);
			ComboBoxInitallize();
			this.btn_Sub_0_3_Click(sender, e);
		}
		private void btn_Default_Member_Delete_Click(object sender, EventArgs e)
		{
			_StandardController.DeleteMember(Convert.ToInt32(btn_Default_Member_Delete.Tag));
			ComboBoxInitallize();
			this.btn_Sub_0_3_Click(sender, e);
		}
		private void btn_Default_Machine_Add_Apply_Click(object sender, EventArgs e)
		{

			//빈값 확인하기
			if (tb_Machine_Name_Add.Text.Length == 0)
			{
				MessageBox.Show("설비명을 입력해주세요.");
			}
			else
			{
				Machine machine = new Machine();

				machine.Name = tb_Machine_Name_Add.Text;
				machine.Supervisor = cb_Machine_Main_Add.Text;
				machine.Subordinate = cb_Machine_Sub_Add.Text;
				machine.Manufact = cb_Machine_Brand_Add.Text;
				machine.Buy = dtp_Machine_Buy_Add.Text;
				machine.IP = tb_Machine_IP_Add.Text;
				machine.Use = cb_Machine_Use_Add.Text;


				_StandardController.AddMachine(machine);

			}
			ComboBoxInitallize();
			this.btn_Sub_0_2_Click(sender, e);
		}
		private void btn_Default_Machine_Update_Click(object sender, EventArgs e)
		{
			_StandardController.UpdateMachine(Convert.ToInt32(btn_Default_Machine_Update.Tag), tb_Machine_Name.Text, cb_Machine_Main.Text, cb_Machine_Sub.Text, cb_Machine_Brand.Text, dtp_Machine_Buy.Text, tb_Machine_IP.Text, cb_Machine_Use.Text);

			ComboBoxInitallize();
			this.btn_Sub_0_2_Click(sender, e);
		}
		private void btn_Default_Machine_Delete_Click(object sender, EventArgs e)
		{
			_StandardController.DeleteMachine(Convert.ToInt32(btn_Default_Machine_Delete.Tag));
			ComboBoxInitallize();
			this.btn_Sub_0_2_Click(sender, e);
		}
		private void btn_Default_Custommer_Add_Click(object sender, EventArgs e)
		{
			if (tb_Cutomer_No.Text.Length == 0)
			{
				MessageBox.Show("사원번호를 입력해주세요.");
			}
			else
			{
				Customer newCustomer = new Customer();
				newCustomer.No = Convert.ToInt32(tb_Cutomer_No.Text);
				newCustomer.CGroup = cb_Cutomer_Group.SelectedItem.ToString();
				newCustomer.Name = tb_Cutomer_Name.Text;
				newCustomer.CEO = tb_Cutomer_CEO.Text;
				newCustomer.Number = tb_Cutomer_Number.Text;
				newCustomer.Fax = tb_Cutomer_Fax.Text;
				newCustomer.Transaction = cb_Cutomer_Use.SelectedItem.ToString();



				if (_StandardController.OverlapCheck("Customer", newCustomer.No))
				{
					_StandardController.AddCustomer(newCustomer);
				}
				else
				{
					MessageBox.Show("이미 존재하는 업체번호입니다.");
				}

			}
			ComboBoxInitallize();
			this.btn_Sub_0_4_Click(sender, e);
		}
		private void btn_Default_Custommer_Delete_Click(object sender, EventArgs e)
		{
			_StandardController.DeleteCustomer(Convert.ToInt32(btn_Default_Custommer_Delete.Tag));
			ComboBoxInitallize();
			this.btn_Sub_0_4_Click(sender, e);
		}
		private void btn_Default_Custommer_Update_Click(object sender, EventArgs e)
		{
			if (_StandardController.OverlapCheck("Customer", Convert.ToInt32(btn_Default_Custommer_Update.Tag)) || Convert.ToInt32(btn_Default_Custommer_Update.Tag) == Convert.ToInt32(tb_Cutomer_No.Text))
			{
				_StandardController.UpdateCustomer(Convert.ToInt32(btn_Default_Custommer_Update.Tag), cb_Cutomer_Divistion.Text, cb_Cutomer_Group.Text, tb_Cutomer_Name.Text, tb_Cutomer_CEO.Text, tb_Cutomer_Number.Text, tb_Cutomer_Fax.Text, cb_Cutomer_Use.Text);
			}
			else
			{
				MessageBox.Show("이미 존재하는 업체번호입니다.");
			}

			ComboBoxInitallize();
			this.btn_Sub_0_4_Click(sender, e);
		}
		private void btn_Default_Custommer_Member_Add_Click(object sender, EventArgs e)
		{

			CustomerMember cm = new CustomerMember();
			cm.No = Convert.ToInt32(tb_Cutomer_No.Text);
			cm.Name = tb_CM_Name.Text;
			cm.Part = tb_CM_Part.Text;
			cm.Rank = tb_CM_Rank.Text;
			cm.Number = tb_CM_Number.Text;
			cm.Fax = tb_CM_Fax.Text;
			cm.Email = tb_CM_Email.Text;
			cm.ETC = tb_CM_ETC.Text;


			_StandardController.AddCustomerMember(cm);


			ComboBoxInitallize();
			this.btn_Sub_0_4_Click(sender, e);
		}
		private void btn_Default_Custommer_Member_Update_Click(object sender, EventArgs e)
		{
			_StandardController.UpdateCustomerMember(Convert.ToInt32(btn_Default_Custommer_Member_Update.Tag), Convert.ToInt32(cb_CM_Code.Text), tb_CM_Name.Text, tb_CM_Part.Text, tb_CM_Rank.Text, tb_CM_Number.Text, tb_CM_Fax.Text, tb_CM_Email.Text, tb_CM_ETC.Text);

			ComboBoxInitallize();
			this.btn_Sub_0_4_Click(sender, e);
		}
		private void btn_Default_Custommer_Member_Delete_Click(object sender, EventArgs e)
		{
			_StandardController.DeleteCustomerMember(Convert.ToInt32(btn_Default_Custommer_Member_Delete.Tag));
			ComboBoxInitallize();
			this.btn_Sub_0_4_Click(sender, e);
		}
		private void tb_Cutomer_No_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
			{
				e.Handled = true;
			}
		}

		private void btn_Default_Process_Add_Click(object sender, EventArgs e)
		{
			Process process = new Process();
			process.No = pnl_0_1.Controls.Count + 1;
			process.Sort = pnl_0_1.Controls.Count + 1;
			process.Color = "";
			process.Name = "";

			_StandardController.ProcessAdd(process.No);
			ProcessSet();
		}

		private void btn_Default_Process_Apply_Click(object sender, EventArgs e)
		{
			Boolean result = true;
			List<Process> list = new List<Process>();
			for (int i = 0; i < this.pnl_0_1.Controls.Count; i++)//전체갯수
			{
				/*StandardProcess sp = (StandardProcess)pnl_0_1.Controls[i];
				Process pro = sp.ProcessData;
				if(pro.Sort == 0)
				{
					pro.Sort = sp.directSortValue();
				}
				if(pro.Name.Length == 0)
				{
					MessageBox.Show("공정명을 입력해주세요");
				}
				list.Add(pro);*/
			}

			if (result)
			{
				int check = 0;
				for (int i = 0; i < list.Count; i++)
				{
					foreach (Process pro in list)
					{
						if (pro.Sort == i + 1)
						{
							check++;
						}
					}
					if (check != 1)
					{
						result = false;
						MessageBox.Show("입력값을 확인해주세요");
						break;
					}
					else
					{
						check = 0;
					}

				}
				if (result)
				{
					_StandardController.UpdateProcess(list);
				}
			}
			else
			{
				MessageBox.Show("입력 인자값이 부족합니다.");
			}
			
			

			
			ProcessSet();
		}

		private void btn_Default_Notice_Add_Click(object sender, EventArgs e)
		{
			pnl_7_Add.Visible = true;

			pnl_7_Add.Dock = System.Windows.Forms.DockStyle.Fill;
		}

		private void btn_Notice_Add_cancle_Click(object sender, EventArgs e)
		{
			NoticeInitalize();
		}
		private void NoticeInitalize()
		{
			pnl_Top_Sub.Visible = false;

			ButtomPanelInitialize(0);
			PageInitialize();
			this.pnl_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			pnl_splitter.Visible = true;



			List<Notice> notices = new List<Notice>();
			notices = _StandardController.GetNotices();

			dgv_Notice_List.Rows.Clear();
			if (notices is null)
			{

			}
			else
			{
				foreach (Notice notice in notices)
				{
					dgv_Notice_List.Rows.Add(notice.Title, notice.Name, notice.Date, notice.No);
				}
			}
			dgv_left_DGV.Visible = false;
			dgv_left_DGV_Sub.Visible = false;
			pnl_7.Visible = true;
			this.pnl_7.Dock = System.Windows.Forms.DockStyle.Fill;

			pnl_7.BringToFront();
			SubPageInitialize("공지 사항", pnl_right_Notice);


			btn_Default_Notice_Delete.Tag = null;
			btn_Default_Notice_Update.Tag = null;

			tlp_Notice_Contect.Visible = false;
			pnl_7_Add.Visible = false;
		}
		private void btn_Notice_Add_apply_Click(object sender, EventArgs e)
		{

			if (btn_Notice_Add_apply.Tag is null)
			{
				_StandardController.AddNotice(tb_Notice_Add_title.Text, tb_Notice_Add_content.Text, _LoginInfo.Name);
			}
			else
			{
				_StandardController.UpdateNotice(tb_Notice_Add_title.Text, tb_Notice_Add_content.Text, _LoginInfo.Name, Convert.ToInt32(btn_Notice_Add_apply.Tag));
			}



			btn_Notice_Add_apply.Tag = null;
			NoticeInitalize();
		}

		private void dgv_Notice_List_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow dr = dgv_Notice_List.SelectedRows[0];

			if (dr.Cells[3].Value is null)
			{

			}
			else
			{
				int selectNo = Convert.ToInt32(dr.Cells[3].Value);

				//해당 데이터 받아와서 뿌려주기
				_StandardController.GetNotices(selectNo);

				tlp_Notice_Contect.Visible = true;
				tlp_Notice_Contect.Dock = System.Windows.Forms.DockStyle.Fill;
			}
		}

		public void StandardSetSelectDataNotice(Notice notice)
		{
			lbl_Notice_Content_Title.Text = notice.Title;
			lbl_Notice_Content_Name.Text = notice.Name;
			lbl_Notice_Content_content.Text = notice.Content;
			lbl_Notice_Content_Date.Text = notice.Date;

			btn_Default_Notice_Delete.Tag = notice.No;
			btn_Default_Notice_Update.Tag = notice.No;

		}

		public void StandardSetSelectDataNoticeUpdate(Notice notice)
		{
			tb_Notice_Add_title.Text = notice.Title;
			tb_Notice_Add_content.Text = notice.Content;

			btn_Notice_Add_apply.Tag = notice.No;

		}



		//여기서부터 할것!
		public void ProductSetSelectDataOrder(Orders orders)
		{
			pnl_right_Product_Add.Tag = orders.ProductNo;

			//클릭 했을때 거기에 대한 항목 나올수있게 구현
			//dgv_left_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_left_DGV.AllowUserToResizeColumns = false;
			dgv_left_DGV.AllowUserToResizeRows = false;

			dgv_left_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
			dgv_left_DGV_Sub.Visible = false;

			dgv_left_DGV.Rows.Clear();


			Column9.Visible = true;
			Column10.Visible = true;
			Column11.Visible = true;
			Column12.Visible = true;
			Column13.Visible = true;
			Column14.Visible = true;
			Column16.Visible = true;
			Column17.Visible = true;

			dgv_left_DGV.Tag = 3;

			//table 상태 이상 (이거 항목이랑 매칭 해야함)
			//품번부터 시작할것
			Column1.HeaderText = "번호";
			Column2.HeaderText = "제번";
			Column3.HeaderText = "품목명";
			Column4.HeaderText = "규격";
			Column5.HeaderText = "재질";


			ButtomPanelInitialize(0);

			List<Orders> order123 = new List<Orders>();

		/*	orders = _ProductController.GetOrders();
			if (orders is null)
			{

			}
			else
			{
				foreach (Orders od in orders)
				{
					dgv_left_DGV.Rows.Add(od.No, od.ProductNo, od.State, od.CarType, od.ArticleNum, od.Material, od.DueDate, od.DiliveryDate, od.RealDate, od.Customer, od.CustomerMember, od.Designer, od.Developer, od.ETC);
				}
			}*/
		}
		public void StandardSetSelectDataOrder(Orders order)
		{
			_SelectedOrder = order;
			btn_right_Order_Update.Tag = order.ProductNo;
			btn_right_Order_Delete.Tag = order.ProductNo;
			btn_right_Order_View.Tag = order.ProductNo;

			tb_Order_ProductNo_Up.Text = order.ProductNo;
			tb_Order_CarType_Up.Text = order.CarType;
			tb_Order_ProductName_Up.Text = order.ProductName;
			tb_Order_Material_Up.Text = order.Material;
			dtp_Order_Dilivery_Up.Value = DateTime.ParseExact(order.DiliveryDate, "yyyy-MM-dd", null);
			dtp_Order_DueDate_Up.Value = DateTime.ParseExact(order.DueDate, "yyyy-MM-dd", null);
			tb_Order_FinalData_Up.Text = order.FinalData;
			cb_Order_Designer_Up.Text = order.Designer;
			cb_Order_CAM_Up.Text = order.CAM;
			tb_Order_MB_Data_Up.Text = order.MB_Data;
			cb_Order_Worker_Up.Text = order.Worker;
			cb_Order_Customer_Up.Text = order.Customer;
			tb_Order_CM_Up.Text = order.CustomerMember;
			tb_Order_ETC_Up.Text = order.ETC;
		}

		private void btn_Default_Notice_Delete_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			_StandardController.DeleteNotice(Convert.ToInt32(btn.Tag));
			NoticeInitalize();
		}

		private void btn_Default_Notice_Update_Click(object sender, EventArgs e)
		{
			pnl_7_Add.Visible = true;
			pnl_7_Add.Dock = System.Windows.Forms.DockStyle.Fill;
			if(btn_Default_Notice_Update.Tag is null){;}
			else
			{
				_StandardController.GetNotice_UpdateData(Convert.ToInt32(btn_Default_Notice_Update.Tag));
			}
		}
		private void btn_Sub_1_0_Click(object sender, EventArgs e)
		{

			//수주 출하 정보
			PageInitialize();
			this.pnl_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			pnl_splitter.Visible = true;

		
			dgv_left_DGV.AllowUserToResizeColumns = false;
			dgv_left_DGV.AllowUserToResizeRows = false;

			dgv_left_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
			dgv_left_DGV_Sub.Visible = false;

			dgv_left_DGV.Rows.Clear();


			Column9.Visible = true;
			Column10.Visible = true;
			Column11.Visible = true;
			Column12.Visible = true;
			Column13.Visible = true;
			Column14.Visible = true;
			Column16.Visible = true;
			Column17.Visible = true;

			dgv_left_DGV.Tag = 3;



			Column1.HeaderText = "금형번호";
			Column2.HeaderText = "상태";
			Column3.HeaderText = "차종";
			Column4.HeaderText = "품번";
			Column5.HeaderText = "재질";
			Column6.HeaderText = "개발요청일";
			Column7.HeaderText = "납기일";
			Column8.HeaderText = "납품일";
			Column9.HeaderText = "최종 DATA";
			Column10.HeaderText ="설계자";
			Column11.HeaderText = "CAM";
			Column12.HeaderText = "M/B 입고";
			Column13.HeaderText = "작업자";
			Column14.HeaderText = "고객사";
			Column16.HeaderText = "개발 담당자";
			Column17.HeaderText = "비고";

			ButtomPanelInitialize(0);

			List<Orders> orders = new List<Orders>();

			orders = _ProductController.GetOrders();
			if (orders is null)
			{
				;
			}
			else
			{
				foreach (Orders od in orders)
				{
				dgv_left_DGV.Rows.Add(od.ProductNo, od.State, od.CarType, od.ProductName, od.Material, od.DueDate, od.DiliveryDate, od.RealDate, od.FinalData, od.Designer, od.CAM, od.MB_Data, od.Worker, od.Customer, od.CustomerMember, od.ETC );
				}
			}

			SubPageInitialize("수주 정보", pnl_right_Orders);
		}

		private void btn_right_Order_Add_Click(object sender, EventArgs e)
		{
			pnl_right_Orders_Update.Visible = false;

			if (pnl_right_Orders_Add.Visible)
			{
				pnl_right_Orders_Add.Visible = false;
			}
			else
			{
				pnl_right_Orders_Add.Visible = true;
			}
		}
		private void btn_right_Order_Update_Click(object sender, EventArgs e)
		{
			pnl_right_Orders_Add.Visible = false;
			if (pnl_right_Orders_Update.Visible)
			{
				pnl_right_Orders_Update.Visible = false;
			}
			else
			{
				pnl_right_Orders_Update.Visible = true;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Clear();

			string file_Address = null;

			if(ofd.ShowDialog() == DialogResult.OK)
			{
				file_Address = ofd.FileName;
		//		textBox1.Text = file_Address.Split('\\')[file_Address.Split('\\').Length - 1];
				textBox1.Text = file_Address;
			}
		}


		private void btn_right_Order_Cancle_Click(object sender, EventArgs e)
		{
			pnl_right_Orders_Add.Visible = false;

			tb_Order_ProductName.Text = "";
			tb_Order_ProductNo.Text = "";
			tb_Order_CarType.Text = "";
			tb_Order_ETC.Text = "";
			tb_Order_Material.Text = "";
			tb_Order_FinalData.Text = "";
			tb_Order_MB_Data.Text = "";

			cb_Order_CM.SelectedIndex = -1;
			cb_Order_Customer.SelectedIndex = -1;
			cb_Order_Designer.SelectedIndex = -1;
			cb_Order_CAM.SelectedIndex = -1;
			cb_Order_Worker.SelectedIndex = -1;

			dtp_Order_Dilivery.Value = DateTime.Now;
			dtp_Order_DueDate.Value = DateTime.Now;
		}

		private void cb_Order_Customer_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBoxInitallizeSub();
		}

		private void btn_Sub_6_2_MouseClick(object sender, MouseEventArgs e)
		{
			Button button = (Button)sender;

			button.BackColor = SystemColors.ControlDark;
			for (int i = 0; i < this.pnl_Top_Sub.Controls.Count; i++)
			{
				pnl_Top_Sub.Controls[i].BackColor = SystemColors.Control;
			}
			button.BackColor = SystemColors.ControlDark;
		}

		private void btn_right_Order_Apply_Click(object sender, EventArgs e)
		{
			Orders order = new Orders();

			order.ProductNo = tb_Order_ProductNo.Text;
			order.CarType = tb_Order_CarType.Text;
			order.ProductName = tb_Order_ProductName.Text;
			order.Material = tb_Order_Material.Text;
			order.DiliveryDate = dtp_Order_Dilivery.Text;
			order.DueDate = dtp_Order_DueDate.Text;
			order.FinalData = tb_Order_FinalData.Text;

			if (cb_Order_Designer.SelectedItem is null) order.Designer = "";
			else order.Designer = cb_Order_Designer.SelectedItem.ToString();

			if (cb_Order_CAM.SelectedItem is null) order.CAM = "";
			else order.CAM = cb_Order_CAM.SelectedItem.ToString();

			order.MB_Data = tb_Order_MB_Data.Text;

			if (cb_Order_Worker.SelectedItem is null) order.Worker = "";
			else order.Worker = cb_Order_Worker.SelectedItem.ToString();

			if (cb_Order_Customer.SelectedItem is null) order.Customer = "";
			else order.Customer = cb_Order_Customer.SelectedItem.ToString();

			if (cb_Order_CM.SelectedItem is null) order.CustomerMember = "";
			else order.CustomerMember = cb_Order_CM.SelectedItem.ToString();

			order.ETC = tb_Order_ETC.Text;

			_ProductController.AddOrder(order);

			btn_Sub_1_0_Click(sender, e);
		}

		private void btn_right_Order_Delete_Click(object sender, EventArgs e)
		{
			_ProductController.DeleteOrder(btn_right_Order_Delete.Tag.ToString());
			btn_Sub_1_0_Click(sender, e);
		}

		private void btn_right_Order_Apply_Up_Click(object sender, EventArgs e)
		{
			Orders order = new Orders();

			order.ProductNo = tb_Order_ProductNo_Up.Text;
			order.CarType = tb_Order_CarType_Up.Text;
			order.ProductName = tb_Order_ProductName_Up.Text;
			order.Material = tb_Order_Material_Up.Text;

			order.FinalData = tb_Order_FinalData_Up.Text;

			if (cb_Order_Designer_Up.SelectedItem is null) order.Designer = "";
			else order.Designer = cb_Order_Designer_Up.SelectedItem.ToString();

			if (cb_Order_CAM_Up.SelectedItem is null) order.CAM = "";
			else order.CAM = cb_Order_CAM_Up.SelectedItem.ToString();

			order.MB_Data = tb_Order_MB_Data_Up.Text;

			if (cb_Order_Worker_Up.SelectedItem is null) order.Worker = "";
			else order.Worker = cb_Order_Worker_Up.SelectedItem.ToString();

			if (cb_Order_Customer_Up.SelectedItem is null) order.Customer = "";
			else order.Customer = cb_Order_Customer_Up.SelectedItem.ToString();

			order.CustomerMember = tb_Order_CM_Up.Text;
			order.ETC = tb_Order_ETC_Up.Text;

			order.DiliveryDate = dtp_Order_Dilivery_Up.Text;
			order.DueDate = dtp_Order_DueDate_Up.Text;

			_ProductController.UpdateOrder(order);

			btn_Sub_1_0_Click(sender, e);
		}

		private void btn_right_Order_Cancle_Up_Click(object sender, EventArgs e)
		{
			pnl_right_Orders_Update.Visible = false;

			tb_Order_ProductNo_Up.Text = "";
			tb_Order_CarType_Up.Text = "";
			tb_Order_ProductName_Up.Text = "";
			tb_Order_Material_Up.Text = "";
			dtp_Order_Dilivery_Up.Value = DateTime.Now;
			dtp_Order_DueDate_Up.Value = DateTime.Now;
			tb_Order_FinalData_Up.Text = "";

			cb_Order_Designer_Up.SelectedIndex = -1;
			cb_Order_CAM_Up.SelectedIndex = -1;
			tb_Order_MB_Data_Up.Text = "";
			cb_Order_Worker_Up.SelectedIndex = -1;
			cb_Order_Customer_Up.SelectedIndex = -1;
			tb_Order_CM_Up.Text = "";
			tb_Order_ETC_Up.Text = "";







		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void btn_Sub_1_1_Click(object sender, EventArgs e)
		{
			
			PageInitialize();
			pnl_right.Width = 450;
			this.pnl_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			pnl_splitter.Visible = true;

			dgv_Product.AllowUserToResizeColumns = false;
			dgv_Product.AllowUserToResizeRows = false;

			dgv_Product.Dock = System.Windows.Forms.DockStyle.Top;
			dgv_Product.Visible = true;

			dgv_Product.Rows.Clear();


			//table 상태 이상 (이거 항목이랑 매칭 해야함)
			dataGridViewTextBoxColumn9.HeaderText = "제번";
			dataGridViewTextBoxColumn10.HeaderText = "상태";
			dataGridViewTextBoxColumn11.HeaderText = "품명";
			dataGridViewTextBoxColumn12.HeaderText = "요청일";
			dataGridViewTextBoxColumn13.HeaderText = "납기일";
			dataGridViewTextBoxColumn14.HeaderText = "고객사";
			Column15.Visible = false;

			ButtomPanelInitialize(0);

			List<Orders> orders = new List<Orders>();

			orders = _ProductController.GetOrders();
			if (orders is null)
			{
				;
			}
			else
			{
				foreach (Orders od in orders)
				{
					dgv_Product.Rows.Add("",od.ProductNo,  od.State, od.ProductName, od.DiliveryDate, od.DueDate, od.Customer);
				}
			}

			dgv_left_DGV.AllowUserToResizeColumns = false;
			dgv_left_DGV.AllowUserToResizeRows = false;

			dgv_left_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
			dgv_left_DGV_Sub.Visible = false;

			dgv_left_DGV.Rows.Clear();


			Column9.Visible = true;
			Column10.Visible = true;
			Column11.Visible = true;
			Column12.Visible = false;
			Column13.Visible = false;
			Column14.Visible = false;
			Column16.Visible = false;
			Column17.Visible = false;

			dgv_left_DGV.Tag = 4;

			Column1.HeaderText = "제번";
			Column2.HeaderText = "부품번호";
			Column3.HeaderText = "품명";
			Column4.HeaderText = "설계";
			Column5.HeaderText = "CAM";
			Column6.HeaderText = "조";
			Column7.HeaderText = "부품";
			Column8.HeaderText = "공정";
			Column9.HeaderText = "상태";
			Column10.HeaderText = "시작";
			Column11.HeaderText = "종료";

			ButtomPanelInitialize(0);

			List<Products> products = new List<Products>();

			products = _ProductController.GetProducts();
			if (products is null)
			{
				;
			}
			else
			{
				foreach (Products pro in products)
				{
					dgv_left_DGV.Rows.Add(pro.No, pro.ProductNo, pro.ProductName, pro.Designer, pro.CAM, pro.Work, pro.Product, pro.Fair, pro.State, pro.Start, pro.End);
				}
			}
			SubPageInitialize("부품 정보", pnl_right_Product);
		}

		private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;

			if (dgv.SelectedRows.Count != 0)
			{
				DataGridViewRow dr = dgv_Product.SelectedRows[0];

				if (dr.Cells[0].Value is null)
				{
					;
				}
				else
				{
					String selectNo = dr.Cells[0].Value.ToString();
					_StandardController.FindGridData(Convert.ToInt32(dgv_left_DGV.Tag), selectNo);
				}
			}
		}

		private void btn_right_Order_Check_Up_Click(object sender, EventArgs e)
		{
			
			if(btn_right_Order_Update.Tag.ToString().Length == 0)
			{
				;
			}
			else
			{
				Orders order = new Orders();
				order.ProductNo = btn_right_Order_Update.Tag.ToString();

				order.ProductNo = tb_Order_ProductNo_Up.Text;
				order.CarType = tb_Order_CarType_Up.Text;
				order.ETC = tb_Order_ETC_Up.Text;
				order.Material = tb_Order_Material_Up.Text;
				order.CustomerMember = tb_Order_CM_Up.Text;
				order.Customer = cb_Order_Customer_Up.SelectedItem.ToString();
				order.Designer = cb_Order_Designer_Up.SelectedItem.ToString();
				order.DiliveryDate = dtp_Order_Dilivery_Up.Text;
				order.DueDate = dtp_Order_DueDate_Up.Text;

				PreviewOrder po = new PreviewOrder(order);
				po.ShowDialog();
			}
		}

		private void btn_right_Order_View_Click(object sender, EventArgs e)
		{
				PreviewOrder po = new PreviewOrder(_SelectedOrder);
				po.ShowDialog();
		}

		private void dgv_left_DGV_CellBorderStyleChanged(object sender, EventArgs e)
		{

		}
	}
}
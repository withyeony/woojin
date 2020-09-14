using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooJinDataBase;


namespace Controller
{
	//기준 정보 + 공지사항
	public class StandardController
	{
		private IMainForm _form;
		DataBase dataBase = DataBase.Instance;
		public StandardController(IMainForm form) { _form = form; }

		public List<String> getDefualtCode(String type)
		{
			List<string> list = null;

			list = dataBase.GetDefaultCodeList(type);
			return list;
		}
		public List<String> getMemberList()
		{
			List<string> list = null;

			list = dataBase.getMemberList();
			return list;
		}

		public void AddDefualtCode(String type, String value)
		{
			dataBase.AddDefualtCode(type, value);
		}

		public void DeleteDefualtCode(String type, String value)
		{
		//	dataBase.DeleteDefualtCode(type, value);
		}

		public List<Member> GetMembers()
		{
			List<Member> members = new List<Member>();
			members = dataBase.GetMembers();
			return members;
		}
	
		public Boolean OverlapCheck(String type, int no)
		{
			return dataBase.OverlapCheck(type, no);
		}
		public Boolean OverlapCheck(String type, string Id)
		{
			return dataBase.OverlapIdCheck(type, Id);
		}
		public void AddMember(Member member)
		{
			dataBase.AddMember(member);
			_form.SetAlarm("사원 추가가 완료되었습니다.");
			_form.ResultOk();
		}

		public void FindGridData(int type, string no)
		{
			String str = "";
			switch (type)
			{
				case 0:
					str = "machine";
					_form.StandardSetSelectDataMachine(dataBase.SelectDataGridRowMachine(str, no));
					break;

				case 1:
					str = "member";
					_form.StandardSetSelectDataMember(dataBase.SelectDataGridRowMember(str, no));
					break;

				case 2:
					str = "customer";
					_form.StandardSetSelectDataCustomer(dataBase.SelectDataGridRowCustomer(str, no));
					break;

				case 3:
					str = "orders";
					_form.StandardSetSelectDataOrder(dataBase.SelectDataGridRowOrder(str, no));
					break;

				case 4:
					str = "product";
				//	_form.ProductSetSelectDataOrder(dataBase.SelectDataGridRowProduct(str, no));
					break;

			}
		}

		public void FindGridData(int type, string name, string rank)
		{
			String str = "";
			switch (type)
			{
				case 3:
					str = "customerMember";
					_form.StandardSetSelectDataCustomerMember(dataBase.SelectDataGridRowCustomerMember(str, name, rank));
					break;
			}
		}

		public void UpdateMember(int no, string name, string rank, string part, string longevity, string birthday, string phone, string email)
		{
			dataBase.UpdateMember(no, name, rank, part, longevity, birthday, phone, email);

			_form.SetAlarm("사원 수정이 완료되었습니다.");
			_form.resetMemberTable();
		}

		public void DeleteMember(int no)
		{
			dataBase.DeleteMember(no);

			_form.SetAlarm("사원 삭제가 완료되었습니다.");
			_form.resetMemberTable();
		}
		public void AddMachine(Machine machine)
		{
			dataBase.AddMachine(machine);
			_form.SetAlarm("설비 추가가 완료되었습니다.");
			_form.ResultOk();
		}

		public List<Machine> GetMachines()
		{
			List<Machine> machines = new List<Machine>();
			machines = dataBase.GetMachines();
			return machines;
		}

		public List<Process> getProcessList()
		{
			List<Process> list = dataBase.GetStandardProcesses();

			return list;
		}

		public void UpdateMachine(int no, string name, string main, string sub, string brand, string buy, string ip, string ues)
		{
			dataBase.UpdateMachine(no, name, main, sub, brand, buy, ip, ues);

			_form.SetAlarm("장비정보 수정이 완료되었습니다.");
			_form.resetMachineTable();
		}

		public void DeleteMachine(int no)
		{
			dataBase.DeleteMachine(no);

			_form.SetAlarm("장비정보 삭제가 완료되었습니다.");
			_form.resetMachineTable();
		}
		public List<Customer> GetCustomers()
		{
			List<Customer> customer = new List<Customer>();
			customer = dataBase.GetCustomers();
			return customer;
		}
		public List<CustomerMember> GetCustomerMembers(int no)
		{//할일
			List<CustomerMember> customerMember = new List<CustomerMember>();
			customerMember = dataBase.GetCustomerMembers(no);
			return customerMember;
		}

		public void AddCustomer(Customer customer)
		{
			dataBase.AddCustomer(customer);
			_form.SetAlarm("업체 추가가 완료되었습니다.");
			_form.ResultOk();
		}

		public void DeleteCustomer(int no)
		{
			dataBase.DeleteCustomer(no);
			dataBase.DeleteCustomerMembers(no);

			_form.SetAlarm("업체정보 삭제가 완료되었습니다.");
			_form.resetCustomerTable();
		}

		public void UpdateCustomer(int no, string division, string gruop, string name, string ceo, string number, string fax, string transaction)
		{
			dataBase.UpdateCustomer(no, division, gruop, name, ceo, number, fax, transaction);

			_form.SetAlarm("업체정보 수정이 완료되었습니다.");
			_form.resetCustomerTable();
		}

		public List<string> getCustomerList()
		{
			List<string> list = null;

		//	list = dataBase.getCustomerList();
			return list;
		}

		public void AddCustomerMember(CustomerMember cm)
		{
			dataBase.AddCustomerMember(cm);
			_form.SetAlarm("업체 담당자 추가가 완료되었습니다.");
			_form.ResultOk();
		}

		public void UpdateCustomerMember(int sNo, int no, string name, string part, string rank, string number, string fax, string email, string etc)
		{
			dataBase.UpdateCustomerMember( sNo, no, name, part, rank, number, fax, email, etc);

			_form.SetAlarm("담당자정보 수정이 완료되었습니다.");
			_form.resetCustomerTable();
		}

		public void DeleteCustomerMember(int no)
		{
			dataBase.DeleteCustomerMember(no);

			_form.SetAlarm("담당자정보 삭제가 완료되었습니다.");
			_form.resetCustomerTable();
		}


		public void ProcessAdd(int no)
		{ 
			dataBase.ProcessAdd(no);
		}

		public List<Notice> GetNotices()
		{
			List<Notice> list = null;

			list = dataBase.GetNotices();
			return list;
		}

		public void AddNotice(string title, string content, string name)
		{
			dataBase.AddNotice(title, content, name);
			_form.SetAlarm("공지 등록이 완료되었습니다.");
			_form.ResultOk();
		}

		public void GetNotices(int selectNo)
		{
			_form.StandardSetSelectDataNotice(dataBase.GetNotices(selectNo));
		}
		public void GetNotice_UpdateData(int selectNo)
		{
			_form.StandardSetSelectDataNoticeUpdate(dataBase.GetNotices(selectNo));
		}
		public void DeleteNotice(int no)
		{
			dataBase.DeleteNotice(no);

			_form.SetAlarm("공지사항 삭제가 완료되었습니다.");
			_form.resetCustomerTable();
		}

		public void UpdateNotice(string title, string content, string name, int no)
		{
			dataBase.UpdateNotice(no, title, content, name);

			_form.SetAlarm("공지사항 수정이 완료되었습니다.");
			_form.resetCustomerTable();
		}

		public void UpdateProcess(List<Process> list)
		{
			dataBase.UpdateProcess(list);

			_form.SetAlarm("표준공정 수정이 완료되었습니다.");
			_form.resetCustomerTable();

		}

		public int MemberCnt()
		{
			return  dataBase.MemberCnt();
		}
	}
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
	public interface IMainForm
	{
		void SetAlarm(String Content);

		void ResultOk();

		void StandardSetSelectDataMember(Member member);
		void StandardSetSelectDataMachine(Machine machine);
		void StandardSetSelectDataCustomer(Customer machine);
		void StandardSetSelectDataCustomerMember(CustomerMember customerMember);
		void StandardSetSelectDataNotice(Notice notice);
		void StandardSetSelectDataNoticeUpdate(Notice notice);
		void StandardSetSelectDataOrder(Orders orders);

		void ProductSetSelectDataOrder(Orders orders);
		void resetMemberTable();
		void resetCustomerTable();
		void resetMachineTable();
	}
}

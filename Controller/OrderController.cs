using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
	public class OrderController
	{
		DataBase dataBase = DataBase.Instance;
		public OrderController()
		{
		}

		public List<Orders> GetOrders()
		{
			return dataBase.GetOrders();
		}

		public List<string> GetMemberPart(int value)
		{
			return dataBase.GetMemberPart(value);
		}

		public List<Customer> GetCustomers()
		{
			return dataBase.getOrderOfCustomerList();
		}

		public List<CustomerMember> GetCustomerMembers()
		{
			return dataBase.getOrderOfCustomerMemberList();
		}

		public bool CheckData(string value)
		{
			return dataBase.ProductNoUseCheck(value);
		}

		public void AddOrder(Orders order)
		{
			dataBase.AddOrder(order);
		}

		public void DeleteOrder(string productNo)
		{
			dataBase.DeleteOrder(productNo);
		}

		public void UpdateOrder(Orders order)
		{
			dataBase.UpdateOrder(order);
		}

		public List<Orders> FindData(string result, string text)
		{
			return dataBase.GetListSelectOrder(result, text);
		}
	}
}

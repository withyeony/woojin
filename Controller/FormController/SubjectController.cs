using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using WooJinDataBase;

namespace Controller
{
	public class SubjectController
	{
		DataBase dataBase = DataBase.Instance;
		public SubjectController()
		{
		}

		public List<Orders> GetOrders()
		{
			return dataBase.GetOrders();
		}

		public List<Orders> FindData(string result, string text)
		{
			return dataBase.GetListSelectOrder(result, text);
		}

		public List<Subject> GetSubJectList(string OrderNo)
		{
			return dataBase.GetSubJectList(OrderNo);
		}
	}
}

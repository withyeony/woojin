using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
	public class ProcessController
	{
		DataBase dataBase = DataBase.Instance;

		public ProcessController() {}

		public void StandardProcessesExit(int no)
		{
			dataBase.StandardProcessesExit(no);
		}

		public List<int> StandardProcessesSet()
		{
			List<int> list = dataBase.StandardProcessesSet();
			return list;
		}
	}
}

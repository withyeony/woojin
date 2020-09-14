using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
	public class Class1
	{
		DataBaseECS cncnet = DataBaseECS.Instance;

		public List<Model.Class1> getList()
		{
			return cncnet.GetList();
		}
		public List<Model.Class1> getListAll()
		{
			return cncnet.GetListAll();
		}
	}
}

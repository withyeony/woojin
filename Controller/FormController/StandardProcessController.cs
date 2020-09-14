using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
	public class StandardProcessController
	{
		DataBase dataBase = DataBase.Instance;

		public StandardProcessController() { }

		public List<StandardProcessModel> GetStandardProcess()
		{
			List<StandardProcessModel> list = null;
			list = dataBase.GetStandardProcess();
			return list;

		}

		public void AddStandardProcess(StandardProcessModel newSPM)
		{
			dataBase.AddStandardProcess(newSPM);
		}

		public void UpdateStandardProcess(List<StandardProcessModel> sPMs)
		{
			dataBase.UpdateStandardProcess(sPMs);
		}

		public void DeleteStandardProcess(StandardProcessModel sPM)
		{
			dataBase.DeleteStandardProcess(sPM);
			dataBase.DeleteStandardProcessChild(sPM);
			dataBase.DeleteStandardProcessAfter(sPM);
		}

		public List<DetailProcess> DetailProcessList(int no)
		{
			return dataBase.DetailProcessList(no);
		}

		public void DP_Add(DetailProcess dp)
		{
			dataBase.DP_Add(dp);
		}

		public void DP_Update(DetailProcess dp)
		{
			dataBase.DP_Update(dp);
		}

		public void DP_Delete(int staticNo)
		{
			dataBase.DP_Delete(staticNo);
		}

		public List<string> GetDefualtCode(string type)
		{ 
			return dataBase.GetDefaultCodeList(type);
		}
	}
}

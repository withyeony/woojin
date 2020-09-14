using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
	public class NoticeController
	{
		DataBase dataBase = DataBase.Instance;
		public NoticeController()
		{

		}

		public List<Notice> GetNotice()
		{
			return dataBase.GetNotice();
		}

		public void UpdateNoticeData(Notice selectData)
		{
			dataBase.UpdateNoticeData(selectData);

		}

		public void DeleteNoticeData(Notice selectData)
		{
			dataBase.DeleteNoticeData(selectData);
		}

		public void AddNoticeData(Notice selectData)
		{
			dataBase.AddNoticeData(selectData);
		}

		public List<Notice> FindData(string result, string value)
		{
			return dataBase.NoticeGetSelete(result, value);
		}

	}
}

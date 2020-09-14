using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
	public class MemberController
	{
		DataBase dataBase = DataBase.Instance;
		public MemberController()
		{
		}

		public List<Member> GetMemberList()
		{
			return dataBase.GetMemberList();
		}

		public List<Member> FindData(string result, string value)
		{
			return dataBase.GetListSelectMember(result, value);
		}

		public List<string> GetDefualtCode(string type)
		{
			List<string> list = null;

			list = dataBase.GetDefaultCodeList(type);
			return list;
		}

		public void UpdateMember(Member member)
		{
			dataBase.UpdateMember(member);
		
		}

		public void DeleteMember(int text)
		{
			dataBase.DeleteMember(text);
		}

		public bool CheckData(string type, string value)
		{
			return	dataBase.MemberUseCheck(type, value);
		}

		public void AddMember(Member member)
		{
			dataBase.AddMember(member);
		}
	}
}

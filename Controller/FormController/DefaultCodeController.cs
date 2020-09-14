using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
	public class DefaultCodeController
	{
		private String _SelectCode;
		private String _SelectCodeName;
		private DefaultType _SelectValue;
		DataBase dataBase = DataBase.Instance;
		public DefaultCodeController()
		{
			_SelectCode = "";
			_SelectCodeName = "";
			_SelectValue = new DefaultType();
		}

		public List<DefaultType> GetList(string type)
		{
			List<DefaultType> list = null;

			list = dataBase.DefualtCodeList(type);
			return list;
		}

		public String SelectCode
		{
			get { return _SelectCode; }
			set
			{
				_SelectCode = value;
			}
		}
		public String SelectCodeName
		{
			get { return _SelectCodeName; }
			set
			{
				_SelectCodeName = value;
			}
		}
		public DefaultType SelectValue
		{
			get { return _SelectValue; }
			set
			{
				_SelectValue = value;
			}
		}

		public List<DefaultType> Delete()
		{
			dataBase.DeleteDefualtCode(SelectCode, SelectValue);
			dataBase.SortChangeDefaultCode(SelectCode, SelectValue.Sort);

			return dataBase.DefualtCodeList(SelectCode);
		}

		public List<DefaultType> Add(string text)
		{
			dataBase.AddDefualtCode(SelectCode, text);
			return dataBase.DefualtCodeList(SelectCode);
		}

		public List<DefaultType> Update(string text)
		{
			dataBase.UpdateDefualtCode(SelectCode, SelectValue, text);
			return dataBase.DefualtCodeList(SelectCode);
		}

		public bool DuplicateCheck(string text)
		{
			return dataBase.DefualtCodeDuplicateCheck(SelectCode, text);
		}

		public int ValueCount()
		{
			return dataBase.DefualtCodeCount(SelectCode);
		}
		public List<DefaultType> SortUp()
		{
			dataBase.DefualtCodeSortUp(SelectCode, SelectValue);
			dataBase.DefualtCodeSortUpOppenent(SelectCode, SelectValue);
			return dataBase.DefualtCodeList(SelectCode);
		}
		public List<DefaultType> SortDown()
		{
			dataBase.DefualtCodeSortDown(SelectCode, SelectValue);
			dataBase.DefualtCodeSortDownOppenent(SelectCode, SelectValue);
			return dataBase.DefualtCodeList(SelectCode);
		}
		public List<DefaultType> Reset(string tableName)
		{
			return dataBase.DefualtCodeList(tableName);
		}


	}
}

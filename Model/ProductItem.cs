using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class ProductItem
	{
		private int _No;
		private String _Division;
		private String _Part;
		private String _Code;
		private String _Name;
		private String _EName;

		public ProductItem() { }

		public int No
		{
			get { return _No; }
			set
			{
				_No = value;
			}
		}
		public String Division
		{
			get { return _Division; }
			set
			{
				_Division = value;
			}
		}
		public String Part
		{
			get { return _Part; }
			set
			{
				_Part = value;
			}
		}
		public String Code
		{
			get { return _Code; }
			set
			{
				_Code = value;
			}
		}
		public String Name
		{
			get { return _Name; }
			set
			{
				_Name = value;
			}
		}
		public String EName
		{
			get { return _EName; }
			set
			{
				_EName = value;
			}
		}
	}

}

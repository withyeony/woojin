using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DivisionOfProduct
    {
		private int _No;
		private String _Type;
		private String _Sort;

		public DivisionOfProduct() { }

		public int No
		{
			get { return _No; }
			set
			{
				_No = value;
			}
		}
		public String Type
		{
			get { return _Type; }
			set
			{
				_Type = value;
			}
		}

		public String Sort
		{
			get { return _Sort; }
			set
			{
				_Sort = value;
			}
		}
	}
}

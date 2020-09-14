using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Serializable]
	public class DefaultType
	{
		private int _No;
		private int _Sort;
		private String _Value;

		public DefaultType() { }

		public int No
		{
			get { return _No; }
			set
			{
				_No = value;
			}
		}
		public int Sort
		{
			get { return _Sort; }
			set
			{
				_Sort = value;
			}
		}
		public String Value
		{
			get { return _Value; }
			set
			{
				_Value = value;
			}
		}

	}
}

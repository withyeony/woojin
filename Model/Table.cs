using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Table
	{
		private String _Title;
		private String _Content;
		private String _Name;
		private String _Date;

		public Table() { }
		public String Title
		{
			get { return _Title; }
			set
			{
				_Title = value;
			}
		}
		public String Content
		{
			get { return _Content; }
			set
			{
				_Content = value;
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
		public String Date
		{
			get { return _Date; }
			set
			{
				_Date = value;
			}
		}


	}
}

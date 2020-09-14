using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Model
{
    public class Products
    {

		private String _No;
		private String _ProductNo;
		private String _ProductName;
		private String _Designer;
		private String _CAM;
		private String _Work;
		private String _Product;
		private String _Fair;
		private String _State;
		private String _Start;
		private String _End;

		public Products() { }
    
        public String No
        {
            get { return _No; }
            set
            {
                _No = value;
            }
        }
        public String ProductNo
        {
            get { return _ProductNo; }
            set
            {
                _ProductNo = value;
            }
        }
        public String ProductName
        {
            get { return _ProductName; }
            set
            {
                _ProductName = value;
            }
        }
        public String Designer
        {
            get { return _Designer; }
            set
            {
                _Designer = value;
            }
        }
        public String CAM
        {
            get { return _CAM; }
            set
            {
                _CAM = value;
            }
        }
        public String Work
        {
            get { return _Work; }
            set
            {
                _Work = value;
            }
        }
		public String Product
        {
			get { return _Product; }
			set
			{
                _Product = value;
			}
		}
        public String Fair
        {
            get { return _Fair; }
            set
            {
                _Fair = value;
            }
        }
        public String State
        {
            get { return _State; }
            set
            {
                _State = value;
            }
        }
        public String Start
        {
            get { return _Start; }
            set
            {
                _Start = value;
            }
        }
        public String End
        {
            get { return _End; }
            set
            {
                _End = value;
            }
        }
    }
}

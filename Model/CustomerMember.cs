using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Model
{
    public class CustomerMember
    {
        private int    _No;
        private String _Name;
        private String _Part;
        private String _Rank;
        private String _Number;
        private String _Fax;
        private String _Email;
        private String _ETC;
        private int _staticNo;
        public CustomerMember() { }

        public int No
        {
            get { return _No; }
            set
            {
                _No = value;
            }
        }
        public int StaticNo
        {
            get { return _staticNo; }
            set
            {
                _staticNo = value;
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
        public String Part
        {
            get { return _Part; }
            set
            {
                _Part = value;
            }
        }
        public String Rank
        {
            get { return _Rank; }
            set
            {
                _Rank = value;
            }
        }
        public String Number
        {
            get { return _Number; }
            set
            {
                _Number = value;
            }
        }
        public String Fax
        {
            get { return _Fax; }
            set
            {
                _Fax = value;
            }
        }
        public String Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
            }
        }
        public String ETC
        {
            get { return _ETC; }
            set
            {
                _ETC = value;
            }
        }

    }
}

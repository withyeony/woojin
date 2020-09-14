using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        private int _No;
        private String _CGroup;
        private String _Name;
        private String _CEO;
        private String _Address;
        private String _Number;
        private String _Fax;
        private String _Transaction;

        public Customer() { }

        public int No
        {
            get { return _No; }
            set
            {
                _No = value;
            }
        }

        public String CGroup
        {
            get { return _CGroup; }
            set
            {
                _CGroup = value;
            }
        }

        public void GetDgvMemberOpen(object v)
        {
            throw new NotImplementedException();
        }

        public String Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }
        public String CEO
        {
            get { return _CEO; }
            set
            {
                _CEO = value;
            }
        }

        public String Address
        {
            get { return _Address; }
            set
            {
                _Address = value;
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
        public string Transaction
        {
            get { return _Transaction; }
            set
            {
                _Transaction = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Model
{
    public class Machine
    {
        private int    _No;
        private String _Name;
        private String _Division;
        private String _Supervisor;
        private String _Subordinate;
        private String _Manufact;
        private String _Buy;
        private String _IP;
        private String _Use;

        public Machine() {}

        public int No
        {
            get { return _No; }
            set
            {
                _No = value;
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
        public String Division
        {
            get { return _Division; }
            set
            {
                _Division = value;
            }
        }
        public String Supervisor
        {
            get { return _Supervisor; }
            set
            {
                _Supervisor = value;
            }
        }
        public String Subordinate
        {
            get { return _Subordinate; }
            set
            {
                _Subordinate = value;
            }
        }
        public String Manufact
        {
            get { return _Manufact; }
            set
            {
               _Manufact = value;
            }
        }
        public String Buy
        {
            get { return _Buy; }
            set
            {
                _Buy = value;
            }
        }
        public String IP
        {
            get { return _IP; }
            set
            {
                _IP = value;
            }
        }

        public String Use
        {
            get { return _Use; }
            set { _Use = value; }
        }
    }
}

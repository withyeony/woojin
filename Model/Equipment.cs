using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Equipment
    {
        private int _No;
        private String _Name;
        private String _Supervisor;
        private String _Useable;
        private String _day;
        private String _Check;
        private String _Inspector;

        public Equipment() { }

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
        public String Supervisor
        {
            get { return _Supervisor; }
            set
            {
                _Supervisor = value;
            }
        }
        public String Useable
        {
            get { return _Useable; }
            set
            {
                _Useable = value;
            }
        }
        public String day
        {
            get { return _day; }
            set
            {
                _day = value;
            }
        }
        public String Check
        {
            get { return _Check; }
            set
            {
                _Check = value;
            }
        }
        public String Inspector
        {
            get { return _Inspector; }
            set
            {
                _Inspector = value;
            }
        }
    }
}
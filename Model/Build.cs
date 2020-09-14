using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Build
    { 
        private int    _No;
        private int    _OrderNo;
        private int    _ProductNo;
        private String _Name;
        private String _Machine;
        private String _Start;
        private String _End;
        private String _State;
        private String _Worker;
        private String _Checker;

        public Build(){}

        public int No
        {
            get { return _No; }
            set
            {
                _No = value;
            }
        }
        public int OrderNo
        {
            get { return _OrderNo; }
            set
            {
                _OrderNo = value;
            }
        }
        public int ProductNo
        {
            get { return _ProductNo; }
            set
            {
                _ProductNo = value;
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
        public String Machine
        {
            get { return _Machine; }
            set
            {
                _Machine = value;
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
        public String State
        {
            get { return _State; }
            set
            {
                _State = value;
            }
        }
        public String Worker
        {
            get { return _Worker; }
            set
            {
                _Worker = value;
            }
        }
        public String Checker
        {
            get { return _Checker; }
            set
            {
                _Checker = value;
            }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Model
{
    public class Error
    { 
        private int    _No;
        private int    _OrderNo;
        private int    _ProductNo;
        private int    _MemberNo;

        private String _Date;
        private String _Checker;
        private String _Cause;
        private String _ETC;

        public Error() { }

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
        public int MemberNo
        {
            get { return _MemberNo; }
            set
            {
                _MemberNo = value;
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
        public String Checker
        {
            get { return _Checker; }
            set
            {
                _Checker = value;
            }
        }

        public String Cause
        {
            get { return _Cause; }
            set
            {
                _Cause = value;
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


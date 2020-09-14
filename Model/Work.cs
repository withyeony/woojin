using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Model
{
    public class Work
    { 
        private int    _No;
        private int    _OrderNo;
        private int    _ProductNo;
        private int    _MemberNo;

        private String _Start;
        private String _End;
        private String _Error;

        public Work() { }

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

        public String Error
        {
            get { return _Error; }
            set
            {
                _Error = value;
            }
        }


    }
}


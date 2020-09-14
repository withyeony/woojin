using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DetailProcess
    {
        private int _StaticNo;
        private int _No;
        private String _Name;
        private String _DFname;
        private String _Color1;
        private String _Color2;

        public DetailProcess() { }
        public int StaticNo
        {
            get { return _StaticNo; }
            set
            {
                _StaticNo = value;
            }
        }
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
        public String DFName
        {
            get { return _DFname; }
            set
            {
                _DFname = value;
            }
        }
        public String Color1
        {
            get { return _Color1; }
            set
            {
                _Color1 = value;
            }
        }
        public String Color2
        {
            get { return _Color2; }
            set
            {
                _Color2 = value;
            }
        }

    }
}


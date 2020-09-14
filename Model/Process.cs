using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Process
    { 
        private int    _No;
        private int    _Sort;
        private String _Name;
        private String _Color;

        public Process(){}

        public int No
        {
            get { return _No; }
            set
            {
                _No = value;
            }
        }

        public int Sort
        {
            get { return _Sort; }
            set
            {
                _Sort = value;
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
        public String Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
            }
        }
     

    }
}


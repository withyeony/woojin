using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StandardProcessModel
    {
        private int _No;
        private int _Sort;
        private String _Name;
        private String _Color1;
        private String _Color2;

        public StandardProcessModel() { }

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


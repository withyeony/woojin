using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Notice
    { 
        private int    _No;
        private String _Name;
        private String _Title;
        private String _Content;
        private String _Date;

        public Notice(){}

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
        public String Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
            }
        }
        public String Content
        {
            get { return _Content; }
            set
            {
                _Content = value;
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
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Subject
    {
        private int _No;
        private String _OrderNo;
        private String _State;
        private String _Name;
        private String _Designer;
        private String _CAM;
        private String _Assembly;
        private String _Color1;
        private String _Color2;

        public Subject() { }

        public int No
        {
            get { return _No; }
            set
            {
                _No = value;
            }
        }
        public String OrderNo
        {
            get { return _OrderNo; }
            set
            {
                _OrderNo = value;
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
        public String Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }
        public String Designer
        {
            get { return _Designer; }
            set
            {
                _Designer = value;
            }
        }
        public String CAM
        {
            get { return _CAM; }
            set
            {
                _CAM = value;
            }
        }
        public String Assembly
        {
            get { return _Assembly; }
            set
            {
                _Assembly = value;
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

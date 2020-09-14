using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Model
{
    public class Member
    {
        private int    _No;
        private String _Name;
        private String _PassWord;
        private String _Birthday;
        private String _Rank;
        private String _Part;
        private String _Phone;
        private String _Email;
        private String _Longevity;
        private AuthorityOfMember _Authority;
        private String _Id;

        public Member() { }


        public enum AuthorityOfMember
        {
            Staff = 0,
            Admin = 1
        }
        public int No
        {
            get { return _No; }
            set
            {
                _No = value;
            }
        }
        public String Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
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
        public String PassWord
        {
            get { return _PassWord; }
            set
            {
                _PassWord = value;
            }
        }
        public String Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
            }
        }
        public String Rank
        {
            get { return _Rank; }
            set
            {
                _Rank = value;
            }
        }
        public String Part
        {
            get { return _Part; }
            set
            {
                _Part = value;
            }
        }
        public String Phone
        {
            get { return _Phone; }
            set
            {
                _Phone = value;
            }
        }
        public String Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
            }
        }

        public String Longevity
        {
            get { return _Longevity; }
            set
            {
                _Longevity = value;
            }
        }
        public AuthorityOfMember Authority
        {
            get { return _Authority; }
            set { _Authority = value; }
        }
    }
}

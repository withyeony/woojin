using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
    public class CustomerController
    {
        DataBase dataBase = DataBase.Instance;

        public CustomerController()
        {
        }

        public List<Customer> GetDgvCompany()
        {
            return dataBase.GetDgvCompany();
        }

        public List<Customer> FindData(string result, string value)
        {
            return dataBase.CustomerGetSelete(result, value);
        }

        public List<CustomerMember> GetCustomerMembers(int No)
        {
            return (List<CustomerMember>)dataBase.GetCustomerMembers(No);
        }
    }
}

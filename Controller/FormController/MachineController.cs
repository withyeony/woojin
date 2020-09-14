using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using WooJinDataBase;

namespace Controller
{

    public class MachineController
    {
        DataBase dataBase = DataBase.Instance;
        public MachineController()
        {
        }

        public List<Machine> GetList()
        {
            return dataBase.GetList();
        }

        public void MachineAdd(Machine machine)
        {
            dataBase.MachineAdd(machine);
        }

        public void MachineDelete(int value)
        {
            dataBase.DeleteMachine(value);
        }
        public void UpdateMachine(Machine machine)
        {
            dataBase.UpdateMachine(machine);
        }

        public List<Machine> FindDataMachine(string result, string value)
        {
            return dataBase.GetListMachine(result, value);
        }
        public List<string> GetDefualtCode(string type)
        {
            List<string> list = null;

            list = dataBase.GetDefaultCodeList(type);
            return list;
        }
    }
}

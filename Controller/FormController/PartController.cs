using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;

namespace Controller
{
    public class PartController
    {
        DataBase dataBase = DataBase.Instance;

        public PartController()
        {
        }
        public List<ProductItem> GetDgvPart()
        {
            return dataBase.GetDgvPart();
        }

        public List<DivisionOfProduct> ProductComboboxListAdd1()
        {
            return dataBase.ProductComboboxListAdd1();
        }

        public List<GroupOfProduct> ProductComboboxListAdd2()
        {
            return dataBase.ProductComboboxListAdd2();
        }

        public void AddPartData(ProductItem _SelectData)
        {
            dataBase.AddPartData(_SelectData);
        }
        public void ModifyPartData(ProductItem _SelectData)
        {
            dataBase.ModifyPartData(_SelectData);
        }
        public void DeletePartData(ProductItem _SelectData)
        {
            dataBase.DeletePartData(_SelectData);
        }
    }
}

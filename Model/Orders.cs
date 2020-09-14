using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Model
{
    public class Orders
    { 
        private String _ProductNo;        //수주번호                ProductNo;       "금형번호";
        private String _State;            //상태                    State;           "상태";
        private String _CarType;          //차종                    CarType;         "차종";
        private String _ProductName;      //제품 명                 ProductName;     "품번";
        private String _Material;         //제질                    Material         "재질";
        private String _DueDate;          //착수일                  DueDate          "개발요청일";
        private String _DiliveryDate;     //납기일                  DiliveryDate     "납기일";
        private String _RealDate;         //납품일                  RealDate         "납품일";
        private String _FinalData;        //최종 data               FinalData        "최종 DATA";
        private String _Designer;         //설계자                  Designer        ="설계자";
        private String _CAM;              //CAM                     CAM             = "CAM";
        private String _MB_Data;          //MB_Data                 MB_Data         = "M/B 입고";
        private String _Worker;           //작업자                  Worker          = "작업자";
        private String _Customer;         //고객사                  Customer        = "고객사";
        private String _CustomerMember;   //고객사                  CustomerMember  = "개발 담당자";
        private String _ETC;              //비고                    ETC             = "비고";

        public Orders() { }

        public String ProductNo
        {
            get { return _ProductNo; }
            set
            {
                _ProductNo = value;
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
        public String CarType
        {
            get { return _CarType; }
            set
            {
                _CarType = value;
            }
        }
        public String ProductName
        {
            get { return _ProductName; }
            set
            {
                _ProductName = value;
            }
        }
        public String Material
        {
            get { return _Material; }
            set
            {
                _Material = value;
            }
        }
        public String DueDate
        {
            get { return _DueDate; }
            set
            {
                _DueDate = value;
            }
        }
        public String DiliveryDate
        {
            get { return _DiliveryDate; }
            set
            {
                _DiliveryDate = value;
            }
        }
        public String RealDate
        {
            get { return _RealDate; }
            set
            {
                _RealDate = value;
            }
        }
        public String FinalData
        {
            get { return _FinalData; }
            set
            {
                _FinalData = value;
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
        public String MB_Data
        {
            get { return _MB_Data; }
            set
            {
                _MB_Data = value;
            }
        }
        public String Worker
        {
            get { return _Worker; }
            set
            {
                _Worker = value;
            }
        }
        public String Customer
        {
            get { return _Customer; }
            set
            {
                _Customer = value;
            }
        }

        public String CustomerMember
        {
            get { return _CustomerMember; }
            set
            {
                _CustomerMember = value;
            }
        }
        public String ETC
        {
            get { return _ETC; }
            set
            {
                _ETC = value;
            }
        }
    }
}

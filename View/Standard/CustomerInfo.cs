using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CustomerInfo : Form, IBasicForm
    {
        private Member _LoginInfo;
        private BasicForm _Mother;
        private CustomerController _CustomerController;

        private Customer _SelectData;
        private CustomerMember _SelectData_m;

        public CustomerInfo(Member member, BasicForm form)
        {
            InitializeComponent();

            _LoginInfo = member;
            _Mother = form;
            _CustomerController = new CustomerController();

            _SelectData = new Customer();
            _SelectData_m = new CustomerMember();
            cb_customer_Select.SelectedIndex = 1;

            GetDgvCompany();
        }

        public Form SetForm()
        {
            return this;
        }

        private void GetDgvCompany()
        {
            dgv_company.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgv_Notice_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_company.AllowUserToResizeColumns = false;
            dgv_company.AllowUserToResizeRows = false;
            dgv_company.RowHeadersVisible = false;
            dgv_company.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_company.RowHeadersVisible = false;

            DgvCompanyOpen();
        }

        private void DgvCompanyOpen()
        {
            dgv_company.Rows.Clear();
            List<Customer> customers = new List<Customer>();
            customers = _CustomerController.GetDgvCompany();

            if (customers is null)
            {
                ;
            }
            else
            {
                foreach (Customer cus in customers)
                {
                    dgv_company.Rows.Add(cus.No, cus.Group, cus.Name, cus.CEO, cus.Adress, cus.Number, cus.Fax, cus.Transaction);
                }
            }
        }

        private void dgv_company_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count != 0 && e.RowIndex != -1)
            {
                _SelectData.No = (int)dgv_company.Rows[e.RowIndex].Cells[0].Value;
                _SelectData.Adress = dgv_company.Rows[e.RowIndex].Cells[1].Value.ToString();
                _SelectData.Group = dgv_company.Rows[e.RowIndex].Cells[2].Value.ToString();
                _SelectData.Name = dgv_company.Rows[e.RowIndex].Cells[3].Value.ToString();
                _SelectData.CEO = dgv_company.Rows[e.RowIndex].Cells[4].Value.ToString();
                _SelectData.Number = dgv_company.Rows[e.RowIndex].Cells[5].Value.ToString();
                _SelectData.Fax = dgv_company.Rows[e.RowIndex].Cells[6].Value.ToString();
                _SelectData.Transaction = dgv_company.Rows[e.RowIndex].Cells[7].Value.ToString();

                SetUpdata(_SelectData);

                txt_member_name.Text = string.Empty;
                txt_member_part.Text = string.Empty;
                txt_member_position.Text = string.Empty;
                txt_member_number.Text = string.Empty;
                txt_member_fax.Text = string.Empty;
                txt_member_email.Text = string.Empty;
                txt_member_etc.Text = string.Empty;

                int no = (int)dgv_company.Rows[e.RowIndex].Cells[0].Value;
                int SelectMemberNo = no;

                DgvMemberOpen(SelectMemberNo);
            }


            
        }

        public void DgvMemberOpen(int SelectMemberNo)
        {
            dgv_member.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgv_member.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_member.AllowUserToResizeColumns = false;
            dgv_member.AllowUserToResizeRows = false;
            dgv_member.RowHeadersVisible = false;
            dgv_member.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_member.RowHeadersVisible = false;

            dgv_member.Rows.Clear();
            List<CustomerMember> cms = new List<CustomerMember>();
            cms = _CustomerController.GetCustomerMembers(SelectMemberNo);

            if (cms is null)
            {
                ;
            }
            else
            {
                int add = 0;
                foreach (CustomerMember cm in cms)
                {
                    dgv_member.Rows.Add(cm.No, cm.Name, cm.Part, cm.Rank, cm.Number, cm.Fax, cm.Email, cm.ETC);

                    add++;

                    if (add.ToString() == "1")
                    {
                        cb_member_code.Text = cm.No.ToString();
                        txt_member_name.Text = cm.Name.ToString();
                        txt_member_part.Text = cm.Part.ToString();
                        txt_member_position.Text = cm.Rank.ToString();
                        txt_member_number.Text = cm.Number.ToString();
                        txt_member_fax.Text = cm.Fax.ToString();
                        txt_member_email.Text = cm.Email.ToString();
                        txt_member_etc.Text = cm.ETC.ToString();
                    }

                }

            }
        }

        private void SetUpdata(Customer customer)
        {
            txt_company_code.Text = customer.No.ToString();
            cb_company_class.Text = customer.Adress;
            cb_company_group.Text = customer.Group;
            txt_company_name.Text = customer.Name;
            txt_company_ceo.Text = customer.CEO;
            txt_company_number.Text = customer.Number;
            txt_company_fax.Text = customer.Fax;
            cb_company_Transaction.Text = customer.Transaction;
        }

        private void dgv_member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count != 0 && e.RowIndex != -1)
            {
                _SelectData_m.No = (int)dgv_member.Rows[e.RowIndex].Cells[0].Value;
                _SelectData_m.Name = dgv_member.Rows[e.RowIndex].Cells[1].Value.ToString();
                _SelectData_m.Part = dgv_member.Rows[e.RowIndex].Cells[2].Value.ToString();
                _SelectData_m.Rank = dgv_member.Rows[e.RowIndex].Cells[3].Value.ToString();
                _SelectData_m.Number = dgv_member.Rows[e.RowIndex].Cells[4].Value.ToString();
                _SelectData_m.Fax = dgv_member.Rows[e.RowIndex].Cells[5].Value.ToString();
                _SelectData_m.Email = dgv_member.Rows[e.RowIndex].Cells[6].Value.ToString();
                _SelectData_m.ETC = dgv_member.Rows[e.RowIndex].Cells[7].Value.ToString();

                SetUpdataMember(_SelectData_m);
            }
        }

        private void SetUpdataMember(CustomerMember customermember)
        {
            cb_member_code.Text = customermember.No.ToString();
            txt_member_name.Text = customermember.Name;
            txt_member_part.Text = customermember.Part;
            txt_member_position.Text = customermember.Rank;
            txt_member_number.Text = customermember.Number;
            txt_member_fax.Text = customermember.Fax;
            txt_member_email.Text = customermember.Email;
            txt_member_etc.Text = customermember.ETC;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String str = btn.Tag.ToString();
            _Mother.RemoveTab(str);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cb_customer_Select.SelectedIndex == -1)
            {

            }
            else
            {
                String value = cb_customer_Select.SelectedItem.ToString();

                string result = "";
                switch (value)
                {
                    case "업체 코드":
                        result = "No";
                        break;

                    case "업체 구분":
                        result = "CGroup";
                        break;

                    case "업체명":
                        result = "Content";
                        break;
                    case "대표자명":
                        result = "Title";
                        break;



                    case "전화번호":
                        result = "Content";
                        break;
                    case "FAX":
                        result = "Title";
                        break;
                }


                dgv_company.Rows.Clear();

                List<Customer> Customer = new List<Customer>();
                Customer = _CustomerController.FindData(result, txt_customer_searchbox.Text);


                if (Customer is null)
                {
                    ;
                }
                else
                {
                    foreach (Customer cus in Customer)
                    {
                        dgv_company.Rows.Add(cus.No, cus.Group, cus.Name, cus.CEO, cus.Adress, cus.Number, cus.Fax, cus.Transaction);
                    }

                    //btn_Delete_Apply.Visible = false;
                    //lbl_DataSelect.Text = "Data Select";

                    //_SelectData.No = (int)dgv_Notice_List.Rows[0].Cells[0].Value;
                    _SelectData.No = (int)dgv_company.Rows[0].Cells[0].Value;
                    _SelectData.Adress = dgv_company.Rows[0].Cells[1].Value.ToString();
                    _SelectData.Group = dgv_company.Rows[0].Cells[2].Value.ToString();
                    _SelectData.Name = dgv_company.Rows[0].Cells[3].Value.ToString();
                    _SelectData.CEO = dgv_company.Rows[0].Cells[4].Value.ToString();
                    _SelectData.Number = dgv_company.Rows[0].Cells[5].Value.ToString();
                    _SelectData.Fax = dgv_company.Rows[0].Cells[6].Value.ToString();
                    _SelectData.Transaction = dgv_company.Rows[0].Cells[7].Value.ToString();

                    SetUpdata(_SelectData);
                }
            }
        }

    }

}
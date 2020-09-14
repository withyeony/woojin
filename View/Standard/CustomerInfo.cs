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

        public int SelectMemberNo;

        public CustomerInfo(Member member, BasicForm form)
        {
            InitializeComponent();

            _LoginInfo = member;
            _Mother = form;
            _CustomerController = new CustomerController();

            _SelectData = new Customer();
            _SelectData_m = new CustomerMember();
            cb_customer_Select.SelectedIndex = 1;

            btn_member_add.Enabled = false;
            btn_member_modify.Enabled = false;
            btn_member_delete.Enabled = false;

            GetDgvCompany();
            

            _SelectData.No = (int)dgv_company.Rows[0].Cells[0].Value;
            _SelectData.CGroup = dgv_company.Rows[0].Cells[1].Value.ToString();
            _SelectData.Name = dgv_company.Rows[0].Cells[2].Value.ToString();
            _SelectData.CEO = dgv_company.Rows[0].Cells[3].Value.ToString();
            _SelectData.Address = dgv_company.Rows[0].Cells[4].Value.ToString();
            _SelectData.Number = dgv_company.Rows[0].Cells[5].Value.ToString();
            _SelectData.Fax = dgv_company.Rows[0].Cells[6].Value.ToString();
            _SelectData.Transaction = dgv_company.Rows[0].Cells[7].Value.ToString();

            SetUpdata(_SelectData);

            CompanyComboboxListAdd();
        }

        public void CompanyComboboxListAdd()
        {
            List<Customer> customers = new List<Customer>();
            customers = _CustomerController.CompanyComboboxListAdd();

            foreach (Customer cus in customers)
            {
                cb_company_group.Items.Add(cus.CGroup);
                cb_member_code.Items.Add(cus.No);
            }

            

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

                    dgv_company.Rows.Add(cus.No, cus.CGroup, cus.Name, cus.CEO, cus.Address, cus.Number, cus.Fax, cus.Transaction);
                }
            }
        }

        private void dgv_company_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_member_add.Enabled = true;
            btn_member_modify.Enabled = true;
            btn_member_delete.Enabled = true;

            //첫번째 열 클릭 안 되게 해야함
            _SelectData.No = (int)dgv_company.Rows[e.RowIndex].Cells[0].Value;
            _SelectData.CGroup = dgv_company.Rows[e.RowIndex].Cells[1].Value.ToString();
            _SelectData.Name = dgv_company.Rows[e.RowIndex].Cells[2].Value.ToString();
            _SelectData.CEO = dgv_company.Rows[e.RowIndex].Cells[3].Value.ToString();
            _SelectData.Address = dgv_company.Rows[e.RowIndex].Cells[4].Value.ToString();
            _SelectData.Number = dgv_company.Rows[e.RowIndex].Cells[5].Value.ToString();
            _SelectData.Fax = dgv_company.Rows[e.RowIndex].Cells[6].Value.ToString();
            _SelectData.Transaction = dgv_company.Rows[e.RowIndex].Cells[7].Value.ToString();

            SetUpdata(_SelectData);
            SelectDataEmptyMember();

            SelectMemberNo = _SelectData.No;

            DgvMemberOpen(SelectMemberNo);
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
                    dgv_member.Rows.Add(cm.No, cm.Name, cm.Part, cm.Rank, cm.Number, cm.Fax, cm.Email, cm.ETC, cm.StaticNo);

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
            txt_company_address.Text = customer.Address;
            cb_company_group.Text = customer.CGroup;
            txt_company_name.Text = customer.Name;
            txt_company_ceo.Text = customer.CEO;
            txt_company_number.Text = customer.Number;
            txt_company_fax.Text = customer.Fax;
            cb_company_Transaction.Text = customer.Transaction;

            
        }

        private void dgv_member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _SelectData_m.No = (int)dgv_member.Rows[e.RowIndex].Cells[0].Value;
            _SelectData_m.Name = dgv_member.Rows[e.RowIndex].Cells[1].Value.ToString();
            _SelectData_m.Part = dgv_member.Rows[e.RowIndex].Cells[2].Value.ToString();
            _SelectData_m.Rank = dgv_member.Rows[e.RowIndex].Cells[3].Value.ToString();
            _SelectData_m.Number = dgv_member.Rows[e.RowIndex].Cells[4].Value.ToString();
            _SelectData_m.Fax = dgv_member.Rows[e.RowIndex].Cells[5].Value.ToString();
            _SelectData_m.Email = dgv_member.Rows[e.RowIndex].Cells[6].Value.ToString();
            _SelectData_m.ETC = dgv_member.Rows[e.RowIndex].Cells[7].Value.ToString();
            _SelectData_m.StaticNo = (int)dgv_member.Rows[e.RowIndex].Cells[8].Value;

            SetUpdataMember(_SelectData_m);
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

        private void SetAlarm(String str)
        {
            Alarm alarm = new Alarm(str);
            alarm.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String value = cb_customer_Select.SelectedItem.ToString();

            string result = "";
            switch (value)
            {
                case "업체 코드":
                    result = "No";
                    break;

                case "그룹 업체":
                    result = "CGroup";
                    break;

                case "업체명":
                    result = "Name";
                    break;

                case "대표자명":
                    result = "CEO";
                    break;

                case "주소":
                    result = "Address";
                    break;

                case "전화번호":
                    result = "Number";
                    break;

                case "FAX":
                    result = "Fax";
                    break;
            }

            List<Customer> Customer = new List<Customer>();
            Customer = _CustomerController.FindData(result, txt_customer_searchbox.Text);

            if (Customer is null || string.IsNullOrEmpty(txt_customer_searchbox.Text))
            {
                SetAlarm("검색어를 입력해주세요.");
            }
            else
            {
                if (Customer.Count != 0)
                {
                    foreach (Customer cus in Customer)
                    {
                        dgv_company.Rows.Clear();
                        dgv_company.Rows.Add(cus.No, cus.CGroup, cus.Name, cus.CEO, cus.Address, cus.Number, cus.Fax, cus.Transaction);

                        _SelectData.No = (int)dgv_company.Rows[0].Cells[0].Value;
                        _SelectData.CGroup = dgv_company.Rows[0].Cells[1].Value.ToString();
                        _SelectData.Name = dgv_company.Rows[0].Cells[2].Value.ToString();
                        _SelectData.CEO = dgv_company.Rows[0].Cells[3].Value.ToString();
                        _SelectData.Address = dgv_company.Rows[0].Cells[4].Value.ToString();
                        _SelectData.Number = dgv_company.Rows[0].Cells[5].Value.ToString();
                        _SelectData.Fax = dgv_company.Rows[0].Cells[6].Value.ToString();
                        _SelectData.Transaction = dgv_company.Rows[0].Cells[7].Value.ToString();

                        SetUpdata(_SelectData);
                    }
                }
                else
                {
                    SetAlarm("검색 된 내용이 없습니다.");
                    txt_customer_searchbox.Text = string.Empty;
                }
            }
        }

        private void btn_dgvRefresh_Click(object sender, EventArgs e)
        {
            btn_member_add.Enabled = false;
            btn_member_modify.Enabled = false;
            btn_member_delete.Enabled = false;
            txt_customer_searchbox.Text = string.Empty;

            GetDgvCompany();

            _SelectData.No = (int)dgv_company.Rows[0].Cells[0].Value;
            _SelectData.CGroup = dgv_company.Rows[0].Cells[1].Value.ToString();
            _SelectData.Name = dgv_company.Rows[0].Cells[2].Value.ToString();
            _SelectData.CEO = dgv_company.Rows[0].Cells[3].Value.ToString();
            _SelectData.Address = dgv_company.Rows[0].Cells[4].Value.ToString();
            _SelectData.Number = dgv_company.Rows[0].Cells[5].Value.ToString();
            _SelectData.Fax = dgv_company.Rows[0].Cells[6].Value.ToString();
            _SelectData.Transaction = dgv_company.Rows[0].Cells[7].Value.ToString();

            SetUpdata(_SelectData);

            SelectDataEmptyMember();

            dgv_member.Rows.Clear();
        }

        private void btn_company_add_Click(object sender, EventArgs e)
        {
            SelectDataHold(_SelectData);

            _CustomerController.AddCustomerData(_SelectData);

            SelectDataEmpty();
            GetDgvCompany();
        }

        private void btn_company_modify_Click(object sender, EventArgs e)
        {
            txt_company_code.Enabled = false;

            SelectDataHold(_SelectData);

            _CustomerController.ModifyCustomerData(_SelectData);
            GetDgvCompany();
        }

        private void btn_company_delete_Click(object sender, EventArgs e)
        {
            txt_company_code.Enabled = false;

            SelectDataHold(_SelectData);

            _CustomerController.DeleteCustomerData(_SelectData);
            GetDgvCompany();
        }

        public void SelectDataHold(Customer selectData)
        {
            _SelectData.No = Int32.Parse(txt_company_code.Text);
            _SelectData.CGroup = cb_company_group.Text;
            _SelectData.Address = txt_company_address.Text;
            
            _SelectData.Name = txt_company_name.Text;
            _SelectData.CEO = txt_company_ceo.Text;
            _SelectData.Number = txt_company_number.Text;
            _SelectData.Fax = txt_company_fax.Text;
            _SelectData.Transaction = cb_company_Transaction.Text;
        }

        private void SelectDataEmpty()
        {
            txt_company_code.Text = string.Empty;
            txt_company_address.Text = string.Empty;
            cb_company_group.Text = string.Empty;
            txt_company_name.Text = string.Empty;
            txt_company_ceo.Text = string.Empty;
            txt_company_number.Text = string.Empty;
            txt_company_fax.Text = string.Empty;
            cb_company_Transaction.Text = string.Empty;
        }

        private void btn_textbox_reset_Click(object sender, EventArgs e)
        {
            SelectDataEmpty();
        }

        private void btn_textbox_reset_m_Click(object sender, EventArgs e)
        {
            SelectDataEmptyMember();
        }

        private void SelectDataEmptyMember()
        {
            txt_member_name.Text = string.Empty;
            txt_member_part.Text = string.Empty;
            txt_member_position.Text = string.Empty;
            txt_member_number.Text = string.Empty;
            txt_member_fax.Text = string.Empty;
            txt_member_email.Text = string.Empty;
            txt_member_etc.Text = string.Empty;
        }

        private void btn_member_add_Click(object sender, EventArgs e)
        {
            SelectMemberDataHold(_SelectData_m);

            _CustomerController.AddCustomerMemberData(_SelectData_m);
            DgvMemberOpen(SelectMemberNo);
        }

        private void btn_member_modify_Click(object sender, EventArgs e)
        {
            SelectMemberDataHold(_SelectData_m);

            _CustomerController.ModifyCustomerMemberData(_SelectData_m);
            DgvMemberOpen(SelectMemberNo);
        }

        private void btn_member_delete_Click(object sender, EventArgs e)
        {
            SelectMemberDataHold(_SelectData_m);

            _CustomerController.DeleteCustomerMemberData(_SelectData_m);
            DgvMemberOpen(_SelectData.No);
        }

        public void SelectMemberDataHold(CustomerMember selectData)
        {
            _SelectData_m.No = Int32.Parse(cb_member_code.Text);
            _SelectData_m.Name = txt_member_name.Text;
            _SelectData_m.Part = txt_member_part.Text;
            _SelectData_m.Rank = txt_member_position.Text;
            _SelectData_m.Number = txt_member_number.Text;
            _SelectData_m.Fax = txt_member_fax.Text;
            _SelectData_m.Email = txt_member_email.Text;
            _SelectData_m.ETC = txt_member_etc.Text;

        }
    }

}
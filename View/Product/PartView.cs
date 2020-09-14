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
	public partial class PartView : Form, IBasicForm
	{
		private Member _LoginInfo;
		private BasicForm _Mother;
		private PartController _PartController;

		private ProductItem _SelectData;
		public PartView(Member member, BasicForm form)
		{
			InitializeComponent();
			_LoginInfo = member;
			_Mother = form;
			_PartController = new PartController();
			_SelectData = new ProductItem();

			GetDgvPart();
			
			_SelectData.No = (int)dgv_Part.Rows[0].Cells[0].Value;
			_SelectData.Division = dgv_Part.Rows[0].Cells[1].Value.ToString();
			_SelectData.Code = dgv_Part.Rows[0].Cells[2].Value.ToString();
			_SelectData.Name = dgv_Part.Rows[0].Cells[3].Value.ToString();
			_SelectData.EName = dgv_Part.Rows[0].Cells[4].Value.ToString();
			SetUpdata(_SelectData);

			ProductComboboxListAdd();
		}

		public Form SetForm()
		{
			return this;
		}

		private void GetDgvPart()
		{
			dgv_Part.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_Part.AllowUserToResizeColumns = false;
			dgv_Part.AllowUserToResizeRows = false;
			dgv_Part.RowHeadersVisible = false;
			dgv_Part.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgv_Part.RowHeadersVisible = false;

			DgvPartOpen();
		}

		public void ProductComboboxListAdd()
		{
			List<DivisionOfProduct> DvsProducts = new List<DivisionOfProduct>();
			DvsProducts = _PartController.ProductComboboxListAdd1();

			foreach (DivisionOfProduct dvs in DvsProducts)
			{
				cb_division.Items.Add(dvs.Type);
			}

			List<GroupOfProduct> GrpProducts = new List<GroupOfProduct>();
			GrpProducts = _PartController.ProductComboboxListAdd2();

			foreach (GroupOfProduct grp in GrpProducts)
			{
				cb_code.Items.Add(grp.Type);
			}
		}

		private void DgvPartOpen()
		{
			dgv_Part.Rows.Clear();
			List<ProductItem> productItems = new List<ProductItem>();
			productItems = _PartController.GetDgvPart();

			if (productItems is null)
			{
				;
			}
			else
			{
				foreach (ProductItem pro in productItems)
				{
					dgv_Part.Rows.Add(pro.No, pro.Division, pro.Code, pro.Name, pro.EName);
					_SelectData.No = (int)dgv_Part.Rows[0].Cells[0].Value;
					_SelectData.Division = dgv_Part.Rows[0].Cells[1].Value.ToString();
					_SelectData.Code = dgv_Part.Rows[0].Cells[2].Value.ToString();
					_SelectData.Name = dgv_Part.Rows[0].Cells[3].Value.ToString();
					_SelectData.EName = dgv_Part.Rows[0].Cells[4].Value.ToString();
					SetUpdata(_SelectData);
				}
			}
		}

		private void dgv_Part_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_SelectData.No = (int)dgv_Part.Rows[e.RowIndex].Cells[0].Value;
			_SelectData.Division = dgv_Part.Rows[e.RowIndex].Cells[1].Value.ToString();
			_SelectData.Code = dgv_Part.Rows[e.RowIndex].Cells[2].Value.ToString();
			_SelectData.Name = dgv_Part.Rows[e.RowIndex].Cells[3].Value.ToString();
			_SelectData.EName = dgv_Part.Rows[e.RowIndex].Cells[4].Value.ToString();

			SetUpdata(_SelectData);
		}
		private void btn_close_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			String str = btn.Tag.ToString();
			_Mother.RemoveTab(str);
		}
		private void btn_partadd_Click(object sender, EventArgs e)
        {
			SelectDataKeep(_SelectData);

			_PartController.AddPartData(_SelectData);

			SelectDataEmpty();
			DgvPartOpen();
		}

        private void btn_partmodify_Click(object sender, EventArgs e)
        {
			SelectDataKeep(_SelectData);

			_PartController.ModifyPartData(_SelectData);

			SelectDataEmpty();
			DgvPartOpen();
		}

        private void btn_partdelete_Click(object sender, EventArgs e)
        {
			SelectDataKeep(_SelectData);

			_PartController.DeletePartData(_SelectData);

			SelectDataEmpty();
			DgvPartOpen();
		}

		private void btn_dgvRefresh_Click(object sender, EventArgs e)
		{ 
			DgvPartOpen();

			SetUpdata(_SelectData);
		}

		private void SelectDataKeep(ProductItem selectData)
		{
            _SelectData.Division = cb_division.Text;
            _SelectData.Code = cb_code.Text;
			_SelectData.Name = txt_name.Text;
			_SelectData.EName = txt_ename.Text;
		}

		private void SetUpdata(ProductItem productItem)
		{
			cb_code.Text = productItem.Code;
			cb_division.Text = productItem.Division;
			txt_name.Text = productItem.Name;
			txt_ename.Text = productItem.EName;
		}
		private void SelectDataEmpty()
		{
            cb_code.Text = string.Empty;
            cb_division.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_ename.Text = string.Empty;
        }
    }
}

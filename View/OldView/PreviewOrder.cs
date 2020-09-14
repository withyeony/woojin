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
	public partial class PreviewOrder : Form
	{
		public PreviewOrder(Orders order)
		{
			InitializeComponent();
			SetValue(order);
		}
		private void SetValue(Orders order)
		{
			PreviewOrder_CM.Text =			order.CustomerMember;
			PreviewOrder_Customer.Text =		order.Customer;
			PreviewOrder_Designer.Text =		order.Designer;
			PreviewOrder_DilivertDate.Text = order.DueDate;
			PreviewOrder_DueDate.Text =		order.DiliveryDate;
			PreviewOrder_ETC.Text =			order.ETC;
			PreviewOrder_Material.Text =		order.Material;
			PreviewOrder_ProductNo.Text =	order.ProductNo;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

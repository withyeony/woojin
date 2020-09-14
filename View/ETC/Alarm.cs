using Controller;
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
	public partial class Alarm : Form 
	{
		public Alarm(String contnent)
		{
			InitializeComponent();
			Content = contnent;
		}
		public string Content
		{
			get { return this.lbl_Content_1.Text; }
			set { this.lbl_Content_1.Text = value; }
		}



		private void Btn_Confirm_1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

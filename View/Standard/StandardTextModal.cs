using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
	public partial class StandardTextModal : Form
	{
		private UCStandardProcess _UCStandardProcess;
		private StandardProcessModel _SPM;

		public StandardTextModal(UCStandardProcess uCStandardProcess, StandardProcessModel spm)
		{
			InitializeComponent();
			_UCStandardProcess = uCStandardProcess;
			SPM = spm;
		}

		StandardProcessModel SPM
		{
			get 
			{ 
				return _SPM; 
			}
			set
			{
				_SPM = value;
				SetTextBox(SPM.Name);
			}
		}
		private void SetTextBox(String str)
		{
			lbl_Value.Text = str;
		}
		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Change_Click(object sender, EventArgs e)
		{
			SPM.Name = tb_Value.Text;
			_UCStandardProcess.GetData(SPM);
			this.Close();
		}
	}
}

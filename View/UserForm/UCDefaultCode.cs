using System;
using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
	public partial class UCDefaultCode : UserControl
	{
		private String _Name;
		private String _TypeName;
		private List<DefaultType> _TypeList;
		private DefaultType _SelectValue;

		private DefaultCode _From;
		[Description("MakeEvent"), Category("MakeEvent")]
		public event EventHandler GetData;
		public UCDefaultCode()
		{
			InitializeComponent();

			_Name = "";
			TypeList = new List<DefaultType>();
			SelectValue = new DefaultType();
		}
		public DefaultType SelectValue
		{
			get
			{
				return _SelectValue;
			}
			set
			{
				_SelectValue = value;
			}
		}
		public List<DefaultType> TypeList
		{
			get
			{
				return _TypeList;
			}
			set
			{
				_TypeList = value;
			}
		}

		public string SetName
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
				ApplyName(_Name);
			}
		}
		public DefaultCode SetForm
		{
			get
			{
				return _From;
			}
			set
			{
				_From = value;
			}
		}
		public String SetTypeName
		{
			get
			{
				return _TypeName;
			}
			set
			{
				_TypeName = value;
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[System.ComponentModel.Localizable(false)]
		[System.Xml.Serialization.XmlArray]
		[DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public List<DefaultType> SetList
		{
			get
			{
				return TypeList;
			}
			set
			{
				TypeList = value;
				ApplyList(TypeList);
			}
		}
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[System.ComponentModel.Localizable(false)]
		[System.Xml.Serialization.XmlArray]
		[DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public List<DefaultType> UpdateList
		{
			set
			{
				TypeList = value;
				ClearList();
				ApplyList(TypeList);
			}
		}
		private void ApplyName(String Str)
		{
			lbl_Name.Text = Str;
		}
		private void ClearList()
		{

			for (int i = 0; i < this.tableLayoutPanel1.Controls.Count; i++)
			{
				tableLayoutPanel1.Controls[i].Text = "";
				tableLayoutPanel1.Controls[i].BackColor = System.Drawing.SystemColors.Control;
			}
		}
		private void ApplyList(List<DefaultType> list)
		{
			if(list is null)
			{

			}
			else
			{
				foreach (DefaultType dt in list)
				{
					for (int i = 0; i < this.tableLayoutPanel1.Controls.Count; i++)
					{
						if (tableLayoutPanel1.Controls[i].Tag.ToString() == dt.Sort.ToString())
						{
							tableLayoutPanel1.Controls[i].Text = dt.Value;
						}
					}
				}
			}
			
		}
		public void OnClick(object sender, EventArgs args)
		{
			if (GetData != null)
			{
				Invoke(GetData, null);
			}
		}
		private void btn_Click_Click_1(object sender, EventArgs e)
		{
			OnClick(sender, e);
			_From.SetSelectDivision(_Name, _TypeName);
		}

		private void lbl_Unit11_Click(object sender, EventArgs e)
		{
			Label lbl = (Label)sender;
			if (lbl.BackColor == System.Drawing.Color.GreenYellow)
			{
				_From.ResetValue();
				lbl.BackColor = System.Drawing.SystemColors.Control;
			}
			else
			{
				foreach (DefaultType dt in TypeList)
				{
					if (lbl.Text.Equals(dt.Value))
					{
						_SelectValue = dt;
						_From.SetValue(dt, SetName);
						lbl_ColorChange(dt);
						break;
					}
				}
			}
		}
		private void lbl_ColorChange(DefaultType dt)
		{
			for (int i = 0; i < this.tableLayoutPanel1.Controls.Count; i++)
			{
				if (tableLayoutPanel1.Controls[i].Text == dt.Value)
				{
					tableLayoutPanel1.Controls[i].BackColor = System.Drawing.Color.GreenYellow;
				}
				else
				{
					tableLayoutPanel1.Controls[i].BackColor = System.Drawing.SystemColors.Control;
				}
			}
		}

	}
}

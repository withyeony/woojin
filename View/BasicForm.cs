using System;
using Model;
using Controller;
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
	public partial class BasicForm : Form
	{
		private Member _LoginInfo;
		public BasicForm()
		{
			InitializeComponent();
		}
		public Member LoginInfo  //로그인 정보
		{
			get { return _LoginInfo; }
			set { _LoginInfo = value; }
		}
		private void BasicForm_Load(object sender, EventArgs e)
		{
			this.Hide();

			LoginForm loginForm = new LoginForm();

			if (loginForm.ShowDialog(this) != DialogResult.OK)
			{
				Application.Exit();
			}
			else
			{
				this.Show();
			}
		}
		private void Manu_Click(object sender, EventArgs e)
		{
			String str = sender.ToString();  //해당 문자열 나옴

			Boolean check = false;
			TabPage selectTab = new TabPage();
			foreach (TabPage tab in tabControl1.TabPages)
			{
				if (tab.Text == str)
				{
					check = true;
					selectTab = tab;
				}
			}
			if (check) this.tabControl1.SelectedTab = selectTab;
			else MakeTag(str);
		}
		private void MakeTag(String str)
		{
			string title = str;
			TabPage myTabPage = new TabPage(title);
			tabControl1.TabPages.Add(myTabPage);

			IBasicForm it = SetForm(str);

			it.TopLevel = false;
			myTabPage.Controls.Add(it.SetForm());
			it.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			it.Show();

			this.tabControl1.SelectedTab = myTabPage;
		}
		public void RemoveTab(String str)
		{
			foreach (TabPage tab in tabControl1.TabPages)
			{
				if (tab.Text == str)
				{
					tabControl1.TabPages.Remove(tab);
					break;
				}
			}

		}
		private IBasicForm SetForm(String tag)
		{
			IBasicForm ift = null;

			switch (tag)
			{

				case "표준 코드":
					ift = new DefaultCode(_LoginInfo, this);
					break;
				case "표준 공정":
					ift = new StandardProcess(_LoginInfo, this);
					break;
				case "사원 정보":
					ift = new MemberView(_LoginInfo, this);
					break;
				case "수주/출하 정보":
					ift = new OrderView(_LoginInfo, this);
					break;
				case "품목 정보":
					ift = new SubjectView(_LoginInfo, this);
					break;
				case "부품 정보":
					ift = new PartView(_LoginInfo, this);
					break;
				case "공지사항":
					ift = new NoticeBoard(_LoginInfo, this);
					break;
				case "거래처 정보":
					ift = new CustomerInfo(_LoginInfo, this);
					break;
				case "표준 설비":
					ift = new MachineView(_LoginInfo, this);
					break; 
			}

			return ift;
		}
	}
}

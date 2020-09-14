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
	public partial class NoticeBoard : Form, IBasicForm
	{
		private Member _LoginInfo;
		private BasicForm _Mother;
		private NoticeController _NoticeController;

		private Notice _SelectData; //빈공간

		public NoticeBoard(Member member, BasicForm form)
		{
			InitializeComponent();
			_LoginInfo = member;
			_Mother = form;
			_NoticeController = new NoticeController();
			_SelectData = new Notice();  //빈공간 생성
			this.dgv_Notice_List.Font = new Font("Tahoma", 10, FontStyle.Regular);

			//cb_Notice_Select.Text = "--Select--";
			cb_Notice_Select.SelectedIndex = 1;
			GetNotice();

			//_SelectData.Title = dgv_Notice_List.Rows[0].Cells[2].Value.ToString();
			//_SelectData.Content = dgv_Notice_List.Rows[0].Cells[4].Value.ToString();

			SetUpdata(_SelectData);

		}

		public Form SetForm()
		{
			return this;
		}

		private void GetNotice()
		{
			dgv_Notice_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			//dgv_Notice_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgv_Notice_List.AllowUserToResizeColumns = false;
			dgv_Notice_List.AllowUserToResizeRows = false;
			dgv_Notice_List.RowHeadersVisible = false;

			GridOpen();
		}

		private void dgv_Notice_List_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.SelectedRows.Count != 0 && e.RowIndex != -1)
			{
				_SelectData.No = (int)dgv_Notice_List.Rows[e.RowIndex].Cells[0].Value;
				_SelectData.Title = dgv_Notice_List.Rows[e.RowIndex].Cells[1].Value.ToString();
				_SelectData.Content = dgv_Notice_List.Rows[e.RowIndex].Cells[4].Value.ToString();

				SetUpdata(_SelectData);
			}
		}

		private void SetUpdata(Notice notice)
		{
			read_write.Text = "Admin";
			read_title.Text = notice.Title;
			read_content.Text = notice.Content;

			modify_content.Text = notice.Content;
			modify_title.Text = "Admin";
		}

		private void btn_modify_Click(object sender, EventArgs e)
		{
			pnl_modify.Visible = true;
			btn_modify.Visible = false;
			btn_delete.Visible = false;
			SetUpdata(_SelectData);

		}
		private void SetAlarm(String str)
		{
			Alarm alarm = new Alarm(str);
			alarm.ShowDialog();
		}
		private void GridOpen()
		{
			dgv_Notice_List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			dgv_Notice_List.Rows.Clear();
			List<Notice> Notices = new List<Notice>();
			Notices = _NoticeController.GetNotice();

			if (Notices is null)
			{
				;
			}
			else
			{
				foreach (Notice mem in Notices)
				{
					dgv_Notice_List.Rows.Add(mem.No, mem.Title, mem.Name, mem.Date, mem.Content);
				}
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("글을 삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				_NoticeController.DeleteNoticeData(_SelectData);

				MessageBox.Show("삭제 되었습니다.");

				GridOpen();

				_SelectData.Title = dgv_Notice_List.Rows[0].Cells[2].Value.ToString();
				_SelectData.Content = dgv_Notice_List.Rows[0].Cells[4].Value.ToString();

				SetUpdata(_SelectData);
			}
			else
			{
				;
			}
		}

		private void btn_write_Click(object sender, EventArgs e)
		{
			pnl_write.Visible = true;
		}

		private void btn_write_check_Click(object sender, EventArgs e)
		{
			_SelectData.Title = txt_write_title.Text;
			_SelectData.Content = txt_write_content.Text;

			_NoticeController.AddNoticeData(_SelectData);

			txt_write_title.Text = string.Empty;
			txt_write_content.Text = string.Empty;

			pnl_write.Visible = false;
			GridOpen();
		}

		private void btn_write_cancel_Click(object sender, EventArgs e)
		{
			pnl_write.Visible = false;
			txt_write_title.Text = string.Empty;
			txt_write_content.Text = string.Empty;
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			String str = btn.Tag.ToString();
			_Mother.RemoveTab(str);
		}

		private void btn_modify_check_Click(object sender, EventArgs e)
		{
			_SelectData.Title = modify_title.Text;
			_SelectData.Content = modify_content.Text;

			_NoticeController.UpdateNoticeData(_SelectData);

			GridOpen();
			pnl_modify.Visible = false;

			_SelectData.Title = dgv_Notice_List.Rows[0].Cells[2].Value.ToString();
			_SelectData.Content = dgv_Notice_List.Rows[0].Cells[4].Value.ToString();

			SetUpdata(_SelectData);

			btn_modify.Visible = true;
			btn_delete.Visible = true;
			SetAlarm("글이 수정되었습니다.");
		}

		private void btn_modify_cancel_Click(object sender, EventArgs e)
		{
			pnl_modify.Visible = false;
			btn_modify.Visible = true;
			btn_delete.Visible = true;
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			if (cb_Notice_Select.SelectedIndex == -1)
			{

			}
			else
			{
				String value = cb_Notice_Select.SelectedItem.ToString();

				string result = "";
				switch (value)
				{

					case "제목":
						result = "Title";
						break;

					case "글내용":
						result = "Content";

						break;
				}


				dgv_Notice_List.Rows.Clear();

				List<Notice> Notices = new List<Notice>();
				Notices = _NoticeController.FindData(result, txt_searchbox.Text);


				if (Notices is null)
				{
					;
				}
				else
				{
					foreach (Notice noti in Notices)
					{
						dgv_Notice_List.Rows.Add(noti.No, noti.Title, noti.Name, noti.Date, noti.Content);
					}

					//btn_Delete_Apply.Visible = false;
					//lbl_DataSelect.Text = "Data Select";

					//_SelectData.No = (int)dgv_Notice_List.Rows[0].Cells[0].Value;
					_SelectData.Content = dgv_Notice_List.Rows[0].Cells[4].Value.ToString();

					SetUpdata(_SelectData);
				}
			}
		}
	}
}

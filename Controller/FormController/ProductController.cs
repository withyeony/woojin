using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooJinDataBase;
using Model;
using System.Xml.Serialization;

namespace Controller
{
	//수주, 출하, 제품, 생산
	public class ProductController
	{
		private IProductForm _form;
		DataBase dataBase = DataBase.Instance;
		public ProductController(IProductForm form) { _form = form; }

		public List<Orders> GetOrders()
		{
			List<Orders> list = null;

			list = dataBase.GetOrders();
			return list;
		}

		public List<string> getCustomList()
		{
			List<string> list = null;

			list = dataBase.getOriginalList();
			return list;
		}

		public List<string> getMemberPartList(string Part)
		{
			List<string> list = null;

			list = dataBase.getMemberPartList(Part);
			return list;
		}

		public List<string> getSelectMemberOfCustom(string Custom)
		{
			List<string> list = null;

			list = dataBase.getSelectMemberOfCustom(Custom);
			return list;
		}

		public void AddOrder(Orders order)
		{
			dataBase.AddOrder(order);


			_form.SetAlarm("수주정보 추가가 완료되었습니다.");
			_form.OrderSetInitilze();
		}

		public void UpdateOrder(Orders order)
		{
			dataBase.UpdateOrder(order);

			_form.SetAlarm("수주정보 수정이 완료되었습니다.");
			_form.OrderSetInitilze();
		}

		public void DeleteOrder(string no)
		{
			dataBase.DeleteOrder(no);

			_form.SetAlarm("수주정보 삭제 완료되었습니다.");
		}
		public void FileCopy(String path)
		{
			string fileName = path;
			string sourcePath = @"C:\Users\Public\TestFolder";
			string targetPath = @"C:\Users\Public\TestFolder\SubDir";

			string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
			string destFile = System.IO.Path.Combine(targetPath, fileName);

			System.IO.Directory.CreateDirectory(targetPath);

			System.IO.File.Copy(sourceFile, destFile, true);

			if (System.IO.Directory.Exists(sourcePath))
			{
				string[] files = System.IO.Directory.GetFiles(sourcePath);

				foreach (string s in files)
				{
					fileName = System.IO.Path.GetFileName(s);
					destFile = System.IO.Path.Combine(targetPath, fileName);
					System.IO.File.Copy(s, destFile, true);
				}
			}
			else
			{
				Console.WriteLine("Source path does not exist!");
			}

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		public List<Products> GetProducts()
		{
			List<Products> list = null;

			list = dataBase.GetProducts();
			return list;
		}
	}
}

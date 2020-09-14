using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
using Model;
using System.Collections;

namespace WooJinDataBase
{
	public sealed class DataBase
	{
		private string ServerAddress = "server=localhost;user=root;database=woojin;password=root; " +
										"port=3308;" +
										"CharSet = utf8;";

		public List<Machine> GetListMachine(string result, string value)
		{
			List<Machine> machines = new List<Machine>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM machine";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM machine where " + result + " LIKE " + "'%" + value + "%'";

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Machine machine = new Machine
							{
								No = (int)rdr[0],
								Division = rdr[1].ToString(),
								Name = rdr[2].ToString(),
								Supervisor = rdr[3].ToString(),
								Subordinate = rdr[4].ToString(),
								Manufact = rdr[5].ToString(),
								Buy = rdr[6].ToString(),
								IP = rdr[7].ToString(),
								Use = rdr[8].ToString()
							};

							machines.Add(machine);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return machines;
		}

		public List<Subject> GetSubJectList(string OrderNo)
		{
			List<Subject> list = new List<Subject>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Subject where OrderNo = @OrderNo";

				cmd.Parameters.Add("@OrderNo", MySqlDbType.VarChar, 50, "OrderNo");
				cmd.Parameters["@OrderNo"].Value = OrderNo;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Subject where OrderNo = @OrderNo";
						cmd.Parameters["@OrderNo"].Value = OrderNo;

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Subject subject = new Subject
							{
								No = (int)rdr[0],
								OrderNo = rdr[1].ToString(),
								State = rdr[2].ToString(),
								Name = rdr[3].ToString(),
								Designer = rdr[4].ToString(),
								CAM = rdr[5].ToString(),
								Assembly = rdr[6].ToString(),
								Color1 = rdr[7].ToString(),
								Color2 = rdr[8].ToString()
							};

							list.Add(subject);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public void MachineAdd(Machine machine)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO machine (Name, Supervisor, Subordinate, Manufact, Buy, IP, Useable) "
					+ "VALUES(@Name, @Division, @Supervisor, @Subordinate, @Manufact, @Buy, @IP, @Useable)";

				cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 50, "Name");
				cmd.Parameters.Add("@Division", MySqlDbType.VarChar, 50, "Division");
				cmd.Parameters.Add("@Supervisor", MySqlDbType.VarChar, 50, "Supervisor");
				cmd.Parameters.Add("@Subordinate", MySqlDbType.VarChar, 50, "Subordinate");
				cmd.Parameters.Add("@Manufact", MySqlDbType.VarChar, 50, "Manufact");
				cmd.Parameters.Add("@Buy", MySqlDbType.VarChar, 50, "Buy");
				cmd.Parameters.Add("@IP", MySqlDbType.VarChar, 50, "IP");
				cmd.Parameters.Add("@Useable", MySqlDbType.VarChar, 50, "Useable");

				cmd.Parameters["@no"].Value = machine.No;
				cmd.Parameters["@name"].Value = machine.Name;
				cmd.Parameters["@Division"].Value = machine.Division;
				cmd.Parameters["@supervisor"].Value = machine.Supervisor;
				cmd.Parameters["@subordinate"].Value = machine.Subordinate;
				cmd.Parameters["@manufact"].Value = machine.Manufact;
				cmd.Parameters["@buy"].Value = machine.Buy;
				cmd.Parameters["@ip"].Value = machine.IP;
				cmd.Parameters["@useable"].Value = machine.Use;


				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using
		}
		public List<Machine> GetList()
		{
			List<Machine> machines = new List<Machine>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM machine";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Machine machine = new Machine
							{
								No = (int)rdr[0],
								Division = rdr[1].ToString(),
								Name = rdr[2].ToString(),
								Supervisor = rdr[3].ToString(),
								Subordinate = rdr[4].ToString(),
								Manufact = rdr[5].ToString(),
								Buy = rdr[6].ToString(),
								IP = rdr[7].ToString(),
								Use = rdr[8].ToString()
							};

							machines.Add(machine);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return machines;
		}

		public void UpdateMachine(Machine machine)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE machine SET"
					+ " name = @name, Division = @Division, supervisor = @supervisor, subordinate = @subordinate, manufact = @manufact, buy = @buy , ip = @ip, useable = @useable"
					+ " WHERE NO = @no";

				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@Division", MySqlDbType.VarChar, 50, "Division");
				cmd.Parameters.Add("@supervisor", MySqlDbType.VarChar, 50, "supervisor");
				cmd.Parameters.Add("@subordinate", MySqlDbType.VarChar, 50, "subordinate");
				cmd.Parameters.Add("@manufact", MySqlDbType.VarChar, 50, "manufact");
				cmd.Parameters.Add("@buy", MySqlDbType.VarChar, 50, "buy");
				cmd.Parameters.Add("@ip", MySqlDbType.VarChar, 50, "ip");
				cmd.Parameters.Add("@useable", MySqlDbType.VarChar, 50, "useable");


				cmd.Parameters["@no"].Value = machine.No;
				cmd.Parameters["@name"].Value = machine.Name;
				cmd.Parameters["@Division"].Value = machine.Division;
				cmd.Parameters["@supervisor"].Value = machine.Supervisor;
				cmd.Parameters["@subordinate"].Value = machine.Subordinate;
				cmd.Parameters["@manufact"].Value = machine.Manufact;
				cmd.Parameters["@buy"].Value = machine.Buy;
				cmd.Parameters["@ip"].Value = machine.IP;
				cmd.Parameters["@useable"].Value = machine.Use;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}
		}
		public List<Customer> GetDgvCompany()
		{
			List<Customer> members = new List<Customer>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM Customer";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Customer customer = new Customer();
							customer.No = (int)rdr[0];
							customer.CEO = rdr[1].ToString();
							customer.Group = rdr[2].ToString();
							customer.Name = rdr[3].ToString();
							customer.Adress = rdr[4].ToString();
							customer.Number = rdr[5].ToString();
							customer.Fax = rdr[6].ToString();
							customer.Transaction = rdr[7].ToString();

							members.Add(customer);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return members;
		}

		public List<Member> GetMemberList()
		{
			List<Member> members = new List<Member>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Member";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Member";

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Member member = new Member();

							member.No = (int)rdr[0];
							member.PassWord = rdr[1].ToString();
							member.Name = rdr[2].ToString();
							member.Birthday = rdr[3].ToString();
							member.Rank = rdr[4].ToString();
							member.Part = rdr[5].ToString();
							member.Phone = rdr[6].ToString();
							member.Email = rdr[7].ToString();
							member.Longevity = rdr[8].ToString();
						//	member.Authority = rdr[9].ToString();
							member.Id = rdr[10].ToString();

							members.Add(member);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return members;
		}

		public void DP_Delete(int staticNo)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "DELETE FROM detailprocess WHERE Staticno = @no";

				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = staticNo;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void DP_Update(DetailProcess dp)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE detailprocess SET"
					+ " DFname = @DFname, Name = @Name, Color1 = @Color1, Color2 = @Color2"
					+ " WHERE StaticNo = @StaticNo";

				cmd.Parameters.Add("@StaticNo", MySqlDbType.VarChar, 50, "StaticNo");
				cmd.Parameters.Add("@DFname", MySqlDbType.VarChar, 50, "DFname");
				cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 50, "Name");
				cmd.Parameters.Add("@Color1", MySqlDbType.VarChar, 50, "Color1");
				cmd.Parameters.Add("@Color2", MySqlDbType.VarChar, 50, "Color2");



				cmd.Parameters["@StaticNo"].Value = dp.StaticNo;
				cmd.Parameters["@DFname"].Value = dp.DFName;
				cmd.Parameters["@Name"].Value = dp.Name;
				cmd.Parameters["@Color1"].Value = dp.Color1;
				cmd.Parameters["@Color2"].Value = dp.Color2;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}
		}

		public void DP_Add(DetailProcess dp)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO detailprocess ( No, DFName, Name, Color1, Color2) VALUES( @No, @DFName, @Name, @Color1, @Color2);";

				cmd.Parameters.Add("@No", MySqlDbType.VarChar, 50, "No");
				cmd.Parameters.Add("@DFName", MySqlDbType.VarChar, 50, "DFName");
				cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 50, "Name");
				cmd.Parameters.Add("@Color1", MySqlDbType.VarChar, 50, "Color1");
				cmd.Parameters.Add("@Color2", MySqlDbType.VarChar, 50, "Color2");

				cmd.Parameters["@No"].Value = dp.No;
				cmd.Parameters["@DFName"].Value = dp.DFName;
				cmd.Parameters["@Name"].Value = dp.Name;
				cmd.Parameters["@Color1"].Value = dp.Color1;
				cmd.Parameters["@Color2"].Value = dp.Color2;

				cmd.Connection = conn;
				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using
		}

		public List<DetailProcess> DetailProcessList(int no)
		{
			List<DetailProcess> list = new List<DetailProcess>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM detailprocess where no = " + no;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM detailprocess where no = " + no;
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							DetailProcess dp = new DetailProcess();

							dp.StaticNo = (int)rdr[0];
							dp.DFName = rdr[1].ToString();
							dp.No = (int)rdr[2];
							dp.Name = rdr[3].ToString();
							dp.Color1 = rdr[4].ToString();
							dp.Color2 = rdr[5].ToString();

							list.Add(dp);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public bool ProductNoUseCheck(string value)
		{
			bool result = false;
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Orders where ProductNo = @ProductNo";
				cmd.Parameters.Add("@ProductNo", MySqlDbType.VarChar, 50, "ProductNo");
				cmd.Parameters["@ProductNo"].Value = value;
				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check == 0)
					{
						result = true;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}
			return result;
		}

		public List<string> GetMemberPart(int value)
		{
			List<String> list = new List<string>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(NAME) FROM member WHERE part = (SELECT VALUE FROM partring WHERE NO = @NO)";
				cmd.Parameters.Add("@NO", MySqlDbType.Int32, 50, "NO");
				cmd.Parameters["@NO"].Value = value;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT name FROM member WHERE part = (SELECT VALUE FROM partring WHERE NO = @NO)";
						cmd.Parameters["@NO"].Value = value;
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							list.Add(rdr[0].ToString());
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}



		public bool MemberUseCheck(string type, string value)
		{
			bool result = false;
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Member where " + type + " = "+value;

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check == 0)
					{
						result = true;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}
			return result;
		}

		public void UpdateMember(Member member)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE member SET"
					+ " name = @name, rank = @rank, longevity = @longevity, birthday = @birthday, part = @part, phone = @phone, email = @email"
					+ " WHERE NO = @no";

				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@rank", MySqlDbType.VarChar, 50, "rank");
				cmd.Parameters.Add("@part", MySqlDbType.VarChar, 50, "part");
				cmd.Parameters.Add("@longevity", MySqlDbType.VarChar, 50, "longevity");
				cmd.Parameters.Add("@birthday", MySqlDbType.VarChar, 50, "birthday");
				cmd.Parameters.Add("@phone", MySqlDbType.VarChar, 50, "phone");
				cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");



				cmd.Parameters["@no"].Value = member.No;
				cmd.Parameters["@name"].Value = member.Name;
				cmd.Parameters["@rank"].Value = member.Rank;
				cmd.Parameters["@part"].Value = member.Part;
				cmd.Parameters["@longevity"].Value = member.Longevity;
				cmd.Parameters["@birthday"].Value = member.Birthday;
				cmd.Parameters["@phone"].Value = member.Phone;
				cmd.Parameters["@email"].Value = member.Email;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}
		}

		public List<Member> GetListSelectMember(string result, string value)
		{
			List<Member> members = new List<Member>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Member";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Member where " + result + " LIKE " +"'%"+ value + "%'";

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Member member = new Member();

							member.No = (int)rdr[0];
							member.PassWord = rdr[1].ToString();
							member.Name = rdr[2].ToString();
							member.Birthday = rdr[3].ToString();
							member.Rank = rdr[4].ToString();
							member.Part = rdr[5].ToString();
							member.Phone = rdr[6].ToString();
							member.Email = rdr[7].ToString();
							member.Longevity = rdr[8].ToString();
							//	member.Authority = rdr[9].ToString();
							member.Id = rdr[10].ToString();

							members.Add(member);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return members;
		}
		public List<Orders> GetListSelectOrder(string result, string value)
		{
			List<Orders> list = new List<Orders>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Orders";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Orders where " + result + " LIKE " + "'%" + value + "%'";

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Orders order = new Orders();
							order.ProductNo = rdr[0].ToString();
							order.State = rdr[1].ToString();
							order.CarType = rdr[2].ToString();
							order.ProductName = rdr[3].ToString();
							order.Material = rdr[4].ToString();
							order.DueDate = rdr[5].ToString();
							order.DiliveryDate = rdr[6].ToString();
							order.RealDate = rdr[7].ToString();
							order.FinalData = rdr[8].ToString();
							order.Designer = rdr[9].ToString();
							order.CAM = rdr[10].ToString();
							order.MB_Data = rdr[11].ToString();
							order.Worker = rdr[12].ToString();
							order.Customer = rdr[13].ToString();
							order.CustomerMember = rdr[14].ToString();
							order.ETC = rdr[15].ToString();

							list.Add(order);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return list;
		}
		public void DeleteStandardProcessAfter(StandardProcessModel sPM)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress + " allow user variables=true "))
			{
				MySqlCommand cmd = new MySqlCommand();


				try
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = "UPDATE standardprocess SET sort = sort-1 WHERE sort > " + sPM.Sort;

					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();

				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void DeleteStandardProcess(StandardProcessModel sPM)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "DELETE FROM standardprocess WHERE no = @no";

				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = sPM.No;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void DeleteStandardProcessChild(StandardProcessModel sPM)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "DELETE FROM detailprocess WHERE no = @no";

				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = sPM.No;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}
		public void UpdateStandardProcess(List<StandardProcessModel> sPMs)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress + "allow user variables=true;"))
			{

				MySqlCommand cmd = new MySqlCommand();

				MySqlTransaction Mtran = null;


				if (conn.State == ConnectionState.Open) conn.Close();
				cmd.Connection = conn;
				conn.Open();
				Mtran = conn.BeginTransaction();
				try
				{
					cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
					cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
					cmd.Parameters.Add("@sort", MySqlDbType.VarChar, 50, "sort");
					cmd.Parameters.Add("@color1", MySqlDbType.VarChar, 50, "color1");
					cmd.Parameters.Add("@color2", MySqlDbType.VarChar, 50, "color2");

					foreach (StandardProcessModel pro in sPMs)
					{
						cmd.CommandType = CommandType.Text;
						cmd.CommandText = "UPDATE standardprocess SET"
							+ "  sort = @sort, color1 = @color1, color2 = @color2, name = @name WHERE No = @No";

						cmd.Parameters["@no"].Value = pro.No;
						cmd.Parameters["@name"].Value = pro.Name;
						cmd.Parameters["@sort"].Value = pro.Sort;
						cmd.Parameters["@color1"].Value = pro.Color1;
						cmd.Parameters["@color2"].Value = pro.Color2;


						cmd.ExecuteNonQuery();

						cmd.CommandType = CommandType.Text;
						cmd.CommandText = "UPDATE detailprocess SET"
							+ "   DFname = @name WHERE No = @No";

						cmd.Parameters["@no"].Value = pro.No;
						cmd.Parameters["@name"].Value = pro.Name;

						cmd.ExecuteNonQuery();
					}

					Mtran.Commit();


				}
				catch (Exception e)
				{
					Mtran.Rollback();
					Console.WriteLine(e.ToString());
				}
			}//using
		}
		

		public void StandardProcessesExit(int no)
		{
		
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "DELETE FROM standardprocess WHERE no = @no";

				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = no;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void AddStandardProcess(StandardProcessModel newSPM)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO standardprocess ( sort, color1, color2, name) VALUES( @sort, @color1, @color2, @name);";

				cmd.Parameters.Add("@sort", MySqlDbType.VarChar, 50, "sort");
				cmd.Parameters.Add("@color1", MySqlDbType.VarChar, 50, "color1");
				cmd.Parameters.Add("@color2", MySqlDbType.VarChar, 50, "color2");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");

				cmd.Parameters["@sort"].Value = newSPM.Sort;
				cmd.Parameters["@color1"].Value = newSPM.Color1;
				cmd.Parameters["@color2"].Value = newSPM.Color2;
				cmd.Parameters["@name"].Value = newSPM.Name;

				cmd.Connection = conn;
				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using

		}

		public List<StandardProcessModel> GetStandardProcess()
		{
			List<StandardProcessModel> list = new List<StandardProcessModel>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM standardprocess";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM standardprocess";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							StandardProcessModel spm = new StandardProcessModel();

							spm.No = (int)rdr[0];
							spm.Sort = (int)rdr[1];
							spm.Color1 = rdr[2].ToString();
							spm.Color2 = rdr[3].ToString();
							spm.Name = rdr[4].ToString();

							list.Add(spm);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public void AddOrder(Orders order)
		{

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO orders ( ProductNo, State, CarType, ProductName, Material, DueDate,  DiliveryDate, FinalData, Designer, CAM, MBWearing, Worker, Customer, CustomerMember, ETC) "
											+ "VALUES( @ProductNo, @State, @CarType, @ProductName, @Material, @DueDate,  @DiliveryDate, @FinalData, @Designer, @CAM, @MBWearing, @Worker, @Customer, @CustomerMember, @ETC)";

				cmd.Parameters.Add("@ProductNo", MySqlDbType.VarChar, 50, "ProductNo");
				cmd.Parameters.Add("@State", MySqlDbType.VarChar, 50, "State");
				cmd.Parameters.Add("@CarType", MySqlDbType.VarChar, 50, "CarType");
				cmd.Parameters.Add("@ProductName", MySqlDbType.VarChar, 50, "ProductName");
				cmd.Parameters.Add("@Material", MySqlDbType.VarChar, 50, "Material");
				cmd.Parameters.Add("@DueDate", MySqlDbType.VarChar, 50, "DueDate");
				cmd.Parameters.Add("@DiliveryDate", MySqlDbType.VarChar, 50, "DiliveryDate");
				cmd.Parameters.Add("@FinalData", MySqlDbType.VarChar, 50, "FinalData");
				cmd.Parameters.Add("@Designer", MySqlDbType.VarChar, 50, "Designer");
				cmd.Parameters.Add("@CAM", MySqlDbType.VarChar, 50, "CAM");
				cmd.Parameters.Add("@MBWearing", MySqlDbType.VarChar, 50, "MBWearing");
				cmd.Parameters.Add("@Worker", MySqlDbType.VarChar, 50, "Worker");
				cmd.Parameters.Add("@Customer", MySqlDbType.VarChar, 50, "Customer");
				cmd.Parameters.Add("@CustomerMember", MySqlDbType.VarChar, 50, "CustomerMember");
				cmd.Parameters.Add("@ETC", MySqlDbType.VarChar, 200, "ETC");


				cmd.Parameters["@ProductNo"].Value = order.ProductNo;
				cmd.Parameters["@CarType"].Value = order.CarType;
				cmd.Parameters["@ProductName"].Value = order.ProductName;
				cmd.Parameters["@Material"].Value = order.Material;
				cmd.Parameters["@DueDate"].Value = order.DueDate;
				cmd.Parameters["@DiliveryDate"].Value = order.DiliveryDate;
				cmd.Parameters["@FinalData"].Value = order.FinalData;
				cmd.Parameters["@Designer"].Value = order.Designer;
				cmd.Parameters["@CAM"].Value = order.CAM;
				cmd.Parameters["@MBWearing"].Value = order.MB_Data;
				cmd.Parameters["@Worker"].Value = order.Worker;
				cmd.Parameters["@Customer"].Value = order.Customer;
				cmd.Parameters["@CustomerMember"].Value = order.CustomerMember;
				cmd.Parameters["@ETC"].Value = order.ETC;
				cmd.Parameters["@state"].Value = "수주 등록";

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using
		}

		public void DefualtCodeSortDown(string selectCode, DefaultType selectValue)    //가져온거 sort +1
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();
				try
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = "UPDATE " + selectCode + " SET sort = sort+1 WHERE no = @No";

					cmd.Parameters.Add("@No", MySqlDbType.VarChar, 11, "No");
					cmd.Parameters["@No"].Value = selectValue.No;


					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}
		public void DefualtCodeSortDownOppenent(string selectCode, DefaultType selectValue)    //가져온거 sort +1
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();

				cmd.CommandText = "Select No From " + selectCode + " WHERE Sort = @Sort and No != @No";
				cmd.Parameters.Add("@Sort", MySqlDbType.Int32, 11, "Sort");
				cmd.Parameters.Add("@No", MySqlDbType.Int32, 11, "No");
				cmd.Parameters["@No"].Value = selectValue.No;
				cmd.Parameters["@Sort"].Value = selectValue.Sort + 1;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText = "UPDATE " + selectCode + " SET sort = sort-1 WHERE no = @No";

					cmd.Parameters["@No"].Value = check;

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void DefualtCodeSortUp(string selectCode, DefaultType selectValue)    //가져온거 sort -1
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();
				try
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = "UPDATE " + selectCode + " SET sort = sort-1 WHERE no = @No";

					cmd.Parameters.Add("@No", MySqlDbType.VarChar, 11, "No");
					cmd.Parameters["@No"].Value = selectValue.No;


					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}
		public void DefualtCodeSortUpOppenent(string selectCode, DefaultType selectValue)    //가져온거 sort -1
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();

				cmd.CommandText = "Select No From " + selectCode + " WHERE Sort = @Sort and No != @No";
				cmd.Parameters.Add("@Sort", MySqlDbType.Int32, 11, "Sort");
				cmd.Parameters.Add("@No", MySqlDbType.Int32, 11, "No");
				cmd.Parameters["@No"].Value = selectValue.No;
				cmd.Parameters["@Sort"].Value = selectValue.Sort - 1;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText = "UPDATE " + selectCode + " SET sort = sort+1 WHERE no = @No";

					cmd.Parameters["@No"].Value = check;

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public int DefualtCodeCount(string selectCode)
		{
			int check = 0;
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM " + selectCode;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					check = Convert.ToInt32(cmd.ExecuteScalar());
				}
				catch (Exception e) { }
			}

			return check;
		}

		public bool DefualtCodeDuplicateCheck(String SelectCode, string text)
		{
			int check = 0;
			bool result = true;
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM " + SelectCode + "where Type = @Type";
				cmd.Parameters.Add("@Type", MySqlDbType.VarChar, 50, "Type");
				cmd.Parameters["@Type"].Value = text;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					check = Convert.ToInt32(cmd.ExecuteScalar());
				}
				catch (Exception e) { }
			}
			if (check == 0)
				result = false; //중복이 없으면 true
			return result;
		}

		public void AddDefualtCode(string selectCode, string text)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM " + selectCode;

				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());



					cmd.CommandText = " INSERT INTO " + selectCode + " (Type, Sort)  VALUES (@Type, @Sort); ";

					cmd.Parameters.Add("@Type", MySqlDbType.VarChar, 50, "Type");
					cmd.Parameters.Add("@Sort", MySqlDbType.VarChar, 50, "Sort");
					cmd.Parameters["@Type"].Value = text;
					cmd.Parameters["@Sort"].Value = check + 1;

					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}//using
		}

		public void UpdateDefualtCode(string selectCode, DefaultType selectValue, String Text)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress + " allow user variables=true "))
			{
				MySqlCommand cmd = new MySqlCommand();


				try
				{

					cmd.CommandType = CommandType.Text;
					cmd.CommandText = "UPDATE " + selectCode + " SET"
						+ "  Type = @Type "
						+ "  WHERE No = @No";


					cmd.Parameters.Add("@Type", MySqlDbType.VarChar, 50, "Type");
					cmd.Parameters.Add("@No", MySqlDbType.VarChar, 50, "No");
					cmd.Parameters["@Type"].Value = Text;
					cmd.Parameters["@No"].Value = selectValue.No;


					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();

				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void SortChangeDefaultCode(String SelectCode, int sort)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress + " allow user variables=true "))
			{
				MySqlCommand cmd = new MySqlCommand();


				try
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = "UPDATE " + SelectCode + " SET sort = sort-1 WHERE sort > " + sort;

					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();

				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using

		}

	

		public bool OverlapIdCheck(string type, string id)
		{
			Boolean result = false;
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM " + type + " where id = @id";

				cmd.Parameters.Add("@id", MySqlDbType.VarChar, 50, "id");
				cmd.Parameters["@id"].Value = id;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check == 0) result = true;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}
			return result;
		}

		public void DeleteOrder(string no)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "DELETE  FROM orders WHERE ProductNO = @NO";
				cmd.Parameters.Add("@No", MySqlDbType.VarChar, 50, "No");
				cmd.Parameters["@No"].Value = no;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void UpdateOrder(Orders order)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress + " allow user variables=true "))
			{
				MySqlCommand cmd = new MySqlCommand();


				try
				{

					cmd.CommandType = CommandType.Text;
					cmd.CommandText = "UPDATE orders SET"
						+ "  CarType = @CarType, ProductName = @ProductName, "
						+ "  Material = @Material, DueDate = @DueDate, DiliveryDate = @DiliveryDate, "
						+ "  FinalData = @FinalData, Designer = @Designer, "
						+ "  CAM = @CAM, MBWearing = @MBWearing, "
						+ "  Worker = @Worker, Customer = @Customer, "
						+ "  CustomerMember = @CustomerMember, ETC = @ETC"
						+ "  WHERE ProductNo = @ProductNo";


					cmd.Parameters.Add("@ProductNo", MySqlDbType.VarChar, 50, "ProductNo");
					cmd.Parameters.Add("@CarType", MySqlDbType.VarChar, 50, "CarType");
					cmd.Parameters.Add("@ProductName", MySqlDbType.VarChar, 50, "ProductName");
					cmd.Parameters.Add("@Material", MySqlDbType.VarChar, 50, "Material");
					cmd.Parameters.Add("@DueDate", MySqlDbType.VarChar, 50, "DueDate");
					cmd.Parameters.Add("@DiliveryDate", MySqlDbType.VarChar, 50, "DiliveryDate");
					cmd.Parameters.Add("@FinalData", MySqlDbType.VarChar, 50, "FinalData");
					cmd.Parameters.Add("@Designer", MySqlDbType.VarChar, 50, "Designer");
					cmd.Parameters.Add("@MBWearing", MySqlDbType.VarChar, 50, "MBWearing");
					cmd.Parameters.Add("@CAM", MySqlDbType.VarChar, 50, "CAM");
					cmd.Parameters.Add("@Customer", MySqlDbType.VarChar, 50, "Customer");
					cmd.Parameters.Add("@CustomerMember", MySqlDbType.VarChar, 50, "CustomerMember");
					cmd.Parameters.Add("@ETC", MySqlDbType.VarChar, 50, "ETC");

					cmd.Parameters["@ProductNo"].Value = order.ProductNo;
					cmd.Parameters["@CarType"].Value = order.CarType;
					cmd.Parameters["@ProductName"].Value = order.ProductName;
					cmd.Parameters["@Material"].Value = order.Material;
					cmd.Parameters["@DueDate"].Value = order.DueDate;
					cmd.Parameters["@DiliveryDate"].Value = order.DiliveryDate;
					cmd.Parameters["@FinalData"].Value = order.FinalData;
					cmd.Parameters["@Designer"].Value = order.Designer;
					cmd.Parameters["@MBWearing"].Value = order.MB_Data;
					cmd.Parameters["@CAM"].Value = order.CAM;
					cmd.Parameters["@Customer"].Value = order.Customer;
					cmd.Parameters["@CustomerMember"].Value = order.CustomerMember;
					cmd.Parameters["@ETC"].Value = order.ETC;


					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();

				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public int MemberCnt()
		{

			int check = 0;
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM member ";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					check = Convert.ToInt32(cmd.ExecuteScalar());

				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}
			return check;
		}


		public List<string> getSelectMemberOfCustom(string custom)
		{
			List<String> list = new List<string>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT no FROM customer where name = '" + custom + "'";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT name FROM customermember where no = " + check;
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							list.Add(rdr[0].ToString());
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}
		public List<string> getMemberPartList(string part)
		{
			List<String> list = new List<string>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM member where Part = '" + part + "'";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT name FROM member where Part = '" + part + "'";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							list.Add(rdr[0].ToString());
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public List<string> getOriginalList()
		{
			List<String> list = new List<string>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM customer where division = '원청'";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT Name FROM customer where division = '원청'";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							list.Add(rdr[0].ToString());
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public List<Orders> GetOrders()
		{
			List<Orders> list = new List<Orders>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Orders";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM orders";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Orders order = new Orders();
							order.ProductNo = rdr[0].ToString();
							order.State = rdr[1].ToString();
							order.CarType = rdr[2].ToString();
							order.ProductName = rdr[3].ToString();
							order.Material = rdr[4].ToString();
							order.DueDate = rdr[5].ToString();
							order.DiliveryDate = rdr[6].ToString();
							order.RealDate = rdr[7].ToString();
							order.FinalData = rdr[8].ToString();
							order.Designer = rdr[9].ToString();
							order.CAM = rdr[10].ToString();
							order.MB_Data = rdr[11].ToString();
							order.Worker = rdr[12].ToString();
							order.Customer = rdr[13].ToString();
							order.CustomerMember = rdr[14].ToString();
							order.ETC = rdr[15].ToString();

							list.Add(order);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}
		public List<Products> GetProducts()
		{
			List<Products> list = new List<Products>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM product";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM product";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Products product = new Products();

							product.No = rdr[0].ToString();
							product.ProductNo = rdr[1].ToString();
							product.ProductName = rdr[2].ToString();
							product.Designer = rdr[3].ToString();
							product.CAM = rdr[4].ToString();
							product.Work = rdr[5].ToString();
							product.Product = rdr[6].ToString();
							product.Fair = rdr[7].ToString();
							product.State = rdr[8].ToString();
							product.Start = rdr[9].ToString();
							product.End = rdr[10].ToString();

							list.Add(product);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}
		public Orders SelectDataGridRowOrder(string str, string no)
		{
			Orders order = new Orders();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM " + str + " where productNo = @productNo";

				cmd.Parameters.Add("@productNo", MySqlDbType.VarChar, 50, "productNo");
				cmd.Parameters["@productNo"].Value = no;

				try
				{
					cmd.Connection = conn;
					conn.Open();

					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						order.ProductNo = rdr[0].ToString();
						order.State = rdr[1].ToString();
						order.CarType = rdr[2].ToString();
						order.ProductName = rdr[3].ToString();
						order.Material = rdr[4].ToString();
						order.DueDate = rdr[5].ToString();
						order.DiliveryDate = rdr[6].ToString();
						order.RealDate = rdr[7].ToString();
						order.FinalData = rdr[8].ToString();
						order.Designer = rdr[9].ToString();
						order.CAM = rdr[10].ToString();
						order.MB_Data = rdr[11].ToString();
						order.Worker = rdr[12].ToString();
						order.Customer = rdr[13].ToString();
						order.CustomerMember = rdr[14].ToString();
						order.ETC = rdr[15].ToString();
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return order;
		}
		public Products SelectDataGridRowProduct(string str, string no)
		{
			Products order = new Products();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM " + str + " where productNo = @productNo";

				cmd.Parameters.Add("@productNo", MySqlDbType.VarChar, 50, "productNo");
				cmd.Parameters["@productNo"].Value = no;

				try
				{
					cmd.Connection = conn;
					conn.Open();

					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						/*order.ProductNo = rdr[0].ToString();
						order.State = rdr[1].ToString();
						order.CarType = rdr[2].ToString();
						order.ProductName = rdr[3].ToString();
						order.Material = rdr[4].ToString();
						order.DueDate = rdr[5].ToString();
						order.DiliveryDate = rdr[6].ToString();
						order.RealDate = rdr[7].ToString();
						order.FinalData = rdr[8].ToString();
						order.Designer = rdr[9].ToString();
						order.CAM = rdr[10].ToString();
						order.MB_Data = rdr[11].ToString();
						order.Worker = rdr[12].ToString();
						order.Customer = rdr[13].ToString();
						order.CustomerMember = rdr[14].ToString();
						order.ETC = rdr[15].ToString();*/
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return order;
		}
		public List<int> StandardProcessesSet()
		{
			List<int> list = new List<int>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT no FROM standardprocess";

				try
				{
					cmd.Connection = conn;
					conn.Open();

					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						list.Add((int)rdr[0]);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		//싱글톤 패턴 ---------------------------------------------------------------------------------- 
		private DataBase() { }

		private static readonly Lazy<DataBase> _instance = new Lazy<DataBase>(() => new DataBase());

		public static DataBase Instance { get { return _instance.Value; } }



		//싱글톤 패턴 ---------------------------------------------------------------------------------- 


		//id check 
		public Member IdCheck(string id, string pw)
		{
			Member member = new Member();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Member WHERE Id = @Id and PassWord = @PassWord";

				cmd.Parameters.Add("@Id", MySqlDbType.VarChar, 50, "Id");
				cmd.Parameters["@Id"].Value = id;
				cmd.Parameters.Add("@PassWord", MySqlDbType.VarChar, 50, "PassWord");
				cmd.Parameters["@PassWord"].Value = pw;

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Member WHERE Id = @Id and PassWord = @PassWord";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							member.No = (int)rdr[0];
							member.PassWord = rdr[1].ToString();
							member.Name = rdr[2].ToString();
							member.Birthday = rdr[3].ToString();
							member.Rank = rdr[4].ToString();
							member.Part = rdr[5].ToString();
							member.Phone = rdr[6].ToString();
							member.Email = rdr[7].ToString();
							member.Longevity = rdr[8].ToString();
							member.Authority = (Model.Member.AuthorityOfMember)rdr[9];
							member.Id = rdr[10].ToString();
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return member;
		}

		public CustomerMember SelectDataGridRowCustomerMember(string type, string name, string rank)
		{
			CustomerMember cm = new CustomerMember();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM " + type + " where name = @name and rank = @rank";

				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters["@name"].Value = name;

				cmd.Parameters.Add("@rank", MySqlDbType.VarChar, 50, "rank");
				cmd.Parameters["@rank"].Value = rank;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						cm.No = (int)rdr[0];
						cm.Name = rdr[1].ToString();
						cm.Part = rdr[2].ToString();
						cm.Rank = rdr[3].ToString();
						cm.Number = rdr[4].ToString();
						cm.Fax = rdr[5].ToString();
						cm.Email = rdr[6].ToString();
						cm.ETC = rdr[7].ToString();
						cm.StaticNo = (int)rdr[8];
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return cm;
		}

		public List<Process> GetStandardProcesses()
		{
			List<Process> list = new List<Process>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM standardprocess";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM standardprocess order by sort DESC";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Process cm = new Process();

							cm.No = (int)rdr[0];
							cm.Sort = (int)rdr[1];
							cm.Color = rdr[2].ToString();
							cm.Name = rdr[3].ToString();

							list.Add(cm);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public Customer SelectDataGridRowCustomer(string type, string no)
		{
			Customer customer = new Customer();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM " + type + " where No = @No";

				cmd.Parameters.Add("@NO", MySqlDbType.VarChar, 50, "NO");
				cmd.Parameters["@NO"].Value = no;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						customer.No = (int)rdr[0];
						customer.Group = rdr[2].ToString();
						customer.Name = rdr[3].ToString();
						customer.CEO = rdr[4].ToString();
						customer.Number = rdr[5].ToString();
						customer.Fax = rdr[6].ToString();
						customer.Transaction = rdr[7].ToString();
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return customer;
		}

		public void UpdateProcess(List<Process> list)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();

				MySqlTransaction Mtran = null;


				if (conn.State == ConnectionState.Open) conn.Close();
				cmd.Connection = conn;
				conn.Open();
				Mtran = conn.BeginTransaction();
				try
				{
					cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
					cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
					cmd.Parameters.Add("@sort", MySqlDbType.VarChar, 50, "sort");
					cmd.Parameters.Add("@color", MySqlDbType.VarChar, 50, "color");

					foreach (Process pro in list)
					{
						cmd.CommandType = CommandType.Text;
						cmd.CommandText = "UPDATE standardprocess SET"
							+ "  sort = @sort, color = @color, name = @name WHERE No = @No";

						cmd.Parameters["@no"].Value = pro.No;
						cmd.Parameters["@name"].Value = pro.Name;
						cmd.Parameters["@sort"].Value = pro.Sort;
						cmd.Parameters["@color"].Value = pro.Color;


						cmd.ExecuteNonQuery();
					}

					Mtran.Commit();


				}
				catch (Exception e)
				{
					Mtran.Rollback();
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void DeleteNotice(int no)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "DELETE  FROM Notice WHERE NO = @NO";
				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = no;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void UpdateNotice(int no, string title, string content, string name)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE notice SET"
					+ "  name = @name, title = @title, content = @content, noticedate = @NoticeDate WHERE No = @No";

				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@title", MySqlDbType.VarChar, 50, "title");
				cmd.Parameters.Add("@content", MySqlDbType.VarChar, 50, "content");
				cmd.Parameters.Add("@NoticeDate", MySqlDbType.VarChar, 50, "NoticeDate");



				cmd.Parameters["@no"].Value = no;
				cmd.Parameters["@name"].Value = name;
				cmd.Parameters["@title"].Value = title;
				cmd.Parameters["@content"].Value = content;
				cmd.Parameters["@NoticeDate"].Value = DateTime.Now.ToString("yyyy-MM-dd");

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using
		}

		public Notice GetNotices(int selectNo)
		{
			Notice notice = new Notice();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM Notice where No = @No";

				cmd.Parameters.Add("@NO", MySqlDbType.VarChar, 50, "NO");
				cmd.Parameters["@NO"].Value = selectNo;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						notice.No = (int)rdr[0];
						notice.Name = rdr[1].ToString();
						notice.Title = rdr[2].ToString();
						notice.Content = rdr[3].ToString();
						notice.Date = rdr[4].ToString();
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return notice;
		}

		public void AddNotice(string title, string content, string name)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO Notice (Name, Title, Content, NoticeDate) "
					+ "VALUES(@Name, @Title, @Content, @NoticeDate)";

				cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 50, "Name");
				cmd.Parameters.Add("@Title", MySqlDbType.VarChar, 50, "Title");
				cmd.Parameters.Add("@Content", MySqlDbType.VarChar, 6000, "Content");
				cmd.Parameters.Add("@NoticeDate", MySqlDbType.VarChar, 50, "NoticeDate");

				cmd.Parameters["@Name"].Value = name;
				cmd.Parameters["@Title"].Value = title;
				cmd.Parameters["@Content"].Value = content;
				cmd.Parameters["@NoticeDate"].Value = DateTime.Now.ToString("yyyy-MM-dd");

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using
		}

		public List<Notice> GetNotices()
		{
			List<Notice> list = new List<Notice>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Notice";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Notice";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Notice notice = new Notice();
							notice.No = (int)rdr[0];
							notice.Name = rdr[1].ToString();
							notice.Title = rdr[2].ToString();
							notice.Date = rdr[4].ToString();

							list.Add(notice);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public void DeleteMember(int no)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "DELETE  FROM Member WHERE NO = @NO";
				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = no;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}


			}//using
		}



		public void UpdateCustomerMember(int sNo, int no, string name, string part, string rank, string number, string fax, string email, string etc)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE CustomerMember SET"
					+ " no = @no, name = @name, part = @part, rank = @rank, number = @number , fax = @fax, email = @email. etc = @etc"
					+ " WHERE StaticNo = @staticNo";

				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@part", MySqlDbType.VarChar, 50, "part");
				cmd.Parameters.Add("@rank", MySqlDbType.VarChar, 50, "rank");
				cmd.Parameters.Add("@number", MySqlDbType.VarChar, 50, "number");
				cmd.Parameters.Add("@fax", MySqlDbType.VarChar, 50, "fax");
				cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
				cmd.Parameters.Add("@etc", MySqlDbType.VarChar, 50, "etc");
				cmd.Parameters.Add("@StaticNo", MySqlDbType.VarChar, 50, "StaticNo");
				cmd.Parameters.Add("@transaction", MySqlDbType.VarChar, 50, "transaction");


				cmd.Parameters["@no"].Value = no;
				cmd.Parameters["@name"].Value = name;
				cmd.Parameters["@part"].Value = part;
				cmd.Parameters["@rank"].Value = rank;
				cmd.Parameters["@number"].Value = number;
				cmd.Parameters["@fax"].Value = fax;
				cmd.Parameters["@email"].Value = email;
				cmd.Parameters["@etc"].Value = etc;
				cmd.Parameters["@StaticNo"].Value = sNo;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}
		}

		public void ProcessAdd(int no)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO standardprocess (no, sort) VALUES(@no, @sort);";

				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@sort", MySqlDbType.VarChar, 50, "sort");
				cmd.Parameters["@no"].Value = no;
				cmd.Parameters["@sort"].Value = no;

				cmd.Connection = conn;
				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using
		}

		public void DeleteCustomerMember(int no)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "DELETE  FROM CustomerMember WHERE StaticNo = @StaticNo";
				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "StaticNo");
				cmd.Parameters["@StaticNo"].Value = no;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void DeleteCustomerMembers(int no)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "DELETE  FROM CustomerMember WHERE NO = @NO";
				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = no;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}
		public List<Customer> CustomerGetSelete(string result, string value)
		{
			List<Customer> notices = new List<Customer>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Notice";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Notice where " + result + " LIKE " + "'%" + value + "%'";

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Customer notice = new Customer();

							//notice.No = (int)rdr[0];
							//notice.Name = rdr[1].ToString();
							//notice.Title = rdr[2].ToString();
							//notice.Content = rdr[3].ToString();
							//notice.Date = rdr[4].ToString();

							notices.Add(notice);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return notices;
		}
		public List<CustomerMember> GetCustomerMembers(int no)
		{
			List<CustomerMember> cms = new List<CustomerMember>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM CustomerMember where No = @no";

				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = no;

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							CustomerMember cm = new CustomerMember();

							cm.No = (int)rdr[0];
							cm.Name = rdr[1].ToString();
							cm.Part = rdr[2].ToString();
							cm.Rank = rdr[3].ToString();
							cm.Number = rdr[4].ToString();
							cm.Fax = rdr[5].ToString();
							cm.Email = rdr[6].ToString();
							cm.ETC = rdr[7].ToString();

							cms.Add(cm);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return cms;
		}

		public void AddCustomerMember(CustomerMember cm)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO customerMember (no, name, part, rank, number, fax, email, etc) "
					+ "VALUES(@no, @name, @part, @rank, @number, @fax, @email, @etc)";



				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@part", MySqlDbType.VarChar, 50, "part");
				cmd.Parameters.Add("@rank", MySqlDbType.VarChar, 50, "rank");
				cmd.Parameters.Add("@number", MySqlDbType.VarChar, 50, "number");
				cmd.Parameters.Add("@fax", MySqlDbType.VarChar, 50, "fax");
				cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
				cmd.Parameters.Add("@etc", MySqlDbType.VarChar, 50, "etc");

				cmd.Parameters["@no"].Value = cm.No;
				cmd.Parameters["@name"].Value = cm.Name;
				cmd.Parameters["@part"].Value = cm.Part;
				cmd.Parameters["@rank"].Value = cm.Rank;
				cmd.Parameters["@number"].Value = cm.Number;
				cmd.Parameters["@fax"].Value = cm.Fax;
				cmd.Parameters["@email"].Value = cm.Email;
				cmd.Parameters["@etc"].Value = cm.ETC;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using
		}

		public List<Customer> getOrderOfCustomerList()
		{
			List<Customer> list = new List<Customer>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Customer";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Customer";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Customer customer = new Customer();

							customer.No = (int)rdr[0];
							customer.Name = rdr[2].ToString();

							list.Add(customer);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}
		public List<CustomerMember> getOrderOfCustomerMemberList()
		{
			List<CustomerMember> list = new List<CustomerMember>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM CustomerMember";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM CustomerMember";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							CustomerMember customer = new CustomerMember();

							customer.No = (int)rdr[0];
							customer.Name = rdr[1].ToString();

							list.Add(customer);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}
		public void DeleteCustomer(int no)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "DELETE  FROM Customer WHERE NO = @NO";
				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = no;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}//using
		}

		public void UpdateCustomer(int no, string division, string gruop, string name, string ceo, string number, string fax, string transaction)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE Customer SET"
					+ " division = @division, cgroup = @gruop, name = @name, ceo = @ceo, number = @number , fax = @fax, transaction = @transaction"
					+ " WHERE NO = @no";

				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@division", MySqlDbType.VarChar, 50, "division");
				cmd.Parameters.Add("@gruop", MySqlDbType.VarChar, 50, "gruop");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@ceo", MySqlDbType.VarChar, 50, "ceo");
				cmd.Parameters.Add("@number", MySqlDbType.VarChar, 50, "number");
				cmd.Parameters.Add("@fax", MySqlDbType.VarChar, 50, "fax");
				cmd.Parameters.Add("@transaction", MySqlDbType.VarChar, 50, "transaction");


				cmd.Parameters["@no"].Value = no;
				cmd.Parameters["@division"].Value = division;
				cmd.Parameters["@gruop"].Value = gruop;
				cmd.Parameters["@name"].Value = name;
				cmd.Parameters["@ceo"].Value = ceo;
				cmd.Parameters["@number"].Value = number;
				cmd.Parameters["@fax"].Value = fax;
				cmd.Parameters["@transaction"].Value = transaction;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}
		}

		public void DeleteMachine(int no)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "DELETE  FROM machine WHERE NO = @NO";
				cmd.Parameters.Add("@No", MySqlDbType.Int32, 50, "No");
				cmd.Parameters["@No"].Value = no;

				try
				{
					cmd.Connection = conn;
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}


			}//using
		}

		public void AddCustomer(Customer customer)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO customer (no, division, CGroup, name, ceo, number, fax, Transaction) "
					+ "VALUES(@no, @division, @group, @name, @ceo, @number, @fax, @Transaction)";



				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@group", MySqlDbType.VarChar, 50, "group");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@ceo", MySqlDbType.VarChar, 50, "ceo");
				cmd.Parameters.Add("@number", MySqlDbType.VarChar, 50, "number");
				cmd.Parameters.Add("@fax", MySqlDbType.VarChar, 50, "fax");
				cmd.Parameters.Add("@Transaction", MySqlDbType.VarChar, 50, "Transaction");

				cmd.Parameters["@no"].Value = customer.No;
				cmd.Parameters["@group"].Value = customer.Group;
				cmd.Parameters["@name"].Value = customer.Name;
				cmd.Parameters["@ceo"].Value = customer.CEO;
				cmd.Parameters["@number"].Value = customer.Number;
				cmd.Parameters["@fax"].Value = customer.Fax;
				cmd.Parameters["@Transaction"].Value = customer.Transaction;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using

		}

		public void UpdateMachine(int no, string name, string main, string sub, string brand, string buy, string ip, string ues)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE machine SET"
					+ " name = @name, supervisor = @supervisor, subordinate = @subordinate, manufact = @manufact, buy = @buy , ip = @ip, useable = @useable"
					+ " WHERE NO = @no";

				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@supervisor", MySqlDbType.VarChar, 50, "supervisor");
				cmd.Parameters.Add("@subordinate", MySqlDbType.VarChar, 50, "subordinate");
				cmd.Parameters.Add("@manufact", MySqlDbType.VarChar, 50, "manufact");
				cmd.Parameters.Add("@buy", MySqlDbType.VarChar, 50, "buy");
				cmd.Parameters.Add("@ip", MySqlDbType.VarChar, 50, "ip");
				cmd.Parameters.Add("@useable", MySqlDbType.VarChar, 50, "useable");


				cmd.Parameters["@no"].Value = no;
				cmd.Parameters["@name"].Value = name;
				cmd.Parameters["@supervisor"].Value = main;
				cmd.Parameters["@subordinate"].Value = sub;
				cmd.Parameters["@manufact"].Value = brand;
				cmd.Parameters["@buy"].Value = buy;
				cmd.Parameters["@ip"].Value = ip;
				cmd.Parameters["@useable"].Value = ues;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}
		}

		public void UpdateMember(int no, string name, string rank, string part, string longevity, string birthday, string phone, string email)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE member SET"
					+ " name = @name, rank = @rank, longevity = @longevity, birthday = @birthday, part = @part, phone = @phone, email = @email"
					+ " WHERE NO = @no";

				cmd.Parameters.Add("@no", MySqlDbType.VarChar, 50, "no");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar, 50, "name");
				cmd.Parameters.Add("@rank", MySqlDbType.VarChar, 50, "rank");
				cmd.Parameters.Add("@part", MySqlDbType.VarChar, 50, "part");
				cmd.Parameters.Add("@longevity", MySqlDbType.VarChar, 50, "longevity");
				cmd.Parameters.Add("@birthday", MySqlDbType.VarChar, 50, "birthday");
				cmd.Parameters.Add("@phone", MySqlDbType.VarChar, 50, "phone");
				cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");



				cmd.Parameters["@no"].Value = no;
				cmd.Parameters["@name"].Value = name;
				cmd.Parameters["@rank"].Value = rank;
				cmd.Parameters["@part"].Value = part;
				cmd.Parameters["@longevity"].Value = longevity;
				cmd.Parameters["@birthday"].Value = birthday;
				cmd.Parameters["@phone"].Value = phone;
				cmd.Parameters["@email"].Value = email;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}
		}

		public List<String> GetDefaultCodeList(String type)
		{
			List<String> list = new List<string>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM " + type ;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT type FROM " + type + " Order By Sort";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							list.Add(rdr[0].ToString());
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public List<string> getMemberList()
		{
			List<String> list = new List<string>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM member";
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT name FROM member";
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							list.Add(rdr[0].ToString());
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}

		public void DeleteDefualtCode(String type, DefaultType df)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				try
				{
					cmd.Connection = conn;
					conn.Open();
					cmd.CommandText = "DELETE FROM " + type + " WHERE No = @No";

					cmd.Parameters.Add("@No", MySqlDbType.VarChar, 50, "No");
					cmd.Parameters["@No"].Value = df.No.ToString();

					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();


					cmd.CommandText = "UPDATE rankofmember SET sort = sort - 1 WHERE sort > " + df.Sort.ToString();
					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();
					cmd.Connection = conn;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}

		public List<Member> GetMembers()
		{
			List<Member> members = new List<Member>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM Member";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Member member = new Member();
							member.No = (int)rdr[0];
							member.Name = rdr[2].ToString();
							member.Birthday = rdr[3].ToString();
							member.Rank = rdr[4].ToString();
							member.Part = rdr[5].ToString();
							member.Phone = rdr[6].ToString();
							member.Email = rdr[7].ToString();
							member.Longevity = rdr[8].ToString();

							members.Add(member);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return members;
		}
		//CheckCodeMember
		public Boolean OverlapCheck(String type, int no)
		{
			Boolean result = false;
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM " + type + " where No = @No";

				cmd.Parameters.Add("@NO", MySqlDbType.VarChar, 50, "NO");
				cmd.Parameters["@NO"].Value = no;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check == 0) result = true;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}
			return result;
		}
		public void AddMember(Member member)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO MEMBER(NO, NAME, PassWord, Birthday, Rank, Part, Phone, Email, Longevity, Authority) "
					+ "VALUES(@NO, @NAME, @PassWord, @Birthday, @Rank, @Part, @Phone, @Email, @Longevity, @Authority)";



				cmd.Parameters.Add("@NO", MySqlDbType.VarChar, 50, "NO");
				cmd.Parameters.Add("@NAME", MySqlDbType.VarChar, 50, "NAME");
				cmd.Parameters.Add("@PassWord", MySqlDbType.VarChar, 50, "PassWord");
				cmd.Parameters.Add("@Birthday", MySqlDbType.VarChar, 50, "Birthday");
				cmd.Parameters.Add("@Rank", MySqlDbType.VarChar, 50, "Rank");
				cmd.Parameters.Add("@Part", MySqlDbType.VarChar, 50, "Part");
				cmd.Parameters.Add("@Phone", MySqlDbType.VarChar, 50, "Phone");
				cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 50, "Email");
				cmd.Parameters.Add("@Longevity", MySqlDbType.VarChar, 50, "Longevity");
				cmd.Parameters.Add("@Authority", MySqlDbType.VarChar, 50, "Authority");

				cmd.Parameters["@NO"].Value = member.No;
				cmd.Parameters["@NAME"].Value = member.Name;
				cmd.Parameters["@PassWord"].Value = member.PassWord;
				cmd.Parameters["@Birthday"].Value = member.Birthday;
				cmd.Parameters["@Rank"].Value = member.Rank;
				cmd.Parameters["@Part"].Value = member.Part;
				cmd.Parameters["@Phone"].Value = member.Phone;
				cmd.Parameters["@Email"].Value = member.Email;
				cmd.Parameters["@Longevity"].Value = member.Longevity;
				cmd.Parameters["@Authority"].Value = member.Authority;

				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using

		}
		public Member SelectDataGridRowMember(String type, string no)
		{

			Member member = new Member();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM " + type + " where No = @No";

				cmd.Parameters.Add("@NO", MySqlDbType.VarChar, 50, "NO");
				cmd.Parameters["@NO"].Value = no;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						member.No = (int)rdr[0];
						member.PassWord = rdr[1].ToString();
						member.Name = rdr[2].ToString();
						member.Birthday = rdr[3].ToString();
						member.Rank = rdr[4].ToString();
						member.Part = rdr[5].ToString();
						member.Phone = rdr[6].ToString();
						member.Email = rdr[7].ToString();
						member.Longevity = rdr[8].ToString();
						member.Authority = (Model.Member.AuthorityOfMember)rdr[9];
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return member;
		}
		public void AddMachine(Machine machine)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;

				cmd.CommandText = "INSERT INTO machine (Name, Supervisor, Subordinate, Manufact, Buy, IP, Useable) "
					+ "VALUES(@Name, @Supervisor, @Subordinate, @Manufact, @Buy, @IP, @Useable)";

				cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 50, "Name");
				cmd.Parameters.Add("@Supervisor", MySqlDbType.VarChar, 50, "Supervisor");
				cmd.Parameters.Add("@Subordinate", MySqlDbType.VarChar, 50, "Subordinate");
				cmd.Parameters.Add("@Manufact", MySqlDbType.VarChar, 50, "Manufact");
				cmd.Parameters.Add("@Buy", MySqlDbType.VarChar, 50, "Buy");
				cmd.Parameters.Add("@IP", MySqlDbType.VarChar, 50, "IP");
				cmd.Parameters.Add("@Useable", MySqlDbType.VarChar, 50, "Useable");

				cmd.Parameters["@Name"].Value = machine.Name;
				cmd.Parameters["@Supervisor"].Value = machine.Supervisor;
				cmd.Parameters["@Subordinate"].Value = machine.Subordinate;
				cmd.Parameters["@Manufact"].Value = machine.Manufact;
				cmd.Parameters["@Buy"].Value = machine.Buy;
				cmd.Parameters["@IP"].Value = machine.IP;
				cmd.Parameters["@Useable"].Value = machine.Use;


				cmd.Connection = conn;

				if (conn.State == ConnectionState.Open) conn.Close();
				conn.Open();

				cmd.ExecuteNonQuery();

			}//using
		}
		public List<Machine> GetMachines()
		{
			List<Machine> machines = new List<Machine>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM machine";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Machine machine = new Machine();

							machine.No = (int)rdr[0];
							machine.Name = rdr[1].ToString();
							machine.Supervisor = rdr[3].ToString();
							machine.Subordinate = rdr[4].ToString();
							machine.Manufact = rdr[5].ToString();
							machine.Buy = rdr[6].ToString();
							machine.IP = rdr[7].ToString();
							machine.Use = rdr[8].ToString();

							machines.Add(machine);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return machines;
		}
		public Machine SelectDataGridRowMachine(String type, string no)
		{

			Machine machine = new Machine();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM " + type + " where No = @No";

				cmd.Parameters.Add("@NO", MySqlDbType.VarChar, 50, "NO");
				cmd.Parameters["@NO"].Value = no;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						machine.No = (int)rdr[0];
						machine.Name = rdr[1].ToString();
						machine.Supervisor = rdr[3].ToString();
						machine.Subordinate = rdr[4].ToString();
						machine.Manufact = rdr[5].ToString();
						machine.Buy = rdr[6].ToString();
						machine.IP = rdr[7].ToString();
						machine.Use = rdr[8].ToString();
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return machine;
		}
		public List<Customer> GetCustomers()
		{
			List<Customer> members = new List<Customer>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT * FROM Customer";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Customer customer = new Customer();
							customer.No = (int)rdr[0];
							customer.Group = rdr[2].ToString();
							customer.Name = rdr[3].ToString();
							customer.CEO = rdr[4].ToString();
							customer.Number = rdr[5].ToString();
							customer.Fax = rdr[6].ToString();
							customer.Transaction = rdr[7].ToString();

							members.Add(customer);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return members;
		}









		public List<DefaultType> DefualtCodeList(String type)
		{
			List<DefaultType> list = new List<DefaultType>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM " + type;
				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM " + type;
						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							DefaultType dt = new DefaultType();
							dt.No = (int)rdr[0];
							dt.Value = rdr[1].ToString();
							dt.Sort = (int)rdr[2];

							list.Add(dt);
						}
					}
					else
					{
						return null;
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return list;
		}



		public List<Notice> NoticeGetSelete(string result, string value)
		{
			List<Notice> notices = new List<Notice>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Notice";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Notice where " + result + " LIKE " + "'%" + value + "%'";

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Notice notice = new Notice();

							notice.No = (int)rdr[0];
							notice.Name = rdr[1].ToString();
							notice.Title = rdr[2].ToString();
							notice.Content = rdr[3].ToString();
							notice.Date = rdr[4].ToString();

							notices.Add(notice);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return notices;
		}

		public List<Notice> GetNotice()
		{
			List<Notice> notices = new List<Notice>();

			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM Notice";

				try
				{
					cmd.Connection = conn;
					conn.Open();
					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM Notice";

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Notice notice = new Notice();

							notice.No = (int)rdr[0];
							notice.Name = rdr[1].ToString();
							notice.Title = rdr[2].ToString();
							notice.Content = rdr[3].ToString();
							notice.Date = rdr[4].ToString();

							notices.Add(notice);
						}
					}
					else
					{
						return null;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			return notices;
		}

		public void UpdateNoticeData(Notice selectData)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();

				try
				{
					cmd.CommandText = "UPDATE Notice SET Title = @Title, Content = @Content , NoticeDate = DATE_FORMAT(now(), '%Y-%m-%d') WHERE NO = @No ";

					cmd.Parameters.Add("@Title", MySqlDbType.VarChar, 50, "Title");
					cmd.Parameters.Add("@Content", MySqlDbType.VarChar, 50, "Content");
					cmd.Parameters.Add("@No", MySqlDbType.Int32, 11, "No");


					cmd.Parameters["@No"].Value = selectData.No;
					cmd.Parameters["@Title"].Value = selectData.Title;
					cmd.Parameters["@Content"].Value = selectData.Content;


					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}

			//return selectData.No.ToString();

		}

		public void DeleteNoticeData(Notice selectData)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();

				try
				{
					cmd.CommandText = "DELETE FROM Notice WHERE NO = @No ";

					cmd.Parameters.Add("@No", MySqlDbType.Int32, 11, "No");

					cmd.Parameters["@No"].Value = selectData.No;


					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}


		}

		public void AddNoticeData(Notice selectData)
		{
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{
				MySqlCommand cmd = new MySqlCommand();

				try
				{
					cmd.CommandText = "INSERT INTO Notice (`Name`, `Title`, `Content`, `NoticeDate`) VALUES ('Admin', @Title, @Content, DATE_FORMAT(now(), '%Y-%m-%d'))";

					cmd.Parameters.Add("@Title", MySqlDbType.VarChar, 50, "Title");
					cmd.Parameters.Add("@Content", MySqlDbType.VarChar, 50, "Content");

					cmd.Parameters["@Title"].Value = selectData.Title;
					cmd.Parameters["@Content"].Value = selectData.Content;


					cmd.Connection = conn;

					if (conn.State == ConnectionState.Open) conn.Close();
					conn.Open();

					cmd.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.ToString());
				}
			}
		}









	}//class
}

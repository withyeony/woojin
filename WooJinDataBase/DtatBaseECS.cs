using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WooJinDataBase
{
	public sealed class DataBaseECS
	{
		private string ServerAddress = "server=localhost;user=root;database=cncnet;password=root;" +
										"port=3308;" +
										"CharSet = utf8;";

		

		private DataBaseECS() { }



		private static readonly Lazy<DataBaseECS> _instance = new Lazy<DataBaseECS>(() => new DataBaseECS());

		public static DataBaseECS Instance { get { return _instance.Value; } }


		public List<Class1> GetList()
		{
				List<Class1> list = new List<Class1>();
				using (MySqlConnection conn = new MySqlConnection(ServerAddress))
				{

					MySqlCommand cmd = new MySqlCommand();
					cmd.CommandText = "SELECT count(*) FROM mth_raw_data where GROUP_ID = (SELECT  MAX(GROUP_ID) FROM mth_raw_data) ORDER BY creation_date DESC;";

					try
					{
						cmd.Connection = conn;
						conn.Open();

						int check = Convert.ToInt32(cmd.ExecuteScalar());

						if (check != 0)
						{
							cmd.CommandText = "SELECT * FROM mth_raw_data WHERE GROUP_ID = (SELECT  MAX(GROUP_ID) FROM mth_raw_data) ORDER BY creation_date DESC";

							cmd.Connection = conn;

							MySqlDataReader rdr = cmd.ExecuteReader();

							while (rdr.Read())
							{
							Class1 subject = new Class1();

							subject.value1 = rdr[0].ToString();
							subject.value2 = rdr[1].ToString();
							subject.value3 = (int)rdr[2];
							subject.value4 = rdr[3].ToString();
							subject.value5 = rdr[4].ToString();
							

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

		public List<Class1> GetListAll()
		{
			List<Class1> list = new List<Class1>();
			using (MySqlConnection conn = new MySqlConnection(ServerAddress))
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandText = "SELECT count(*) FROM mth_raw_data ;";

				try
				{
					cmd.Connection = conn;
					conn.Open();

					int check = Convert.ToInt32(cmd.ExecuteScalar());

					if (check != 0)
					{
						cmd.CommandText = "SELECT * FROM mth_raw_data ;";

						cmd.Connection = conn;

						MySqlDataReader rdr = cmd.ExecuteReader();

						while (rdr.Read())
						{
							Class1 subject = new Class1
							{
								value1 = rdr[0].ToString(),
							value2 = rdr[1].ToString(),
								value3 = (int)rdr[2],
								value4 = rdr[3].ToString(),
								value5 = rdr[4].ToString(),
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
	}
}

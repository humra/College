using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnect();
            Console.ReadKey();
        }

        private static void DatabaseConnect()
        {
            Console.WriteLine("Input database name: ");
            string dbName = Console.ReadLine();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = CreateConnectionString(dbName);
            con.StateChange += con_StateChange;

            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL EXCEPTION: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }

        static void con_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine("STATUS: " + e.CurrentState);
        }

        private static string CreateConnectionString(string dbName)
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.ConnectTimeout = 5;
            sb.DataSource = @".\SQLEXPRESS";
            sb.InitialCatalog = dbName;
            sb.IntegratedSecurity = true;

            return sb.ToString();
        }
    }
}

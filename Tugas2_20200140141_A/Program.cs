using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tugas2_20200140141_A
{
    class Program
    {
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-KINALAKA\\NURSAKINAH;database=TenantMall;Integrated Security = TRUE");
                con.Open();
            } catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            } finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

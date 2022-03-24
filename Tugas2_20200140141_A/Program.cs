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

                SqlCommand id1 = new SqlCommand ("insert into Penyewa (Id_Penyewa, Nama_Depan, Nama_Belakang, No_Telepon, Alamat, Email, Jenis_Kelamin) values ('7271030606000001','Abel', 'Khaizure', '085834470606', 'Jalan Neo No. 06', 'abelganteng@gmail.com','L')", con);
                id1.ExecuteNonQuery();

                SqlCommand id2 = new SqlCommand("insert into Tenant (Id_Tenant, Jenis_Tenant, Harga_Sewa, Jenis_Sewa, Lantai) values ('001','Anchor', 50000000, 'Tahun', '2')", con);
                id2.ExecuteNonQuery();

                SqlCommand id3 = new SqlCommand("insert into Sales (Id_Sales, Nama_Sales, No_Telepon, Email) values ('097','Sheila', '082218819581', 'sheilalala@mail.com')", con);
                id3.ExecuteNonQuery();

                SqlCommand id4 = new SqlCommand("insert into Penyewaan_Tenant (Id_Sewa, Id_Penyewa, Id_Tenant, Tanggal_Mulai, Tanggal_Selesai, Total_Bayar, Jenis_Pembayaran) values ('0689','7271030606000001', '001', '2022-04-01', '23-03-31', 50000000, 'Non Tunai')", con);
                id4.ExecuteNonQuery();

                SqlCommand id5 = new SqlCommand("insert into Penawaran (Id_Penawaran, Id_Tenant, Id_Sales, Tanggal_Mulai, Tanggal_Penawaran, Total_Terima, Bonus_Sales, Deskripsi) values ('1674','001', '097', '2022-01-11', '23-03-24', 50000000, 2500000, 'Jarak waktu penawaran dan penerimaan 2 bulan. Mulai sewa Tenant dihitung mulai 01 April 2022 dan Selesai pada 31 Maret 2023')", con);
                id5.ExecuteNonQuery();

                Console.WriteLine("Berhasil menambahkan data!");
                Console.ReadKey();
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

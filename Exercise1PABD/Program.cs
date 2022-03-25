using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise1PABD
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MSI;database=Exercise1PABD;Integrated Security=TRUE");
                con.Open();

                SqlCommand brg = new SqlCommand("create table Barang (Id_Barang char(5) primary key," +
                    "Jumlah_Barang varchar(50), Tipe_Barang varchar(30), Harga_Barang int, Nama_Barang varchar(30))", con);
                brg.ExecuteNonQuery();
                SqlCommand ksr = new SqlCommand("create table Kasir (Id_Kasir char(5) primary key," +
                   "Nama_Depan varchar(50), Nama_Belakang varchar(50), No_Telp char(12))", con);
                ksr.ExecuteNonQuery();
                SqlCommand pbl = new SqlCommand("create table Pembeli (Id_Pembeli char(5) primary key," +
                   "Nama_Depan varchar(50), Nama_Belakang varchar(50), No_Telp char(12))", con);
                pbl.ExecuteNonQuery();
                SqlCommand trx = new SqlCommand("create table Transaksi (Id_Transaksi char(5) primary key," +
                  "Id_Barang char(5) foreign key references Barang(Id_Barang), Id_Kasir char(5) foreign key references Kasir(Id_Kasir), Id_Pembeli char(5) foreign key references Pembeli(Id_Pembeli))", con);
                trx.ExecuteNonQuery();

                Console.WriteLine("Tabel Berhasil Dibuat....");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Membuat Tabel... " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MSI;database=Exercise1PABD;Integrated Security=TRUE");
                con.Open();

                SqlCommand brg = new SqlCommand("insert into Barang (Id_Barang, Jumlah_Barang, Tipe_Barang, Harga_Barang, Nama_Barang)" +
                    "values('CK001','1','Kue Kering', '14999', 'Nastar')", con);
                brg.ExecuteNonQuery();
                SqlCommand brg1 = new SqlCommand("insert into Barang (Id_Barang, Jumlah_Barang, Tipe_Barang, Harga_Barang, Nama_Barang)" +
                    "values('CK002','3','Kue Kering', '30000', 'Putri Salju')", con);
                brg1.ExecuteNonQuery();
                SqlCommand brg2 = new SqlCommand("insert into Barang (Id_Barang, Jumlah_Barang, Tipe_Barang, Harga_Barang, Nama_Barang)" +
                     "values('CK003','10','Kue Basah', '20000', 'Onde Onde')", con);
                brg2.ExecuteNonQuery();
                SqlCommand brg3 = new SqlCommand("insert into Barang (Id_Barang, Jumlah_Barang, Tipe_Barang, Harga_Barang, Nama_Barang)" +
                     "values('CK004','2','Kue Basah', '50000', 'Bolu Pisang')", con);
                brg3.ExecuteNonQuery();
                SqlCommand brg4 = new SqlCommand("insert into Barang (Id_Barang, Jumlah_Barang, Tipe_Barang, Harga_Barang, Nama_Barang)" +
                     "values('CK005','3','Kue Kering', '75000', 'Kastengel')", con);
                brg4.ExecuteNonQuery();


                SqlCommand ksr = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Depan, Nama_Belakang, No_Telp)" +
                    "values('SBRD1','Indra','Mukti', '081343220962')", con);
                ksr.ExecuteNonQuery();
                SqlCommand ksr1 = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Depan, Nama_Belakang, No_Telp)" +
                    "values('SBRD2','Muhammad','Dzaki','081376219842')", con);
                ksr1.ExecuteNonQuery();
                SqlCommand ksr2 = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Depan, Nama_Belakang, No_Telp)" +
                                    "values('SBRD3','Andre','Pratama', '081209757812')", con);
                ksr2.ExecuteNonQuery();
                SqlCommand ksr3 = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Depan, Nama_Belakang, No_Telp)" +
                                    "values('SBRD4','Naufal','Rozan', '081343228612')", con);
                ksr3.ExecuteNonQuery();
                SqlCommand ksr4 = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Depan, Nama_Belakang, No_Telp)" +
                                    "values('SBRD5','Asra','Syahrastani', '081365874924')", con);
                ksr4.ExecuteNonQuery();


                SqlCommand pbl = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Depan, Nama_Belakang, No_Telp)" +
                    "values('BYR01','Alfiansah','Erik','085546321476')", con);
                pbl.ExecuteNonQuery();
                SqlCommand pbl1 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Depan, Nama_Belakang, No_Telp)" +
                    "values('BYR02','Cindy','Nur','085546322194')", con);
                pbl1.ExecuteNonQuery();
                SqlCommand pbl2 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Depan, Nama_Belakang, No_Telp)" +
                                    "values('BYR03','Dimas','Pratama','085546326234')", con);
                pbl2.ExecuteNonQuery();
                SqlCommand pbl3 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Depan, Nama_Belakang, No_Telp)" +
                                    "values('BYR04','Rafi','Utama','085546329850')", con);
                pbl3.ExecuteNonQuery();
                SqlCommand pbl4 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Depan, Nama_Belakang, No_Telp)" +
                                    "values('BYR05','Rizvaldi','Samantha','085546326930')", con);
                pbl4.ExecuteNonQuery();



                SqlCommand trx = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Kasir, Id_Barang)" +
                    "values('T001','BYR01','SBRD1','CK001')", con);
                trx.ExecuteNonQuery();
                SqlCommand trx1 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Kasir, Id_Barang)" +
                    "values('T002','BYR02','SBRD2','CK002')", con);
                trx1.ExecuteNonQuery();
                SqlCommand trx2 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Kasir, Id_Barang)" +
                    "values('T003','BYR03','SBRD3','CK003')", con);
                trx2.ExecuteNonQuery();
                SqlCommand trx3 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Kasir, Id_Barang)" +
                    "values('T004','BYR04','SBRD4','CK004')", con);
                trx3.ExecuteNonQuery();
                SqlCommand trx4 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Kasir, Id_Barang)" +
                    "values('T005','BYR05','SBRD5','CK005')", con);
                trx4.ExecuteNonQuery();

                Console.WriteLine("Data berhasil Di input...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menginput data... " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            //new Program().CreateTable();
            new Program().InsertData();
        }
    }
}

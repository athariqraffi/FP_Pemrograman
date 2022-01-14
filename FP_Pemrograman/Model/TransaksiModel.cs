using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FP_Pemrograman.Model
{
    class TransaksiModel
    {
        ModelTemplateQuery template;
        public string id_transaksi { get; set; }
        public string id_barang { get; set; }
        public string tgl_penjualan { get; set; }
        public string jumlah { get; set; }
        public string total_harga { get; set; }

        public TransaksiModel()
        {
            template = new ModelTemplateQuery();
        }

        public DataSet SelectTransaksi(string cari)
        {
            DataSet data = new DataSet();
            if (cari == "")
            {
                data = template.Select("transaksi");
            }
            else
            {
                string kondisi = "id_transaksi LIKE '%"+ cari + "%' OR id_barang LIKE '%" + cari + "%' OR tgl_penjulan LIKE '%" + cari + "%' OR jumlah LIKE '%" + cari + "%' OR total_harga LIKE '%" + cari + "%'";
                data = template.Select("transaksi", kondisi);
            }
            return data;
        }
        public DataSet countTodayStatistic()
        {
            string tabel = "transaksi";
            string data = string.Format("COUNT(*) as jumlah_transaksi");
            string kondisi = string.Format("tgl_penjualan", DateTime.Now.ToString());

            return template.CustomSelect(tabel,data,kondisi);
        }
    }
}

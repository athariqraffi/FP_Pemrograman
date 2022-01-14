using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Pemrograman.Model
{
    class DashboardModel
    {
        ModelTemplateQuery template;

        public DashboardModel()
        {
            template = new ModelTemplateQuery();
        }

        public DataSet gettodayTransaksi()
        {
            DataSet ds = new DataSet();
            ds = template.Select("transaksi", "");
            return ds;
        }
        public string JumlahIncome(string tanggal)
        {
            string result = "0";
            DataSet ds = new DataSet();
            ds = template.SelectData("SELECT SUM(total_harga) FROM transaksi WHERE tgl_penjualan = '" + tanggal + "'", "transaksi");
            result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }

        public string JumlahMasukToday(string tanggal)
        {
            string result = "0";
            DataSet ds = new DataSet();
            ds = template.SelectData("SELECT COUNT(*) FROM barang WHERE tanggal = '" + tanggal + "'", "barang");
            result = ds.Tables[0].Rows[0][0].ToString();
            return result;
        }
    }
}

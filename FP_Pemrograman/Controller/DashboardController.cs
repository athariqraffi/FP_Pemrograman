using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Pemrograman.Controller
{
    class DashboardController
    {

        private View.DashboardPage page;
        private Model.TransaksiModel transaksi;
        private Model.BarangModel barang;

        public DashboardController(View.DashboardPage page)
        {
            this.page = page;
            transaksi = new Model.TransaksiModel();
            barang = new Model.BarangModel();
            Refresh();
        }

        public void Refresh()
        {
            DataSet ds = transaksi.countTodayStatistic();
            var data = ds.Tables[0].Rows[0];
            page.lblTransaksi.Content = data["jumlah_transaksi"].ToString();
        }

    }
}

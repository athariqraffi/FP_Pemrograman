using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Pemrograman.Controller
{
    class DashboardController
    {

        private View.DashboardPage page;
        private View.TransaksiPage transaksiPage;
        private Model.TransaksiModel transaksi;
        private Model.BarangModel barang;
        private Model.DashboardModel dashboard;


        public DashboardController(View.DashboardPage page)
        {
            this.page = page;
            transaksi = new Model.TransaksiModel();
            transaksiPage = new View.TransaksiPage();
            barang = new Model.BarangModel();
            dashboard = new Model.DashboardModel();
            Refresh();
        }

        public void DataTransaksi()
        {
            DataSet ds = dashboard.gettodayTransaksi();
            page.dgpenjualan.ItemsSource = ds.Tables[0].DefaultView;
        }


        public void Refresh()
        {
            string tanggal = DateTime.Now.ToString("yyyy-MM-dd");
            page.lblTransaksi.Content = transaksi.JumlahTransaksi(tanggal);

        }

        public void showincome()
        {
            string tanggal = DateTime.Now.ToString("yyyy-MM-dd");
            page.lblKeuntungan.Content = dashboard.JumlahIncome(tanggal);
        }
        public void showjumlahmasuktoday()
        {
            string tanggal = DateTime.Now.ToString("yyyy-MM-dd");
            page.lblmasuktoday.Content = dashboard.JumlahMasukToday(tanggal);
        }
    }
}

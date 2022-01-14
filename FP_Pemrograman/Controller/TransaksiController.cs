using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace FP_Pemrograman.Controller
{
    class TransaksiController
    {
        private Model.TransaksiModel transaksiModel;
        private View.TransaksiPage transaksiPage;

        public TransaksiController(View.TransaksiPage transaksiPage)
        {
            transaksiModel = new Model.TransaksiModel();
            this.transaksiPage = transaksiPage;
        }

        public void DataTransaksi()
        {
            string cari = transaksiPage.TxtCari.Text;
            DataSet data = transaksiModel.SelectTransaksi(cari);
            transaksiPage.dgTransaksi.ItemsSource = data.Tables[0].DefaultView;
        }

        public void ShowJumlahTransaksi()
        {
            string tanggal = DateTime.Now.ToString("yyyy-MM-dd");
            transaksiPage.lblTransaksi.Content = transaksiModel.JumlahTransaksi(tanggal);

        }
    }
}

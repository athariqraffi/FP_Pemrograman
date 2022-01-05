using System;
using System.Data;
using System.Windows;
using System.Collections.Generic;
using System.Text;

namespace FP_Pemrograman.Controller
{
    internal class Barang
    {
        Model.BarangModel barang;
        View.BarangMasukPage barangpage;

        public Barang(View.BarangMasukPage barangpage)
        { 
            barang = new Model.BarangModel();
            this.barangpage = barangpage;
        }

        public void Insert()
        {
            barang.tanggal = barangpage.dtpTglMsk.Text;
            barang.id_barang = barangpage.txtIdBrng.Text;
            barang.nama_barang = barangpage.txtNamaBrng.Text;
            barang.harga = barangpage.txtHargaBrng.Text;

            bool result = barang.InsertBarang();
            if (result)
            {
                MessageBox.Show("Menginputkan barang baru berhasil");
            }
            else
            {
                MessageBox.Show("Maaf, proses input barang baru gagal, silahkan coba lagi");
            }

        }
    }
}

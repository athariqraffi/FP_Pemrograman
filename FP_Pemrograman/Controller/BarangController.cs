using System;
using System.Data;
using System.Windows;
using System.Collections.Generic;
using System.Text;

namespace FP_Pemrograman.Controller
{
    internal class BarangController
    {
        Model.BarangModel barang;
        View.BarangMasukPage barangpage;

        //instance
        public BarangController(View.BarangMasukPage barangpage)
        { 
            barang = new Model.BarangModel();
            this.barangpage = barangpage;
        }

        public void InsertController()
        {
            
            barang.id_barang = barangpage.txtIdBrng.Text;
            barang.nama_barang = barangpage.txtNamaBrng.Text;
            barang.harga = barangpage.txtHargaBrng.Text;
            barang.tanggal = barangpage.dtpTglMsk.Text;
            

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

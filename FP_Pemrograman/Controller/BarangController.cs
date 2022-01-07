using System;
using System.Data;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace FP_Pemrograman.Controller
{
    internal class BarangController
    {
        Model.BarangModel barang;
        View.BarangMasukPage barangpage;
        Model.SupplierModel supplier;

        //instance
        public BarangController(View.BarangMasukPage barangpage)
        { 
            barang = new Model.BarangModel();
            supplier = new Model.SupplierModel();
            this.barangpage = barangpage;
        }

        public void InsertController()
        {

            barang.id_barang = barangpage.txtIdBrng.Text;
            barang.id_supplier = barangpage.cmbSupplier.SelectedValue.ToString();
            barang.nama_barang = barangpage.txtNamaBrng.Text;
            barang.tanggal = barangpage.dtpTglMsk.SelectedDate.Value.ToString("yyyy-MM-dd");
            barang.harga = barangpage.txtHargaBrng.Text;
          
            if (barang.InsertBarang())
            {
                MessageBox.Show("Data Berhasil Dimasukan");
            }
            else
            {
                MessageBox.Show("Data Gagal Dimasukan");
            }

        }
    }
}

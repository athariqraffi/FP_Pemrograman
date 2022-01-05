﻿using System;
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
            barang.harga = barangpage.txtHargaBrng.Text;
            barang.tanggal = barangpage.dtpTglMsk.Text;

          
            if (barang.InsertBarang())
            {
                MessageBox.Show("Data Berhasil Dimasukan");
            }
            else
            {
                MessageBox.Show("Data Gagal Dimasukan");
            }

        }


        public void populateSupplier() 
        {
            DataSet ds = supplier.getAllSupplier();

            barangpage.cmbSupplier.ItemsSource = ds.Tables[0].DefaultView;
            barangpage.cmbSupplier.DisplayMemberPath = "nama_supplier";
            barangpage.cmbSupplier.SelectedValuePath = "id_supplier";


        }
    }
}

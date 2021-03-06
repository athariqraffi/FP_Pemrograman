using System;
using System.Data;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FP_Pemrograman.Controller
{
    internal class SupplierController
    {
        Model.SupplierModel supplier;
        View.SupplierPage supplierpage;


        public SupplierController(View.SupplierPage supplierPage)
        {
            supplier = new Model.SupplierModel();
            this.supplierpage = supplierPage;
            loadSupplier();
        }

        public void loadSupplier()
        {
            DataSet ds = supplier.getAllSupplier();
            supplierpage.dgSupplier.ItemsSource = ds.Tables[0].DefaultView;
        }

        public void remvoeSupplier(string id)
        {
            supplier.id_supplier = id;
            Boolean result = supplier.deleteSupplier();
            if (result)
            {
                loadSupplier();
            }
        }

        public void InsertController()
        {

            supplier.id_supplier = supplierpage.txtIdSupply.Text;
            supplier.nama_supplier = supplierpage.txtNamaSupply.Text;
            supplier.no_hp = supplierpage.txtNoHPSupply.Text;
            supplier.alamat = supplierpage.txtAlamatSupply.Text;


            if (supplier.InsertSupplier())
            {
                MessageBox.Show("Data Berhasil Dimasukan");
                supplierpage.popTambah.Visibility = Visibility.Hidden;
                supplierpage.txtIdSupply.Text = "";
                supplierpage.txtNamaSupply.Text = "";
                supplierpage.txtNoHPSupply.Text = "";
                supplierpage.txtAlamatSupply.Text = "";
                loadSupplier();
            }
            else
            {
                MessageBox.Show("Data Gagal Dimasukan");
            }

        }

    }

}

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

        }
        public void InsertController()
        {

            supplier.id_supplier = supplierpage.txtIdSupply.Text;
            supplier.nama_supplier = supplierpage.txtNamaSupply.Text;
            supplier.no_hp = supplierpage.txtNoHPSupply.Text;
            supplier.email = supplierpage.txtEmailSupply.Text;
            supplier.alamat = supplierpage.txtAlamatSupply.Text;


            if (supplier.InsertSupplier())
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

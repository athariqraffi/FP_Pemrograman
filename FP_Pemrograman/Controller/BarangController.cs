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

        public void loadBarang()
        {
            DataSet data = barang.getAllBarang();
            string[] namafile = new string[100];
            for(int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                namafile[i] = data.Tables[0].Rows[i]["foto"].ToString();
                data.Tables[0].Rows[i]["foto"] = "/FotoBarang/" + namafile[i];
            }
            barangpage.ListViewBarang.ItemsSource = data.Tables[0].DefaultView;
        }

        public void InsertController()
        {

            barang.id_barang = barangpage.txtIdBrng.Text;
            barang.id_supplier = barangpage.cmbSupplier.SelectedValue.ToString();
            barang.nama_barang = barangpage.txtNamaBrng.Text;
            barang.tanggal = barangpage.dtpTglMsk.SelectedDate.Value.ToString("yyyy-MM-dd");
            barang.harga = barangpage.txtHargaBrng.Text;
            barang.foto = barangpage.txtIdBrng.Text + ".jpg";
          
            if (barang.InsertBarang())
            {
                MessageBox.Show("Data Berhasil Dimasukan");
                barangpage.popTambah.Visibility = Visibility.Hidden;
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

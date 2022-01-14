using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FP_Pemrograman.Model
{
    class SupplierModel
    {

        public string id_supplier { get; set; }
        public string nama_supplier { get; set; }
        public string no_hp { get; set; }
        public string alamat { get; set; }

        public string email { get; set; }

        ModelTemplateQuery temp;

        public SupplierModel()
        {
            this.temp = new ModelTemplateQuery();
        }

        public DataSet getAllSupplier()
        {
            DataSet ds = new DataSet();
            ds = temp.Select("Supplier", "");
            return ds;
        }

        public DataSet getSupplierById()
        {
            DataSet ds = new DataSet();
            string kondisi = string.Format("id_supplier = {0}", id_supplier);
            ds = temp.Select("supplier", kondisi);
            return ds;
        }

        public Boolean updateSupplier()
        {
            string tabel = "supplier";
            string data = string.Format("nama_supplier = '{0}', no_hp = '{1}', alamat = '{2}'", nama_supplier, no_hp, alamat);
            string kondisi = string.Format("id_supplier = {0}", id_supplier);
            return temp.Update(tabel, data, kondisi);
        }

        public bool InsertSupplier()
        {
            string data = string.Format("'{0}', '{1}', '{2}', '{3}'", id_supplier, nama_supplier, no_hp, alamat);
            return temp.Insert("supplier", data);
        }

        public bool deleteSupplier()
        {
            string kondisi = string.Format("id_supplier = '{0}'", id_supplier);
            return temp.Delete("supplier", kondisi);
        }
    }
}

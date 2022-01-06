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

        public bool InsertSupplier()
        {
            
            string data = "'" + id_supplier + "','" + nama_supplier + "','" + no_hp + "','" + alamat + "','" + email + "'";
            return temp.Insert("supplier", data);
        }
    }
}

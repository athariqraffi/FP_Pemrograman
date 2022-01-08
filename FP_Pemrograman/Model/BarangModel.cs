using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace FP_Pemrograman.Model
{
    internal class BarangModel
    {
        ModelTemplateQuery barang;

        public string id_barang { get; set; }
        public string id_supplier { get; set; }
        public string nama_barang { get; set; }
        public string tanggal { get; set; }
        public string harga { get; set; }
        public string foto { get; set; }

        public BarangModel()
        {
            barang = new ModelTemplateQuery();
            
        }

        public bool InsertBarang()
        {
            string tabel = "barang";
            string data = "'" + id_barang + "', '"+id_supplier + "','" + nama_barang +"','" + tanggal +"','" + harga +"','" + foto + "'";
            return barang.Insert(tabel, data);
        }
    }
}

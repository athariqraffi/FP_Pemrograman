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

        public string tabel = "barang";

        public BarangModel()
        {
            barang = new ModelTemplateQuery();

        }

        public DataSet getAllBarang()
        {
            return barang.Select(tabel);
        }

        public DataSet GetBarangById(string id)
        {
            string kondisi = string.Format("id_barang = '{0}'", id);
            return barang.Select(tabel, kondisi);
        }

        public bool InsertBarang()
        {
            string data = "'" + id_barang + "', '" + id_supplier + "','" + nama_barang + "','" + tanggal + "','" + harga + "','" + foto + "'";
            return barang.Insert(tabel, data);
        }

        public bool updatebarang()
        {
            string table = "barang";
            string data = string.Format("id_supplier = {0}, nama_barang = '{1}', tanggal = '{2}', harga = {3}", id_supplier, nama_barang, tanggal, harga);
            string kondisi = string.Format("id_barang = {0}", id_barang);

            return barang.Update(tabel, data, kondisi);
            
        }

        public bool deleteBarang(string id)
        {
            string kondisi = string.Format("id_barang = '{0}'", id);
            if (barang.Delete(tabel, kondisi))
            {
                return true;
            }
            return false;
        }
    }
}

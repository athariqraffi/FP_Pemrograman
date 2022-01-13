using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Media.Imaging;

namespace FP_Pemrograman.Controller
{

    class PreviewController
    {

        private View.PreviewWindow window;
        private Model.BarangModel barang;
        private Model.SupplierModel supplier;

        private string id_user;
        private string imageFileName;

        public PreviewController(View.PreviewWindow window)
        {
            barang = new Model.BarangModel();
            this.window = window;
            supplier = new Model.SupplierModel();
        }

        public void LoadPreview(string id)
        {
            this.id_user = id;
            DataSet data = barang.GetBarangById(id);
            imageFileName = data.Tables[0].Rows[0]["foto"].ToString();
            string imageFilePath = App.Current.Properties["CURRENT_PATH"].ToString() + "\\FotoBarang\\" + imageFileName;
            window.txtIdBrngUpdate.Text = data.Tables[0].Rows[0]["id_barang"].ToString();
            window.dtpTglMaskUpdate.SelectedDate = DateTime.Parse(data.Tables[0].Rows[0]["tanggal"].ToString());
            window.txtNamaBrngUpdate.Text = data.Tables[0].Rows[0]["nama_barang"].ToString();
            window.txtHargaBrngUpdate.Text = data.Tables[0].Rows[0]["harga"].ToString();
            window.imgFotoUPdate.Source = new BitmapImage(new Uri(imageFilePath));

            DataSet supp = supplier.getAllSupplier();
            window.cmbSupplierUpdate.ItemsSource = supp.Tables[0].DefaultView;
            window.cmbSupplierUpdate.DisplayMemberPath = "nama_supplier";
            window.cmbSupplierUpdate.SelectedValuePath = "id_supplier";
            window.cmbSupplierUpdate.SelectedValue = data.Tables[0].Rows[0]["id_supplier"].ToString();
        }

        public bool deleteBarang(string id)
        {
            return barang.deleteBarang(id);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Pemrograman.Controller
{
    class UpdateSupplierController
    {
        private View.SupplierUpdateWindow window;
        private Model.SupplierModel supplier;

        private string id_supplier;


        public UpdateSupplierController(View.SupplierUpdateWindow window, string id_supplier)
        {
            this.window = window;
            supplier = new Model.SupplierModel();
            this.id_supplier = id_supplier;
            loadSupplier();
        }

        public void loadSupplier()
        {
            supplier.id_supplier = id_supplier;
            DataSet ds = supplier.getSupplierById();
            var data = ds.Tables[0].Rows[0];
            window.txtIdSupply.Text = data["id_supplier"].ToString();
            window.txtNamaSupply.Text = data["nama_supplier"].ToString();
            window.txtNoHPSupply.Text = data["no_hp"].ToString();
            window.txtAlamatSupply.Text = data["alamat"].ToString();
        }
        
        public Boolean updateSupplier()
        {
            supplier.id_supplier = window.txtIdSupply.Text;
            supplier.nama_supplier = window.txtNamaSupply.Text;
            supplier.no_hp = window.txtNoHPSupply.Text;
            supplier.alamat = window.txtAlamatSupply.Text;

            return supplier.updateSupplier();
            
        }

    }
}

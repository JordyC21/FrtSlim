using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSlim.Models; 

namespace FSlim.Vistas
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            using (FrtSlimEntities db = new FrtSlimEntities())
            {
                var listaProducto = from p in db.Proveedor
                                    select new
                                    {
                                        ID = p.idProveedor,
                                        Nombre = p.nombre
                                       
                                    };

                dataGridView1.DataSource = listaProducto.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

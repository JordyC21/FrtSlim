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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }


        private void MostrarProductos()
        {
            using (FrtSlimEntities db = new FrtSlimEntities())
            {
                var listaProducto = from p in db.Productos 
                                    select new
                                    {
                                        ID = p.IdProducto,
                                        name = p.nombre,
                                        Descripcion = p.descripcion,
                                        Stock = p.stock,
                                        Precio = p.precio


                                    };

                dataGridView1.DataSource = listaProducto.ToList();
            }
        }

    }
}

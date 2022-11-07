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
    public partial class frmMadre : Form
    {
        public frmMadre()
        {
            InitializeComponent();
        }

        private void frmMadre_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            using (FrtSlimEntities db = new FrtSlimEntities())
            {
              
                //var ListaProductos = from prod in db.prod select prod;

                dataGridView1.DataSource = db.Productos.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

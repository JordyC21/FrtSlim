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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }


        private void FrmVentas_Load(object sender, EventArgs e)
        {
            MostrarVentas();
        }

        void MostrarVentas()
        {
            using (FrtSlimEntities db = new FrtSlimEntities())
            {
                var listaVentas = from v in db.detalleVentas
                                    select new
                                    {
                                        ID = v.idDetalleVentas,
                                        Cantidad = v.cantidad,
                                        IdProducto = v.idProducto,
                                        Fecha = v.fecha,
                                        Total = v.Total
                                      


                                    };

                dataGridView1.DataSource = listaVentas.ToList();
            }
        }
    }
}

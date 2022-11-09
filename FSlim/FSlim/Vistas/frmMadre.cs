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
using FSlim.Vistas;

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
            
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmLogin SalirLogin = new frmLogin();
            SalirLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FrmProductos());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("H:mm:ss");
            Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FrmVentas());

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FrmProveedores());
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FrmRegistros());
        }

        private void AbrirFormhijo(object formhijo)
        {
            if (this.panel6.Controls.Count > 0)
                this.panel6.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel6.Controls.Add(fh);
            this.panel6.Tag = fh;
            fh.Show();


       
        }
    }
}

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
            FrmProductos MostrarPro = new FrmProductos();
            MostrarPro.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.Show();
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show();  
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FrmRegistros frmRegistros = new FrmRegistros();
            frmRegistros.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSlim.Vistas;
using FSlim.Models;

namespace FSlim
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            using (FrtSlimEntities db = new FrtSlimEntities())
            {
                var Login = (from l in db.Usuario where txtUsuario.Text == l.correo && txtPassword.Text == l.pass select l).FirstOrDefault();

                if (Login != null)
                {
                    MessageBox.Show("Bienvenido " + Login.nombre);
                    frmMadre frmMadre = new frmMadre();
                    frmMadre.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
         
                }
                

            }
          
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = string.Empty;
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;


            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado;
            string claveIngresada;
            usuarioIngresado = txb_usuario.Text;
            claveIngresada = txb_clave.Text;

            AccesoBaseDeDatos accesoBaseDeDatos = new AccesoBaseDeDatos();
            Usuario auxUsuario = accesoBaseDeDatos.ObtenerUsuario(usuarioIngresado, claveIngresada);
            if (auxUsuario != null)
            {
                MenuPrincipal frm_menuPrincipal = new MenuPrincipal(auxUsuario);
                frm_menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                lbl_error.Text = "Datos Incorrectos";
            }
        }
        private void btn_autocompletar_Click(object sender, EventArgs e)
        {
            txb_usuario.Text = "MReinoso";
            txb_clave.Text = "CorreoArg";
        }
    }
}

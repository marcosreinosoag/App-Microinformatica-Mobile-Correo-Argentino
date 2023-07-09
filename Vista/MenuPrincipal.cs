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
    public partial class MenuPrincipal : Form
    {
        Usuario usuario;
        public MenuPrincipal(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void mnt_crearTicket_Click(object sender, EventArgs e)
        {
            Ticket frm_menuPrincipal = new Ticket("Roto",usuario);
            frm_menuPrincipal.Show();
            this.Hide();
        }
    }
}

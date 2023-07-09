using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class DatosEquipo : Form
    {
        Dispositivo dispositivo;
        string serie;
        string opcion;
        public DatosEquipo(string opcion,string serie)
        {
            InitializeComponent();
            this.opcion = opcion;
            this.serie = serie;
        }
        private void DatosEquipo_Load(object sender, EventArgs e)
        {
            txb_serie.Text = this.serie;
            txb_serie.Enabled = false;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            switch(opcion)
            {
                case "Alta":
                    
                    break;
                case "Modificar":

                    break;
                    
            }
        }

        //private void btn_guardar_Click(object sender, EventArgs e)
        //{
        //    if (ValidarDatos(txb_im.Text, txb_contacto.Text, txb_piezaDeEnvio.Text, auxUbicacion, equipoUno, lineaUno) == 6)
        //    {
        //        if (reposicionEquipo && reposicionLinea)
        //        {
        //            if (ValidarDatos(lineaDos) == 1 & ValidarDatos(equipoDos) == 2)
        //            {
        //                HabilitarMenuTrip(true);
        //                auxTicket = new Ticket(txb_im.Text, txb_contacto.Text, txb_piezaDeEnvio.Text, equipoUno, lineaUno, equipoDos, lineaDos);
        //            }
        //        }
                
        //    }
        //}
    }
}

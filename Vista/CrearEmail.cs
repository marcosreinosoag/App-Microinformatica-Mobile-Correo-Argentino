using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class CrearEmail : Form
    {
        Entidades.Ticket ticket;
        DateTime fechaActual = DateTime.Now;
        bool reposicionDeLinea;
        bool reposicionDeEquipo;
        public CrearEmail(Entidades.Ticket ticket, bool reposicionEquipo, bool reposicionLinea)
        {
            InitializeComponent();
            this.ticket = ticket;
            this.reposicionDeEquipo = reposicionEquipo;
            this.reposicionDeLinea = reposicionLinea;
        }
        private void CrearEmail_Load(object sender, EventArgs e)
        {
            RedactarEmail();
        }

        private void RedactarEmail()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DevolverSaludo(fechaActual.Hour) + ticket.Destinatario + " paso a informar la reposición " + DevolverTextoReposicion(reposicionDeEquipo, reposicionDeLinea) + " detallada en el ticket del asunto.");

            if (reposicionDeEquipo == false && reposicionDeLinea == true)
            {
                sb.AppendLine();
                sb.AppendLine("Equipo : " + ticket.Equipo1);
                sb.AppendLine();
                sb.AppendLine("Linea anterior : ");/////);
                sb.AppendLine("Linea nueva : ");/////);
            }
            else
            {
                sb.AppendLine();
                sb.AppendLine("Equipo anterior: " + ticket.Equipo1);
                sb.AppendLine("Equipo nuevo: " + ticket.Equipo2);
                sb.AppendLine();
                if (ticket.LineaDos != null)
                {
                    sb.AppendLine("Linea anterior : ");/////);
                    sb.AppendLine("Linea nueva : ");/////);
                }
                else
                {
                    sb.AppendLine("Se mantiene línea.");
                }
            }
            sb.AppendLine();
            sb.AppendLine("Se envía bajo: " + ticket.PiezaDeEnvio);
            sb.AppendLine();
            sb.AppendLine("Se informa que deberá responder este mail con copia a todos los presentes a modo de firma, con el mismo formulario adjunto, y en el cuerpo del mail su conformidad para poder asentar la reasignación.");
            sb.AppendLine("Ej: \" recibí el equipo y coincide con los datos del formulario, envío mi conformidad y el formulario adjunto\"");
            sb.AppendLine();
            sb.AppendLine("Atte:");

            txb_email.Text = sb.ToString();
        }
        private string DevolverTextoReposicion(bool reposicionEquipo, bool reposicionLinea)
        {
            string auxTexto = "de la linea y del equipo";
            if (reposicionEquipo == false && reposicionLinea == true)
            {
                auxTexto = "de la linea del equipo";
            }
            else if (reposicionEquipo == true && reposicionLinea == false)
            {
                auxTexto = "del equipo";
            }
            return auxTexto;
        }
        private string DevolverSaludo(int hora)
        {
            string auxSaludo = "Buenos dias ";
            if (hora > 12)
            {
                auxSaludo = "Buenas tardes ";
            }
            return auxSaludo;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CrearEmail_Load_1(object sender, EventArgs e)
        {
            RedactarEmail();
        }

    }
}

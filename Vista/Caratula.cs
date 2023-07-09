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
    public partial class Caratula : Form
    {
        Ubicacion ubicacion;
        Entidades.Ticket ticket;
        public Caratula(Entidades.Ticket ticket, Ubicacion ubicacion)
        {
            this.ticket = ticket;
            this.ubicacion = ubicacion;
            InitializeComponent();
        }
        private void Caratula_Load(object sender, EventArgs e)
        {
            DescripcionCaratula();
            LlenarCampos();
        }
        private void LlenarCampos()
        {
            txb_destino.Text = ubicacion.Provincia + ", " + ubicacion.NombreSucursal;
            txb_codPlanta.Text = ubicacion.CodPlanta;
            txb_direccion.Text = ubicacion.Direccion;
            txb_codPostal.Text = ubicacion.CodPostal;
            txb_destinatario.Text = ticket.Destinatario;
            txb_ticket.Text = ticket.Im;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontTitulo = new Font("Arial", 14, FontStyle.Underline);
            Font fontDatos = new Font("Arial", 14, FontStyle.Bold);
            Font fontTitulo2 = new Font("Arial", 12, FontStyle.Underline);
            Font fontAdicional = new Font("Arial", 10, FontStyle.Bold);

            e.Graphics.DrawString(lbl_destino.Text, fontTitulo, Brushes.Black, new RectangleF(10, 5, 0, 20));
            e.Graphics.DrawString(lbl_codPlanta.Text, fontTitulo, Brushes.Black, new RectangleF(10, 30, 0, 20));
            e.Graphics.DrawString(lbl_direccion.Text, fontTitulo, Brushes.Black, new RectangleF(10, 60, 0, 20));
            e.Graphics.DrawString(lbl_codPostal.Text, fontTitulo, Brushes.Black, new RectangleF(10, 90, 0, 20));
            e.Graphics.DrawString(lbl_destinatario.Text, fontTitulo, Brushes.Black, new RectangleF(10, 120, 0, 20));
            e.Graphics.DrawString(lbl_ticket.Text, fontTitulo, Brushes.Black, new RectangleF(10, 150, 0, 20));

            e.Graphics.DrawString(txb_destino.Text, fontDatos, Brushes.Black, new RectangleF(90, 5, 0, 20));
            e.Graphics.DrawString(txb_codPlanta.Text, fontDatos, Brushes.Black, new RectangleF(175, 30, 0, 20));
            e.Graphics.DrawString(txb_direccion.Text, fontDatos, Brushes.Black, new RectangleF(105, 60, 0, 20));
            e.Graphics.DrawString(txb_codPostal.Text, fontDatos, Brushes.Black, new RectangleF(60, 90, 0, 20));
            e.Graphics.DrawString(txb_destinatario.Text, fontDatos, Brushes.Black, new RectangleF(130, 120, 0, 20));
            e.Graphics.DrawString(txb_ticket.Text, fontDatos, Brushes.Black, new RectangleF(75, 150, 0, 20));

            e.Graphics.DrawString(lbl_division.Text, fontDatos, Brushes.Black, new RectangleF(10, 160, 0, 20));
            e.Graphics.DrawString(lbl_division.Text, fontDatos, Brushes.Black, new RectangleF(10, 170, 0, 20));

            e.Graphics.DrawString(lbl_remitente.Text, fontTitulo2, Brushes.Black, new RectangleF(10, 195, 0, 20));
            e.Graphics.DrawString(lbl_descripcion.Text, fontAdicional, Brushes.Black, new RectangleF(10, 220, 0, 60));

            e.Graphics.DrawString(lbl_subCuenta.Text, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new RectangleF(10, 285, 0, 20));
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
        private void DescripcionCaratula()
        {
            lbl_descripcion.Text = "Microinformática Mobile" + Environment.NewLine + "Soporte al Cliente de TIC" + Environment.NewLine + "Dirección de Tecnología de la Información y Comunicaciones."
            + Environment.NewLine + "Int. 1178-1188-1153-1196" + Environment.NewLine + "Av. Fair 1101 – Nivel 6.70 Oeste (B1842ZAC) – Monte Grande - Bs. As.  - Argentina";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class Ticket : Form
    {
        Usuario usuario;
        Entidades.Ticket auxTicket;
        Ubicacion auxUbicacion;
        Dispositivo equipoUno;
        Dispositivo equipoDos;
        LineaTelefonica lineaUno;
        LineaTelefonica lineaDos;
        bool reposicionLinea;
        bool reposicionEquipo;
        string situacion;
        public Ticket(string situacion, Usuario auxUsuario)
        {
            this.usuario = auxUsuario;
            InitializeComponent();
            this.situacion = situacion;
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            grbx_linea2.Visible = false;
            grbx_equipo2.Visible = false;
            CargarCmb();
        }
        private void CargarCmb()
        {
            cmb_prestadora1.Items.Clear();
            cmb_prestadora1.Items.Add("Movistar");
            cmb_prestadora1.Items.Add("Personal");
            cmb_prestadora1.Items.Add("Claro AR");

            cmb_prestadora2.Items.Clear();
            cmb_prestadora2.Items.Add("Movistar");
            cmb_prestadora2.Items.Add("Personal");
            cmb_prestadora2.Items.Add("Claro AR");

            cmb_areaUbicacion.Items.Clear();
            cmb_areaUbicacion.Items.Add(EArea.Interior);
            cmb_areaUbicacion.Items.Add(EArea.Metro);
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-Seleccionando los botones del menu de la parte superior vera la informacion correspondiente \n2-realice doble click sobre el vuelo que desea ingresar\n3-aprete el boton Salir para finalizar el programa");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.reposicionLinea = false;
            grbx_linea2.Visible = false;
            btn_errorLinea2.Visible = false;
            if (chbx_reposicionLinea.Checked == true)
            {
                this.reposicionLinea = true;
                grbx_linea2.Visible = true;
            }
        }
        private void chbx_reposicionEquipo_CheckedChanged(object sender, EventArgs e)
        {
            this.txb_falla.Visible = false;
            this.reposicionEquipo = false;
            grbx_equipo2.Visible = false;
            btn_errorFalla.Visible = false;
            btn_errorEquipo2.Visible = false;
            if (chbx_reposicionEquipo.Checked == true)
            {
                this.txb_falla.Visible = true;
                this.reposicionEquipo = true;
                grbx_equipo2.Visible = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ValidarDatos(txb_im.Text, txb_contacto.Text, txb_piezaDeEnvio.Text, auxUbicacion, equipoUno, lineaUno);
            if (reposicionEquipo && reposicionLinea)
            {
                if (ValidarDatos(lineaDos) == 1 & ValidarDatos(equipoDos) == 2)
                {
                    HabilitarBotonesSecundarios(true);
                    auxTicket = new Entidades.Ticket(txb_im.Text, txb_contacto.Text, txb_piezaDeEnvio.Text, auxUbicacion, equipoUno, lineaUno, equipoDos, situacion);
                }
            }
            if (reposicionEquipo && !reposicionLinea)
            {
                if (ValidarDatos(equipoDos) == 2)
                {
                    HabilitarBotonesSecundarios(true);
                    auxTicket = new Entidades.Ticket(txb_im.Text, txb_contacto.Text, txb_piezaDeEnvio.Text, auxUbicacion, equipoUno, lineaUno, equipoDos, situacion);
                }
            }
            if (!reposicionEquipo && reposicionLinea)
            {
                if (ValidarDatos(lineaDos) == 1)
                {
                    HabilitarBotonesSecundarios(true);
                    auxTicket = new Entidades.Ticket(txb_im.Text, txb_contacto.Text, txb_piezaDeEnvio.Text, auxUbicacion, equipoUno, lineaUno, lineaDos, situacion);
                }
            }
        }
        private void HabilitarBotonesSecundarios(bool estado)
        {
            btn_caratula.Enabled = estado;
            btn_email.Enabled = estado;
            btn_planillas.Enabled = estado;
        }
        private int ValidarDatos(string im, string contacto, string pieza, Ubicacion ubicacion, Dispositivo equipo, LineaTelefonica linea1)
        {
            HabilitarBotonesSecundarios(false);
            int retorno = 6;
            this.btn_errorIm.Visible = false;
            this.btn_errorCodPlanta.Visible = false;
            this.btn_errorContacto.Visible = false;
            this.btn_errorPiezaEnvio.Visible = false;
            this.btn_errorFalla.Visible = false;
            this.btn_errorEquipo1.Visible = false;
            this.btn_errorEquipo2.Visible = false;
            this.btn_errorLinea1.Visible = false;
            this.btn_errorLinea2.Visible = false;

            if (Validar.ValidarString(im) == null)
            {
                retorno -= 1;
                this.btn_errorIm.Visible = true;
            }
            if (Validar.ValidarStringSoloLetras(contacto) == null)
            {
                this.btn_errorContacto.Visible = true;
                retorno -= 1;
            }
            if (Validar.ValidarString(pieza) == null)
            {
                retorno -= 1;
                this.btn_errorPiezaEnvio.Visible = true;
            }
            if (ubicacion == null)
            {
                retorno -= 1;
                this.btn_errorCodPlanta.Visible = true;
            }
            if (equipoUno == null)
            {
                retorno -= 1;
                this.btn_errorEquipo1.Visible = true;
            }
            if (lineaUno == null)
            {
                retorno -= 1;
                this.btn_errorLinea1.Visible = true;
            }
            return retorno;
        }
        private int ValidarDatos(Dispositivo equipo2)
        {
            int retorno = 2;

            this.btn_errorEquipo2.Visible = false;

            if (equipo2 == null)
            {
                retorno -= 1;
                this.btn_errorEquipo2.Visible = true;
            }
            if (txb_falla.Text == "")
            {
                retorno -= 1;
                this.btn_errorFalla.Visible = true;
            }
            return retorno;
        }
        private int ValidarDatos(LineaTelefonica linea2)
        {
            int retorno = 1;
            this.btn_errorLinea2.Visible = false;
            if (linea2 == null)
            {
                this.btn_errorLinea2.Visible = true;
                retorno -= 1;
            }
            return retorno;
        }
        private void bmt_generarPlantillas_Click(object sender, EventArgs e)
        {
            grbx_equipo1.Visible = false;
            grbx_equipo2.Visible = false;
            grbx_linea2.Visible = false;
            grbx_linea1.Visible = false;
            chbx_reposicionLinea.Visible = false;
            chbx_reposicionEquipo.Visible = false;
            lbl_filtrar.Visible = false;
        }

        private void btn_buscarEquipo1_Click(object sender, EventArgs e)
        {
            AccesoBaseDeDatos accesoBaseDeDatos = new AccesoBaseDeDatos();
            if (txb_serie1.Text != txb_serie2.Text && txb_serie1.Text != "")
            {
                try
                {
                    Dispositivo auxDispositivo = accesoBaseDeDatos.ObtenerDispositivo(txb_serie1.Text);
                    if (auxDispositivo != null)
                    {
                        txb_id1.Text = auxDispositivo.Id;
                        txb_imei1.Text = auxDispositivo.Imei;
                        txb_serie1.Enabled = false;
                        txb_modelo1.Text = auxDispositivo.Marca + " " + auxDispositivo.Modelo;
                        txb_modelo1.Enabled = false;
                        equipoUno = auxDispositivo;
                        txb_linea1.Text = auxDispositivo.Numero;
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Desea ingresar el equipo?", "ERROR!! Serie incorrecto", buttons, MessageBoxIcon.Error);
                        if (DialogResult.Yes == result)
                        {

                        }
                    }
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBox.Show("Error critico, consulte con soporte", "ERROR!!", buttons, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_buscarEquipo2_Click(object sender, EventArgs e)
        {
            AccesoBaseDeDatos accesoBaseDeDatos = new AccesoBaseDeDatos();
            Dispositivo auxDispositivo = accesoBaseDeDatos.ObtenerDispositivo(txb_serie2.Text);

            txb_id2.Text = auxDispositivo.Id;
            txb_imei2.Text = auxDispositivo.Imei;
            txb_serie2.Enabled = false;
            txb_modelo2.Text = auxDispositivo.Marca + " " + auxDispositivo.Modelo;
            txb_modelo2.Enabled = false;
            equipoDos = auxDispositivo;
        }
        private void btn_buscarUbicacion_Click(object sender, EventArgs e)
        {
            AccesoBaseDeDatos accesoBaseDeDatos = new AccesoBaseDeDatos();
            try
            {
                Ubicacion ubicacion = accesoBaseDeDatos.ObtenerUbicacion(txb_codPlantaSuc.Text);
                txb_codPostalSuc.Text = ubicacion.CodPostal;
                txb_direccionSuc.Text = ubicacion.Direccion;
                txb_nombreSuc.Text = ubicacion.NombreSucursal;
                txb_codPlantaSuc.Enabled = false;
                btn_buscarUbicacion.Enabled = false;
                this.auxUbicacion = ubicacion;
            }
            catch
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Desea ingresar la ubicacion?", "ERROR!!, Ubicacion incorrecta", buttons, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarEquipo1_Click(object sender, EventArgs e)
        {
            LimpiarDatosEquipoUno();
            equipoUno = null;
        }
        private void LimpiarDatosEquipoUno()
        {
            txb_id1.Text = "";
            txb_imei1.Text = "";
            txb_serie1.Text = "";
            txb_modelo1.Text = "";
            txb_serie1.Enabled = true;
            btn_buscarEquipo1.Enabled = true;
        }
        private void LimpiarDatosEquipoDos()
        {
            txb_id2.Text = "";
            txb_imei2.Text = "";
            txb_serie2.Text = "";
            txb_modelo2.Text = "";
            txb_serie2.Enabled = true;
            btn_buscarEquipo2.Enabled = true;
        }
        private void LimpiarDatosLineaUno()
        {
            txb_linea1.Text = "";
            txb_icid1.Text = "";
            txb_linea1.Enabled = true;
            btn_BuscarLinea1.Enabled = true;
        }
        private void LimpiarDatosLineaDos()
        {
            txb_linea2.Text = "";
            txb_icid2.Text = "";
            txb_linea2.Enabled = true;
            btn_BuscarLinea2.Enabled = true;
        }
        private void LimpiarDatosUbicacion()
        {
            txb_codPlantaSuc.Text = "";
            txb_codPostalSuc.Text = "";
            txb_direccionSuc.Text = "";
            txb_nombreSuc.Text = "";
            btn_buscarUbicacion.Enabled = true;
        }
        private void LimpiarDatosticket()
        {
            txb_im.Text = "";
            txb_contacto.Text = "";
            txb_piezaDeEnvio.Text = "";
        }
        private void btn_limpiarTicket_Click(object sender, EventArgs e)
        {
            LimpiarDatosticket();
        }
        private void btn_limpiarUbicacion_Click(object sender, EventArgs e)
        {
            LimpiarDatosUbicacion();
            txb_codPlantaSuc.Enabled = true;
            auxUbicacion = null;
        }
        private void btn_limpiarLinea1_Click(object sender, EventArgs e)
        {
            LimpiarDatosLineaUno();
            lineaUno = null;
        }
        private void btn_limpiarLinea2_Click(object sender, EventArgs e)
        {
            LimpiarDatosLineaDos();
            lineaDos = null;
        }

        private void btn_limpiarEquipoDos_Click(object sender, EventArgs e)
        {
            LimpiarDatosEquipoDos();
            equipoDos = null;
        }

        private void btn_BuscarLinea1_Click(object sender, EventArgs e)
        {
            AccesoBaseDeDatos accesoBaseDeDatos = new AccesoBaseDeDatos();
            if (txb_linea1.Text != "")
            {
                try
                {
                    LineaTelefonica auxLinea = accesoBaseDeDatos.ObtenerLinea(txb_linea1.Text);
                    txb_icid1.Text = auxLinea.IcId;
                    txb_icid1.Enabled = false;
                    txb_linea1.Enabled = false;
                    lineaUno = auxLinea;
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Desea ingresar la linea?", "ERROR!! linea incorrecta", buttons, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_BuscarLinea2_Click(object sender, EventArgs e)//simplificar////////////////////con 1
        {
            AccesoBaseDeDatos accesoBaseDeDatos = new AccesoBaseDeDatos();
            if (txb_linea2.Text != "")
            {
                try
                {
                    LineaTelefonica auxLinea = accesoBaseDeDatos.ObtenerLinea(txb_linea2.Text);
                    txb_icid2.Text = auxLinea.IcId;
                    txb_icid2.Enabled = false;
                    txb_linea2.Enabled = false;
                    lineaDos = auxLinea;
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Desea ingresar la linea?", "ERROR!! linea incorrecta", buttons, MessageBoxIcon.Error);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            CrearEmail frm_email = new CrearEmail(auxTicket, this.reposicionEquipo, this.reposicionLinea);
            resultado = frm_email.ShowDialog();
        }
        private void btn_caratula_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            Caratula frm_caratula = new Caratula(this.auxTicket, this.auxUbicacion);
            resultado = frm_caratula.ShowDialog();
        }
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            AccesoBaseDeDatos accesoBaseDeDatos = new AccesoBaseDeDatos();
            try
            {
                accesoBaseDeDatos.ModificarEquipo(equipoUno);//sea un cambio de linea o repo cambia
                if (reposicionEquipo)
                {
                    equipoUno.Estado = "Garantia";
                    equipoDos.Estado = "EnUso";
                    equipoUno.Numero = null;
                    if (reposicionLinea)
                    {
                        equipoDos.Numero = lineaDos.Numero;
                    }
                    else
                    {
                        equipoDos.Numero = lineaUno.Numero;
                    }
                    accesoBaseDeDatos.AgregarAPlanillaRotoRobado(equipoUno, lineaUno, auxUbicacion, auxTicket, DateTime.Now.Date, usuario);
                    accesoBaseDeDatos.AgregarGarantia(auxTicket, equipoUno, txb_falla.Text, DateTime.Now.Date, usuario);
                    accesoBaseDeDatos.ModificarEquipo(equipoDos);
                }
                else
                {
                    equipoUno.Numero = lineaDos.Numero;
                }
            }
            catch
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Error general, favor de contactarse con el administrador", "ERROR!!", buttons, MessageBoxIcon.Error);
            }
        }
        private void btn_limpiarLinea2_Click_1(object sender, EventArgs e)
        {
            LimpiarDatosLineaDos();
        }
        private void btn_limpiarEquipo1_Click_1(object sender, EventArgs e)
        {
            LimpiarDatosEquipoUno();
            equipoUno = null;
        }
    }
}

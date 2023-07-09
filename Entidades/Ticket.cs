using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticket
    {
        string im;
        string destinatario;
        string piezaDeEnvio;
        DateTime fecha;
        Dispositivo equipoUno;
        Dispositivo equipoDos;
        Ubicacion ubicacion;
        LineaTelefonica lineaUno;
        LineaTelefonica lineaDos;
        string situacion;

        public Ticket(string im, string destinatario, string piezaDeEnvio,Ubicacion ubicacion,Dispositivo equipoUno, LineaTelefonica lineaUno, string situacion)
        {
            this.im = im;
            this.destinatario = destinatario;
            this.piezaDeEnvio = piezaDeEnvio;
            this.ubicacion = ubicacion;
            this.equipoUno = equipoUno;
            this.lineaUno = lineaUno;
            this.situacion = situacion;
            fecha = DateTime.Now;
        }
        public Ticket(string im, string destinatario, string piezaDeEnvio, Ubicacion ubicacion, Dispositivo equipoUno, LineaTelefonica lineaUno, Dispositivo equipoDos,string situacion) : this(im, destinatario, piezaDeEnvio, ubicacion,equipoUno, lineaUno,situacion)
        {
            this.equipoDos = equipoDos;
        }
        public Ticket(string im, string destinatario, string piezaDeEnvio, Ubicacion ubicacion, Dispositivo equipoUno, LineaTelefonica lineaUno, LineaTelefonica lineaDos, string situacion) : this(im, destinatario, piezaDeEnvio, ubicacion, equipoUno, lineaUno, situacion)
        {
            this.lineaDos = lineaDos;
        }
        public Ticket(string im, string destinatario, string piezaDeEnvio, Ubicacion ubicacion, Dispositivo equipoUno, LineaTelefonica lineaUno, Dispositivo equipoDos, LineaTelefonica lineaDos, string situacion) : this(im, destinatario, piezaDeEnvio, ubicacion, equipoUno, lineaUno, situacion)
        {
            this.equipoDos = equipoDos;
        }
        public string Im { get => im; }
        public string Destinatario { get => destinatario; }
        public string Equipo1 { get => equipoUno.Id; }
        public string Equipo2 { get => equipoDos.Id; }
        public string PiezaDeEnvio { get => piezaDeEnvio; }
        public string Situacion { get => situacion; }
        public Ubicacion Ubicacion { get => ubicacion; }
        public LineaTelefonica LineaUno { get => lineaUno; }
        public LineaTelefonica LineaDos { get => lineaDos; }
    }
}



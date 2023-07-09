using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EArea
    {
        Interior,
        Metro,
    }
    public enum EProvincia
    {
        BuenosAires,
        LaPampa,
        Misiones,
        Cordoba,
        Formosa,
        EntreRios,
        Corrientes,
        LaRioja,
        Catamarca,
        Jujuy,
        Salta,
        Mendoza,
        Chaco,
        SantaFe,
        SanJuan,
        TierraDelFuego,
        Chubut,
        RioNegro,
        Neuquen,
        Tucuman,
        SantiagoDelEstero,
        SantaCruz,
        SanLuis,
    }
    public class Ubicacion
    {
        string nombreSucursal;
        string codPlanta;
        string direccion;
        string codPostal;
        string provincia;
        string zona;

        public Ubicacion(string nombreSucursal, string codPlanta, string direccion, string provincia, string codPostal, string zona)
        {
            this.nombreSucursal = nombreSucursal;
            this.codPlanta = codPlanta;
            this.direccion = direccion;
            this.provincia = provincia;
            this.codPostal = codPostal;
            this.zona = zona;
        }
        public string NombreSucursal { get => nombreSucursal; }
        public string CodPlanta { get => codPlanta; }
        public string Direccion { get => direccion; }
        public string CodPostal { get => codPostal; }
        public string Provincia { get => provincia; }
        public string Zona { get => zona; }
    }
}

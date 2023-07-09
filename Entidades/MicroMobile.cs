using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class MicroMobile
    {
        public static List<Dispositivo> listaDeDispositivos;
        public static List<Usuario> listaDeUsuarios;
        public static List<Ticket> listaDeVuelos;
        public static List<Ubicacion> listaUbicacion;

        static MicroMobile()
        {
            listaDeDispositivos = new List<Dispositivo>();
        }

        
    }
}

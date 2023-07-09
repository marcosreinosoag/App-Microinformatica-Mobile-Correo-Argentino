using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        string usuario;
        string nombre;
        string apellido;
        string permiso;
        //permisos

        public Usuario(string usuario, string nombre, string apellido, string permiso)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.permiso = permiso;
        }
        public string NombreUsuario
        {
            get { return this.usuario; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return apellido; }
        }
        public string Permiso
        {
            get { return permiso; }
        }
        public override string ToString()
        {
            return usuario.ToString();
        }

        public override bool Equals(object obj)
        {
            Usuario persona = obj as Usuario;
            if (persona is not null)
            {
                return persona.usuario == this.usuario;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (usuario).GetHashCode();
        }
    }
}

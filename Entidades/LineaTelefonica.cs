using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LineaTelefonica
    {
        string numero;
        string icId;
        string compania;

        public LineaTelefonica(string numero, string icId, string compania)
        {
            this.numero = numero;
            this.icId = icId;
            this.compania = compania;
        }

        public string Numero { get => numero; }
        public string IcId { get => icId; }
        public string Compania { get => compania; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dispositivo
    {
        string id;
        string marca;
        string numero;
        string modelo;
        string imei;
        string serie;
        string estado;

        public Dispositivo(string id, string numero, string imei, string serie, string marca, string modelo, string estado)
        {
            this.id = id;
            this.numero = numero;
            this.imei = imei;
            this.marca = marca;
            this.modelo = modelo;
            this.serie = serie;
            this.estado = estado;
        }
        public string Id { get => id; }
        public string Marca { get => marca; }
        public string Numero
        {
            get => numero;
            set => numero = value;
        }
        public string Modelo { get => modelo; }
        public string Imei { get => imei; }
        public string Serie { get => serie; }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }
    }
}

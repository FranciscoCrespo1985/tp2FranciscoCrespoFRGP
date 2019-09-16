using Dominio;
using System;

namespace Dominio
{
    public class Marca
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public Marca() { }
        public Marca(int id,string descripcion) { this.id = id;this.descripcion = descripcion;  }
        public override string ToString()
        {
            return descripcion;
        }
    }
}

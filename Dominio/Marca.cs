using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Marca
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public Marca() {; }
        public Marca(int id, string descripcion) { this.id = id; this.descripcion = descripcion; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}

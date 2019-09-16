using Dominio;
using System;


namespace Dominio
{
    public class Categoria
    {

        public int id { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public Categoria() {; }
        public Categoria(int id, string descripcion) { this.id = id; this.descripcion = descripcion; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}

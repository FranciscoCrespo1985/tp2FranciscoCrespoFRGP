using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string Imagen { get; set; }

        public float Precio { get; set; }
        public bool Estado { get; set; }

        
    }
}

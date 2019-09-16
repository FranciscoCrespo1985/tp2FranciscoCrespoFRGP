using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
using System.Data.SqlClient;
namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlDataReader lector;
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            Categoria aux;
            try
            {
                cn.ConnectionString = "data source=Paco-PC ; initial catalog=CATALOGO_DB; integrated security=sspi";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "Select Id, Descripcion From Categorias";
                cm.Connection = cn;
                cn.Open();
                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Categoria((int)lector["Id"], (string)lector["Descripcion"]);
                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw;
            }


        }

    }
}


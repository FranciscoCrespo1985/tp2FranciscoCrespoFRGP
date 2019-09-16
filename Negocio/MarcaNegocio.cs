using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
using System.Data.SqlClient;
namespace Negocio
{
    public class MarcaNegocio
    {


        public List<Marca> listar() {
            List<Marca> lista = new List<Marca>();
            SqlDataReader lector;
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            Marca aux;
            try
            {
                cn.ConnectionString = "data source=Paco-PC ; initial catalog=CATALOGO_DB; integrated security=sspi";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "Select Id, Descripcion From Marcas";
                cm.Connection = cn;
                cn.Open();
                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Marca((int)lector["Id"], (string)lector["Descripcion"]);
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dominio;


namespace Negocio
{
    public class ArticuloNegocio
    {




        public List<Articulo> listar()
            
            {
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=Paco-PC ; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "SELECT a.Id,a.Codigo,a.Nombre,a.Descripcion,a.IdMarca,a.IdCategoria,a.Imagen,a.Precio,m.descripcion as Marca,c.descripcion as Categoria,a.estado FROM ARTICULOS as a"
                                       + " inner join marcas as m on m.id = a.idmarca" 
                                       + " inner join categorias as c on c.id = a.idcategoria  where a.estado=1";
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Id = lector.GetInt32(0);
                    aux.Codigo = lector.GetString(1);
                    aux.Nombre = lector.GetString(2);
                    aux.Descripcion = lector.GetString(3);
                    aux.Marca.id = lector.GetInt32(4);
                    aux.Categoria.id = lector.GetInt32(5);
                    aux.Imagen = lector.GetString(6);                     
                    aux.Precio = (float)lector.GetDecimal(7); 
                    aux.Marca.descripcion = lector.GetString(8);
                    aux.Categoria.descripcion = lector.GetString(9);

                    lista.Add(aux);


                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                conexion.Close();                
            }
            return lista;

            }
        public void AgregarArticulo (Articulo articulo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=Paco-PC ; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "Insert into ARTICULOS values(@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Imagen,@Precio,1)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulo.Marca.id);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.id);
                comando.Parameters.AddWithValue("@Imagen", articulo.Imagen);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex )
            {

                throw ex;
            }
            
            



        }

        public void eliminar(int id)
        {
            AccesoDatosNegocio datos = new AccesoDatosNegocio();
            try
            {
                datos.setearQuery("update articulos set estado=0 from articulos where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Articulo articulo)
        {

            AccesoDatosNegocio datos = new AccesoDatosNegocio();
            try
            {
                datos.setearQuery("Update Articulos set Nombre=@Nombre,Codigo=@Codigo,Descripcion=@Descripcion,IdMarca=@IdMarca,IdCategoria=@IdCategoria, imagen=@imagen,precio=@precio  Where Id=@Id");
                datos.agregarParametro("@Nombre", articulo.Nombre);
                datos.agregarParametro("@Id", articulo.Id);
                datos.agregarParametro("@Codigo", articulo.Codigo);
                datos.agregarParametro("@Descripcion", articulo.Descripcion);
                datos.agregarParametro("@IdCategoria", articulo.Categoria.id);
                datos.agregarParametro("@IdMarca", articulo.Marca.id);
                datos.agregarParametro("@Imagen", articulo.Imagen);
                datos.agregarParametro("@Precio", articulo.Precio);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

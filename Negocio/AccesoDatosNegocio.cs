﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Negocio
{
    class AccesoDatosNegocio
    {
        public SqlDataReader lector { get; set; }
        public SqlConnection conexion { get; }
        public SqlCommand comando { get; set; }

        public AccesoDatosNegocio()
        {
            conexion = new SqlConnection("data source=Paco-PC; initial catalog=Catalogo_DB; integrated security=sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }
        public void setearQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }
        public void setearSP(string sp)
        {

        }

        public void agregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarLector()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // conexion.Close();
            }
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        internal void ejecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using CapaEntidades;

namespace CapaDatos
{
    public class D_Pasajeros 
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings ["tangobus"].ConnectionString);
        

        public DataTable Mostrartegistros()
        {
            DataTable Dtresultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spmostrar_pasajeros", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(Dtresultado);

            return Dtresultado;

        }

        public DataTable BuscarRegistros(string textobuscar)
        {
            DataTable Dtresultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spbuscar_pasajeros", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(Dtresultado);

            return Dtresultado;
        }

        public void InsertarRegistros(E_Pasajeros pasajeros)
        {
            SqlCommand SqlCmd = new SqlCommand("spinsertar_pasajeros", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();


            SqlCmd.Parameters.AddWithValue("@apellidos", pasajeros.Apellidos);
            SqlCmd.Parameters.AddWithValue("@nombres", pasajeros.Nombres);
            SqlCmd.Parameters.AddWithValue("@dni", pasajeros.Dni);
            SqlCmd.Parameters.AddWithValue("@nacionalidad", pasajeros.Nacionalidad);
            SqlCmd.Parameters.AddWithValue("@mayor", pasajeros.Mayor);
            SqlCmd.Parameters.AddWithValue("@ascenso", pasajeros.Ascenso);
            SqlCmd.Parameters.AddWithValue("@telefonos", pasajeros.Telefonos);
            SqlCmd.Parameters.AddWithValue("@grupo", pasajeros.Grupo);
            SqlCmd.Parameters.AddWithValue("@fecha", pasajeros.Fecha);
            SqlCmd.Parameters.AddWithValue("@destino", pasajeros.Destino);

            SqlCmd.ExecuteNonQuery();
            conectar.Close();
        }



        public void EditarRegistros(E_Pasajeros pasajeros)
        {
            SqlCommand SqlCmd = new SqlCommand("speditar_pasajeros", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            
            SqlCmd.Parameters.AddWithValue("@idpasajeros", pasajeros.IdPasajeros);
            SqlCmd.Parameters.AddWithValue("@apellidos", pasajeros.Apellidos);
            SqlCmd.Parameters.AddWithValue("@nombres", pasajeros.Nombres);
            SqlCmd.Parameters.AddWithValue("@dni", pasajeros.Dni);
            SqlCmd.Parameters.AddWithValue("@nacionalidad", pasajeros.Nacionalidad);
            SqlCmd.Parameters.AddWithValue("@mayor", pasajeros.Mayor);
            SqlCmd.Parameters.AddWithValue("@ascenso", pasajeros.Ascenso);
            SqlCmd.Parameters.AddWithValue("@telefonos", pasajeros.Telefonos);
            SqlCmd.Parameters.AddWithValue("@grupo", pasajeros.Grupo);
            SqlCmd.Parameters.AddWithValue("@fecha", pasajeros.Fecha);
            SqlCmd.Parameters.AddWithValue("@destino", pasajeros.Destino);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();

        }


        public void EliminarRegistros(E_Pasajeros pasajeros)
        {
            SqlCommand SqlCmd = new SqlCommand("speliminar_pasajeros", conectar)
            {
                CommandType = CommandType.StoredProcedure

            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@idpasajeros", pasajeros.IdPasajeros);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
using System.Data;

namespace ProyectoVenta
{
    class AccesoDatos
    {
        public string cadenaConexion = "Data Source=BDINVENTARIO.db; Version=3;";
        public SQLiteConnection Conexion = new SQLiteConnection();

        public void Conectar()
        {
            try
            {
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();
            }
            catch (SQLiteException ex)
            {
                Trace.WriteLine(ex.Message);
                throw;
            }
        
        
        }

        public void Desconectar()
        {
            try
            {
               
                Conexion.Close();
            }
            catch (SQLiteException ex)
            {
                Trace.WriteLine(ex.Message);
                throw;
            }


        }
        public DataSet ConsultarDatos(string cadenaSql)
        {
            DataSet resultado = new DataSet();
            try
            {
                Conectar();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cadenaSql, Conexion);
                adaptador.Fill(resultado);
            }
            catch (SQLiteException ex)
            {

                Trace.WriteLine(ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return resultado;
        
        }









    }
}

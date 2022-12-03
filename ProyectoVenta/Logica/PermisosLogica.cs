using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Logica
{
    public class PermisosLogica
    {
        private static PermisosLogica _instancia = null;

        public PermisosLogica()
        {

        }
        public static PermisosLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new PermisosLogica();
                return _instancia;
            }
        }
        public Permisos Obtener(int idpermisos)
        {
            Permisos obj = new Permisos();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select IdPermisos,Descripcion,Productos,Inventario,Configuracion from PERMISOS where IdPermisos = @pid";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pid", idpermisos));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Permisos()
                            {
                                IdPermisos = int.Parse(dr["IdPermisos"].ToString()),
                                Descripcion = dr["Descripcion"].ToString(),
                                Productos = int.Parse(dr["Productos"].ToString()),
                                Inventario = int.Parse(dr["Inventario"].ToString()),
                                Configuracion = int.Parse(dr["Configuracion"].ToString())
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obj = new Permisos();
            }
            return obj;
        }
        public int Guardar(Permisos objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PERMISOS SET");
                    query.AppendLine("Productos = @pproducto,");
                    query.AppendLine("Inventario = @pinventario,");
                    query.AppendLine("Configuracion = @pconfiguracion");
                    query.AppendLine("where IdPermisos = @pid;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pproducto", objeto.Productos));
                    cmd.Parameters.Add(new SQLiteParameter("@pinventario", objeto.Inventario));
                    cmd.Parameters.Add(new SQLiteParameter("@pconfiguracion", objeto.Configuracion));
                    cmd.Parameters.Add(new SQLiteParameter("@pid", objeto.IdPermisos));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo actualizar los permisos";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}

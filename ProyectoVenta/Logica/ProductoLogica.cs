using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoVenta.Logica
{
    public class ProductoLogica
    {
        private static ProductoLogica _instancia = null;

        public ProductoLogica()
        {

        }

        public static ProductoLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new ProductoLogica();
                return _instancia;
            }
        }
        public int Guardar(Producto objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("insert into PRODUCTO(Nombre,Fecha,Categoria,Cantidad) values (@pnombre,@pfecha,@pcategoria,@pcantidad);");
                    query.AppendLine("select last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnombre", objeto.Nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@pfecha", objeto.Fecha));
                    cmd.Parameters.Add(new SQLiteParameter("@pcategoria", objeto.Categoria));
                    cmd.Parameters.Add(new SQLiteParameter("@pcantidad", objeto.Cantidad));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta < 1)
                        mensaje = "No se pudo registrar el producto";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }
        public int Editar(Producto objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update PRODUCTO set Nombre = @pNombre,Fecha = @pFecha, Categoria=@pcategoria ,Cantidad = @pcantidad where IdProducto = @pidproducto");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pidproducto", objeto.IdProducto));
                    cmd.Parameters.Add(new SQLiteParameter("@pnombre", objeto.Nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@pfecha", objeto.Fecha));
                    cmd.Parameters.Add(new SQLiteParameter("@pcategoria", objeto.Categoria));
                    cmd.Parameters.Add(new SQLiteParameter("@pcantidad", objeto.Cantidad));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo editar el producto";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }
        public int Eliminar(int id)
        {
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("delete from PRODUCTO where IdProducto= @id;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));
                    cmd.CommandType = System.Data.CommandType.Text;
                    respuesta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
            }

            return respuesta;
        }
        public List<Producto> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Producto> oLista = new List<Producto>();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select IdProducto,Nombre,Fecha,Categoria,Cantidad from PRODUCTO;";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Producto()
                            {
                                IdProducto = int.Parse(dr["IdProducto"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                Fecha = dr["Fecha"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Producto>();
                mensaje = ex.Message;
            }


            return oLista;
        }
    }
}

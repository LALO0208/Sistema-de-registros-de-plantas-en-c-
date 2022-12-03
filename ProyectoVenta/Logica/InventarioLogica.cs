using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Logica
{
    public class InventarioLogica
    {
        private static InventarioLogica _instancia = null;

        public InventarioLogica()
        {

        }
        public static InventarioLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new InventarioLogica();
                return _instancia;
            }
        }
    }
}

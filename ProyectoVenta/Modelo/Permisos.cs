using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Modelo
{
    public class Permisos
    {
        public int IdPermisos { get; set; }
        public string Descripcion { get; set; }
        public int Productos { get; set; }
        public int Inventario { get; set; }
        public int Configuracion { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Modelo
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Categoria { get; set; }
        public string Cantidad { get; set; }
        //public int Stock { get; set; }
        //public string PrecioVenta { get; set; }
    }
}

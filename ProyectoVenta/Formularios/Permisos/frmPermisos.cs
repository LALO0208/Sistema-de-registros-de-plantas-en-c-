using ProyectoVenta.Logica;
using ProyectoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVenta.Formularios.Permisos
{
    public partial class frmPermisos : Form
    {
        public frmPermisos()
        {
            InitializeComponent();
        }

        private void btnguardaradministrador_Click(object sender, EventArgs e)
        {
                int _a_productos = 0;
                int _a_inventario = 0;
                int _a_configuracion = 0;

                if (a_productos.Checked)
                    _a_productos = 1;

                if (a_inventario.Checked)
                    _a_inventario = 1;

                if (a_configuracion.Checked)
                    _a_configuracion = 1;


                string mensaje = string.Empty;

                int operaciones = PermisosLogica.Instancia.Guardar(new Modelo.Permisos()
                {
                    IdPermisos = 1,
                    Productos = _a_productos,
                    Inventario = _a_inventario,
                    Configuracion = _a_configuracion
                }, out mensaje);

                if (operaciones < 1)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void btnguardarempleados_Click(object sender, EventArgs e)
        {
            int _e_productos = 0;
            int _e_inventario = 0;
            int _e_configuracion = 0;

            if (e_productos.Checked)
                _e_productos = 1;

            if (e_inventario.Checked)
                _e_inventario = 1;

            if (e_configuracion.Checked)
                _e_configuracion = 1;


            string mensaje = string.Empty;

            int operaciones = PermisosLogica.Instancia.Guardar(new Modelo.Permisos()
            {
                IdPermisos = 2,
                Productos = _e_productos,
                Inventario = _e_inventario,
                Configuracion = _e_configuracion
            }, out mensaje);

            if (operaciones < 1)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            Modelo.Permisos padmin = PermisosLogica.Instancia.Obtener(1);
            Modelo.Permisos pemple = PermisosLogica.Instancia.Obtener(2);

            a_productos.Checked = padmin.Productos == 1 ? true : false;
            a_inventario.Checked = padmin.Inventario == 1 ? true : false;
            a_configuracion.Checked = padmin.Configuracion == 1 ? true : false;

            e_productos.Checked = pemple.Productos == 1 ? true : false;
            e_inventario.Checked = pemple.Inventario == 1 ? true : false;
            e_configuracion.Checked = pemple.Configuracion == 1 ? true : false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

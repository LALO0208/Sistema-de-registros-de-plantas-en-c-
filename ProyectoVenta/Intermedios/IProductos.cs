using ProyectoVenta.Formularios;
using ProyectoVenta.Formularios.Agregar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoVenta.Intermedios
{
    public partial class IProductos : Form
    {
        public Form FormularioVista { get; set; }
        public IProductos()
        {
            InitializeComponent();
        }

        private void IProductos_Load(object sender, EventArgs e)
        {

        }
        private void btnvolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregarproductos_Click_1(object sender, EventArgs e)
        {
            FormularioVista = new frmRegistrarProducto();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

using ProyectoVenta.Herramientas;
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
using BarcodeLib;
using System.IO;

namespace ProyectoVenta.Formularios.Agregar
{
    public partial class frmRegistrarProducto : Form
    {
        private static int _id = 0;
        private static int _indice = 0;
        public frmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (txtnombre.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar el codigo";
                lblresultado.ForeColor = Color.Red;
                return;
            }
            if (txtfecha.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar la descripción";
                lblresultado.ForeColor = Color.Red;
                return;
            }

            Producto obj = new Producto()
            {
                IdProducto = _id,
                Nombre = txtnombre.Text,
                Fecha = txtfecha.Text,
                Categoria = txtcategoria.Text,
                Cantidad = txtcantidad.Text
            };



            if (_id == 0)
            {

                int idgenerado = ProductoLogica.Instancia.Guardar(obj, out mensaje);
                if (idgenerado > 0)
                {
                    Limpiar();
                    dgvdata.Rows.Add(new object[] { idgenerado, "", obj.Nombre, obj.Fecha, obj.Categoria, obj.Cantidad });
                    lblresultado.Text = "Registro Correcto";
                    lblresultado.ForeColor = Color.Green;
                }
                else
                {
                    lblresultado.Text = mensaje;
                    lblresultado.ForeColor = Color.Red; ;
                }
            }
            else
            {

                int afectados = ProductoLogica.Instancia.Editar(obj, out mensaje);
                if (afectados > 0)
                {
                    dgvdata.Rows[_indice].Cells["NombrePlanta"].Value = obj.Nombre;
                    dgvdata.Rows[_indice].Cells["Fecha"].Value = obj.Fecha;
                    dgvdata.Rows[_indice].Cells["Categoria"].Value = obj.Categoria;
                    dgvdata.Rows[_indice].Cells["Cantidad"].Value = obj.Cantidad;
                    Limpiar();
                    lblresultado.Text = "Modificación Correcta";
                    lblresultado.ForeColor = Color.Green;
                }
                else
                {
                    lblresultado.Text = mensaje;
                    lblresultado.ForeColor = Color.Red;
                }
            }
        }
        private void Limpiar(bool vista = true)
        {
            txtnombre.BackColor = Color.White;
            txtfecha.BackColor = Color.White;
            txtcategoria.BackColor = Color.White;
            txtcantidad.BackColor = Color.White;
            if (vista)
            {
                if (dgvdata.Rows.Count > 0)
                {
                    dgvdata.Rows[_indice].DefaultCellStyle.BackColor = Color.White;
                }
            }
            _id = 0;
            _indice = 0;
            txtnombre.Text = "";
            txtfecha.Text = "";
            txtcategoria.Text = "";
            txtcantidad.Text = "";
            lblresultado.Text = "";

            txtnombre.Focus();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int respuesta = ProductoLogica.Instancia.Eliminar(_id);
                    if (respuesta > 0)
                    {
                        dgvdata.Rows.RemoveAt(_indice);
                        Limpiar(false);
                    }
                    else
                        MessageBox.Show("No se pudo eliminar el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobuscar.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
        //cambios
        private void frmRegistrarProducto_Load(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            List<Producto> lista = ProductoLogica.Instancia.Listar(out mensaje);

            foreach (Producto pr in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    pr.IdProducto,
                    "",
                    pr.Nombre,
                    pr.Fecha,
                    pr.Categoria,
                    pr.Cantidad
                });
            }
            Limpiar();

            foreach (DataGridViewColumn cl in dgvdata.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnseleccionar")
                {
                    cbobuscar.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
                {
                    dgvdata.Rows[_indice].DefaultCellStyle.BackColor = Color.White;

                    _id = Convert.ToInt32(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                    _indice = index;
                    txtnombre.Text = dgvdata.Rows[index].Cells["NombrePlanta"].Value.ToString();
                    txtfecha.Text = dgvdata.Rows[index].Cells["Fecha"].Value.ToString();
                    txtcategoria.Text = dgvdata.Rows[index].Cells["Categoria"].Value.ToString();
                    txtcantidad.Text = dgvdata.Rows[index].Cells["Cantidad"].Value.ToString();

                    txtnombre.BackColor = Color.LemonChiffon;
                    txtfecha.BackColor = Color.LemonChiffon;
                    txtcategoria.BackColor = Color.LemonChiffon;
                    txtcantidad.BackColor = Color.LemonChiffon;
                    dgvdata.Rows[index].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }

            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check16.Width;
                var h = Properties.Resources.check16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar !=(char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("INGRESE SOLAMENTE LETRAS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("INGRESE SOLAMENTE LETRAS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO NUMEROS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}


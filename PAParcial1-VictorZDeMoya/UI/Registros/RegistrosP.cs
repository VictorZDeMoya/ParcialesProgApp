using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAParcial1_VictorZDeMoya.BLL;
using PAParcial1_VictorZDeMoya.Entidades;

namespace PAParcial1_VictorZDeMoya.UI.Registros
{
    public partial class RegistrosP : Form
    {
        public RegistrosP()
        {
            InitializeComponent();
        }

        private void LlenarCampos(Producto producto)
        {
            IdPicker.Value = producto.IdProducto;
            DescripcionTBox.Text = producto.Descripcion;
            ExistenciaTBox.Text = producto.Existencia.ToString();
            ValorInvTBox.Text = producto.ValorInv.ToString();
            CostoTBox.Text = producto.Costo.ToString();
        }

        private Producto LlenarClases()
        {
            Producto producto = new Producto();
            producto.IdProducto = Convert.ToInt32(IdPicker.Value);
            producto.Descripcion = DescripcionTBox.Text;
            producto.Costo = Convert.ToSingle(CostoTBox.Text);
            producto.Existencia = Convert.ToInt32(ExistenciaTBox.Text);
            producto.ValorInv = Convert.ToSingle(ValorInvTBox.Text);
            return producto;
        }

        private void Limpiar()
        {
            IdPicker.Value = 0;
            DescripcionTBox.Text = string.Empty;
            CostoTBox.Text = string.Empty;
            ExistenciaTBox.Text = string.Empty;
            ValorInvTBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private bool ExisteEnLaDB()
        {
            Producto producto = ProductosBLL.Buscar((int)IdPicker.Value);

            return (producto != null);
        }

        private bool ValidarG()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripcionTBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTBox, "Este Campo no puede estar vacio.");
                DescripcionTBox.Focus();
                paso = false;
            }
            if (CostoTBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CostoTBox, "Este Campo no puede estar vacio.");
                CostoTBox.Focus();
                paso = false;
            }
            if (ExistenciaTBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ExistenciaTBox, "Este Campo no puede estar vacio.");
                ExistenciaTBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ValidarE()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (IdPicker.Value == 0)
            {
                MyErrorProvider.SetError(IdPicker, "Primero busque el producto para luego eliminarlo.");
                IdPicker.Focus();
                paso = false;
            }
            return paso;
        }

        private void NuevoBTN_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarBTN_Click(object sender, EventArgs e)
        {
            Producto producto;

            bool paso = false;
            if (!ValidarG())
                return;

            producto = LlenarClases();


            if (IdPicker.Value == 0)

                paso = ProductosBLL.Guardar(producto);
            else
            {
                if (!ExisteEnLaDB())
                {
                    MessageBox.Show("No se puede guardar un producto no existente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ProductosBLL.Modificar(producto);
            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            if (!ValidarE())
                return;

            int id;
            int.TryParse(IdPicker.Text, out id);

            Limpiar();

            if (ProductosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MyErrorProvider.SetError(IdPicker, "No se puede eliminar un producto no existente");
        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            int id;
            Producto producto = new Producto();
            int.TryParse(IdPicker.Text, out id);

            Limpiar();

            producto = ProductosBLL.Buscar(id);

            if (producto != null)
            {
                MessageBox.Show("Producto Encontrado.");
                LlenarCampos(producto);
            }
            else
                MessageBox.Show("Producto no encontrado.");
        }

        private void ExistenciaTBox_TextChanged(object sender, EventArgs e)
        {

            if (CostoTBox.Text.Length > 0 && ExistenciaTBox.Text.Length > 0)
                ValorInvTBox.Text = Convert.ToString(Convert.ToSingle(CostoTBox.Text) * Convert.ToInt32(ExistenciaTBox.Text));

            if (CostoTBox.Text.Length > 0 && ExistenciaTBox.Text.Length == 0)
                ValorInvTBox.Text = "0.0";

            if (CostoTBox.Text.Length == 0 && ExistenciaTBox.Text.Length > 0)
                ValorInvTBox.Text = "0.0";

            if (CostoTBox.Text.Length == 0 && ExistenciaTBox.Text.Length == 0)
                ValorInvTBox.Text = "0.0";
        }

        private void CostoTBox_TextChanged(object sender, EventArgs e)
        {
            if (CostoTBox.Text.Length > 0 && ExistenciaTBox.Text.Length > 0)
                ValorInvTBox.Text = Convert.ToString(Convert.ToSingle(CostoTBox.Text) * Convert.ToInt32(ExistenciaTBox.Text));

            if (CostoTBox.Text.Length > 0 && ExistenciaTBox.Text.Length == 0)
                ValorInvTBox.Text = "0.0";

            if (CostoTBox.Text.Length == 0 && ExistenciaTBox.Text.Length > 0)
                ValorInvTBox.Text = "0.0";

            if (CostoTBox.Text.Length == 0 && ExistenciaTBox.Text.Length == 0)
                ValorInvTBox.Text = "0.0";


        }

        private void ExistenciaTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Digite números solamente", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CostoTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Digite números solamente", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

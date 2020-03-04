using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace ApplicationLayer
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void GuardarBD()
        {
            ClientesEntity cliente = new ClientesEntity();
            cliente.numero_documento = txtNumeroDocumento.Text;

            cliente.primer_nombre = txtPrimerNombre.Text;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private bool Validacion()
        {
            if (cmbTipoDocumento.SelectedIndex.Equals(-1)) 
            {
                MessageBox.Show("El tipo de documento es un dato " +
                "obligatorio", "Error de validación", MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
                cmbTipoDocumento.Focus();
                return false;
                
            }
        
            if(txtNumeroDocumento.Text == "")
            {
                MessageBox.Show("El núemero de documento es un dato " +
                "obligatorio", "Error de validación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtNumeroDocumento.Focus();
                return false;
            }
            if (txtPrimerNombre.Text == "")
            {
                MessageBox.Show("Este campo es obligatorio", "Error de validación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtPrimerNombre.Focus();
                return false;
            }
            if (txtSegudoNombre.Text == "")
            {
                MessageBox.Show("Este campo es obligatorio", "Error de validación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtSegudoNombre.Focus();
                return false;
            }
            if (txtPrimerApellido.Text == "")
            {
                MessageBox.Show("Este campo es obligatorio", "Error de validación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtPrimerApellido.Focus();
                return false;
            } if (txtSegundoApellido.Text == "")
            {
                MessageBox.Show("Este campo es obligatorio", "Error de validación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtSegundoApellido.Focus();
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Este campo es obligatorio", "Error de validación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtDireccion.Focus();
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Este campo es obligatorio", "Error de validación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            } if (txtEmail.Text == "")
            {
                MessageBox.Show("Este campo es obligatorio", "Error de validación", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) &&
                (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Ingrese únicamente números...", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}

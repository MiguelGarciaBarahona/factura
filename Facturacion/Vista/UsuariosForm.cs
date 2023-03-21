using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        string tipoOperacion;

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CodigoTextBox.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese Un Codigo");
                    CodigoTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese Un Nombre");
                    NombreTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(ContraseñaTextBox.Text))
                {
                    errorProvider1.SetError(ContraseñaTextBox, "Ingrese Una Contraseña");
                    ContraseñaTextBox.Focus();
                    return;
                }

                errorProvider1.Clear();
                if (string.IsNullOrEmpty(RolComboBox.Text))
                {
                    errorProvider1.SetError(RolComboBox, "Seleccione un Rol");
                    RolComboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                Usuario


                //insertar en la base de datos

            }
            else if (tipoOperacion == "Modificar")
            {

            }




        }

        private void HabilitarControles()
        {

            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ContraseñaTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            RolComboBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            AbjuntarFotoButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
        }

        private void DesabilitarControles()
        {

            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            ContraseñaTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            RolComboBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            AbjuntarFotoButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            ContraseñaTextBox.Clear();
            CorreoTextBox.Clear();
            RolComboBox.Text = string.Empty;
            EstaActivoCheckBox.Checked = false;
            FotoPictureBox.Image = null;

        }

        private void AbjuntarFotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog diagalofoto = new OpenFileDialog();
            DialogResult resultado = diagalofoto.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FotoPictureBox.Image = Image.FromFile(diagalofoto.FileName);
            }



        }
    }
}

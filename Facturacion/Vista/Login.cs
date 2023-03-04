using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese Un Usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ContraseñaTextBox.Text))
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese Una Contraseña");
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();


            //validar base de datos



            //mostramos el menu



            Menu menuFormulario = new Menu();
            this.Hide();
            menuFormulario.Show();





        }

        private void MostrarContraseñaButton_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0';
            }
            else
            {

                ContraseñaTextBox.PasswordChar = '*';
            }
        }
    }
}

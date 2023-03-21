using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripButton_Click(object sender, EventArgs e)
        {
            UsuariosForm UserForm = new UsuariosForm();
            UserForm.MdiParent = this;
            UserForm.Show();
        }

        private void ProductosToolStripButton_Click(object sender, EventArgs e)
        {
            ProductosForms productosForms = new ProductosForms();
            productosForms.MdiParent = this;
            productosForms.Show();
        }
    }
}

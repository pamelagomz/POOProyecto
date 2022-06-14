using System;
using System.Windows.Forms;

namespace V1ProyectoPOO.UserControls
{
    public partial class UC_Usuarios : UserControl
    {
        public UC_Usuarios()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrarUser.DataSource = null;
            dgvMostrarUser.DataSource = UsuarioDAO.MostrarUsuarios();
        }
    }
}
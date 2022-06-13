using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1ProyectoPOO
{
    public partial class frmBiblioteca : Form
    { 
        private Button currentButton;
        private int tempIndex;
        
        public frmBiblioteca()
        {
            InitializeComponent();
        }
        
        private void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button) btnSender)
                {
                    DisableButton();
                    currentButton = (Button) btnSender;
                    currentButton.BackColor = Color.Bisque;
                    currentButton.ForeColor = Color.Black;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in tlpMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(5, 29,64);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnColecciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
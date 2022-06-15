using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using V1ProyectoPOO.Properties;

namespace V1ProyectoPOO.UserControls
{
    public partial class UC_Inicio : UserControl
    {
        private List<Bitmap> ListaImagenes;
        public UC_Inicio()
        {
            InitializeComponent();

            ListaImagenes = new List<Bitmap>();
            ListaImagenes.Add(Resources.Conia);
            ListaImagenes.Add(Resources._3__1_);
        }

        private int contadorBanner = 0;
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (contadorBanner < ListaImagenes.Count)
            {
                pictureBox1.Image = ListaImagenes[contadorBanner];
                contadorBanner++;

                if (contadorBanner == ListaImagenes.Count)
                    contadorBanner = 0;
            }
        }
    }
}
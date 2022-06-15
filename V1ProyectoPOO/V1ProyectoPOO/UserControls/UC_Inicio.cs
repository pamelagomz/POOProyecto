using System;
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
                picBienvenido.Image = ListaImagenes[contadorBanner];
                contadorBanner++;

                if (contadorBanner == ListaImagenes.Count)
                    contadorBanner = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inicio));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picBienvenido = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picFeriaLibro = new System.Windows.Forms.PictureBox();
            this.picPlaneta = new System.Windows.Forms.PictureBox();
            this.picClubLectura = new System.Windows.Forms.PictureBox();
            this.picInvitacion = new System.Windows.Forms.PictureBox();
            this.picRedesSociales = new System.Windows.Forms.PictureBox();
            this.picNuevoLibro = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picBienvenido)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picFeriaLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picPlaneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picClubLectura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picInvitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picRedesSociales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picNuevoLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picBienvenido, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 138);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picBienvenido
            // 
            this.picBienvenido.Image = ((System.Drawing.Image) (resources.GetObject("picBienvenido.Image")));
            this.picBienvenido.Location = new System.Drawing.Point(3, 3);
            this.picBienvenido.Name = "picBienvenido";
            this.picBienvenido.Size = new System.Drawing.Size(561, 126);
            this.picBienvenido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBienvenido.TabIndex = 0;
            this.picBienvenido.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel2.Controls.Add(this.picFeriaLibro, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.picPlaneta, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.picClubLectura, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.picInvitacion, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.picRedesSociales, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.picNuevoLibro, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 132);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.36686F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.63314F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(567, 338);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // picFeriaLibro
            // 
            this.picFeriaLibro.Image = ((System.Drawing.Image) (resources.GetObject("picFeriaLibro.Image")));
            this.picFeriaLibro.Location = new System.Drawing.Point(392, 3);
            this.picFeriaLibro.Name = "picFeriaLibro";
            this.picFeriaLibro.Size = new System.Drawing.Size(172, 170);
            this.picFeriaLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFeriaLibro.TabIndex = 3;
            this.picFeriaLibro.TabStop = false;
            // 
            // picPlaneta
            // 
            this.picPlaneta.Image = ((System.Drawing.Image) (resources.GetObject("picPlaneta.Image")));
            this.picPlaneta.Location = new System.Drawing.Point(217, 3);
            this.picPlaneta.Name = "picPlaneta";
            this.picPlaneta.Size = new System.Drawing.Size(168, 170);
            this.picPlaneta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlaneta.TabIndex = 4;
            this.picPlaneta.TabStop = false;
            // 
            // picClubLectura
            // 
            this.picClubLectura.Image = ((System.Drawing.Image) (resources.GetObject("picClubLectura.Image")));
            this.picClubLectura.Location = new System.Drawing.Point(3, 3);
            this.picClubLectura.Name = "picClubLectura";
            this.picClubLectura.Size = new System.Drawing.Size(208, 170);
            this.picClubLectura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClubLectura.TabIndex = 2;
            this.picClubLectura.TabStop = false;
            // 
            // picInvitacion
            // 
            this.picInvitacion.Image = ((System.Drawing.Image) (resources.GetObject("picInvitacion.Image")));
            this.picInvitacion.Location = new System.Drawing.Point(392, 179);
            this.picInvitacion.Name = "picInvitacion";
            this.picInvitacion.Size = new System.Drawing.Size(172, 156);
            this.picInvitacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInvitacion.TabIndex = 0;
            this.picInvitacion.TabStop = false;
            // 
            // picRedesSociales
            // 
            this.picRedesSociales.Image = ((System.Drawing.Image) (resources.GetObject("picRedesSociales.Image")));
            this.picRedesSociales.Location = new System.Drawing.Point(217, 179);
            this.picRedesSociales.Name = "picRedesSociales";
            this.picRedesSociales.Size = new System.Drawing.Size(169, 156);
            this.picRedesSociales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRedesSociales.TabIndex = 5;
            this.picRedesSociales.TabStop = false;
            // 
            // picNuevoLibro
            // 
            this.picNuevoLibro.Image = ((System.Drawing.Image) (resources.GetObject("picNuevoLibro.Image")));
            this.picNuevoLibro.Location = new System.Drawing.Point(3, 179);
            this.picNuevoLibro.Name = "picNuevoLibro";
            this.picNuevoLibro.Size = new System.Drawing.Size(208, 156);
            this.picNuevoLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNuevoLibro.TabIndex = 1;
            this.picNuevoLibro.TabStop = false;
            // 
            // UC_Inicio
            // 
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Inicio";
            this.Size = new System.Drawing.Size(567, 473);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picBienvenido)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picFeriaLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picPlaneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picClubLectura)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picInvitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picRedesSociales)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picNuevoLibro)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picRedesSociales;

        private System.Windows.Forms.PictureBox picPlaneta;

        private System.Windows.Forms.PictureBox picFeriaLibro;

        private System.Windows.Forms.PictureBox picClubLectura;

        private System.Windows.Forms.PictureBox picNuevoLibro;

        private System.Windows.Forms.PictureBox picInvitacion;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.PictureBox picBienvenido;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
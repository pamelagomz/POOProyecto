using System.ComponentModel;

namespace V1ProyectoPOO.UserControls
{
    partial class UC_Inicio
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Ravie", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInicio.Location = new System.Drawing.Point(149, 95);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(452, 78);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Bienvenido ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(261, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ale Fer Clau y Pam";
            // 
            // UC_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInicio);
            this.Name = "UC_Inicio";
            this.Size = new System.Drawing.Size(781, 608);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblInicio;

        #endregion
    }
}
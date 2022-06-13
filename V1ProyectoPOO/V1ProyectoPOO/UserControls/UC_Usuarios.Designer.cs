using System.ComponentModel;

namespace V1ProyectoPOO.UserControls
{
    partial class UC_Usuarios
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
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Location = new System.Drawing.Point(328, 258);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(190, 127);
            this.lblUsuarios.TabIndex = 0;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // UC_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUsuarios);
            this.Name = "UC_Usuarios";
            this.Size = new System.Drawing.Size(781, 583);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblUsuarios;

        #endregion
    }
}
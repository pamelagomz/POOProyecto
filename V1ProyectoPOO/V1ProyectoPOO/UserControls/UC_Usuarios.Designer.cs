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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvMostrarUser = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Mostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Location = new System.Drawing.Point(316, 335);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(190, 127);
            this.lblUsuarios.TabIndex = 0;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Mostrar);
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(3, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 528);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agergar Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.btnMostrar);
            this.Mostrar.Controls.Add(this.dgvMostrarUser);
            this.Mostrar.Location = new System.Drawing.Point(4, 34);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(3);
            this.Mostrar.Size = new System.Drawing.Size(730, 490);
            this.Mostrar.TabIndex = 2;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (5)))), ((int) (((byte) (29)))), ((int) (((byte) (64)))));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrar.Location = new System.Drawing.Point(461, 42);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(222, 45);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar lista de usuarios";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvMostrarUser
            // 
            this.dgvMostrarUser.AllowUserToDeleteRows = false;
            this.dgvMostrarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarUser.Location = new System.Drawing.Point(46, 108);
            this.dgvMostrarUser.Name = "dgvMostrarUser";
            this.dgvMostrarUser.RowTemplate.Height = 28;
            this.dgvMostrarUser.Size = new System.Drawing.Size(637, 356);
            this.dgvMostrarUser.TabIndex = 0;
            // 
            // UC_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblUsuarios);
            this.Name = "UC_Usuarios";
            this.Size = new System.Drawing.Size(781, 583);
            this.tabControl1.ResumeLayout(false);
            this.Mostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnMostrar;

        private System.Windows.Forms.DataGridView dgvMostrarUser;

        private System.Windows.Forms.TabPage Mostrar;

        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Label lblUsuarios;

        #endregion
    }
}
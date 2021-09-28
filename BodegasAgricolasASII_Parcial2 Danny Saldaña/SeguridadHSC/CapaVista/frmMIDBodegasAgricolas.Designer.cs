
namespace CapaVista
{
    partial class frmMIDBodegasAgricolas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMIDBodegasAgricolas));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignacionDeAplicacionAUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCambioContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mantenimientosToolStripMenuItem,
            this.asignacionesToolStripMenuItem1,
            this.btnCambioContraseña,
            this.btnBitacora,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 33);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.inicioToolStripMenuItem.Text = "Abrir";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 29);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.mantenimientosToolStripMenuItem.Text = "Catálogos";
            // 
            // asignacionesToolStripMenuItem1
            // 
            this.asignacionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAsignacionDeAplicacionAUsuarios});
            this.asignacionesToolStripMenuItem1.Name = "asignacionesToolStripMenuItem1";
            this.asignacionesToolStripMenuItem1.Size = new System.Drawing.Size(108, 29);
            this.asignacionesToolStripMenuItem1.Text = "Procesos";
            // 
            // btnAsignacionDeAplicacionAUsuarios
            // 
            this.btnAsignacionDeAplicacionAUsuarios.Name = "btnAsignacionDeAplicacionAUsuarios";
            this.btnAsignacionDeAplicacionAUsuarios.Size = new System.Drawing.Size(178, 30);
            this.btnAsignacionDeAplicacionAUsuarios.Text = "Compras";
            this.btnAsignacionDeAplicacionAUsuarios.Click += new System.EventHandler(this.btnAsignacionDeAplicacionAUsuarios_Click);
            // 
            // btnCambioContraseña
            // 
            this.btnCambioContraseña.Name = "btnCambioContraseña";
            this.btnCambioContraseña.Size = new System.Drawing.Size(101, 29);
            this.btnCambioContraseña.Text = "Informes";
            // 
            // btnBitacora
            // 
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(142, 29);
            this.btnBitacora.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // frmMIDBodegasAgricolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMIDBodegasAgricolas";
            this.Text = "frmBodegasAgricolas";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCambioContraseña;
        private System.Windows.Forms.ToolStripMenuItem btnBitacora;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnAsignacionDeAplicacionAUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}
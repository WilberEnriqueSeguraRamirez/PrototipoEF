
namespace Vista
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarTipoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCuentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.reporteCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1465, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCuentasToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // consultarCuentasToolStripMenuItem
            // 
            this.consultarCuentasToolStripMenuItem.Name = "consultarCuentasToolStripMenuItem";
            this.consultarCuentasToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.consultarCuentasToolStripMenuItem.Text = "Consultar Cuentas";
            this.consultarCuentasToolStripMenuItem.Click += new System.EventHandler(this.consultarCuentasToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCuentaToolStripMenuItem,
            this.modificarCuentaToolStripMenuItem,
            this.darDeBajaCuentaToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // ingresarCuentaToolStripMenuItem
            // 
            this.ingresarCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarTipoCuentaToolStripMenuItem,
            this.ingresarCuentaToolStripMenuItem1});
            this.ingresarCuentaToolStripMenuItem.Name = "ingresarCuentaToolStripMenuItem";
            this.ingresarCuentaToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ingresarCuentaToolStripMenuItem.Text = "Ingresar Cuenta";
            // 
            // ingresarTipoCuentaToolStripMenuItem
            // 
            this.ingresarTipoCuentaToolStripMenuItem.Name = "ingresarTipoCuentaToolStripMenuItem";
            this.ingresarTipoCuentaToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.ingresarTipoCuentaToolStripMenuItem.Text = "Ingresar Tipo Cuenta";
            this.ingresarTipoCuentaToolStripMenuItem.Click += new System.EventHandler(this.ingresarTipoCuentaToolStripMenuItem_Click);
            // 
            // ingresarCuentaToolStripMenuItem1
            // 
            this.ingresarCuentaToolStripMenuItem1.Name = "ingresarCuentaToolStripMenuItem1";
            this.ingresarCuentaToolStripMenuItem1.Size = new System.Drawing.Size(229, 26);
            this.ingresarCuentaToolStripMenuItem1.Text = "Ingresar Cuenta";
            this.ingresarCuentaToolStripMenuItem1.Click += new System.EventHandler(this.ingresarCuentaToolStripMenuItem1_Click);
            // 
            // modificarCuentaToolStripMenuItem
            // 
            this.modificarCuentaToolStripMenuItem.Name = "modificarCuentaToolStripMenuItem";
            this.modificarCuentaToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.modificarCuentaToolStripMenuItem.Text = "Modificar Cuenta";
            this.modificarCuentaToolStripMenuItem.Click += new System.EventHandler(this.modificarCuentaToolStripMenuItem_Click);
            // 
            // darDeBajaCuentaToolStripMenuItem
            // 
            this.darDeBajaCuentaToolStripMenuItem.Name = "darDeBajaCuentaToolStripMenuItem";
            this.darDeBajaCuentaToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.darDeBajaCuentaToolStripMenuItem.Text = "Dar de Baja Cuenta";
            this.darDeBajaCuentaToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaCuentaToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteCuentaToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(594, 9);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(0, 17);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(556, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(132, 22);
            this.txtUser.TabIndex = 4;
            // 
            // reporteCuentaToolStripMenuItem
            // 
            this.reporteCuentaToolStripMenuItem.Name = "reporteCuentaToolStripMenuItem";
            this.reporteCuentaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reporteCuentaToolStripMenuItem.Text = "Reporte Cuenta";
            this.reporteCuentaToolStripMenuItem.Click += new System.EventHandler(this.reporteCuentaToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 531);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "0901-18-13952 Wilber Segura ";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ToolStripMenuItem consultarCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarTipoCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCuentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCuentaToolStripMenuItem;
    }
}
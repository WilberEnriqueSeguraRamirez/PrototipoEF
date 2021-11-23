using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;

namespace Vista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUser.Text = form.usuario();
            }
            else
            {
                this.Close();
            } 
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUser.Text = form.usuario();
                this.Show();
            }
            else
            { this.Close(); }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresarTipoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoCuenta formulario = new frmTipoCuenta();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void ingresarCuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCuenta formulario = new frmCuenta();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void consultarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCuentas formulario = new frmConsultaCuentas();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void modificarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaA formulario = new frmConsultaA();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void darDeBajaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDarDeBaja formulario = new frmDarDeBaja();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void reporteCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte formulario = new Reporte();
            formulario.Show();
            formulario.MdiParent = this;
        }
    }
}

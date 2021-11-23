using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmConsultaA : Form
    {
        public frmConsultaA()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmModificarCuenta formulario = new frmModificarCuenta();
            formulario.consulta(txtId.Text);
            this.Hide();
            formulario.Show();
        }

        private void frmConsultaA_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class frmDarDeBaja : Form
    {
        CapaControlador cn = new CapaControlador();
        public frmDarDeBaja()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            actualizardatagriew("Cuenta");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = cn.llenarTbl2(tabla, txtBaja.Text);
            dvgTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTipo.DataSource = dt;

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            cn.bajaCuenta(txtBaja.Text);
        }
    }
}

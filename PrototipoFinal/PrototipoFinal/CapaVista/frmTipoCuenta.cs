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
    public partial class frmTipoCuenta : Form
    {
        CapaControlador cn = new CapaControlador();
        public frmTipoCuenta()
        {
            InitializeComponent();
            actualizardatagriew("tipocuenta");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = cn.llenarTbl(tabla);
            dvgTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTipo.DataSource = dt;

        }

        private void frmTipoCuenta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNom.Text;
            bool resultado = cn.ingresotipoCuenta(id, nombre);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("tipocuenta");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtId.Text = "";
            txtNom.Text = "";
        }
    }
}

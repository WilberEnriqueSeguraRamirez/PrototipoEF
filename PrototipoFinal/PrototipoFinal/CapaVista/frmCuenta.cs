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
    public partial class frmCuenta : Form
    {
        CapaControlador cn = new CapaControlador();
        public frmCuenta()
        {
            InitializeComponent();
            actualizardatagriew("cuenta");
        }
        public void actualizardatagriew(string tabla)
        {
            DataTable dt = cn.llenarTbl(tabla);
            dvgTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTipo.DataSource = dt;

        }
        private void bntEnviar_Click(object sender, EventArgs e)
        {
            bool resultado = cn.ingresoCuenta(txtID.Text, txtNom.Text, txtIdTc.Text,tstC.Text,txtA.Text,txtSa.Text);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("cuenta");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtID.Text = "";
            txtNom.Text = "";
            txtIdTc.Text = "";
            tstC.Text = "";
            txtA.Text = "";
            txtSa.Text = "";
        }
    }
}

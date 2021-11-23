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
    public partial class frmModificarCuenta : Form
    {
        CapaControlador cn = new CapaControlador();
        public frmModificarCuenta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void consulta (string id)
        {
            var arlist = cn.cnInd(id);
            txtId.Text = (string)arlist[0];
            txtNom.Text = (string)arlist[1];
            txtTc.Text = (string)arlist[2];
            txtCargo.Text = arlist[3].ToString();
            txtAbono.Text = arlist[4].ToString();
            txtSaldo.Text = arlist[5].ToString();
            txtEstado.Text = (string)arlist[6];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string id = txtId.Text;
            string nombre = txtNom.Text;
            bool resultado = cn.modificarCuenta(id, nombre, txtTc.Text, txtCargo.Text, txtAbono.Text, txtSaldo.Text, txtEstado.Text);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtId.Text = "";
            txtNom.Text = "";
            txtCargo.Text = "";
            txtAbono.Text = "";
            txtSaldo.Text = "";
            txtTc.Text = "";
            txtEstado.Text = "";
        }
    }
}

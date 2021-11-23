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
    public partial class frmConsultaCuentas : Form
    {
        CapaControlador cn = new CapaControlador();
        public frmConsultaCuentas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
                DataTable dt = cn.llenarTbl("cuenta");
                dvgTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgTipo.DataSource = dt;

            
        }
    }
}

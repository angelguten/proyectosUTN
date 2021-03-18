using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comprador;
using Vendedor;
using BibliotecaFerreteria;

namespace PantallaDeLoguin
{
    public partial class frmLoguin : Form
    {
        frmVendedor vendedor = new frmVendedor();
        frmComprador comprador = new frmComprador();

        

        public frmLoguin()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (rdbComprador.Checked == true)
            {
                //frmComprador comprador = new frmComprador();
                this.Hide();
                comprador.Show();
            }
            if (rdbVendedor.Checked == true)
            {
                //frmVendedor vendedor = new frmVendedor();
                this.Hide();
                vendedor.Show();
            }
            
        }

        private void frmLoguin_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
            vendedor.Hide();
            comprador.Hide();
        }

        private void rdbComprador_CheckedChanged(object sender, EventArgs e)
        {
            btnIngresar.Enabled = true;
        }

        private void rdbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            btnIngresar.Enabled = true;
        }

        private void btnCargarDatosDeInventario_Click(object sender, EventArgs e)
        {
           
           
           
        }
    }
}

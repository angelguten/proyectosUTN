using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class frmMiCalculadora : Form
    {
        //private string operador;

        public frmMiCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (frmMiCalculadora.Operar(this.txtNumero1.Text,this.txtNumero2.Text, cmbOperador.Text)).ToString();
        }
        private static double Operar(string numero1,string numero2, string operador)
        {
            double retorno = 0;

            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);

            retorno=Entidades.Calculadora.Operar(n1, n2, operador);

            return retorno;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero n1 = new Numero(txtNumero1.Text);
            lblResultado.Text = n1.BinarioDecimal(txtNumero1.Text);
        }
    }
}

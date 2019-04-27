using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_TP
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.N1 = Double.Parse(txtN1.Text);
            calc.N2 = Double.Parse(txtN2.Text);
            txtResultado.Text = Convert.ToString(calc.Mult());
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.N1 = Double.Parse(txtN1.Text);
            calc.N2 = Double.Parse(txtN2.Text);
            txtResultado.Text = Convert.ToString(calc.exp());
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.N1 = Double.Parse(txtN1.Text);
            calc.N2 = Double.Parse(txtN2.Text);
            txtResultado.Text = Convert.ToString(calc.Soma());

        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            //Instanciação
            Calculadora calc = new Calculadora();

            calc.N1 = Double.Parse(   txtN1.Text    );
            calc.N2 = Double.Parse(    txtN2.Text    );

            txtResultado.Text = Convert.ToString(calc.Subtrai());
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            
                Calculadora calc = new Calculadora();
            calc.N1 = Double.Parse(txtN1.Text);
            calc.N2 = Double.Parse(txtN2.Text);
         
                txtResultado.Text = Convert.ToString(calc.Div());
            
        }
    }
}

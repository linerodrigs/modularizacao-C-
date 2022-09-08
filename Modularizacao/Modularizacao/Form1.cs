using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modularizacao
{
    public partial class frmModularizacao : Form
    {
        public frmModularizacao()
        {
            InitializeComponent();
        }


        //Função retorna texto de dois valores textos informados
        public string SomarNumeros(string v1, string v2)
        {
            double valor1 = Convert.ToDouble(v1);
            double valor2 = Convert.ToDouble(v2);
            return (valor1 + valor2).ToString();
        }

        public string SubtrairNumeros(string v1, string v2)
        {
            double valor1 = Convert.ToDouble(v1);
            double valor2 = Convert.ToDouble(v2);
            return (valor1 - valor2).ToString();
        }

        public string DividirNumeros(string v1, string v2)
        {
            double valor1 = Convert.ToDouble(v1);
            double valor2 = Convert.ToDouble(v2);
            return (valor1 / valor2).ToString();
        }

        public string MultiplicarNumeros(string v1, string v2)
        {
            double valor1 = Convert.ToDouble(v1);
            double valor2 = Convert.ToDouble(v2);
            return (valor1 * valor2).ToString();
        }


        //criando procedimentos
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdbSomar.Checked)
            {
                string resultado = SomarNumeros(txtValor1.Text, txtValor2.Text);
                lblMsg.Text = resultado;
            }

            else if (rdbSubtrair.Checked)
            {
                string resultado = SubtrairNumeros(txtValor1.Text, txtValor2.Text);
                lblMsg.Text = resultado;
            }

            else if (rdbDividir.Checked)
            {
                string resultado = DividirNumeros(txtValor1.Text, txtValor2.Text);
                lblMsg.Text = resultado;
            }

            else
            {
                string resultado = MultiplicarNumeros(txtValor1.Text, txtValor2.Text);
                lblMsg.Text = resultado;
            }
        }
 

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = string.Empty;
            txtValor2.Text = string.Empty;
            rdbDividir.Checked = false;
            rdbSomar.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbSubtrair.Checked = false;
            lblMsg.Text = "";
        }
    }
}

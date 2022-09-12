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
        public string calcularQuadrado(string lado)
        {

            return MultiplicarNumeros(lado, lado);
        }

        public string calcularRetangulo(string basRetangulo, string altura)
        {
            return MultiplicarNumeros(basRetangulo, altura);
        }

        public string calcularTriangulo(string basTriangulo, string altura)
        {
            return DividirNumeros(MultiplicarNumeros(basTriangulo, altura), "2");
        }
        public string calcularCirculo(string raio)
        {
            return (Math.PI * Convert.ToDouble(MultiplicarNumeros(raio, raio))).ToString();
        }

        //criando procedimentos

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdbSomar.Checked)
            {
                string resultado = SomarNumeros(txtValor1.Text, txtValor2.Text);
                lblMensagem.Text = resultado;
            }

            else if (rdbSubtrair.Checked)
            {
                string resultado = SubtrairNumeros(txtValor1.Text, txtValor2.Text);
                lblMensagem.Text = resultado;
            }

            else if (rdbDividir.Checked)
            {
                string resultado = DividirNumeros(txtValor1.Text, txtValor2.Text);
                lblMensagem.Text = resultado;
            }

            else if(rdbMultiplicar.Checked)
            {
                string resultado = MultiplicarNumeros(txtValor1.Text, txtValor2.Text);
                lblMensagem.Text = resultado;
            }

            else if (rdbQuadrado.Checked)
            {
                lblMensagem.Text = calcularQuadrado(txtValor1.Text);
            }
            else if (rdbRetangulo.Checked)
            {
                string resposta = calcularRetangulo(txtValor1.Text, txtValor2.Text);
                lblMensagem.Text = resposta;
            }
            else if (rdbTriangulo.Checked)
            {
                string resposta = calcularTriangulo(txtValor1.Text, txtValor2.Text);
                lblMensagem.Text = resposta;
            }
            else if (rdbCirculo.Checked)
            {
                string resposta = calcularCirculo(txtValor1.Text);
                lblMensagem.Text = resposta;
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
            rdbQuadrado.Checked = false;
            rdbRetangulo.Checked = false;
            rdbTriangulo.Checked = false;
            rdbCirculo.Checked = false;
            lblMensagem.Text = "";
        }

        private void rdbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbQuadrado.Checked)
            {
                txtValor2.Visible = false;
                lblValor2.Visible = false; 
            }
            else 
            {
                txtValor2.Visible = true;
                lblValor2.Visible = true;
            }
        }

        private void rdbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCirculo.Checked)
            {
                txtValor2.Visible = false;
                lblValor2.Visible = false;
            }
            else
            {
                txtValor2.Visible = true;
                lblValor2.Visible = true;
            }
        }
    }
}

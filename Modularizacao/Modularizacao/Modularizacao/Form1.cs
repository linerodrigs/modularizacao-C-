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

        //Funcao retornar texto de dois valores textos informados

        //Soma

        public string SomarNumeros(string v1, string v2)
        {
            int valor1 = Convert.ToInt32(v1);
            int valor2 = Convert.ToInt32(v2);
            return (valor1 + valor2).ToString();

        }

        //Subtração
        public string SubtrairNumeros(string v1, string v2)
        {
            int valor1 = Convert.ToInt32(v1);
            int valor2 = Convert.ToInt32(v2);
            return (valor1 - valor2).ToString();

        }

        //Divisão
        public string DividirNumeros(string v1, string v2)
        {
            int valor1 = Convert.ToInt32(v1);
            int valor2 = Convert.ToInt32(v2);
            return (valor1 / valor2).ToString();

        }


        //Multiplicar
        public string MultiplicarNumeros (string v1, string v2)
        {
            int valor1 = Convert.ToInt32(v1);
            int valor2 = Convert.ToInt32(v2);
            return (valor1 * valor2).ToString();

        }


            











        //criando procedimento 
        public void LimparControles()
        {
            txtValor1.Text = string.Empty;
            txtValor2.Text = string.Empty;
            lblMensagem.Text = "";
        }


        private void btnSomar_Click(object sender, EventArgs e)
        {
            string resultado = SomarNumeros(txtValor1.Text, txtValor2.Text);
            lblMensagem.Text = resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparControles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparControles();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}

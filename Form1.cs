using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraC
{
    public partial class Form1 : Form
    {
        public decimal valor1 = 0;
        public decimal valor2 = 0;
        public decimal soma = 0;
        public string operacao = " ";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnUm_Click(object sender, EventArgs e)
        {
            tbResult.Text += "1";
            lbResult.Text = "";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            tbResult.Text += "2";
            lbResult.Text = "";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tbResult.Text += "3";
            lbResult.Text = "";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            tbResult.Text += "4";
            lbResult.Text = "";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tbResult.Text += "5";
            lbResult.Text = "";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            tbResult.Text += "6";
            lbResult.Text = "";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            tbResult.Text += "7";
            lbResult.Text = "";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            tbResult.Text += "8";
            lbResult.Text = "";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            tbResult.Text += "9";
            lbResult.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbResult.Text = " ";
            lbResult.Text = "Iniciar nova operação";
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            tbResult.Text = " ";
            lbResult.Text = "Iniciar nova operação";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(tbResult.Text, CultureInfo.InvariantCulture);
            tbResult.Text = "";
            operacao = "div";
            lbResult.Text = "Divisão";

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(tbResult.Text, CultureInfo.InvariantCulture);
            tbResult.Text = "";
            operacao = "mult";
            lbResult.Text = "Multiplicação";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(tbResult.Text, CultureInfo.InvariantCulture);
            tbResult.Text = "";
            operacao = "sub";
            lbResult.Text = "Subtração";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(tbResult.Text, CultureInfo.InvariantCulture);
            tbResult.Text = " ";
            operacao = "soma";
            lbResult.Text = "SOMA";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(tbResult.Text, CultureInfo.InvariantCulture);
            if (operacao == "soma")
            {
                decimal soma = valor1 + valor2;
                tbResult.Text = (soma.ToString());
                lbResult.Text = "O Resultado da soma é";
            }
            else if (operacao == "sub")
            {
                decimal soma = valor1 - valor2;
                tbResult.Text = (soma.ToString());
                lbResult.Text = "O Resultado da subtração é";
            }
            else if (operacao == "mult")
            {
                decimal soma = valor1 * valor2;
                tbResult.Text = (soma.ToString());
                lbResult.Text = "O Resultado da multiplicação é";
            }
            else if (operacao == "div")
            {
                decimal soma = valor1 / valor2;
                tbResult.Text = (soma.ToString());
                lbResult.Text = "O Resultado da divisão é";
            }
        }
        private void btnPonto_Click(object sender, EventArgs e)
        {
            tbResult.Text = ".";
            lbResult.Text = "";

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            tbResult.Text += "0";
            lbResult.Text = "";
        }
    }
}
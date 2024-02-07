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

namespace calculadoraCientificaPC
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        private string _operacao = "";
        private double _valor1 = 0;
        private double _valor2 = 0;
        private bool _novoNumero = true;
        private double _Memoria = 0;

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtVisor.Text = "";
                _novoNumero = false;
            }

            txtVisor.Text += ((Button)sender).Text;
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            _operacao = ((Button)sender).Text;
            _valor1 = double.Parse(txtVisor.Text, CultureInfo.CreateSpecificCulture("pt-BR"));
            _novoNumero = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            _valor2 = double.Parse(txtVisor.Text);

            double resultado = 0;

            switch (_operacao)
            {
                case "+":
                    resultado = _valor1 + _valor2;
                    break;
                case "-":
                    resultado = _valor1 - _valor2;
                    break;
                case "*":
                    resultado = _valor1 * _valor2;
                    break;
                case "/":
                    resultado = _valor1 / _valor2;
                    break;
                case "%":
                    resultado = _valor1 % _valor2;
                    break;
            }

            txtVisor.Text = resultado.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            _valor1 = 0;
            _valor2 = 0;
            _operacao = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!_novoNumero)
            {
                txtVisor.Text += ",";
            }

            _novoNumero = false;
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVisor.Text))
            {
                if (txtVisor.Text[0] == '-')
                {
                    txtVisor.Text = txtVisor.Text.Substring(1);
                }
                else
                {
                    txtVisor.Text = "-" + txtVisor.Text;
                }
            }
            btnOperacao_Click(sender, e);
        }

        private void FormCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            _Memoria = 0;

        }

        private void Mem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVisor.Text))
                _Memoria = double.Parse(txtVisor.Text);
            else
                _Memoria = 0;
        }

    }
}

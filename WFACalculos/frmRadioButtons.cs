using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFACalculos
{
    public partial class frmRadioButtons : Form
    {
        public frmRadioButtons()
        {
            InitializeComponent();
        }

        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "+";
        }

        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
        }

        private void rdbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "*";
        }

        private void rdbDividir_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
        }

        private void rdbPorcentagem_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "%";
        }

        private void rdbPotencia_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "^";
        }

        private void rdbComparar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "==";
        }

        private void rdbParImpar_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "P ou I";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                switch (lblSinal.Text)
                {
                    case "+":
                        lblResultado.Text = (double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text)).ToString();
                        break;

                    case "-":
                        lblResultado.Text = (double.Parse(txtNum1.Text) - double.Parse(txtNum2.Text)).ToString();
                        break;

                    case "*":
                        lblResultado.Text = (double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text)).ToString();
                        break;

                    case "/":
                        lblResultado.Text = (double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text)).ToString();
                        break;

                    case "%":
                        lblResultado.Text = (double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text) / 100).ToString();
                        break;

                    case "^":
                        lblResultado.Text = Math.Pow(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text)).ToString();
                        break;

                    case "==":
                        if ((double.Parse(txtNum1.Text) > double.Parse(txtNum2.Text)))
                            {
                                lblResultado.Text = (double.Parse(txtNum1.Text) + " Maior que " + double.Parse(txtNum2.Text).ToString());
                            }

                        else if ((double.Parse(txtNum1.Text) < double.Parse(txtNum2.Text)))
                            {
                                lblResultado.Text = (double.Parse(txtNum2.Text) + " Maior que " + double.Parse(txtNum1.Text).ToString());
                            }
                        else
                            {
                                lblResultado.Text = "Os números são iguais";
                            }
                        break;

                    case "P ou I":
                        double a, b, NumA, NumB;
                        a = double.Parse(txtNum1.Text);
                        b = double.Parse(txtNum2.Text);

                        NumA = a % 2;
                        NumB = b % 2;
                        lblSinal.Text = "I ou P";

                        if (NumA == 0 && NumB == 0)
                        {
                            lblResultado.Text = "Ambos os números são Par";
                        }
                        else if (NumA == 1 && NumB == 1)
                        {
                            lblResultado.Text = "Ambos os números são Impar";
                        }
                        else if (NumA == 0 && NumB == 1)
                        {
                            lblResultado.Text = a + " é Par e " + b + " é Impar";
                        }
                        else if (NumA == 1 && NumB == 0)
                        {
                            lblResultado.Text = a + " é Impar e " + b + " é Par";
                        }
                        break;

                    default:
                        lblResultado.Text = "?";
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblResultado.Text = "?";
            lblSinal.Text = "?";
            txtNum1.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

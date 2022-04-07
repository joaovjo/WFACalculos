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
    public partial class frmComBotoes : Form
    {
        public frmComBotoes()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = "+";

                lblResultado.Text = (double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text)).ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = "-";

                lblResultado.Text = (double.Parse(txtNum1.Text) - double.Parse(txtNum2.Text)).ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = "*";

                lblResultado.Text = (double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text)).ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = "/";

                lblResultado.Text = (double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text)).ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = "%";

                lblResultado.Text = (double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text) / 100).ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = "^";

                lblResultado.Text = Math.Pow(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text)).ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = "==";

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

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            try
            {
                lblSinal.Text = "P ou I";

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

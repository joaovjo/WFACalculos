using System;
using System.Windows.Forms;

namespace WFACalculos
{
    public partial class frmCalcOO : Form
    {
        public frmCalcOO()
        {
            InitializeComponent();
        }

        private void cmbOperacao_TextChanged(object sender, EventArgs e)
        {
            Classes.CalculadoraBasica objCalc = new Classes.CalculadoraBasica();

            switch (cmbOperacao.Text)
            {
                case "Somar":
                    {
                        try
                        {
                            objCalc.Num1 = double.Parse(txtNum1.Text);
                            objCalc.Num2 = double.Parse(txtNum2.Text);
                            objCalc.Adicao();//Executa o Método Adicao()
                            lblResultado.Text = objCalc.Adicao();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
                        }
                        break;
                    }

                case "Subtrair":
                    {
                        try
                        {
                            objCalc.Num1 = double.Parse(txtNum1.Text);
                            objCalc.Num2 = double.Parse(txtNum2.Text);
                            objCalc.Subtracao();//Executa o Método Subtrair()
                            lblResultado.Text = objCalc.Subtracao();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
                        }
                        break;
                    }

                case "Multiplicar":
                    {
                        try
                        {
                            objCalc.Num1 = double.Parse(txtNum1.Text);
                            objCalc.Num2 = double.Parse(txtNum2.Text);
                            objCalc.Multiplicacao();//Executa o Método multiplicar()
                            lblResultado.Text = objCalc.Multiplicacao();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
                        }
                        break;
                    }

                case "Dividir":
                    {
                        try
                        {
                            objCalc.Num1 = double.Parse(txtNum1.Text);
                            objCalc.Num2 = double.Parse(txtNum2.Text);
                            if (objCalc.Num2 == 0)
                            {
                                MessageBox.Show("O número divisor não pode ser zero! Insira outro número divisor!", "Erro!");
                                return;
                            }

                            objCalc.Divisao();//Executa o Método dividir()
                            lblResultado.Text = objCalc.Divisao();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
                        }
                        break;
                    }

                case "Porcentagem":
                    {
                        try
                        {
                            Classes.CalculadoraCientifica objCalcCient = new Classes.CalculadoraCientifica();
                            objCalcCient.Num1 = double.Parse(txtNum1.Text);
                            objCalcCient.Num2 = double.Parse(txtNum2.Text);

                            lblResultado.Text = objCalcCient.Porcentagem();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
                        }
                        break;
                    }


                case "Elevado a":
                    {
                        try
                        {
                            Classes.CalculadoraCientifica objCalcCient = new Classes.CalculadoraCientifica();
                            objCalcCient.Num1 = double.Parse(txtNum1.Text);
                            objCalcCient.Num2 = double.Parse(txtNum2.Text);

                            lblResultado.Text = objCalcCient.Potencia();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
                        }
                        break;
                    }
                case "Comparar":
                    {
                        try
                        {
                            Classes.CalculadoraCientifica objCalcCient = new Classes.CalculadoraCientifica();
                            objCalcCient.Num1 = double.Parse(txtNum1.Text);
                            objCalcCient.Num2 = double.Parse(txtNum2.Text);

                            lblResultado.Text = objCalcCient.Comparar();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
                        }
                        break;
                    }
                case "ParImpar":
                    {
                        try
                        {
                            Classes.CalculadoraCientifica objCalcCient = new Classes.CalculadoraCientifica();
                            objCalcCient.Num1 = double.Parse(txtNum1.Text);
                            objCalcCient.Num2 = double.Parse(txtNum2.Text);

                            lblResultado.Text = objCalcCient.ParImpar();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Informe apenas números e não deixe nenhum campo em branco!");
                        }
                        break;
                    }
            }
        }
    }
}

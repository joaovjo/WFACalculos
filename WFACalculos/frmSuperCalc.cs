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
    public partial class frmSuperCalc : Form
    {
        public frmSuperCalc()
        {
            InitializeComponent();
        }

        double vNumAnt;
        string vOperacao;
        bool vLimpar = false;
        bool Negativo;

        private void btnNumero_Click(object sender, EventArgs e)
        {
            string vNumero = ((Button)sender).Text;
            
            if (vLimpar)
            {
                lblVisor.Text = "";
                vLimpar = false;
            }
            //Limpa o visor se apenas "0"
            if (lblVisor.Text == "0")
                lblVisor.Text = "";
            if ((vNumero == "," && lblVisor.Text.Contains(",")) || vNumero != ",")
            {
                lblVisor.Text += vNumero; //Concatena o número ao lblVisor
            }

        }

        public void btnOperacao_Click(object sender, EventArgs e)
        {
            vOperacao = ((Button)sender).Text;
            vNumAnt = double.Parse(lblVisor.Text);
            vLimpar = true;
            if (Negativo == true)
            {
                vNumAnt = vNumAnt * (-1);
                lblVisor.Text = vNumAnt.ToString();
                Negativo = false;
            }

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double vNumAtual = double.Parse(lblVisor.Text);
            if (Negativo == true)
            {
                vNumAtual = vNumAtual * (-1);
                lblVisor.Text = vNumAtual.ToString();
                Negativo = false;
            }
            switch (vOperacao)
            {
                case "+":
                    {
                        lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                        vOperacao = "";
                        break;
                    }
                case "-":
                    {
                        lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                        vOperacao = "";
                        break;
                    }
                case "*":
                    {
                        lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                        vOperacao = "";
                        break;
                    }
                case "/":
                    {
                        lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                        vOperacao = "";
                        break;
                    }
                case "%":
                    {
                        lblVisor.Text = (vNumAnt * vNumAtual / 100).ToString();
                        vOperacao = "";
                        break;
                    }
                case "^":
                    {
                        lblVisor.Text = Math.Pow(vNumAnt, vNumAtual).ToString();
                        vOperacao = "";
                        break;
                    }
            }
        }

        public void btnNegativo_Click(object sender, EventArgs e)
        {
            Negativo = true;
          
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            vNumAnt = 0;
            vOperacao = "";
        }
    }
}

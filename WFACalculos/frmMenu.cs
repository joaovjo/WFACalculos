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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void comBotoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComBotoes objComBotoes = new frmComBotoes();
            objComBotoes.MdiParent = this;
            objComBotoes.Show();
        }

        private void radioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadioButtons objRadioButtons = new frmRadioButtons();
            objRadioButtons.MdiParent = this;
            objRadioButtons.Show();
        }

        private void superCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuperCalc objSuperCalc = new frmSuperCalc();
            objSuperCalc.MdiParent = this;
            objSuperCalc.Show();
        }

        private void calculadoraOOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcOO objCalcOO = new frmCalcOO();
            objCalcOO.MdiParent = this;
            objCalcOO.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

    }
}

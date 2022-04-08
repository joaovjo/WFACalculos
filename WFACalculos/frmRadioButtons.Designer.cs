namespace WFACalculos
{
    partial class frmRadioButtons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbOperacoes = new System.Windows.Forms.GroupBox();
            this.rdbParImpar = new System.Windows.Forms.RadioButton();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbComparar = new System.Windows.Forms.RadioButton();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbPorcentagem = new System.Windows.Forms.RadioButton();
            this.rdbPotencia = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOperacoes
            // 
            this.grbOperacoes.Controls.Add(this.rdbParImpar);
            this.grbOperacoes.Controls.Add(this.rdbSomar);
            this.grbOperacoes.Controls.Add(this.rdbSubtrair);
            this.grbOperacoes.Controls.Add(this.rdbComparar);
            this.grbOperacoes.Controls.Add(this.rdbDividir);
            this.grbOperacoes.Controls.Add(this.rdbPorcentagem);
            this.grbOperacoes.Controls.Add(this.rdbPotencia);
            this.grbOperacoes.Controls.Add(this.rdbMultiplicar);
            this.grbOperacoes.Location = new System.Drawing.Point(12, 21);
            this.grbOperacoes.Name = "grbOperacoes";
            this.grbOperacoes.Size = new System.Drawing.Size(136, 207);
            this.grbOperacoes.TabIndex = 0;
            this.grbOperacoes.TabStop = false;
            this.grbOperacoes.Text = "Operações";
            // 
            // rdbParImpar
            // 
            this.rdbParImpar.AutoSize = true;
            this.rdbParImpar.Location = new System.Drawing.Point(6, 180);
            this.rdbParImpar.Name = "rdbParImpar";
            this.rdbParImpar.Size = new System.Drawing.Size(85, 17);
            this.rdbParImpar.TabIndex = 6;
            this.rdbParImpar.TabStop = true;
            this.rdbParImpar.Text = "Par ou Ímpar";
            this.rdbParImpar.UseVisualStyleBackColor = true;
            this.rdbParImpar.CheckedChanged += new System.EventHandler(this.rdbParImpar_CheckedChanged);
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(6, 19);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(55, 17);
            this.rdbSomar.TabIndex = 0;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            this.rdbSomar.CheckedChanged += new System.EventHandler(this.rdbSomar_CheckedChanged);
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(6, 42);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrair.TabIndex = 1;
            this.rdbSubtrair.TabStop = true;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            this.rdbSubtrair.CheckedChanged += new System.EventHandler(this.rdbSubtrair_CheckedChanged);
            // 
            // rdbComparar
            // 
            this.rdbComparar.AutoSize = true;
            this.rdbComparar.Location = new System.Drawing.Point(6, 157);
            this.rdbComparar.Name = "rdbComparar";
            this.rdbComparar.Size = new System.Drawing.Size(70, 17);
            this.rdbComparar.TabIndex = 5;
            this.rdbComparar.TabStop = true;
            this.rdbComparar.Text = "Comparar";
            this.rdbComparar.UseVisualStyleBackColor = true;
            this.rdbComparar.CheckedChanged += new System.EventHandler(this.rdbComparar_CheckedChanged);
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(6, 88);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(54, 17);
            this.rdbDividir.TabIndex = 2;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            this.rdbDividir.CheckedChanged += new System.EventHandler(this.rdbDividir_CheckedChanged);
            // 
            // rdbPorcentagem
            // 
            this.rdbPorcentagem.AutoSize = true;
            this.rdbPorcentagem.Location = new System.Drawing.Point(6, 111);
            this.rdbPorcentagem.Name = "rdbPorcentagem";
            this.rdbPorcentagem.Size = new System.Drawing.Size(88, 17);
            this.rdbPorcentagem.TabIndex = 3;
            this.rdbPorcentagem.TabStop = true;
            this.rdbPorcentagem.Text = "Porcentagem";
            this.rdbPorcentagem.UseVisualStyleBackColor = true;
            this.rdbPorcentagem.CheckedChanged += new System.EventHandler(this.rdbPorcentagem_CheckedChanged);
            // 
            // rdbPotencia
            // 
            this.rdbPotencia.AutoSize = true;
            this.rdbPotencia.Location = new System.Drawing.Point(6, 134);
            this.rdbPotencia.Name = "rdbPotencia";
            this.rdbPotencia.Size = new System.Drawing.Size(85, 17);
            this.rdbPotencia.TabIndex = 4;
            this.rdbPotencia.TabStop = true;
            this.rdbPotencia.Text = "Potenciação";
            this.rdbPotencia.UseVisualStyleBackColor = true;
            this.rdbPotencia.CheckedChanged += new System.EventHandler(this.rdbPotencia_CheckedChanged);
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(6, 65);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdbMultiplicar.TabIndex = 1;
            this.rdbMultiplicar.TabStop = true;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            this.rdbMultiplicar.CheckedChanged += new System.EventHandler(this.rdbMultiplicar_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(337, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(713, 415);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(207, 40);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(436, 40);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 5;
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(365, 44);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(13, 13);
            this.lblSinal.TabIndex = 6;
            this.lblSinal.Text = "?";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(594, 44);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 7;
            this.lblIgual.Text = "=";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(665, 44);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "?";
            // 
            // frmRadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbOperacoes);
            this.Name = "frmRadioButtons";
            this.Text = "Calculadora Radio Buttons";
            this.grbOperacoes.ResumeLayout(false);
            this.grbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOperacoes;
        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.RadioButton rdbPotencia;
        private System.Windows.Forms.RadioButton rdbPorcentagem;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.RadioButton rdbParImpar;
        private System.Windows.Forms.RadioButton rdbComparar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblResultado;
    }
}
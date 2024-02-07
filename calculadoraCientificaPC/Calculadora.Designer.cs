namespace calculadoraCientificaPC
{
    partial class Calculadora
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
            btnNumero = new Button();
            txtVisor = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            btnOperacaoPercentual = new Button();
            btnOperacaoDivisao = new Button();
            btnOperacaoMais = new Button();
            btnOperacaoMenos = new Button();
            Limpar = new Button();
            Mem = new Button();
            SuspendLayout();
            // 
            // btnNumero
            // 
            btnNumero.Location = new Point(21, 85);
            btnNumero.Name = "btnNumero";
            btnNumero.Size = new Size(44, 23);
            btnNumero.TabIndex = 0;
            btnNumero.Text = "1";
            btnNumero.UseVisualStyleBackColor = true;
            btnNumero.Click += btnNumero_Click;
            // 
            // txtVisor
            // 
            txtVisor.Enabled = false;
            txtVisor.Location = new Point(21, 18);
            txtVisor.MaxLength = 15;
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(183, 23);
            txtVisor.TabIndex = 1;
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(71, 114);
            button1.Name = "button1";
            button1.Size = new Size(40, 23);
            button1.TabIndex = 2;
            button1.Text = "5";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNumero_Click;
            // 
            // button2
            // 
            button2.Location = new Point(71, 85);
            button2.Name = "button2";
            button2.Size = new Size(40, 23);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNumero_Click;
            // 
            // button4
            // 
            button4.Location = new Point(19, 172);
            button4.Name = "button4";
            button4.Size = new Size(45, 23);
            button4.TabIndex = 5;
            button4.Text = "0";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNumero_Click;
            // 
            // button5
            // 
            button5.Location = new Point(20, 143);
            button5.Name = "button5";
            button5.Size = new Size(44, 23);
            button5.TabIndex = 6;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnNumero_Click;
            // 
            // button6
            // 
            button6.Location = new Point(21, 114);
            button6.Name = "button6";
            button6.Size = new Size(44, 23);
            button6.TabIndex = 7;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnNumero_Click;
            // 
            // button7
            // 
            button7.Location = new Point(71, 143);
            button7.Name = "button7";
            button7.Size = new Size(40, 23);
            button7.TabIndex = 8;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnNumero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(71, 172);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(40, 23);
            btnVirgula.TabIndex = 9;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(117, 172);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(40, 23);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // button12
            // 
            button12.Location = new Point(117, 143);
            button12.Name = "button12";
            button12.Size = new Size(40, 23);
            button12.TabIndex = 13;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnNumero_Click;
            // 
            // button13
            // 
            button13.Location = new Point(117, 85);
            button13.Name = "button13";
            button13.Size = new Size(40, 23);
            button13.TabIndex = 12;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnNumero_Click;
            // 
            // button14
            // 
            button14.Location = new Point(117, 114);
            button14.Name = "button14";
            button14.Size = new Size(40, 23);
            button14.TabIndex = 11;
            button14.Text = "6";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnNumero_Click;
            // 
            // btnOperacaoPercentual
            // 
            btnOperacaoPercentual.Location = new Point(163, 172);
            btnOperacaoPercentual.Name = "btnOperacaoPercentual";
            btnOperacaoPercentual.Size = new Size(40, 23);
            btnOperacaoPercentual.TabIndex = 19;
            btnOperacaoPercentual.Text = "%";
            btnOperacaoPercentual.UseVisualStyleBackColor = true;
            btnOperacaoPercentual.Click += btnOperacao_Click;
            // 
            // btnOperacaoDivisao
            // 
            btnOperacaoDivisao.Location = new Point(163, 143);
            btnOperacaoDivisao.Name = "btnOperacaoDivisao";
            btnOperacaoDivisao.Size = new Size(40, 23);
            btnOperacaoDivisao.TabIndex = 18;
            btnOperacaoDivisao.Text = "/";
            btnOperacaoDivisao.UseVisualStyleBackColor = true;
            btnOperacaoDivisao.Click += btnOperacao_Click;
            // 
            // btnOperacaoMais
            // 
            btnOperacaoMais.Location = new Point(163, 85);
            btnOperacaoMais.Name = "btnOperacaoMais";
            btnOperacaoMais.Size = new Size(40, 23);
            btnOperacaoMais.TabIndex = 17;
            btnOperacaoMais.Text = "+";
            btnOperacaoMais.UseVisualStyleBackColor = true;
            btnOperacaoMais.Click += btnOperacao_Click;
            // 
            // btnOperacaoMenos
            // 
            btnOperacaoMenos.Location = new Point(163, 114);
            btnOperacaoMenos.Name = "btnOperacaoMenos";
            btnOperacaoMenos.Size = new Size(40, 23);
            btnOperacaoMenos.TabIndex = 16;
            btnOperacaoMenos.Text = "-";
            btnOperacaoMenos.UseVisualStyleBackColor = true;
            btnOperacaoMenos.Click += btnNegativo_Click;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(117, 56);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(86, 23);
            Limpar.TabIndex = 20;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += Limpar_Click;
            // 
            // Mem
            // 
            Mem.Location = new Point(21, 56);
            Mem.Name = "Mem";
            Mem.Size = new Size(90, 23);
            Mem.TabIndex = 21;
            Mem.Text = "Memória";
            Mem.UseVisualStyleBackColor = true;
            Mem.Click += Mem_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 223);
            Controls.Add(Mem);
            Controls.Add(Limpar);
            Controls.Add(btnOperacaoPercentual);
            Controls.Add(btnOperacaoDivisao);
            Controls.Add(btnOperacaoMais);
            Controls.Add(btnOperacaoMenos);
            Controls.Add(btnIgual);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(btnVirgula);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtVisor);
            Controls.Add(btnNumero);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNumero;
        private TextBox txtVisor;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button btnVirgula;
        private Button btnIgual;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button btnOperacaoPercentual;
        private Button btnOperacaoDivisao;
        private Button btnOperacaoMais;
        private Button btnOperacaoMenos;
        private Button Limpar;
        private Button Mem;
    }
}
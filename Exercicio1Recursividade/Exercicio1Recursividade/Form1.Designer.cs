
namespace Exercicio1Recursividade
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Impares = new System.Windows.Forms.Button();
            this.B_Somatorio = new System.Windows.Forms.Button();
            this.B_Decrescente = new System.Windows.Forms.Button();
            this.B_Crescente = new System.Windows.Forms.Button();
            this.TB_NumFinal = new System.Windows.Forms.TextBox();
            this.TB_NumInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_Soma = new System.Windows.Forms.Button();
            this.B_Insere = new System.Windows.Forms.Button();
            this.TB_Numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_Resultado = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Impares);
            this.groupBox1.Controls.Add(this.B_Somatorio);
            this.groupBox1.Controls.Add(this.B_Decrescente);
            this.groupBox1.Controls.Add(this.B_Crescente);
            this.groupBox1.Controls.Add(this.TB_NumFinal);
            this.groupBox1.Controls.Add(this.TB_NumInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritmos Sem vetor";
            // 
            // B_Impares
            // 
            this.B_Impares.Location = new System.Drawing.Point(428, 128);
            this.B_Impares.Name = "B_Impares";
            this.B_Impares.Size = new System.Drawing.Size(75, 23);
            this.B_Impares.TabIndex = 7;
            this.B_Impares.Text = "Ímpares";
            this.B_Impares.UseVisualStyleBackColor = true;
            // 
            // B_Somatorio
            // 
            this.B_Somatorio.Location = new System.Drawing.Point(290, 128);
            this.B_Somatorio.Name = "B_Somatorio";
            this.B_Somatorio.Size = new System.Drawing.Size(75, 23);
            this.B_Somatorio.TabIndex = 6;
            this.B_Somatorio.Text = "Somatório";
            this.B_Somatorio.UseVisualStyleBackColor = true;
            this.B_Somatorio.Click += new System.EventHandler(this.B_Somatorio_Click);
            // 
            // B_Decrescente
            // 
            this.B_Decrescente.Location = new System.Drawing.Point(147, 128);
            this.B_Decrescente.Name = "B_Decrescente";
            this.B_Decrescente.Size = new System.Drawing.Size(87, 23);
            this.B_Decrescente.TabIndex = 5;
            this.B_Decrescente.Text = "Decrescente";
            this.B_Decrescente.UseVisualStyleBackColor = true;
            this.B_Decrescente.Click += new System.EventHandler(this.B_Decrescente_Click);
            // 
            // B_Crescente
            // 
            this.B_Crescente.Location = new System.Drawing.Point(28, 128);
            this.B_Crescente.Name = "B_Crescente";
            this.B_Crescente.Size = new System.Drawing.Size(75, 23);
            this.B_Crescente.TabIndex = 4;
            this.B_Crescente.Text = "Crescente";
            this.B_Crescente.UseVisualStyleBackColor = true;
            this.B_Crescente.Click += new System.EventHandler(this.B_Crescente_Click);
            // 
            // TB_NumFinal
            // 
            this.TB_NumFinal.Location = new System.Drawing.Point(173, 68);
            this.TB_NumFinal.Name = "TB_NumFinal";
            this.TB_NumFinal.Size = new System.Drawing.Size(100, 20);
            this.TB_NumFinal.TabIndex = 3;
            // 
            // TB_NumInicial
            // 
            this.TB_NumInicial.Location = new System.Drawing.Point(33, 68);
            this.TB_NumInicial.Name = "TB_NumInicial";
            this.TB_NumInicial.Size = new System.Drawing.Size(100, 20);
            this.TB_NumInicial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número inicial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.B_Soma);
            this.groupBox2.Controls.Add(this.B_Insere);
            this.groupBox2.Controls.Add(this.TB_Numero);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(36, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algoritmos Com vetor";
            // 
            // B_Soma
            // 
            this.B_Soma.Location = new System.Drawing.Point(389, 61);
            this.B_Soma.Name = "B_Soma";
            this.B_Soma.Size = new System.Drawing.Size(101, 23);
            this.B_Soma.TabIndex = 3;
            this.B_Soma.Text = "Soma o vetor";
            this.B_Soma.UseVisualStyleBackColor = true;
            this.B_Soma.Click += new System.EventHandler(this.B_Soma_Click);
            // 
            // B_Insere
            // 
            this.B_Insere.Location = new System.Drawing.Point(255, 61);
            this.B_Insere.Name = "B_Insere";
            this.B_Insere.Size = new System.Drawing.Size(95, 23);
            this.B_Insere.TabIndex = 2;
            this.B_Insere.Text = "Insere no vetor";
            this.B_Insere.UseVisualStyleBackColor = true;
            this.B_Insere.Click += new System.EventHandler(this.B_Insere_Click);
            // 
            // TB_Numero
            // 
            this.TB_Numero.Location = new System.Drawing.Point(87, 67);
            this.TB_Numero.Name = "TB_Numero";
            this.TB_Numero.Size = new System.Drawing.Size(100, 20);
            this.TB_Numero.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Resultado";
            // 
            // LB_Resultado
            // 
            this.LB_Resultado.FormattingEnabled = true;
            this.LB_Resultado.Location = new System.Drawing.Point(621, 152);
            this.LB_Resultado.Name = "LB_Resultado";
            this.LB_Resultado.Size = new System.Drawing.Size(132, 173);
            this.LB_Resultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 405);
            this.Controls.Add(this.LB_Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Exercício 1 - Recursividade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_Impares;
        private System.Windows.Forms.Button B_Somatorio;
        private System.Windows.Forms.Button B_Decrescente;
        private System.Windows.Forms.Button B_Crescente;
        private System.Windows.Forms.TextBox TB_NumFinal;
        private System.Windows.Forms.TextBox TB_NumInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Soma;
        private System.Windows.Forms.Button B_Insere;
        private System.Windows.Forms.TextBox TB_Numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LB_Resultado;
    }
}


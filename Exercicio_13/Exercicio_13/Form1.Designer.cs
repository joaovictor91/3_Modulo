
namespace Exercicio_13
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
            this.B_Insere_na_Fila = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Valor = new System.Windows.Forms.TextBox();
            this.Lista_Menores = new System.Windows.Forms.ListBox();
            this.TB_Valor_p = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Divide_Fila = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lista_Maiores = new System.Windows.Forms.ListBox();
            this.B_Exibe_Filas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Insere_na_Fila
            // 
            this.B_Insere_na_Fila.Location = new System.Drawing.Point(422, 65);
            this.B_Insere_na_Fila.Name = "B_Insere_na_Fila";
            this.B_Insere_na_Fila.Size = new System.Drawing.Size(174, 34);
            this.B_Insere_na_Fila.TabIndex = 0;
            this.B_Insere_na_Fila.Text = "Insere na Fila";
            this.B_Insere_na_Fila.UseVisualStyleBackColor = true;
            this.B_Insere_na_Fila.Click += new System.EventHandler(this.B_Insere_na_Fila_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor";
            // 
            // TB_Valor
            // 
            this.TB_Valor.Location = new System.Drawing.Point(94, 71);
            this.TB_Valor.Name = "TB_Valor";
            this.TB_Valor.Size = new System.Drawing.Size(235, 22);
            this.TB_Valor.TabIndex = 2;
            // 
            // Lista_Menores
            // 
            this.Lista_Menores.FormattingEnabled = true;
            this.Lista_Menores.ItemHeight = 16;
            this.Lista_Menores.Location = new System.Drawing.Point(110, 290);
            this.Lista_Menores.Name = "Lista_Menores";
            this.Lista_Menores.Size = new System.Drawing.Size(219, 164);
            this.Lista_Menores.TabIndex = 3;
            // 
            // TB_Valor_p
            // 
            this.TB_Valor_p.Location = new System.Drawing.Point(94, 141);
            this.TB_Valor_p.Name = "TB_Valor_p";
            this.TB_Valor_p.Size = new System.Drawing.Size(235, 22);
            this.TB_Valor_p.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor p";
            // 
            // B_Divide_Fila
            // 
            this.B_Divide_Fila.Location = new System.Drawing.Point(422, 133);
            this.B_Divide_Fila.Name = "B_Divide_Fila";
            this.B_Divide_Fila.Size = new System.Drawing.Size(174, 33);
            this.B_Divide_Fila.TabIndex = 4;
            this.B_Divide_Fila.Text = "Divide a fila em 2";
            this.B_Divide_Fila.UseVisualStyleBackColor = true;
            this.B_Divide_Fila.Click += new System.EventHandler(this.B_Divide_Fila_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fila com núemros maiores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fila com números menores";
            // 
            // Lista_Maiores
            // 
            this.Lista_Maiores.FormattingEnabled = true;
            this.Lista_Maiores.ItemHeight = 16;
            this.Lista_Maiores.Location = new System.Drawing.Point(447, 290);
            this.Lista_Maiores.Name = "Lista_Maiores";
            this.Lista_Maiores.Size = new System.Drawing.Size(219, 164);
            this.Lista_Maiores.TabIndex = 9;
            // 
            // B_Exibe_Filas
            // 
            this.B_Exibe_Filas.Location = new System.Drawing.Point(270, 193);
            this.B_Exibe_Filas.Name = "B_Exibe_Filas";
            this.B_Exibe_Filas.Size = new System.Drawing.Size(135, 39);
            this.B_Exibe_Filas.TabIndex = 10;
            this.B_Exibe_Filas.Text = "Exibe Filas";
            this.B_Exibe_Filas.UseVisualStyleBackColor = true;
            this.B_Exibe_Filas.Click += new System.EventHandler(this.B_Exibe_Filas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.B_Exibe_Filas);
            this.Controls.Add(this.Lista_Maiores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Valor_p);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_Divide_Fila);
            this.Controls.Add(this.Lista_Menores);
            this.Controls.Add(this.TB_Valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Insere_na_Fila);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Insere_na_Fila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Valor;
        private System.Windows.Forms.ListBox Lista_Menores;
        private System.Windows.Forms.TextBox TB_Valor_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Divide_Fila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Lista_Maiores;
        private System.Windows.Forms.Button B_Exibe_Filas;
    }
}


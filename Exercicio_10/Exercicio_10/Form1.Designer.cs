
namespace Exercicio_10
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_processa = new System.Windows.Forms.Button();
            this.tb_frase_original = new System.Windows.Forms.TextBox();
            this.tb_frase_invertida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase Original";
            // 
            // b_processa
            // 
            this.b_processa.Location = new System.Drawing.Point(215, 175);
            this.b_processa.Name = "b_processa";
            this.b_processa.Size = new System.Drawing.Size(100, 37);
            this.b_processa.TabIndex = 1;
            this.b_processa.Text = "Processa";
            this.b_processa.UseVisualStyleBackColor = true;
            this.b_processa.Click += new System.EventHandler(this.b_processa_Click);
            // 
            // tb_frase_original
            // 
            this.tb_frase_original.Location = new System.Drawing.Point(243, 90);
            this.tb_frase_original.Name = "tb_frase_original";
            this.tb_frase_original.Size = new System.Drawing.Size(413, 22);
            this.tb_frase_original.TabIndex = 2;
            // 
            // tb_frase_invertida
            // 
            this.tb_frase_invertida.Location = new System.Drawing.Point(243, 298);
            this.tb_frase_invertida.Name = "tb_frase_invertida";
            this.tb_frase_invertida.Size = new System.Drawing.Size(431, 22);
            this.tb_frase_invertida.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frase com palavra invertida";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_frase_invertida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_frase_original);
            this.Controls.Add(this.b_processa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_processa;
        private System.Windows.Forms.TextBox tb_frase_original;
        private System.Windows.Forms.TextBox tb_frase_invertida;
        private System.Windows.Forms.Label label2;
    }
}


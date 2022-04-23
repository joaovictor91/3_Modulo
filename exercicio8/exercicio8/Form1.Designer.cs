
namespace exercicio8
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
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NumInt = new System.Windows.Forms.TextBox();
            this.TB_NumBin = new System.Windows.Forms.TextBox();
            this.B_Processa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número inteiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número binário";
            // 
            // TB_NumInt
            // 
            this.TB_NumInt.Location = new System.Drawing.Point(130, 58);
            this.TB_NumInt.Name = "TB_NumInt";
            this.TB_NumInt.Size = new System.Drawing.Size(100, 20);
            this.TB_NumInt.TabIndex = 2;
            // 
            // TB_NumBin
            // 
            this.TB_NumBin.Location = new System.Drawing.Point(151, 214);
            this.TB_NumBin.Name = "TB_NumBin";
            this.TB_NumBin.Size = new System.Drawing.Size(100, 20);
            this.TB_NumBin.TabIndex = 3;
            // 
            // B_Processa
            // 
            this.B_Processa.Location = new System.Drawing.Point(113, 118);
            this.B_Processa.Name = "B_Processa";
            this.B_Processa.Size = new System.Drawing.Size(96, 41);
            this.B_Processa.TabIndex = 4;
            this.B_Processa.Text = "Processa";
            this.B_Processa.UseVisualStyleBackColor = true;
            this.B_Processa.Click += new System.EventHandler(this.B_Processa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 300);
            this.Controls.Add(this.B_Processa);
            this.Controls.Add(this.TB_NumBin);
            this.Controls.Add(this.TB_NumInt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversão de base numérica decimal para binária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NumInt;
        private System.Windows.Forms.TextBox TB_NumBin;
        private System.Windows.Forms.Button B_Processa;
    }
}


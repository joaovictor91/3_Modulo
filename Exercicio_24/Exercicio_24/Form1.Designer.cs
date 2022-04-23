
namespace Exercicio_24
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
            this.Lista_Exibir = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_Exibir = new System.Windows.Forms.Button();
            this.RB_PreOrdem = new System.Windows.Forms.RadioButton();
            this.RB_EmOrdem = new System.Windows.Forms.RadioButton();
            this.RB_PosOrdem = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Pesquisar = new System.Windows.Forms.Button();
            this.B_Insere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Valor = new System.Windows.Forms.TextBox();
            this.B_Remover = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lista_Exibir
            // 
            this.Lista_Exibir.FormattingEnabled = true;
            this.Lista_Exibir.ItemHeight = 16;
            this.Lista_Exibir.Location = new System.Drawing.Point(54, 103);
            this.Lista_Exibir.Name = "Lista_Exibir";
            this.Lista_Exibir.Size = new System.Drawing.Size(333, 196);
            this.Lista_Exibir.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lista_Exibir);
            this.groupBox2.Controls.Add(this.B_Exibir);
            this.groupBox2.Controls.Add(this.RB_PreOrdem);
            this.groupBox2.Controls.Add(this.RB_EmOrdem);
            this.groupBox2.Controls.Add(this.RB_PosOrdem);
            this.groupBox2.Location = new System.Drawing.Point(65, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 340);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exibir";
            // 
            // B_Exibir
            // 
            this.B_Exibir.Location = new System.Drawing.Point(172, 62);
            this.B_Exibir.Name = "B_Exibir";
            this.B_Exibir.Size = new System.Drawing.Size(84, 35);
            this.B_Exibir.TabIndex = 6;
            this.B_Exibir.Text = "Exibir";
            this.B_Exibir.UseVisualStyleBackColor = true;
            this.B_Exibir.Click += new System.EventHandler(this.B_Exibir_Click);
            // 
            // RB_PreOrdem
            // 
            this.RB_PreOrdem.AutoSize = true;
            this.RB_PreOrdem.Location = new System.Drawing.Point(262, 27);
            this.RB_PreOrdem.Name = "RB_PreOrdem";
            this.RB_PreOrdem.Size = new System.Drawing.Size(98, 21);
            this.RB_PreOrdem.TabIndex = 9;
            this.RB_PreOrdem.TabStop = true;
            this.RB_PreOrdem.Text = "Pré Ordem";
            this.RB_PreOrdem.UseVisualStyleBackColor = true;
            // 
            // RB_EmOrdem
            // 
            this.RB_EmOrdem.AutoSize = true;
            this.RB_EmOrdem.Location = new System.Drawing.Point(54, 27);
            this.RB_EmOrdem.Name = "RB_EmOrdem";
            this.RB_EmOrdem.Size = new System.Drawing.Size(96, 21);
            this.RB_EmOrdem.TabIndex = 3;
            this.RB_EmOrdem.TabStop = true;
            this.RB_EmOrdem.Text = "Em Ordem";
            this.RB_EmOrdem.UseVisualStyleBackColor = true;
            // 
            // RB_PosOrdem
            // 
            this.RB_PosOrdem.AutoSize = true;
            this.RB_PosOrdem.Location = new System.Drawing.Point(156, 27);
            this.RB_PosOrdem.Name = "RB_PosOrdem";
            this.RB_PosOrdem.Size = new System.Drawing.Size(100, 21);
            this.RB_PosOrdem.TabIndex = 8;
            this.RB_PosOrdem.TabStop = true;
            this.RB_PosOrdem.Text = "Pós Ordem";
            this.RB_PosOrdem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Pesquisar);
            this.groupBox1.Controls.Add(this.B_Insere);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_Valor);
            this.groupBox1.Controls.Add(this.B_Remover);
            this.groupBox1.Location = new System.Drawing.Point(65, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 215);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insere, Pesquisar e Remover";
            // 
            // B_Pesquisar
            // 
            this.B_Pesquisar.Location = new System.Drawing.Point(131, 108);
            this.B_Pesquisar.Name = "B_Pesquisar";
            this.B_Pesquisar.Size = new System.Drawing.Size(86, 40);
            this.B_Pesquisar.TabIndex = 7;
            this.B_Pesquisar.Text = "Pesquisar";
            this.B_Pesquisar.UseVisualStyleBackColor = true;
            this.B_Pesquisar.Click += new System.EventHandler(this.B_Pesquisar_Click);
            // 
            // B_Insere
            // 
            this.B_Insere.Location = new System.Drawing.Point(11, 108);
            this.B_Insere.Name = "B_Insere";
            this.B_Insere.Size = new System.Drawing.Size(98, 40);
            this.B_Insere.TabIndex = 0;
            this.B_Insere.Text = "Insere";
            this.B_Insere.UseVisualStyleBackColor = true;
            this.B_Insere.Click += new System.EventHandler(this.B_Insere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor:";
            // 
            // TB_Valor
            // 
            this.TB_Valor.Location = new System.Drawing.Point(59, 55);
            this.TB_Valor.Name = "TB_Valor";
            this.TB_Valor.Size = new System.Drawing.Size(145, 22);
            this.TB_Valor.TabIndex = 2;
            // 
            // B_Remover
            // 
            this.B_Remover.Location = new System.Drawing.Point(236, 108);
            this.B_Remover.Name = "B_Remover";
            this.B_Remover.Size = new System.Drawing.Size(91, 40);
            this.B_Remover.TabIndex = 5;
            this.B_Remover.Text = "Remover";
            this.B_Remover.UseVisualStyleBackColor = true;
            this.B_Remover.Click += new System.EventHandler(this.B_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_Exibir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_Exibir;
        private System.Windows.Forms.RadioButton RB_PreOrdem;
        private System.Windows.Forms.RadioButton RB_EmOrdem;
        private System.Windows.Forms.RadioButton RB_PosOrdem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_Pesquisar;
        private System.Windows.Forms.Button B_Insere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Valor;
        private System.Windows.Forms.Button B_Remover;
    }
}


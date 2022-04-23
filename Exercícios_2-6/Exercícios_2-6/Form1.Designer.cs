
namespace Exercícios_2_6
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
            this.b_processa1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_base = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_expoente = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.b_processa3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_n1 = new System.Windows.Forms.TextBox();
            this.b_processa2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_n2 = new System.Windows.Forms.TextBox();
            this.b_processa4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_n3 = new System.Windows.Forms.TextBox();
            this.b_processa5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.b_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_processa1
            // 
            this.b_processa1.Location = new System.Drawing.Point(216, 42);
            this.b_processa1.Name = "b_processa1";
            this.b_processa1.Size = new System.Drawing.Size(84, 39);
            this.b_processa1.TabIndex = 0;
            this.b_processa1.Text = "Processa";
            this.b_processa1.UseVisualStyleBackColor = true;
            this.b_processa1.Click += new System.EventHandler(this.b_processa1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base";
            // 
            // tb_base
            // 
            this.tb_base.Location = new System.Drawing.Point(101, 39);
            this.tb_base.Name = "tb_base";
            this.tb_base.Size = new System.Drawing.Size(100, 22);
            this.tb_base.TabIndex = 2;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Location = new System.Drawing.Point(617, 324);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(200, 196);
            this.lista.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_expoente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_base);
            this.groupBox1.Controls.Add(this.b_processa1);
            this.groupBox1.Location = new System.Drawing.Point(35, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expoente";
            // 
            // tb_expoente
            // 
            this.tb_expoente.Location = new System.Drawing.Point(101, 82);
            this.tb_expoente.Name = "tb_expoente";
            this.tb_expoente.Size = new System.Drawing.Size(100, 22);
            this.tb_expoente.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.tb_y);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.tb_x);
            this.groupBox6.Controls.Add(this.b_processa3);
            this.groupBox6.Location = new System.Drawing.Point(35, 324);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(306, 131);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Máximo Divisor Comum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(68, 82);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(100, 22);
            this.tb_y.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(68, 42);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(100, 22);
            this.tb_x.TabIndex = 2;
            // 
            // b_processa3
            // 
            this.b_processa3.Location = new System.Drawing.Point(216, 42);
            this.b_processa3.Name = "b_processa3";
            this.b_processa3.Size = new System.Drawing.Size(84, 39);
            this.b_processa3.TabIndex = 0;
            this.b_processa3.Text = "Processa";
            this.b_processa3.UseVisualStyleBackColor = true;
            this.b_processa3.Click += new System.EventHandler(this.b_processa3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_n1);
            this.groupBox2.Controls.Add(this.b_processa2);
            this.groupBox2.Location = new System.Drawing.Point(35, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cubos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "N";
            // 
            // tb_n1
            // 
            this.tb_n1.Location = new System.Drawing.Point(68, 42);
            this.tb_n1.Name = "tb_n1";
            this.tb_n1.Size = new System.Drawing.Size(100, 22);
            this.tb_n1.TabIndex = 2;
            // 
            // b_processa2
            // 
            this.b_processa2.Location = new System.Drawing.Point(216, 42);
            this.b_processa2.Name = "b_processa2";
            this.b_processa2.Size = new System.Drawing.Size(84, 39);
            this.b_processa2.TabIndex = 0;
            this.b_processa2.Text = "Processa";
            this.b_processa2.UseVisualStyleBackColor = true;
            this.b_processa2.Click += new System.EventHandler(this.b_processa2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_n2);
            this.groupBox3.Controls.Add(this.b_processa4);
            this.groupBox3.Location = new System.Drawing.Point(35, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 131);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Série de Fibonacci ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "N";
            // 
            // tb_n2
            // 
            this.tb_n2.Location = new System.Drawing.Point(68, 42);
            this.tb_n2.Name = "tb_n2";
            this.tb_n2.Size = new System.Drawing.Size(100, 22);
            this.tb_n2.TabIndex = 2;
            // 
            // b_processa4
            // 
            this.b_processa4.Location = new System.Drawing.Point(216, 42);
            this.b_processa4.Name = "b_processa4";
            this.b_processa4.Size = new System.Drawing.Size(84, 39);
            this.b_processa4.TabIndex = 0;
            this.b_processa4.Text = "Processa";
            this.b_processa4.UseVisualStyleBackColor = true;
            this.b_processa4.Click += new System.EventHandler(this.b_processa4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tb_n3);
            this.groupBox4.Controls.Add(this.b_processa5);
            this.groupBox4.Location = new System.Drawing.Point(587, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 131);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inteiro para o Binário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "N";
            // 
            // tb_n3
            // 
            this.tb_n3.Location = new System.Drawing.Point(68, 42);
            this.tb_n3.Name = "tb_n3";
            this.tb_n3.Size = new System.Drawing.Size(100, 22);
            this.tb_n3.TabIndex = 2;
            // 
            // b_processa5
            // 
            this.b_processa5.Location = new System.Drawing.Point(216, 42);
            this.b_processa5.Name = "b_processa5";
            this.b_processa5.Size = new System.Drawing.Size(84, 39);
            this.b_processa5.TabIndex = 0;
            this.b_processa5.Text = "Processa";
            this.b_processa5.UseVisualStyleBackColor = true;
            this.b_processa5.Click += new System.EventHandler(this.b_processa5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Resultados";
            // 
            // b_sair
            // 
            this.b_sair.Location = new System.Drawing.Point(882, 576);
            this.b_sair.Name = "b_sair";
            this.b_sair.Size = new System.Drawing.Size(120, 41);
            this.b_sair.TabIndex = 7;
            this.b_sair.Text = "Sair";
            this.b_sair.UseVisualStyleBackColor = true;
            this.b_sair.Click += new System.EventHandler(this.b_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 621);
            this.Controls.Add(this.b_sair);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_processa1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_base;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_expoente;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Button b_processa3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_n1;
        private System.Windows.Forms.Button b_processa2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_n2;
        private System.Windows.Forms.Button b_processa4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_n3;
        private System.Windows.Forms.Button b_processa5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button b_sair;
    }
}


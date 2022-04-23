
namespace Exercico_17
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
            this.TBC_Menu = new System.Windows.Forms.TabControl();
            this.TBP1_Incluir = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Idade_Incluir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Gravar = new System.Windows.Forms.Button();
            this.CB_Sexo_Incluir = new System.Windows.Forms.ComboBox();
            this.TB_Nome_Incluir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBP2_Alterar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Salvar = new System.Windows.Forms.Button();
            this.CB_Sexo_Alterar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_Idade_Alterar = new System.Windows.Forms.TextBox();
            this.TB_Nome_Alterar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_PesquisaNome_Alterar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.B_Pesquisa_Alterar = new System.Windows.Forms.Button();
            this.TBP3_Excluir = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.B_Excluir = new System.Windows.Forms.Button();
            this.CB_Sexo_Excluir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Idade_Excluir = new System.Windows.Forms.TextBox();
            this.TB_Nome_Excluir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TB_PesquisaNome_Excluir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.B_Pesquisar_Excluir = new System.Windows.Forms.Button();
            this.TBP4_Exibir = new System.Windows.Forms.TabPage();
            this.Lista_resultado = new System.Windows.Forms.ListBox();
            this.B_Exibir_Todos = new System.Windows.Forms.Button();
            this.TBC_Menu.SuspendLayout();
            this.TBP1_Incluir.SuspendLayout();
            this.TBP2_Alterar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TBP3_Excluir.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TBP4_Exibir.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBC_Menu
            // 
            this.TBC_Menu.Controls.Add(this.TBP1_Incluir);
            this.TBC_Menu.Controls.Add(this.TBP2_Alterar);
            this.TBC_Menu.Controls.Add(this.TBP3_Excluir);
            this.TBC_Menu.Controls.Add(this.TBP4_Exibir);
            this.TBC_Menu.Location = new System.Drawing.Point(0, 12);
            this.TBC_Menu.Name = "TBC_Menu";
            this.TBC_Menu.SelectedIndex = 0;
            this.TBC_Menu.Size = new System.Drawing.Size(863, 488);
            this.TBC_Menu.TabIndex = 2;
            // 
            // TBP1_Incluir
            // 
            this.TBP1_Incluir.Controls.Add(this.label3);
            this.TBP1_Incluir.Controls.Add(this.TB_Idade_Incluir);
            this.TBP1_Incluir.Controls.Add(this.label2);
            this.TBP1_Incluir.Controls.Add(this.B_Gravar);
            this.TBP1_Incluir.Controls.Add(this.CB_Sexo_Incluir);
            this.TBP1_Incluir.Controls.Add(this.TB_Nome_Incluir);
            this.TBP1_Incluir.Controls.Add(this.label1);
            this.TBP1_Incluir.Location = new System.Drawing.Point(4, 25);
            this.TBP1_Incluir.Name = "TBP1_Incluir";
            this.TBP1_Incluir.Padding = new System.Windows.Forms.Padding(3);
            this.TBP1_Incluir.Size = new System.Drawing.Size(855, 459);
            this.TBP1_Incluir.TabIndex = 0;
            this.TBP1_Incluir.Text = "Incluir";
            this.TBP1_Incluir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo";
            // 
            // TB_Idade_Incluir
            // 
            this.TB_Idade_Incluir.Location = new System.Drawing.Point(86, 153);
            this.TB_Idade_Incluir.Name = "TB_Idade_Incluir";
            this.TB_Idade_Incluir.Size = new System.Drawing.Size(121, 22);
            this.TB_Idade_Incluir.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idade";
            // 
            // B_Gravar
            // 
            this.B_Gravar.Location = new System.Drawing.Point(210, 294);
            this.B_Gravar.Name = "B_Gravar";
            this.B_Gravar.Size = new System.Drawing.Size(91, 36);
            this.B_Gravar.TabIndex = 3;
            this.B_Gravar.Text = "Gravar";
            this.B_Gravar.UseVisualStyleBackColor = true;
            this.B_Gravar.Click += new System.EventHandler(this.B_Gravar_Click);
            // 
            // CB_Sexo_Incluir
            // 
            this.CB_Sexo_Incluir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sexo_Incluir.FormattingEnabled = true;
            this.CB_Sexo_Incluir.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.CB_Sexo_Incluir.Location = new System.Drawing.Point(86, 220);
            this.CB_Sexo_Incluir.Name = "CB_Sexo_Incluir";
            this.CB_Sexo_Incluir.Size = new System.Drawing.Size(160, 24);
            this.CB_Sexo_Incluir.TabIndex = 2;
            // 
            // TB_Nome_Incluir
            // 
            this.TB_Nome_Incluir.Location = new System.Drawing.Point(86, 87);
            this.TB_Nome_Incluir.Name = "TB_Nome_Incluir";
            this.TB_Nome_Incluir.Size = new System.Drawing.Size(284, 22);
            this.TB_Nome_Incluir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // TBP2_Alterar
            // 
            this.TBP2_Alterar.Controls.Add(this.groupBox1);
            this.TBP2_Alterar.Controls.Add(this.groupBox2);
            this.TBP2_Alterar.Location = new System.Drawing.Point(4, 25);
            this.TBP2_Alterar.Name = "TBP2_Alterar";
            this.TBP2_Alterar.Padding = new System.Windows.Forms.Padding(3);
            this.TBP2_Alterar.Size = new System.Drawing.Size(855, 459);
            this.TBP2_Alterar.TabIndex = 1;
            this.TBP2_Alterar.Text = "Alterar";
            this.TBP2_Alterar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Salvar);
            this.groupBox1.Controls.Add(this.CB_Sexo_Alterar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TB_Idade_Alterar);
            this.groupBox1.Controls.Add(this.TB_Nome_Alterar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(52, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 283);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // B_Salvar
            // 
            this.B_Salvar.Location = new System.Drawing.Point(222, 234);
            this.B_Salvar.Name = "B_Salvar";
            this.B_Salvar.Size = new System.Drawing.Size(94, 33);
            this.B_Salvar.TabIndex = 20;
            this.B_Salvar.Text = "Salvar";
            this.B_Salvar.UseVisualStyleBackColor = true;
            this.B_Salvar.Click += new System.EventHandler(this.B_Salvar_Click);
            // 
            // CB_Sexo_Alterar
            // 
            this.CB_Sexo_Alterar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sexo_Alterar.FormattingEnabled = true;
            this.CB_Sexo_Alterar.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.CB_Sexo_Alterar.Location = new System.Drawing.Point(20, 196);
            this.CB_Sexo_Alterar.Name = "CB_Sexo_Alterar";
            this.CB_Sexo_Alterar.Size = new System.Drawing.Size(173, 24);
            this.CB_Sexo_Alterar.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sexo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Nome";
            // 
            // TB_Idade_Alterar
            // 
            this.TB_Idade_Alterar.Location = new System.Drawing.Point(20, 129);
            this.TB_Idade_Alterar.Name = "TB_Idade_Alterar";
            this.TB_Idade_Alterar.Size = new System.Drawing.Size(140, 22);
            this.TB_Idade_Alterar.TabIndex = 22;
            // 
            // TB_Nome_Alterar
            // 
            this.TB_Nome_Alterar.Location = new System.Drawing.Point(20, 63);
            this.TB_Nome_Alterar.Name = "TB_Nome_Alterar";
            this.TB_Nome_Alterar.Size = new System.Drawing.Size(351, 22);
            this.TB_Nome_Alterar.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Idade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_PesquisaNome_Alterar);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.B_Pesquisa_Alterar);
            this.groupBox2.Location = new System.Drawing.Point(52, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 122);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // TB_PesquisaNome_Alterar
            // 
            this.TB_PesquisaNome_Alterar.Location = new System.Drawing.Point(25, 46);
            this.TB_PesquisaNome_Alterar.Name = "TB_PesquisaNome_Alterar";
            this.TB_PesquisaNome_Alterar.Size = new System.Drawing.Size(263, 22);
            this.TB_PesquisaNome_Alterar.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "Nome";
            // 
            // B_Pesquisa_Alterar
            // 
            this.B_Pesquisa_Alterar.Location = new System.Drawing.Point(45, 74);
            this.B_Pesquisa_Alterar.Name = "B_Pesquisa_Alterar";
            this.B_Pesquisa_Alterar.Size = new System.Drawing.Size(82, 34);
            this.B_Pesquisa_Alterar.TabIndex = 26;
            this.B_Pesquisa_Alterar.Text = "Pesquisar";
            this.B_Pesquisa_Alterar.UseVisualStyleBackColor = true;
            this.B_Pesquisa_Alterar.Click += new System.EventHandler(this.B_Pesquisa_Alterar_Click);
            // 
            // TBP3_Excluir
            // 
            this.TBP3_Excluir.Controls.Add(this.groupBox3);
            this.TBP3_Excluir.Controls.Add(this.groupBox4);
            this.TBP3_Excluir.Location = new System.Drawing.Point(4, 25);
            this.TBP3_Excluir.Name = "TBP3_Excluir";
            this.TBP3_Excluir.Padding = new System.Windows.Forms.Padding(3);
            this.TBP3_Excluir.Size = new System.Drawing.Size(855, 459);
            this.TBP3_Excluir.TabIndex = 2;
            this.TBP3_Excluir.Text = "Excluir";
            this.TBP3_Excluir.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.B_Excluir);
            this.groupBox3.Controls.Add(this.CB_Sexo_Excluir);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TB_Idade_Excluir);
            this.groupBox3.Controls.Add(this.TB_Nome_Excluir);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(33, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 283);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // B_Excluir
            // 
            this.B_Excluir.Location = new System.Drawing.Point(222, 234);
            this.B_Excluir.Name = "B_Excluir";
            this.B_Excluir.Size = new System.Drawing.Size(94, 33);
            this.B_Excluir.TabIndex = 20;
            this.B_Excluir.Text = "Excluir";
            this.B_Excluir.UseVisualStyleBackColor = true;
            this.B_Excluir.Click += new System.EventHandler(this.B_Excluir_Click);
            // 
            // CB_Sexo_Excluir
            // 
            this.CB_Sexo_Excluir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sexo_Excluir.Enabled = false;
            this.CB_Sexo_Excluir.FormattingEnabled = true;
            this.CB_Sexo_Excluir.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.CB_Sexo_Excluir.Location = new System.Drawing.Point(20, 196);
            this.CB_Sexo_Excluir.Name = "CB_Sexo_Excluir";
            this.CB_Sexo_Excluir.Size = new System.Drawing.Size(173, 24);
            this.CB_Sexo_Excluir.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nome";
            // 
            // TB_Idade_Excluir
            // 
            this.TB_Idade_Excluir.Enabled = false;
            this.TB_Idade_Excluir.Location = new System.Drawing.Point(20, 129);
            this.TB_Idade_Excluir.Name = "TB_Idade_Excluir";
            this.TB_Idade_Excluir.Size = new System.Drawing.Size(140, 22);
            this.TB_Idade_Excluir.TabIndex = 22;
            // 
            // TB_Nome_Excluir
            // 
            this.TB_Nome_Excluir.Enabled = false;
            this.TB_Nome_Excluir.Location = new System.Drawing.Point(20, 63);
            this.TB_Nome_Excluir.Name = "TB_Nome_Excluir";
            this.TB_Nome_Excluir.Size = new System.Drawing.Size(351, 22);
            this.TB_Nome_Excluir.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Idade";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TB_PesquisaNome_Excluir);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.B_Pesquisar_Excluir);
            this.groupBox4.Location = new System.Drawing.Point(33, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 122);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisa";
            // 
            // TB_PesquisaNome_Excluir
            // 
            this.TB_PesquisaNome_Excluir.Location = new System.Drawing.Point(25, 46);
            this.TB_PesquisaNome_Excluir.Name = "TB_PesquisaNome_Excluir";
            this.TB_PesquisaNome_Excluir.Size = new System.Drawing.Size(263, 22);
            this.TB_PesquisaNome_Excluir.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nome";
            // 
            // B_Pesquisar_Excluir
            // 
            this.B_Pesquisar_Excluir.Location = new System.Drawing.Point(45, 74);
            this.B_Pesquisar_Excluir.Name = "B_Pesquisar_Excluir";
            this.B_Pesquisar_Excluir.Size = new System.Drawing.Size(82, 34);
            this.B_Pesquisar_Excluir.TabIndex = 26;
            this.B_Pesquisar_Excluir.Text = "Pesquisar";
            this.B_Pesquisar_Excluir.UseVisualStyleBackColor = true;
            this.B_Pesquisar_Excluir.Click += new System.EventHandler(this.B_Pesquisar_Excluir_Click);
            // 
            // TBP4_Exibir
            // 
            this.TBP4_Exibir.Controls.Add(this.Lista_resultado);
            this.TBP4_Exibir.Controls.Add(this.B_Exibir_Todos);
            this.TBP4_Exibir.Location = new System.Drawing.Point(4, 25);
            this.TBP4_Exibir.Name = "TBP4_Exibir";
            this.TBP4_Exibir.Padding = new System.Windows.Forms.Padding(3);
            this.TBP4_Exibir.Size = new System.Drawing.Size(855, 459);
            this.TBP4_Exibir.TabIndex = 3;
            this.TBP4_Exibir.Text = "Exibir";
            this.TBP4_Exibir.UseVisualStyleBackColor = true;
            // 
            // Lista_resultado
            // 
            this.Lista_resultado.FormattingEnabled = true;
            this.Lista_resultado.ItemHeight = 16;
            this.Lista_resultado.Location = new System.Drawing.Point(168, 147);
            this.Lista_resultado.Name = "Lista_resultado";
            this.Lista_resultado.Size = new System.Drawing.Size(244, 180);
            this.Lista_resultado.TabIndex = 1;
            // 
            // B_Exibir_Todos
            // 
            this.B_Exibir_Todos.Location = new System.Drawing.Point(82, 51);
            this.B_Exibir_Todos.Name = "B_Exibir_Todos";
            this.B_Exibir_Todos.Size = new System.Drawing.Size(130, 40);
            this.B_Exibir_Todos.TabIndex = 0;
            this.B_Exibir_Todos.Text = "Exibir Todos";
            this.B_Exibir_Todos.UseVisualStyleBackColor = true;
            this.B_Exibir_Todos.Click += new System.EventHandler(this.B_Exibir_Todos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 496);
            this.Controls.Add(this.TBC_Menu);
            this.Name = "Form1";
            this.Text = "CRUD De Pessoas - Lista Encadeada";
            this.TBC_Menu.ResumeLayout(false);
            this.TBP1_Incluir.ResumeLayout(false);
            this.TBP1_Incluir.PerformLayout();
            this.TBP2_Alterar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TBP3_Excluir.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TBP4_Exibir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TBC_Menu;
        private System.Windows.Forms.TabPage TBP1_Incluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Idade_Incluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Gravar;
        private System.Windows.Forms.TextBox TB_Nome_Incluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TBP2_Alterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_Salvar;
        private System.Windows.Forms.ComboBox CB_Sexo_Alterar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_Idade_Alterar;
        private System.Windows.Forms.TextBox TB_Nome_Alterar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_PesquisaNome_Alterar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button B_Pesquisa_Alterar;
        private System.Windows.Forms.TabPage TBP3_Excluir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button B_Excluir;
        private System.Windows.Forms.ComboBox CB_Sexo_Excluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Idade_Excluir;
        private System.Windows.Forms.TextBox TB_Nome_Excluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TB_PesquisaNome_Excluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button B_Pesquisar_Excluir;
        private System.Windows.Forms.TabPage TBP4_Exibir;
        private System.Windows.Forms.ListBox Lista_resultado;
        private System.Windows.Forms.Button B_Exibir_Todos;
        public System.Windows.Forms.ComboBox CB_Sexo_Incluir;
    }
}



namespace Exercicio_27
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lista_SemTratamento = new System.Windows.Forms.ListBox();
            this.B_Exibir_SemTratamento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Procurar_SemTratamento = new System.Windows.Forms.Button();
            this.TB_Nome_SemTratamento = new System.Windows.Forms.TextBox();
            this.B_Salvar_SemTratamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Idade_SemTratamento = new System.Windows.Forms.TextBox();
            this.CB_Genero_SemTratamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Lista_ComTratamento = new System.Windows.Forms.ListBox();
            this.B_Exibir_ComTratamento = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.B_Procurar_ComTratamento = new System.Windows.Forms.Button();
            this.TB_Nome_ComTratamento = new System.Windows.Forms.TextBox();
            this.B_Salvar_ComTratamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Idade_ComTratamento = new System.Windows.Forms.TextBox();
            this.CB_Genero_ComTratamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Lista_ListaEncadeada = new System.Windows.Forms.ListBox();
            this.B_Exibir_ListaEncadeada = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.B_Procurar_ListaEncadeada = new System.Windows.Forms.Button();
            this.TB_Nome_ListaEncadeada = new System.Windows.Forms.TextBox();
            this.B_Salvar_ListaEncadeada = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Idade_ListaEncadeada = new System.Windows.Forms.TextBox();
            this.CB_Genero_ListaEncadeada = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sem tratamento ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lista_SemTratamento);
            this.groupBox2.Controls.Add(this.B_Exibir_SemTratamento);
            this.groupBox2.Location = new System.Drawing.Point(437, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 252);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório";
            // 
            // Lista_SemTratamento
            // 
            this.Lista_SemTratamento.FormattingEnabled = true;
            this.Lista_SemTratamento.ItemHeight = 16;
            this.Lista_SemTratamento.Location = new System.Drawing.Point(6, 21);
            this.Lista_SemTratamento.Name = "Lista_SemTratamento";
            this.Lista_SemTratamento.Size = new System.Drawing.Size(267, 164);
            this.Lista_SemTratamento.TabIndex = 4;
            // 
            // B_Exibir_SemTratamento
            // 
            this.B_Exibir_SemTratamento.Location = new System.Drawing.Point(99, 208);
            this.B_Exibir_SemTratamento.Name = "B_Exibir_SemTratamento";
            this.B_Exibir_SemTratamento.Size = new System.Drawing.Size(78, 28);
            this.B_Exibir_SemTratamento.TabIndex = 10;
            this.B_Exibir_SemTratamento.Text = "Exibir";
            this.B_Exibir_SemTratamento.UseVisualStyleBackColor = true;
            this.B_Exibir_SemTratamento.Click += new System.EventHandler(this.B_Exibir_SemTratamento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Procurar_SemTratamento);
            this.groupBox1.Controls.Add(this.TB_Nome_SemTratamento);
            this.groupBox1.Controls.Add(this.B_Salvar_SemTratamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_Idade_SemTratamento);
            this.groupBox1.Controls.Add(this.CB_Genero_SemTratamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 302);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir/Consultar/Alterar";
            // 
            // B_Procurar_SemTratamento
            // 
            this.B_Procurar_SemTratamento.Location = new System.Drawing.Point(235, 42);
            this.B_Procurar_SemTratamento.Name = "B_Procurar_SemTratamento";
            this.B_Procurar_SemTratamento.Size = new System.Drawing.Size(78, 28);
            this.B_Procurar_SemTratamento.TabIndex = 3;
            this.B_Procurar_SemTratamento.Text = "Procurar";
            this.B_Procurar_SemTratamento.UseVisualStyleBackColor = true;
            this.B_Procurar_SemTratamento.Click += new System.EventHandler(this.B_Procurar_SemTratamento_Click);
            // 
            // TB_Nome_SemTratamento
            // 
            this.TB_Nome_SemTratamento.Location = new System.Drawing.Point(98, 105);
            this.TB_Nome_SemTratamento.Name = "TB_Nome_SemTratamento";
            this.TB_Nome_SemTratamento.Size = new System.Drawing.Size(180, 22);
            this.TB_Nome_SemTratamento.TabIndex = 7;
            // 
            // B_Salvar_SemTratamento
            // 
            this.B_Salvar_SemTratamento.Location = new System.Drawing.Point(120, 255);
            this.B_Salvar_SemTratamento.Name = "B_Salvar_SemTratamento";
            this.B_Salvar_SemTratamento.Size = new System.Drawing.Size(78, 28);
            this.B_Salvar_SemTratamento.TabIndex = 9;
            this.B_Salvar_SemTratamento.Text = "Salvar";
            this.B_Salvar_SemTratamento.UseVisualStyleBackColor = true;
            this.B_Salvar_SemTratamento.Click += new System.EventHandler(this.B_Salvar_SemTratamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gênero";
            // 
            // TB_Idade_SemTratamento
            // 
            this.TB_Idade_SemTratamento.Location = new System.Drawing.Point(98, 42);
            this.TB_Idade_SemTratamento.Name = "TB_Idade_SemTratamento";
            this.TB_Idade_SemTratamento.Size = new System.Drawing.Size(100, 22);
            this.TB_Idade_SemTratamento.TabIndex = 1;
            // 
            // CB_Genero_SemTratamento
            // 
            this.CB_Genero_SemTratamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Genero_SemTratamento.FormattingEnabled = true;
            this.CB_Genero_SemTratamento.Items.AddRange(new object[] {
            "",
            "Feminino",
            "Masculino"});
            this.CB_Genero_SemTratamento.Location = new System.Drawing.Point(98, 185);
            this.CB_Genero_SemTratamento.Name = "CB_Genero_SemTratamento";
            this.CB_Genero_SemTratamento.Size = new System.Drawing.Size(157, 24);
            this.CB_Genero_SemTratamento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Com Tratamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Lista_ComTratamento);
            this.groupBox3.Controls.Add(this.B_Exibir_ComTratamento);
            this.groupBox3.Location = new System.Drawing.Point(450, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 252);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relatório";
            // 
            // Lista_ComTratamento
            // 
            this.Lista_ComTratamento.FormattingEnabled = true;
            this.Lista_ComTratamento.ItemHeight = 16;
            this.Lista_ComTratamento.Location = new System.Drawing.Point(6, 21);
            this.Lista_ComTratamento.Name = "Lista_ComTratamento";
            this.Lista_ComTratamento.Size = new System.Drawing.Size(267, 164);
            this.Lista_ComTratamento.TabIndex = 4;
            // 
            // B_Exibir_ComTratamento
            // 
            this.B_Exibir_ComTratamento.Location = new System.Drawing.Point(102, 218);
            this.B_Exibir_ComTratamento.Name = "B_Exibir_ComTratamento";
            this.B_Exibir_ComTratamento.Size = new System.Drawing.Size(78, 28);
            this.B_Exibir_ComTratamento.TabIndex = 10;
            this.B_Exibir_ComTratamento.Text = "Exibir";
            this.B_Exibir_ComTratamento.UseVisualStyleBackColor = true;
            this.B_Exibir_ComTratamento.Click += new System.EventHandler(this.B_Exibir_ComTratamento_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.B_Procurar_ComTratamento);
            this.groupBox4.Controls.Add(this.TB_Nome_ComTratamento);
            this.groupBox4.Controls.Add(this.B_Salvar_ComTratamento);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TB_Idade_ComTratamento);
            this.groupBox4.Controls.Add(this.CB_Genero_ComTratamento);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(37, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 302);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inserir/Consultar/Alterar";
            // 
            // B_Procurar_ComTratamento
            // 
            this.B_Procurar_ComTratamento.Location = new System.Drawing.Point(235, 42);
            this.B_Procurar_ComTratamento.Name = "B_Procurar_ComTratamento";
            this.B_Procurar_ComTratamento.Size = new System.Drawing.Size(78, 28);
            this.B_Procurar_ComTratamento.TabIndex = 3;
            this.B_Procurar_ComTratamento.Text = "Procurar";
            this.B_Procurar_ComTratamento.UseVisualStyleBackColor = true;
            this.B_Procurar_ComTratamento.Click += new System.EventHandler(this.B_Procurar_ComTratamento_Click);
            // 
            // TB_Nome_ComTratamento
            // 
            this.TB_Nome_ComTratamento.Location = new System.Drawing.Point(98, 105);
            this.TB_Nome_ComTratamento.Name = "TB_Nome_ComTratamento";
            this.TB_Nome_ComTratamento.Size = new System.Drawing.Size(180, 22);
            this.TB_Nome_ComTratamento.TabIndex = 7;
            // 
            // B_Salvar_ComTratamento
            // 
            this.B_Salvar_ComTratamento.Location = new System.Drawing.Point(120, 255);
            this.B_Salvar_ComTratamento.Name = "B_Salvar_ComTratamento";
            this.B_Salvar_ComTratamento.Size = new System.Drawing.Size(78, 28);
            this.B_Salvar_ComTratamento.TabIndex = 9;
            this.B_Salvar_ComTratamento.Text = "Salvar";
            this.B_Salvar_ComTratamento.UseVisualStyleBackColor = true;
            this.B_Salvar_ComTratamento.Click += new System.EventHandler(this.B_Salvar_ComTratamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gênero";
            // 
            // TB_Idade_ComTratamento
            // 
            this.TB_Idade_ComTratamento.Location = new System.Drawing.Point(98, 42);
            this.TB_Idade_ComTratamento.Name = "TB_Idade_ComTratamento";
            this.TB_Idade_ComTratamento.Size = new System.Drawing.Size(100, 22);
            this.TB_Idade_ComTratamento.TabIndex = 1;
            // 
            // CB_Genero_ComTratamento
            // 
            this.CB_Genero_ComTratamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Genero_ComTratamento.FormattingEnabled = true;
            this.CB_Genero_ComTratamento.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.CB_Genero_ComTratamento.Location = new System.Drawing.Point(98, 185);
            this.CB_Genero_ComTratamento.Name = "CB_Genero_ComTratamento";
            this.CB_Genero_ComTratamento.Size = new System.Drawing.Size(157, 24);
            this.CB_Genero_ComTratamento.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Com e Tratamento de Lista Encadeada";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Lista_ListaEncadeada);
            this.groupBox5.Controls.Add(this.B_Exibir_ListaEncadeada);
            this.groupBox5.Location = new System.Drawing.Point(450, 47);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 252);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Relatório";
            // 
            // Lista_ListaEncadeada
            // 
            this.Lista_ListaEncadeada.FormattingEnabled = true;
            this.Lista_ListaEncadeada.ItemHeight = 16;
            this.Lista_ListaEncadeada.Location = new System.Drawing.Point(6, 21);
            this.Lista_ListaEncadeada.Name = "Lista_ListaEncadeada";
            this.Lista_ListaEncadeada.Size = new System.Drawing.Size(267, 164);
            this.Lista_ListaEncadeada.TabIndex = 4;
            // 
            // B_Exibir_ListaEncadeada
            // 
            this.B_Exibir_ListaEncadeada.Location = new System.Drawing.Point(108, 218);
            this.B_Exibir_ListaEncadeada.Name = "B_Exibir_ListaEncadeada";
            this.B_Exibir_ListaEncadeada.Size = new System.Drawing.Size(78, 28);
            this.B_Exibir_ListaEncadeada.TabIndex = 10;
            this.B_Exibir_ListaEncadeada.Text = "Exibir";
            this.B_Exibir_ListaEncadeada.UseVisualStyleBackColor = true;
            this.B_Exibir_ListaEncadeada.Click += new System.EventHandler(this.B_Exibir_ListaEncadeada_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.B_Procurar_ListaEncadeada);
            this.groupBox6.Controls.Add(this.TB_Nome_ListaEncadeada);
            this.groupBox6.Controls.Add(this.B_Salvar_ListaEncadeada);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.TB_Idade_ListaEncadeada);
            this.groupBox6.Controls.Add(this.CB_Genero_ListaEncadeada);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(37, 47);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(355, 302);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Inserir/Consultar/Alterar";
            // 
            // B_Procurar_ListaEncadeada
            // 
            this.B_Procurar_ListaEncadeada.Location = new System.Drawing.Point(235, 42);
            this.B_Procurar_ListaEncadeada.Name = "B_Procurar_ListaEncadeada";
            this.B_Procurar_ListaEncadeada.Size = new System.Drawing.Size(78, 28);
            this.B_Procurar_ListaEncadeada.TabIndex = 3;
            this.B_Procurar_ListaEncadeada.Text = "Procurar";
            this.B_Procurar_ListaEncadeada.UseVisualStyleBackColor = true;
            this.B_Procurar_ListaEncadeada.Click += new System.EventHandler(this.B_Procurar_ListaEncadeada_Click);
            // 
            // TB_Nome_ListaEncadeada
            // 
            this.TB_Nome_ListaEncadeada.Location = new System.Drawing.Point(98, 105);
            this.TB_Nome_ListaEncadeada.Name = "TB_Nome_ListaEncadeada";
            this.TB_Nome_ListaEncadeada.Size = new System.Drawing.Size(180, 22);
            this.TB_Nome_ListaEncadeada.TabIndex = 7;
            // 
            // B_Salvar_ListaEncadeada
            // 
            this.B_Salvar_ListaEncadeada.Location = new System.Drawing.Point(120, 255);
            this.B_Salvar_ListaEncadeada.Name = "B_Salvar_ListaEncadeada";
            this.B_Salvar_ListaEncadeada.Size = new System.Drawing.Size(78, 28);
            this.B_Salvar_ListaEncadeada.TabIndex = 9;
            this.B_Salvar_ListaEncadeada.Text = "Salvar";
            this.B_Salvar_ListaEncadeada.UseVisualStyleBackColor = true;
            this.B_Salvar_ListaEncadeada.Click += new System.EventHandler(this.B_Salvar_ListaEncadeada_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Idade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gênero";
            // 
            // TB_Idade_ListaEncadeada
            // 
            this.TB_Idade_ListaEncadeada.Location = new System.Drawing.Point(98, 42);
            this.TB_Idade_ListaEncadeada.Name = "TB_Idade_ListaEncadeada";
            this.TB_Idade_ListaEncadeada.Size = new System.Drawing.Size(100, 22);
            this.TB_Idade_ListaEncadeada.TabIndex = 1;
            // 
            // CB_Genero_ListaEncadeada
            // 
            this.CB_Genero_ListaEncadeada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Genero_ListaEncadeada.FormattingEnabled = true;
            this.CB_Genero_ListaEncadeada.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.CB_Genero_ListaEncadeada.Location = new System.Drawing.Point(98, 185);
            this.CB_Genero_ListaEncadeada.Name = "CB_Genero_ListaEncadeada";
            this.CB_Genero_ListaEncadeada.Size = new System.Drawing.Size(157, 24);
            this.CB_Genero_ListaEncadeada.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Lista_SemTratamento;
        private System.Windows.Forms.Button B_Exibir_SemTratamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_Procurar_SemTratamento;
        private System.Windows.Forms.TextBox TB_Nome_SemTratamento;
        private System.Windows.Forms.Button B_Salvar_SemTratamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Idade_SemTratamento;
        private System.Windows.Forms.ComboBox CB_Genero_SemTratamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox Lista_ComTratamento;
        private System.Windows.Forms.Button B_Exibir_ComTratamento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button B_Procurar_ComTratamento;
        private System.Windows.Forms.TextBox TB_Nome_ComTratamento;
        private System.Windows.Forms.Button B_Salvar_ComTratamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Idade_ComTratamento;
        private System.Windows.Forms.ComboBox CB_Genero_ComTratamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox Lista_ListaEncadeada;
        private System.Windows.Forms.Button B_Exibir_ListaEncadeada;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button B_Procurar_ListaEncadeada;
        private System.Windows.Forms.TextBox TB_Nome_ListaEncadeada;
        private System.Windows.Forms.Button B_Salvar_ListaEncadeada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Idade_ListaEncadeada;
        private System.Windows.Forms.ComboBox CB_Genero_ListaEncadeada;
        private System.Windows.Forms.Label label9;
    }
}


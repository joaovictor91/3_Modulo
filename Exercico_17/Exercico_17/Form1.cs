using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercico_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class tp_no
        {
            public string nome,idade,genero;
            public tp_no prox;
        }
        tp_no topo = null, atual = null, anterior = null;


        void Insere(ref tp_no t, string n, string i, string g)
        {
            tp_no no = new tp_no();
            no.nome = n;
            no.idade = i;
            no.genero = g;
            if (t != null)
                no.prox = t;
            t = no;
        }
        void Procura(tp_no t, string nomeProcurado, ref tp_no a, ref tp_no ant)
        {
            ant = null;
            a = t;
            while (a != null && nomeProcurado != a.nome)
            {
                ant = a;
                a = a.prox;
            }
        }

        private void B_Exibir_Todos_Click(object sender, EventArgs e)
        {
            Lista_resultado.Items.Clear();
            atual = topo;
            int i = 1;
            while (atual != null) // Não é o fim da lista
            {
                Lista_resultado.Items.Add("Registro: " + i);
                Lista_resultado.Items.Add("Nome: " + atual.nome);
                Lista_resultado.Items.Add("Idade: " + atual.idade);
                Lista_resultado.Items.Add("Gênero: " + atual.genero);
                Lista_resultado.Items.Add("---------------------------------------------");
                atual = atual.prox;
                i++;
            }
        }

        private void B_Salvar_Click(object sender, EventArgs e)
        {
            if (TB_Nome_Alterar.Text != "" && TB_Idade_Alterar.Text != "" && CB_Sexo_Alterar.Text != "")
            {
                atual.nome = TB_Nome_Alterar.Text;
                atual.idade = TB_Idade_Alterar.Text;
                atual.genero = CB_Sexo_Alterar.Text;
                MessageBox.Show("Os dados foram alterados!");
                TB_Nome_Alterar.Clear();
                TB_Idade_Alterar.Clear();
                CB_Sexo_Alterar.Text = "";
                TB_PesquisaNome_Alterar.Clear();


            }
            /* Se o campo inteiro estiver vazio*/
            else if (TB_Nome_Alterar.Text == "" && TB_Idade_Alterar.Text == "" && CB_Sexo_Alterar.Text == "")
            {
                MessageBox.Show("Não foi digitado nada!");
            }
            /*Se os outros campos estiverem vazio */
            else if (TB_Nome_Alterar.Text == "" && CB_Sexo_Alterar.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e selecioar o sexo!");
            }
            else if (TB_Nome_Alterar.Text == "" && TB_Idade_Alterar.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e a idade!");
            }
            else if (TB_Idade_Alterar.Text == "" && TB_Nome_Alterar.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e o nome!");
            }
            else if (TB_Idade_Alterar.Text == "" && CB_Sexo_Alterar.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e selecioar o sexo!");
            }
            else if (CB_Sexo_Alterar.Text == "" && TB_Nome_Alterar.Text == "")
            {
                MessageBox.Show("Falta selecioar o sexo e digitar o nome!");
            }
            else if (CB_Sexo_Alterar.Text == "" && TB_Idade_Alterar.Text == "")
            {
                MessageBox.Show("Falta selecioar o sexo e digitar a idade!");
            }
            /* Se só um campo estiver vazio*/
            else if (TB_Nome_Alterar.Text == "")
            {
                MessageBox.Show("Falta digitar o nome!");
            }
            else if (TB_Idade_Alterar.Text == "")
            {
                MessageBox.Show("Falta digitar a idade!");
            }
            else if (CB_Sexo_Alterar.Text == "")
            {
                MessageBox.Show("Falta selecioar o sexo!");
            }
            
        }

        private void B_Pesquisar_Excluir_Click(object sender, EventArgs e)
        {
            Procura(topo, TB_PesquisaNome_Excluir.Text, ref atual, ref anterior);
            if (atual != null)  // Encontrou
            {
                // Pega da memória e joga na IU
                TB_Nome_Excluir.Text = atual.nome;
                TB_Idade_Excluir.Text = atual.idade;
                CB_Sexo_Excluir.Text = atual.genero;
            }
            else // Não encontrou
                MessageBox.Show("Não encontrado!");
        }

        private void B_Excluir_Click(object sender, EventArgs e)
        {
            if (atual == topo) // É o 1º elemento
            {
                topo = atual.prox;
                atual.prox = null;
            }
            else if (atual.prox == null) // É o último elemento
            {
                anterior.prox = null;
            }
            else // É um do meio
            {
                anterior.prox = atual.prox;
                atual.prox = null;
            }
            MessageBox.Show("Os dados foram Excluidos!");
            TB_Nome_Excluir.Clear();
            TB_Idade_Excluir.Clear();
            CB_Sexo_Excluir.Text = "";
            TB_PesquisaNome_Excluir.Clear();
        }

        private void B_Pesquisa_Alterar_Click(object sender, EventArgs e)
        {

            Procura(topo, TB_PesquisaNome_Alterar.Text, ref atual, ref anterior);
            if (atual != null)  // Encontrou
            {
                // Pega da memória e joga na IU
                TB_Nome_Alterar.Text = atual.nome;
                TB_Idade_Alterar.Text = atual.idade;
                CB_Sexo_Alterar.Text = atual.genero;
            }
            else // Não encontrou
                MessageBox.Show("Não encontrado!");
        }
      


        private void B_Gravar_Click(object sender, EventArgs e)
        {
            string n1, n2, n3;
            /* Se os campos estiverem preenchidos*/
            if (TB_Nome_Incluir.Text != "" && TB_Idade_Incluir.Text!="" && CB_Sexo_Incluir.Text!="")
            {

                n1 = TB_Nome_Incluir.Text;
                n2 = TB_Idade_Incluir.Text;
                n3 = CB_Sexo_Incluir.Text;
                Insere(ref topo, TB_Nome_Incluir.Text, TB_Idade_Incluir.Text, CB_Sexo_Incluir.Text);
                TB_Nome_Incluir.Clear();
                TB_Idade_Incluir.Clear();
                CB_Sexo_Incluir.Text="";

            }
            /* Se o campo inteiro estiver vazio*/
            else if(TB_Nome_Incluir.Text == "" && TB_Idade_Incluir.Text == "" && CB_Sexo_Incluir.Text == "")
            {
                MessageBox.Show("Não foi digitado nada!");
            }
            /*Se os outros campos estiverem vazio */
            else if(TB_Nome_Incluir.Text == "" && CB_Sexo_Incluir.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e selecioar o sexo!");
            }
            else if (TB_Nome_Incluir.Text == "" && TB_Idade_Incluir.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e a idade!");
            }
            else if (TB_Idade_Incluir.Text == "" && TB_Nome_Incluir.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e o nome!");
            }
            else if (TB_Idade_Incluir.Text == "" && CB_Sexo_Incluir.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e selecioar o sexo!");
            }
            else if (CB_Sexo_Incluir.Text == "" && TB_Nome_Incluir.Text == "")
            {
                MessageBox.Show("Falta selecioar o sexo e digitar o nome!");
            }
            else if (CB_Sexo_Incluir.Text == "" && TB_Idade_Incluir.Text == "")
            {
                MessageBox.Show("Falta selecioar o sexo e digitar a idade!");
            }
            /* Se só um campo estiver vazio*/
            else if (TB_Nome_Incluir.Text == "")
            {
                MessageBox.Show("Falta digitar o nome!");
            }
            else if (TB_Idade_Incluir.Text == "")
            {
                MessageBox.Show("Falta digitar o idade!");
            }
            else if (CB_Sexo_Incluir.Text == "")
            {
                MessageBox.Show("Falta selecioar o sexo!");
            }
            
        }
        }
}

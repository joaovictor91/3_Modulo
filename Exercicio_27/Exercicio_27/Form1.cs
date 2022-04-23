using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int N = 5;
        class tp_registro
        {
            public int idade;
            public string nome, genero;
            public tp_registro prox;

        }
        tp_registro topo = null, atual = null, anterior = null;

        //Lista Linear Ínicio
        int Hash(int chave)
        {
            return (chave % N);
        }

        void InsereLinear(tp_registro[] v, int id, string nm, string gn)
        {
            int pos = Hash(id);
            while (v[pos].idade != 0)
            {
                pos++;
                pos = pos % N;
                
            }
            v[pos].idade = id;
            v[pos].nome = nm;
            v[pos].genero = gn;
        }

        int RecuperaLinear(tp_registro[] v, int id)
        {
            int pos = Hash(id);
            while (v[pos].idade != id)
            {
                pos++;
                pos = pos % N;
            }
            return pos;
        }



        //Fim Lista Linear


        // Sem Tratamento
        int Hash2(int chave)
        {
            return (chave % N);
        }

        void InsereSemTratamento(tp_registro[] v2, int id, string nm, string gn)
        {
            int pos = Hash2(id);
            
            v2[pos].idade = id;
            v2[pos].nome = nm;
            v2[pos].genero = gn;
        }

        int RecuperaSemTratamento(tp_registro[] v2, int id)
        {
            int pos = Hash2(id);
            
            return pos;
        }

        // Fim Sem Tratamento

        //Encadeada 
        int Hash3(int chave)
        {
            return (chave % N);
        }

        void InsereEncadeada(tp_registro[] v3, tp_registro no)
        {
            
            int pos = Hash3(no.idade);
            if (v3[pos] != null)
                
                no.prox = v3[pos];
                
            v3[pos] = no;
        }

        int RecuperaEncadeada(tp_registro[] v3, int id, ref tp_registro a, ref tp_registro ant)
        {
            ant = null;
            
            int pos = Hash(id);
            a = v3[pos];
            while (a != null && id !=a.idade)
            {

                ant = a;
                a = a.prox;

            }
            return pos;
        }


        //Fim Encadeada
        bool verifica=true;
        tp_registro[] vetor = new tp_registro[N];
        tp_registro[] vetor2 = new tp_registro[N];
        tp_registro[] vetor3= new tp_registro[N];
        
        
        


    private void B_Salvar_ComTratamento_Click(object sender, EventArgs e)
        {
            
            int pos = 0;
            Lista_ComTratamento.Items.Clear();
            

            if (TB_Nome_ComTratamento.Text != "" && TB_Idade_ComTratamento.Text != "" && CB_Genero_ComTratamento.Text != "")
            {
                int id = Convert.ToInt32(TB_Idade_ComTratamento.Text);
                string nm = TB_Nome_ComTratamento.Text, gn = CB_Genero_ComTratamento.Text;
                if (verifica == true)
                {

                    int aux=0;
                    while (pos < N)
                    {
                        if (vetor[pos].idade == id)
                        {
                            aux = id;

                        }
                        

                        pos++;
                    }
                    if (id != aux)
                    {
                        InsereLinear(vetor, id, nm, gn);
                        MessageBox.Show("Cadastro Realizado Com Sucesso!");
                        TB_Nome_ComTratamento.Clear();
                        TB_Idade_ComTratamento.Clear();
                        CB_Genero_ComTratamento.Text = "";
                    }
                    else 
                    {
                        MessageBox.Show("Cadastro Não Realizado! Por Causa que já possui um cadastro com a mesma idade!");


                    }
                        




                }
                else
                {
                    TB_Idade_ComTratamento.Enabled=true;
                    while (pos < N)
                    {


                        if (id == vetor[pos].idade)
                        {
                            vetor[pos].nome = TB_Nome_ComTratamento.Text;
                            vetor[pos].genero = CB_Genero_ComTratamento.Text;
                            MessageBox.Show("Cadastro foi atualizado Com Sucesso!");
                            verifica = true;
                        }
                        pos++;
                    }
                    TB_Nome_ComTratamento.Clear();
                    TB_Idade_ComTratamento.Clear();
                    CB_Genero_ComTratamento.Text = "";
                }


            }
            /* Se o campo inteiro estiver vazio*/
            else if (TB_Nome_ComTratamento.Text == "" && TB_Idade_ComTratamento.Text == "" && CB_Genero_ComTratamento.Text == "")
            {
                MessageBox.Show("Não foi digitado nada!");
            }
            /*Se os outros campos estiverem vazio */
            else if (TB_Nome_ComTratamento.Text == "" && CB_Genero_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e selecioar o gênero!");
            }
            else if (TB_Nome_ComTratamento.Text == "" && TB_Idade_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e a idade!");
            }
            else if (TB_Idade_ComTratamento.Text == "" && TB_Nome_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e o nome!");
            }
            else if (TB_Idade_ComTratamento.Text == "" && CB_Genero_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e selecioar o gênero!");
            }
            else if (CB_Genero_ComTratamento.Text == "" && TB_Nome_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero e digitar o nome!");
            }
            else if (CB_Genero_ComTratamento.Text == "" && TB_Idade_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero e digitar a idade!");
            }
            /* Se só um campo estiver vazio*/
            else if (TB_Nome_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o nome!");
            }
            else if (TB_Idade_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o idade!");
            }
            else if (CB_Genero_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero!");
            }


            
            
            
            

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
                vetor[i] = new tp_registro();


            for (int i = 0; i < N; i++)
                vetor2[i] = new tp_registro();

            
            for (int i = 0; i < N; i++)
                vetor3[i] =null;
        }

        private void B_Procurar_ComTratamento_Click(object sender, EventArgs e)
        {
            if (TB_Idade_ComTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o idade!");
            }
            else
            {
                Lista_ComTratamento.Items.Clear();

                int id = Convert.ToInt32(TB_Idade_ComTratamento.Text), x = 0;
                bool r = false;
                while (x < N)
                {
                    if (vetor[x].idade == id)
                    {
                        r = true;

                    }

                    x++;
                }
                if (r == true)
                {
                    int pos = RecuperaLinear(vetor, Convert.ToInt32(TB_Idade_ComTratamento.Text));
                    TB_Nome_ComTratamento.Text = vetor[pos].nome;
                    CB_Genero_ComTratamento.Text = vetor[pos].genero;
                    verifica = false;
                    TB_Idade_ComTratamento.Enabled = false;
                }
                else
                    MessageBox.Show("Não foi encontrado!");

            }

        }

        private void B_Exibir_ComTratamento_Click(object sender, EventArgs e)
        {
            Lista_ComTratamento.Items.Clear();
            int pos = 0;
            
            TB_Idade_ComTratamento.Enabled = true;
            TB_Nome_ComTratamento.Clear();
            TB_Idade_ComTratamento.Clear();
            CB_Genero_ComTratamento.Text = "";
            verifica = true;
            while (pos<N)
            {
                if (vetor[pos].nome != null)
                {
                    Lista_ComTratamento.Items.Add("Posição: " + pos);
                    Lista_ComTratamento.Items.Add("Idade: " + vetor[pos].idade);
                    Lista_ComTratamento.Items.Add("Nome: " + vetor[pos].nome);
                    Lista_ComTratamento.Items.Add("Gênero: " + vetor[pos].genero);
                    Lista_ComTratamento.Items.Add("---------------------------------------------");

                }
                
                pos++;
            }
        }

        private void B_Salvar_SemTratamento_Click(object sender, EventArgs e)
        {
            Lista_SemTratamento.Items.Clear();
            
            int pos = 0;
            if (TB_Nome_SemTratamento.Text != "" && TB_Idade_SemTratamento.Text != "" && CB_Genero_SemTratamento.Text != "")
            {
                int id = Convert.ToInt32(TB_Idade_SemTratamento.Text);
                string nm = TB_Nome_SemTratamento.Text, gn = CB_Genero_SemTratamento.Text;
                if (verifica == true)
                {
                    InsereSemTratamento(vetor2, id, nm, gn);

                    MessageBox.Show("Cadastro Realizado Com Sucesso!");
                    TB_Idade_SemTratamento.Clear();
                    TB_Nome_SemTratamento.Clear();
                    CB_Genero_SemTratamento.Text = "";

                }
                else
                {
                    while (pos < N)
                    {
                        TB_Idade_SemTratamento.Enabled = true;

                        if (id == vetor2[pos].idade)
                        {
                            vetor2[pos].nome = TB_Nome_SemTratamento.Text;
                            vetor2[pos].genero = CB_Genero_SemTratamento.Text;
                            MessageBox.Show("Cadastro foi atualizado Com Sucesso!");
                            verifica = true;
                        }
                        pos++;
                    }
                    TB_Idade_SemTratamento.Clear();
                    TB_Nome_SemTratamento.Clear();
                    CB_Genero_SemTratamento.Text = "";
                }


            }
            /* Se o campo inteiro estiver vazio*/
            else if (TB_Nome_SemTratamento.Text == "" && TB_Idade_SemTratamento.Text == "" && CB_Genero_SemTratamento.Text == "")
            {
                MessageBox.Show("Não foi digitado nada!");
            }
            /*Se os outros campos estiverem vazio */
            else if (TB_Nome_SemTratamento.Text == "" && CB_Genero_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e selecioar o gênero!");
            }
            else if (TB_Nome_SemTratamento.Text == "" && TB_Idade_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e a idade!");
            }
            else if (TB_Idade_SemTratamento.Text == "" && TB_Nome_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e o nome!");
            }
            else if (TB_Idade_SemTratamento.Text == "" && CB_Genero_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e selecioar o gênero!");
            }
            else if (CB_Genero_SemTratamento.Text == "" && TB_Nome_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero e digitar o nome!");
            }
            else if (CB_Genero_SemTratamento.Text == "" && TB_Idade_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero e digitar a idade!");
            }
            /* Se só um campo estiver vazio*/
            else if (TB_Nome_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o nome!");
            }
            else if (TB_Idade_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o idade!");
            }
            else if (CB_Genero_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero!");
            }
            

            


            
        }

        private void B_Procurar_SemTratamento_Click(object sender, EventArgs e)
        {
            if (TB_Idade_SemTratamento.Text == "")
            {
                MessageBox.Show("Falta digitar o idade!");
            }
            else
            {
                Lista_SemTratamento.Items.Clear();
                int pos = RecuperaSemTratamento(vetor2, Convert.ToInt32(TB_Idade_SemTratamento.Text));
                int id = Convert.ToInt32(TB_Idade_SemTratamento.Text);
                if (id == vetor2[pos].idade)
                {
                    TB_Nome_SemTratamento.Text = vetor2[pos].nome;
                    CB_Genero_SemTratamento.Text = vetor2[pos].genero;
                    verifica = false;
                    TB_Idade_SemTratamento.Enabled = false;
                }
                else
                    MessageBox.Show("Não foi encontrado!");
            }
            


        }

        private void B_Exibir_SemTratamento_Click(object sender, EventArgs e)
        {
            Lista_SemTratamento.Items.Clear();
            int pos = 0;
            TB_Idade_SemTratamento.Enabled = true;
            TB_Idade_SemTratamento.Clear();
            TB_Nome_SemTratamento.Clear();
            CB_Genero_SemTratamento.Text = "";
            while (pos < N)
            {
                if (vetor2[pos].nome != null)
                {
                    Lista_SemTratamento.Items.Add("Posição: " + pos);
                    Lista_SemTratamento.Items.Add("Idade: " + vetor2[pos].idade);
                    Lista_SemTratamento.Items.Add("Nome: " + vetor2[pos].nome);
                    Lista_SemTratamento.Items.Add("Gênero: " + vetor2[pos].genero);
                    Lista_SemTratamento.Items.Add("---------------------------------------------");
                    
                }
                pos++;
            }
        }

        private void B_Salvar_ListaEncadeada_Click(object sender, EventArgs e)
        {
            Lista_ListaEncadeada.Items.Clear();
            
            
            if (TB_Nome_ListaEncadeada.Text != "" && TB_Idade_ListaEncadeada.Text != "" && CB_Genero_ListaEncadeada.Text != "")
            {
                int id = Convert.ToInt32(TB_Idade_ListaEncadeada.Text);
                string nm = TB_Nome_ListaEncadeada.Text, gn = CB_Genero_ListaEncadeada.Text;
                tp_registro no = new tp_registro();
                int aux = 0;
                int pos = 0;
                if (verifica == true)
                {

                    while (pos < N)
                    {
                        atual = vetor3[pos];
                        while (atual != null)
                        {
                            if (atual.idade == id)
                            {
                                aux = id;
                            }

                            atual = atual.prox;

                        }
                        pos++;
                    }
                    if (id != aux)
                    {
                        no.idade = id;
                        no.nome = nm;
                        no.genero = gn;
                        InsereEncadeada(vetor3, no);
                        MessageBox.Show("Cadastro Realizado Com Sucesso!");
                        TB_Idade_ListaEncadeada.Clear();
                        TB_Nome_ListaEncadeada.Clear();
                        CB_Genero_ListaEncadeada.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cadastro Não Realizado! Por Causa que já possui um cadastro com a mesma idade!");


                    }

                    

                }
                else
                {
                    TB_Idade_ListaEncadeada.Enabled = true;
                    
                    
                    atual.nome = TB_Nome_ListaEncadeada.Text;
                    atual.genero = CB_Genero_ListaEncadeada.Text;
                    MessageBox.Show("Cadastro foi atualizado Com Sucesso!");
                    TB_Idade_ListaEncadeada.Clear();
                    TB_Nome_ListaEncadeada.Clear();
                    CB_Genero_ListaEncadeada.Text = "";
                    verifica = true;
                }


            }
            /* Se o campo inteiro estiver vazio*/
            else if (TB_Nome_ListaEncadeada.Text == "" && TB_Idade_ListaEncadeada.Text == "" && CB_Genero_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Não foi digitado nada!");
            }
            /*Se os outros campos estiverem vazio */
            else if (TB_Nome_ListaEncadeada.Text == "" && CB_Genero_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e selecioar o gênero!");
            }
            else if (TB_Nome_ListaEncadeada.Text == "" && TB_Idade_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta digitar o nome e a idade!");
            }
            else if (TB_Idade_ListaEncadeada.Text == "" && TB_Nome_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e o nome!");
            }
            else if (TB_Idade_ListaEncadeada.Text == "" && CB_Genero_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta digitar a idade e selecioar o gênero!");
            }
            else if (CB_Genero_ListaEncadeada.Text == "" && TB_Nome_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero e digitar o nome!");
            }
            else if (CB_Genero_ListaEncadeada.Text == "" && TB_Idade_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero e digitar a idade!");
            }
            /* Se só um campo estiver vazio*/
            else if (TB_Nome_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta digitar o nome!");
            }
            else if (TB_Idade_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta digitar o idade!");
            }
            else if (CB_Genero_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta selecioar o gênero!");
            }
            

            

            
        }

        private void B_Exibir_ListaEncadeada_Click(object sender, EventArgs e)
        {
            Lista_ListaEncadeada.Items.Clear();
            int pos = 0;
            int i = 1;
            TB_Idade_ListaEncadeada.Enabled = true;
            TB_Idade_ListaEncadeada.Clear();
            TB_Nome_ListaEncadeada.Clear();
            CB_Genero_ListaEncadeada.Text = "";
            verifica = true;
            
            while (pos < N)
            {
                atual = vetor3[pos];
                while (atual!= null)
                {
                    Lista_ListaEncadeada.Items.Add("Posição: " + i);
                    Lista_ListaEncadeada.Items.Add("Idade: " + atual.idade);
                    Lista_ListaEncadeada.Items.Add("Nome: " + atual.nome);
                    Lista_ListaEncadeada.Items.Add("Gênero: " + atual.genero);

                    Lista_ListaEncadeada.Items.Add("---------------------------------------------");
                    atual= atual.prox;
                    i++;



                }
                pos++;
            }
        }

        private void B_Procurar_ListaEncadeada_Click(object sender, EventArgs e)
        {
            if (TB_Idade_ListaEncadeada.Text == "")
            {
                MessageBox.Show("Falta digitar o idade!");
            }
            else
            {
                Lista_ListaEncadeada.Items.Clear();
                int pos = RecuperaEncadeada(vetor3, Convert.ToInt32(TB_Idade_ListaEncadeada.Text), ref atual, ref anterior);

                if (atual != null)  // Encontrou
                {
                    // Pega da memória e joga na IU
                    TB_Nome_ListaEncadeada.Text = atual.nome;
                    CB_Genero_ListaEncadeada.Text = atual.genero;
                    verifica = false;

                    TB_Idade_ListaEncadeada.Enabled = false;

                }
                else // Não encontrou
                    MessageBox.Show("Não encontrado!");
            }
            
            
            
        }
    }
}

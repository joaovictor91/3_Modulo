using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class tp_no
        {
            public tp_no esq;
            public int valor;
            public tp_no dir;
        }
        tp_no raiz = null;
        
        void Insere(ref tp_no r, int x)
        {
            
            if (r == null)
            {
                r = new tp_no();
                r.valor = x;
            }
            else if (x < r.valor)
                Insere(ref r.esq, x);
            else 
                Insere(ref r.dir, x);
        }

        tp_no Busca(tp_no r, int x)
        {
            if (r == null)
                return null;
            else if (x == r.valor)
                return r;
            else if (x < r.valor)
                return Busca(r.esq, x);
            else
                return Busca(r.dir, x);
        }

        tp_no RetornaMaior(tp_no r)
        {
            if (r.dir == null)
            {
                tp_no p = r;
                r = r.esq;
                return p;
            }
            else
                return RetornaMaior(r.dir);
        }

        tp_no Remove(ref tp_no r, int x)
        {
            if (r == null)      // elemento nao encontrado
                return null;
            else if (x == r.valor)    // elemento encontrado
            {
                tp_no p = r;
                if (r.esq == null)        // nao tem filho esquerdo
                    r = r.dir;
                else if (r.dir == null)  // nao tem filho direito
                    r = r.esq;
                else                          // tem ambos os filhos
                {
                    p = RetornaMaior(r.esq);
                    r.valor = p.valor;
                }
                return p;
            }
            else if (x < r.valor)
                return Remove(ref r.esq, x);      // procura na subarvore esquerda
            else
                return Remove(ref r.dir, x);       // procura na subarvore direta
        }

        void EmOrdem(tp_no r)
        {
            if (r != null)
            {
                EmOrdem(r.esq);
                Lista_Exibir.Items.Add(r.valor);
                EmOrdem(r.dir);
            }
        }

        void PreOrdem(tp_no r)
        {
            if (r != null)
            {
                Lista_Exibir.Items.Add(r.valor);
                PreOrdem(r.esq);
                PreOrdem(r.dir);
            }
        }

        void PosOrdem(tp_no r)
        {
            if (r != null)
            {
                PosOrdem(r.esq);
                PosOrdem(r.dir);
                Lista_Exibir.Items.Add(r.valor);
            }
        }

        private void B_Insere_Click(object sender, EventArgs e)
        {
            Lista_Exibir.Items.Clear();
            int v;
            if (TB_Valor.Text != "")
            {
                v = Convert.ToInt32(TB_Valor.Text);

                Insere(ref raiz, v);
                MessageBox.Show("Valor Inserido!");
                TB_Valor.Clear();

            }

            else
            {
                MessageBox.Show("Não foi digitado nada!");
            }

        }

        private void B_Pesquisar_Click(object sender, EventArgs e)
        {
            Lista_Exibir.Items.Clear();
            int n1;
            if (TB_Valor.Text != "")
            {
                n1 = Convert.ToInt32(TB_Valor.Text);
                
                if (Busca(raiz,n1) != null)
                {
                    MessageBox.Show("O valor foi encontrado");
                    TB_Valor.Clear();
                }
                else 
                {
                    MessageBox.Show("O valor não foi encontrado");

                }

            }
            /* Se o campo inteiro estiver vazio*/
            else
            {
                MessageBox.Show("Não foi digitado nada!");
            }
        }

        private void B_Remover_Click(object sender, EventArgs e)
        {
            Lista_Exibir.Items.Clear();
            int n1;
            if (TB_Valor.Text != "")
            {
                n1 = Convert.ToInt32(TB_Valor.Text);
                
                if (Remove(ref raiz, n1) != null)
                {
                    MessageBox.Show("O valor foi Removido");
                    TB_Valor.Clear();

                }
                else
                {
                    MessageBox.Show("O valor não foi encontrado");

                }


            }
            /* Se o campo inteiro estiver vazio*/
            else
            {
                MessageBox.Show("Não foi digitado nada!");
            }
        }

        private void B_Exibir_Click(object sender, EventArgs e)
        {
            Lista_Exibir.Items.Clear();
            if (RB_EmOrdem.Checked)
            {
                EmOrdem(raiz);
            }
            else if (RB_PosOrdem.Checked)
            {
                PosOrdem(raiz);
            }
            else if (RB_PreOrdem.Checked)
            {
                PreOrdem(raiz);
            }
        }
    }
}

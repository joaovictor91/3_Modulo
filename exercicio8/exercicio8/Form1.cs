using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MAX = 50;
        class LLS_Pilha
        {
            public int topo = 0;
            public int[] vetor = new int[MAX];
        }
        bool EstaVazia(LLS_Pilha p)
        {
            if (p.topo == 0)
                return true;
            else
                return false;
        }
        bool EstaCheia(LLS_Pilha p)
        {
            if (p.topo == MAX)
                return true;
            else
                return false;
        }
        void Insere(LLS_Pilha p, int valor)
        {
            p.vetor[p.topo] = valor;
            p.topo = p.topo + 1;
        }
        int Remove(LLS_Pilha p)
        {
            p.topo = p.topo - 1;
            return (p.vetor[p.topo]);
        }

        LLS_Pilha pilha = new LLS_Pilha();

        private void B_Processa_Click(object sender, EventArgs e)
        {
            int numint=Convert.ToInt32(TB_NumInt.Text);
            string numbin;
            numbin = "";
            int resto;
            while (numint != 0)
            {
                Insere(pilha, numint % 2);
                numint = numint / 2;

            }
            TB_NumBin.Text = numbin;
            while (EstaVazia(pilha) == false) // (!Estavazia(pilha)  Não está vazia
            {
                resto=Remove(pilha);
                TB_NumBin.Text = TB_NumBin.Text + Convert.ToString(resto);

                
            
            }
            
            
        }
    }
}

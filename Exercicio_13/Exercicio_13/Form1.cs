using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MAX = 50;
        class LLS_Fila
        {
            public int inicio = 0;
            public int fim = 0;
            public int[] vetor = new int[MAX];
        }
        bool EstaVazia(LLS_Fila f)
        {
            if (f.inicio == f.fim)
                return true;
            else
                return false;
        }
        bool EstaCheia(LLS_Fila f)
        {
            if (f.fim == MAX)
                return true;
            else
                return false;
        }
        void Insere(LLS_Fila f, int valor)
        {
            f.vetor[f.fim] = valor;
            f.fim = f.fim + 1;
        }
        int Remove(LLS_Fila f)
        {
            int valor = f.vetor[f.inicio];
            f.inicio = f.inicio + 1;
            return valor;
        }
        LLS_Fila FilaOriginal = new LLS_Fila();
        LLS_Fila FilaMenores = new LLS_Fila();
        LLS_Fila FilaMaiores = new LLS_Fila();

        private void B_Insere_na_Fila_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TB_Valor.Text);

            if (EstaCheia(FilaOriginal) == false)
            {
                Insere(FilaOriginal, num);
            }
            else
                MessageBox.Show("A Fila está Cheia, não é possivel inserir mais valores");
            TB_Valor.Clear();
            TB_Valor.Focus();
            Lista_Maiores.Items.Clear();
            Lista_Menores.Items.Clear();

        }

        private void B_Divide_Fila_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(TB_Valor_p.Text);
            int n2, maior, menor;
            

            while (EstaVazia(FilaOriginal) == false)
            {
                n2 = Remove(FilaOriginal);
                if (n2 > p)
                {
                    
                    maior = n2;
                    Insere(FilaMaiores, maior);
                    
                }

                if (n2 <= p)
                {
                    
                    menor = n2;
                    Insere(FilaMenores, menor);
                    
                }
                
            }
           

        }

        private void B_Exibe_Filas_Click(object sender, EventArgs e)
        {
            int n3, n4;
            while (EstaVazia(FilaMenores) == false)
            {
                n3 = Remove(FilaMenores);
                Lista_Menores.Items.Add(n3);
            }
            while (EstaVazia(FilaMaiores) == false)
            {
                n4 = Remove(FilaMaiores);
                Lista_Maiores.Items.Add(n4);
            }
        }
    }
}

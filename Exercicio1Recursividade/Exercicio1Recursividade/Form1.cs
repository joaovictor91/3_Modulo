using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1Recursividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Exibe de forma Iterativa
        void CrescIt(int nI, int nF)
        {
            while (nI <= nF)
            {
                LB_Resultado.Items.Add(nI);
                nI += 1;
            }
        }
        // Exibe de forma Recursiva
        void CrescRec(int nI, int nF)
        {
            if (nI <= nF)
            {
                LB_Resultado.Items.Add(nI);
                CrescRec(nI + 1, nF);
            }
        }
        private void B_Crescente_Click(object sender, EventArgs e)
        {
            int NumInic, NumFinal;
            NumInic = Convert.ToInt32(TB_NumInicial.Text);
            NumFinal = Convert.ToInt32(TB_NumFinal.Text);
            LB_Resultado.Items.Clear();
            // CrescIt(NumInic, NumFinal);
            CrescRec(NumInic, NumFinal);
        }
        void DeCrescRec(int nI, int nF)
        {
            if (nI <= nF)
            {
                DeCrescRec(nI+1, nF);
                LB_Resultado.Items.Add(nI);
            }
        }
        private void B_Decrescente_Click(object sender, EventArgs e)
        {
            int NumInic, NumFinal;
            NumInic = Convert.ToInt32(TB_NumInicial.Text);
            NumFinal = Convert.ToInt32(TB_NumFinal.Text);
            LB_Resultado.Items.Clear();
            DeCrescRec(NumInic, NumFinal);
        }
        int SomaIt(int nI, int nF)
        {
            int s = 0;
            while (nI <= nF)
            {
                s = s + nI;
                nI += 1;
            }
            return s;
        }
        int SomaRec(int nI, int nF)
        {
            if (nI < nF)
                return SomaRec(nI + 1, nF) + nI;
            else
                return nI;
        }
        private void B_Somatorio_Click(object sender, EventArgs e)
        {
            int NumInic, NumFinal;
            NumInic = Convert.ToInt32(TB_NumInicial.Text);
            NumFinal = Convert.ToInt32(TB_NumFinal.Text);
            LB_Resultado.Items.Clear();
            int s;
            s = SomaRec(NumInic, NumFinal);
            LB_Resultado.Items.Add(s);
        }
        int[] vetor = new int[10];
        int tl = 0;
        private void B_Insere_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TB_Numero.Text);
            tl += 1;
            vetor[tl] = num;
            TB_Numero.Clear();
            TB_Numero.Focus();
        }
        int SomaVetorRec(int[] v, int nI, int nF)
        {
            if (nI < nF)
                return SomaVetorRec(v, nI + 1, nF) + v[nI];
            else
                return v[nI];
        }
        private void B_Soma_Click(object sender, EventArgs e)
        {
            LB_Resultado.Items.Clear();
            int s = SomaVetorRec(vetor, 1, tl);
            LB_Resultado.Items.Add(s);
        }
    }
}

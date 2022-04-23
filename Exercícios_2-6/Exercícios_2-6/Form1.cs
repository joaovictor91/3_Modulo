using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void b_processa1_Click(object sender, EventArgs e)
        {
            int b,ex;
            b = Convert.ToInt32(tb_base.Text);
            ex = Convert.ToInt32(tb_expoente.Text);
            lista.Items.Clear();
            potencia(b, ex);
            int  r;
            r = potencia(b, ex);
            lista.Items.Add(r);
        }
        int potencia(int b, int ex)
        {
            
            

            if (ex == 0)
            {
                return 1;
            }
            else if (ex == 1)
            {
               return b;
            }
            else
            {
                
                
                
                return potencia(b,ex - 1)*b;
                
                
            }
        }

        private void b_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_processa2_Click(object sender, EventArgs e)
        {
            int n1;
            
            n1 = Convert.ToInt32(tb_n1.Text);
            lista.Items.Clear();
            cubo(n1);
            

        }

        void cubo(int n1)
        {
            int r;
            if (n1 >-1)
            {
                cubo(n1 - 1);
                r = n1 * n1 * n1;
                lista.Items.Add(r);
                
                


            }
            
            
        }

        private void b_processa3_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(tb_x.Text);
            y = Convert.ToInt32(tb_y.Text);
           
            lista.Items.Clear();
            mdc(x, y);
            int r2;
            r2 = mdc(x, y);
            lista.Items.Add(r2);
            
        }

        int mdc(int x,int y)
        {

            if (x == y)
            {
                return x;
            }
            else if (x < y)
            {
                return mdc(y,(x%y));
            }
            else
            {
                return mdc(x - y, y);
            }

        }

        private void b_processa4_Click(object sender, EventArgs e)
        {
            int n2;

            n2 = Convert.ToInt32(tb_n2.Text);
            fibonacci(n2);
            lista.Items.Clear();
            int r3;
            r3 = fibonacci(n2);
            lista.Items.Add(r3);

        }
        int fibonacci(int n2)
        {
            if(n2==0 || n2 == 1)
            {
                return n2;
            } 
        
            else
            {
                return fibonacci(n2 - 1) + fibonacci(n2 - 2);
            }
        }

        private void b_processa5_Click(object sender, EventArgs e)
        {
            int n3;
            n3 = Convert.ToInt32(tb_n3.Text);
            lista.Items.Clear();
            binario(n3);
            int r4;
            r4 = binario(n3);
            lista.Items.Add(r4);
        }
        int binario(int n3)
        {
            
            int rest, div, bi,b;
            int a;
            if (n3 / 2 != 0)
            {
                
                rest = binario(n3 % 2);
                div = binario(n3 / 2);
                bi = rest+(10*binario(n3/2));
                b = div % 2;
                return binario(n3 % 2) + 10* binario(n3 / 2);
            }
            else
            {
                a = n3;
                return a;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        bool b = true; //b=true significa q se va indroducir un nuevo numero
        double op1;
        double op2;
        double sqrt;
        double memoria;
        bool coma = false;
        char operador;
        
        public Calculadora()
        {
            InitializeComponent();
        }

        private void edToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void b0_Click(object sender, EventArgs e)
        {      
            if (b)
            {
                Lresultado.Text = "0";                
                //b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "0";
            
        }

        private void bmas_Click(object sender, EventArgs e)
        {
            operador = '+';
            op1 = double.Parse(Lresultado.Text);
            b = true;
            coma = false;
            Lauxiliar.Text = op1.ToString() + operador.ToString();
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            op2 = double.Parse(Lresultado.Text);
            switch (operador)
            {
                case '+': Lresultado.Text = (op1 + op2).ToString();
                    break;
                case '-': Lresultado.Text = (op1 - op2).ToString();
                    break;
                case '*': Lresultado.Text = (op1 * op2).ToString();
                    break;
                case '/': Lresultado.Text = (op1 / op2).ToString();
                    break;
            }
            b = true;
        }

        private void uno_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "1";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "2";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "2";
        }

        private void tre_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "3";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "4";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "5";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "6";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "7";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "8";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "";
                Lresultado.Text = "9";
                b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "9";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            operador = '-';
            op1 = double.Parse(Lresultado.Text);
            b = true;
            coma = false;
            Lauxiliar.Text = op1.ToString() + operador.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            operador = '*';
            op1 = double.Parse(Lresultado.Text);
            b = true;
            coma = false;
            Lauxiliar.Text = op1.ToString() + operador.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            operador = '/';
            op1 = double.Parse(Lresultado.Text);
            b = true;
            coma = false;
            Lauxiliar.Text = op1.ToString() + operador.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Lresultado.Text = "0";
            op1 = 0;
            op2 = 0;
            b = true;
            Lauxiliar.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
     
            {
                if (Lresultado.Text.Length > 1)
                {
                    Lresultado.Text = Lresultado.Text.Remove(Lresultado.Text.Length - 1, 1);

                    if (Lresultado.Text.Length == 1)
                    {
                        Lresultado.Text = " 0";
                        op1 = 0;
                        op2 = 0;
                        b = true;
                    }
                    if (Lresultado.Text == "0")
                    {
                        Lresultado.Text = "0";
                        op1 = 0;
                        op2 = 0;
                        b = true;
                    }
                }
                b = true;
            }

        private void button9_Click(object sender, EventArgs e)
        {
            Lresultado.Text = "0";
            op1 = 0;
            op2 = 0;
            b = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lresultado.Text = Convert.ToString(0 - Convert.ToDouble(Lresultado.Text));
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (!coma)
            {
                Lresultado.Text = Lresultado.Text + ",";
                coma = true;
                if (b)
                    b = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(Lresultado.Text);
            Lresultado.Text = (1 / op1).ToString();

            Lauxiliar.Text = "reciproc(" + op1 + ")";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            op2 = double.Parse(Lresultado.Text);

            Lresultado.Text = ((op1 * op2) / 100).ToString();
            b = true;
            Lauxiliar.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(Lresultado.Text);
            sqrt = Math.Sqrt(op1);
            Lresultado.Text = (sqrt).ToString();
            Lauxiliar.Text = "√(" + op1 + ")";
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculadora from = new Calculadora();
            from.Show();
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            Form2 from = new Form2();
            this.Hide();
            from.Show();   
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult res1 = MessageBox.Show("esta seguro d salir de la calculadora??", "confrimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res1 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void acercaDeLaCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fro = new Form3();
            fro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            memoria = memoria - double.Parse(Lresultado.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memoria = memoria + double.Parse(Lresultado.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*memoria = double.Parse(Lresultado.Text);
           memo.Text = "M " + memoria + "";*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lresultado.Text = memoria.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*memoria = 0;
            memo.Text = "";*/
        }
        
    }
}
/*private void bretro_click
string pantalla.text;
int n=checked.length;
if(n==1)
 lpantalla.text="0";
else
lpantalla.Text=c.substring(0,n-1);*/
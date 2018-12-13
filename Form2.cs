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
    public partial class Form2 : Form
    {
        bool b = true; //b=true significa q se va indroducir un nuevo numero
        double op1;
        double op2;
        double sqrt;
        double memoria;
        bool coma1 = false;
        int nuevo = 0;
        string TipoOperacion;
        bool Operacion = true;
        bool Igual = true;
        //string operador;
        char operador;
        bool binv = true;
        double x, y, z;
        public Form2()
        {
            InitializeComponent();
        }

        private void igual_Click(object sender, EventArgs e)
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
        }

        private void button31_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(Lresultado.Text);
            Lresultado.Text = (1 / op1).ToString();

            Lauxiliar.Text = "reciproc(" + op1 + ")";
        }

        private void porcentaje_Click(object sender, EventArgs e)
        {
            op2 = double.Parse(Lresultado.Text);

            Lresultado.Text = ((op1 * op2) / 100).ToString();
            b = true;
            Lauxiliar.Text = "";
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(Lresultado.Text);
            sqrt = Math.Sqrt(op1);
            Lresultado.Text = (sqrt).ToString();
            Lauxiliar.Text = "√(" + op1 + ")";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            memoria = memoria - double.Parse(Lresultado.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            memoria = memoria + double.Parse(Lresultado.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            memoria = double.Parse(Lresultado.Text);
            memo.Text = "M " + memoria + "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lresultado.Text = memoria.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            memoria = 0;
            memo.Text = "";
        }

        private void mas_Click(object sender, EventArgs e)
        {
            operador = '+';
            op1 = double.Parse(Lresultado.Text);
            b = true;
            coma1 = false;
            Lauxiliar.Text = op1.ToString() + operador.ToString();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            operador = '-';
            op1 = double.Parse(Lresultado.Text);
            b = true;
            coma1 = false;
            Lauxiliar.Text = op1.ToString() + operador.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            operador = '*';
            op1 = double.Parse(Lresultado.Text);
            b = true;
            coma1 = false;
            Lauxiliar.Text = op1.ToString() + operador.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            operador = '/';
            op1 = double.Parse(Lresultado.Text);
            b = true;
            coma1 = false;
            Lauxiliar.Text = op1.ToString() + operador.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Lresultado.Text = Convert.ToString(0 - Convert.ToDouble(Lresultado.Text));
        }

        private void coma_Click(object sender, EventArgs e)
        {
            if (!coma1)
            {
                Lresultado.Text = Lresultado.Text + ",";
                coma1 = true;
                if (b)
                    b = false;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Lresultado.Text = "0";
                //b = false;
            }
            else
                Lresultado.Text = Lresultado.Text + "0";
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

        private void tres_Click(object sender, EventArgs e)
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

        private void button13_Click(object sender, EventArgs e)
        {
            Lresultado.Text = "0";
            op1 = 0;
            op2 = 0;
            b = true;
            Lauxiliar.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Lresultado.Text = "0";
            op1 = 0;
            op2 = 0;
            b = true;
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

        private void button54_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = "Potencia( " + op1 + " )";
            Lresultado.Text = Convert.ToString(Math.Pow(10, op1));
        }

        private void button45_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            x = 1;
            y = 3;
            z = x / y;
            Lresultado.Text = Math.Pow(op1, z).ToString();
            Lauxiliar.Text = "3√ " + op1;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            b = true;
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = " √ " + op1;
            TipoOperacion = "raizX";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            x = 1;
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = op1 + "!";
            for (y = 1; y <= op1; y++)
            {
                x = x * y;
            }
            Lresultado.Text = Convert.ToString(x);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Lauxiliar.Text = Lresultado.Text + ")";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Lauxiliar.Text = "";
            Lauxiliar.Text = Lresultado.Text + "(";
            op1 = 0;
            op2 = 0;
            b = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = op1 + " ^ 2";
            Lresultado.Text = Math.Pow(op1, 2).ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            b = true;
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = op1 + " ^ ";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = op1 + " ^ 3";
            Lresultado.Text = Math.Pow(op1, 3).ToString();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = "log( " + op1 + " )";
            Lresultado.Text = Convert.ToString(Math.Log10(op1));
        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void TAN_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = "tan( " + op1 + " )";
            Lresultado.Text = Convert.ToString(Math.Tan(op1));
            Lresultado.Text = Convert.ToString(Math.Tan(Math.PI * (op1) / 180));
        }

        private void COS_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = "cos( " + op1 + " )";
            Lresultado.Text = Convert.ToString(Math.Cos(op1));
            Lresultado.Text = Convert.ToString(Math.Cos(Math.PI * (op1) / 180));
        }

        private void SIN_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(Lresultado.Text);
            Lauxiliar.Text = "sin( " + op1 + " )";
            Lresultado.Text = Math.Sin(op1).ToString();
            Lresultado.Text = Convert.ToString(Math.Sin(Math.PI * (op1) / 180));
        }

        private void InV_Click(object sender, EventArgs e)
        {
            if (binv)
            {
                SINH.Text = "Sinh-1";
                SIN.Text = "Sin-1";
                COSH.Text = "Cosh-1";
                COS.Text = "Cos-1";
                TANH.Text = "Tanh-1";
                TAN.Text = "Tan-1";
                LN.Text = "eX";
                pi.Text = "2*Pi";
                button40.Text = "deg";
                button30.Text = "Frac";
                binv = false;
            }
            else
            {
                SINH.Text = "Sinh";
                SIN.Text = "Sin";
                COSH.Text = "Cosh";
                COS.Text = "Cos";
                TANH.Text = "Tanh";
                TAN.Text = "Tan";
                LN.Text = "ln";
                pi.Text = "π";
                button40.Text = "dms";
                button30.Text = "Int";
                binv = false;
                binv = true;
            }
        }

        private void LN_Click(object sender, EventArgs e)
        {
            if (LN.Text == "eX")
            {
                Lauxiliar.Text = "";
                Lresultado.Text = Convert.ToString(Math.E);
            }
            else
            {
                op1 = Convert.ToDouble(Lresultado.Text);
                Lauxiliar.Text = "ln( " + op1 + " )";
                Lresultado.Text = Convert.ToString(Math.Log(op1));
            }
        }

        private void SINH_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = "sinh( " + op1 + " )";
            Lresultado.Text = Convert.ToString(Math.Sinh(op1));
        }

        private void COSH_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = "cosh( " + op1 + " )";
            Lresultado.Text = Convert.ToString(Math.Cosh(op1));
        }

        private void TANH_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lauxiliar.Text = "cosh( " + op1 + " )";
            Lresultado.Text = Convert.ToString(Math.Tanh(op1));
        }

        private void button57_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDouble(Lresultado.Text);
            Lresultado.Text = Convert.ToString(Math.Exp(op1));
        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void pi_Click(object sender, EventArgs e)
        {
            Lauxiliar.Text = "";
            Lresultado.Text = Math.PI.ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.Text == "dms")
            {
                op1 = Convert.ToDouble(Lresultado.Text);
                Lauxiliar.Text = "dms( " + op1 + " )";
                Lresultado.Text = Convert.ToString(Math.Truncate(op1));
            }
            else
            {
                op1 = Convert.ToDouble(Lresultado.Text);
                Lauxiliar.Text = "dms( " + op1 + " )";
                Lresultado.Text = Convert.ToString(Math.Round(op1));
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.Text == "Frac")
            {
                op1 = Convert.ToDouble(Lresultado.Text);
                Lauxiliar.Text = "Frac( " + op1 + " )";
                Lresultado.Text = Convert.ToString(Math.Truncate(op1));
            }
            else
            {
                op1 = Convert.ToDouble(Lresultado.Text);
                Lauxiliar.Text = "Int( " + op1 + " )";
                Lresultado.Text = Convert.ToString(Math.Round(op1));
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            op1 = int.Parse(Lresultado.Text);
            Lauxiliar.Text = "( " + op1 + " )";
            Lresultado.Text = Convert.ToString(Math.Truncate(op1));
        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora from = new Calculadora();
            this.Hide();
            from.Show();   
        }

        private void acercaDeLaCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fro = new Form3();
            fro.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Lauxiliar_Click(object sender, EventArgs e)
        {

        }

        private void memo_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            /*DialogResult res1 = MessageBox.Show("esta seguro d salir de la calculadora??", "confrimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res1 == DialogResult.Yes)
            {
                this.Close();
            }*/
        }

        
    }
}

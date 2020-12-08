using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeBhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Double a, b, c, x1, x2, delta;
                a = Convert.ToDouble(tbA.Text);
                b = Convert.ToDouble(tbB.Text);
                c = Convert.ToDouble(tbC.Text);

                //TESTE DE DELTA NEGATIVO            
                delta = b * b - 4 * a * c;
                if (delta < 0 & rbR.Checked == true)
                {
                    lbX1.Text = "X1: Impossível pois delta é negativo.";
                    lbX2.Text = "X2: Impossível pois delta é negativo.";
                }
                else if(delta < 0 & rbC.Checked == true)
                {
                    x1 = (-b + Math.Sqrt(-delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(-delta)) / (2 * a);
                    lbX1.Text = "X1: " + x1.ToString() + "i";
                    lbX2.Text = "X2: " + x2.ToString() + "i";
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lbX1.Text = "X1: " + x1.ToString();
                    lbX2.Text = "X2: " + x2.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Digite apenas números !!!"
                    + Environment.NewLine
                    + "Proibido campos em branco ou com letras !!!");
            }
        }

        private void lbAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculadora de Bhaskara"
                + Environment.NewLine
                + "Versão 0.2"
                + Environment.NewLine
                + "Desenvolvedor: Giovan");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbR.Checked = true;
        }
    }
}
/*
V 0.1
CALCULA X1 E X2

V 0.1.1
CORRIGIU A MENSAGEM DE ERRO P DELTA NEGATIVO

V 0.1.2
CORRIGIU A MENSAGEM DE DELTA IMPOSSÍVEL, 
QUE APARECIA COLADO À RESPOSTA ANTERIOR
SE CALCULASSE O BHASKARA MAIS DE UMA VEZ

V 0.1.3
CORRIGIU O ERRO QUANDO O USUÁRIO DIGITAVA LETRAS 
OU DEIXAVA CAMPO EM BRANCO

V 0.2
ADICIONADA A POSSIBILIDADE DE ESCOLHER O CONJUNTO 
NUMÉRICO PARA O CÁLCULO DAS RAÍZES
 */

/*
CÓDIGO DA VERSÃO 0.1

Double a, b, c, x1, x2, delta;
a = Convert.ToDouble(tbA.Text);
b = Convert.ToDouble(tbB.Text);
c = Convert.ToDouble(tbC.Text);         
delta = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(delta)) / (2 * a);
x2 = (-b - Math.Sqrt(delta)) / (2 * a);
lbX1.Text = x1.ToString();
lbX2.Text = x2.ToString();
*/

/*
CÓDIGO DA VERSÃO 0.1.1

Double a, b, c, x1, x2, delta;
a = Convert.ToDouble(tbA.Text);
b = Convert.ToDouble(tbB.Text);
c = Convert.ToDouble(tbC.Text);         

//TESTE DE DELTA NEGATIVO            
delta = b * b - 4 * a * c;
if (delta < 0)
{
    lbX1.Text += "Impossível pois delta é negativo.";
    lbX2.Text += "Impossível pois delta é negativo.";
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    lbX1.Text = "X1: " + x1.ToString();
    lbX2.Text = "X2: " + x2.ToString();
}
*/

/*
CÓDIGO DA VERSÃO 0.1.2

Double a, b, c, x1, x2, delta;
a = Convert.ToDouble(tbA.Text);
b = Convert.ToDouble(tbB.Text);
c = Convert.ToDouble(tbC.Text);         

//TESTE DE DELTA NEGATIVO            
delta = b * b - 4 * a * c;
if (delta < 0)
{
    lbX1.Text = "X1: Impossível pois delta é negativo.";
    lbX2.Text = "X2: Impossível pois delta é negativo.";
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    lbX1.Text = "X1: " + x1.ToString();
    lbX2.Text = "X2: " + x2.ToString();
}
*/

/*
CÓDIGO DA VERSÃO 0.1.3

try
{
    Double a, b, c, x1, x2, delta;
    a = Convert.ToDouble(tbA.Text);
    b = Convert.ToDouble(tbB.Text);
    c = Convert.ToDouble(tbC.Text);

    //TESTE DE DELTA NEGATIVO            
    delta = b * b - 4 * a * c;
    if (delta < 0)
    {
        lbX1.Text = "X1: Impossível pois delta é negativo.";
        lbX2.Text = "X2: Impossível pois delta é negativo.";
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        lbX1.Text = "X1: " + x1.ToString();
        lbX2.Text = "X2: " + x2.ToString();
    }
}
catch
{
    MessageBox.Show("Digite apenas números !!!"
        + Environment.NewLine
        + "Proibido campos em branco ou com letras !!!");
}
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.operation = new Operation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // 7
        {
            textBox1.AppendText("7");
        }

        private void button2_Click(object sender, EventArgs e) // 8
        {
            textBox1.AppendText("8");
        }

        private void button3_Click(object sender, EventArgs e) // 9
        {
            textBox1.AppendText("9");
        }

        private void button4_Click(object sender, EventArgs e) // 4
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e) // 5
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e) // 6 
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e) //1
        {
            textBox1.AppendText("1");
        }

        private void button8_Click(object sender, EventArgs e) // 2
        {
            textBox1.AppendText("2");
        }

        private void button9_Click(object sender, EventArgs e) // 3
        {
            textBox1.AppendText("3");
        }

        private void button10_Click(object sender, EventArgs e) // 0
        {
            textBox1.AppendText("0");
        }

        private void button11_Click(object sender, EventArgs e) // .
        {
            textBox1.AppendText( ".");
        }

        private void button12_Click(object sender, EventArgs e) // =
        {
            String sauvegarde = textBox1.Text;
            char op = sauvegarde.ElementAt(0);
            String reste = sauvegarde.Substring(1);
            operation.setOp2(Double.Parse(reste));
            switch (op)
            {
                case '+':
                    textBox1.Text = operation.plus().ToString();
                    break;
                case '-':
                    textBox1.Text = operation.moins().ToString();
                    break;
                case '/':
                    textBox1.Text = operation.divise().ToString();
                    break;
                case 'x':
                    textBox1.Text = operation.multiplie().ToString();
                    break;
                default:
                    break;
            }
            afficheButton(List());
        }
        
                

        private void button16_Click(object sender, EventArgs e) // +
        {
            operation.setOp1(Double.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.AppendText("+");
            effaceButton(List());

        }

        private void button15_Click(object sender, EventArgs e) // x
        {
            operation.setOp1(Double.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.AppendText("x");
            effaceButton(List());
        }

        private void button14_Click(object sender, EventArgs e) // /
        {
            operation.setOp1(Double.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.AppendText("/");
            effaceButton(List());
        }

        private void button13_Click(object sender, EventArgs e) // -
        {
            operation.setOp1(Double.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.AppendText("-");
            effaceButton(List());
        }

        private List<Button> List ()
        {
            List<Button> list = new List<Button>();
                list.Add(button16);
                list.Add(button15);
                list.Add(button14);
                list.Add(button13);
            return list;
        }

        private void effaceButton(List<Button> list)
        {
            foreach (Button b in list)
            {
                b.Hide();
            }
        }

        private void afficheButton(List<Button> list)
        {
            foreach (Button b in list)
            {
                b.Show();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            afficheButton(List());
        }
    }
}

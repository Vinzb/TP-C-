using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExoSmileys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void 
            button1_Click(object sender, EventArgs e)
        {
            radioButton1.Dispose();
            radioButton2.Dispose();
            radioButton3.Dispose();
            pictureBox1.Dispose();
            textBox1.Dispose();
            button3.Dispose();
            button1.Dispose();

            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            
            string drawString = "Les visages de Toto\n \n Application Test";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 13);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = this.ClientSize.Width / 4;
            float y = this.ClientSize.Height / 4;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            this.button2.Location = new System.Drawing.Point(100, 150);
            button2.Image = Image.FromFile("../Images/ImageOK.ico");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.Text = "Ok";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // sourire
        {
            textBox1.Text = "TOTO Sourire";
            pictureBox1.Image = Image.FromFile("../Images/Sourire.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // colère
        {
            textBox1.Text = "TOTO Colère";
            pictureBox1.Image = Image.FromFile("../Images/Colère.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // mou
        {
            textBox1.Text = "TOTO Mou";
            pictureBox1.Image = Image.FromFile("../Images/Mou.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifumi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            modele = new Modele();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            modele.rand();
            this.pictureBox4.Image = Image.FromFile(modele.randomBotImage);
            this.textBox1.Text = modele.Win(0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            modele.rand();
            this.pictureBox4.Image = Image.FromFile(modele.randomBotImage);
            this.textBox1.Text = modele.Win(2);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            modele.rand();
            this.pictureBox4.Image = Image.FromFile(modele.randomBotImage);
            this.textBox1.Text = modele.Win(1);
        }
    }
}

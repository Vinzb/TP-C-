using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Resources;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            combat = new Combat();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = combat.gagnant( combat.pierre());
            String chemin = combat.chemin() + combat.getName();
            pictureBox5.Image = Image.FromFile(chemin);
            textBox2.Text = combat.getScoreMoi();
            textBox3.Text = combat.getScoreBot();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = combat.gagnant(combat.feuille());
            String chemin = combat.chemin() + combat.getName();
            pictureBox5.Image = Image.FromFile(chemin);
            textBox2.Text = combat.getScoreMoi();
            textBox3.Text = combat.getScoreBot();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = combat.gagnant(combat.ciseaux());
            String chemin = combat.chemin() + combat.getName();
            pictureBox5.Image = Image.FromFile(chemin);
            textBox2.Text = combat.getScoreMoi();
            textBox3.Text = combat.getScoreBot();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}

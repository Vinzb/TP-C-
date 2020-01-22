using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp2.Resources
{
    class Combat
    {
        public int aleatoire;
        public int scoreMoi;
        public int scoreBot;

        public Combat()
        {
            scoreMoi = 0;
            scoreBot = 0;
        }

        public int pierre()
        {
            random();
            if (aleatoire == 2)
            {
                return 0;
            }
            else if (aleatoire == 3)
            {
                return 2;
            }
            else
                return 1;
            
        }

        public int feuille()
        {
            random();
            if (aleatoire == 1)
            {
                return 2;
            }
            else if (aleatoire == 2)
            {
                return 1;
            }
            else return 0;
        }

        public int ciseaux()
        {
            random();
            if (aleatoire == 1)
            {
                return 0;
            }
            else if (aleatoire == 2)
            {
                return 2;
            }
            else return 1;
        }

        public String gagnant(int res)
        {
            if (res == 1)
            {
                return "Egalité !";
            }
            else if (res == 0)
            {
                scoreBot++;
                return "Vous avez perdu !";
            }
            else if (res == 2)
            {
                scoreMoi++;
                return "Vous avez gagné !";
            }
            return "bite";
        }

        public void random()
        {
            Random random = new Random();
            aleatoire = random.Next(1,4);
        }

        public String getScoreMoi()
        {
            return scoreMoi.ToString();
        }

        public String getScoreBot()
        {
            return scoreBot.ToString();
        }

        public String getName()
        {
            if (aleatoire == 1)
                return "Pierre.bmp";
            else if (aleatoire == 2)
                return "Feuille.bmp";
            else
                return "Ciseau.bmp";
        }

        public String chemin()
        {
            return "../Images/";
        }
    }

}


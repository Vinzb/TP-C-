using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shifumi
{
    public class Modele
    {
        //Variable de choix aléatoire, 0 pour feuille, 1 pour ciseaux, 2 pour pierre
        public int randomBotChoice = -1;
        public String randomBotImage = "";

        enum Coup : int
        {
            FEUILLE = 0,
            CISEAUX = 1,
            PIERRE = 2
        };

        public Modele()
        {
        }


        //Retourne -1 si défaite du joueur, 0 si match nul ou 1 si victoire du joueur
        public string Win(int humanChoice)
        {
            if (humanChoice == (int)Coup.CISEAUX)
            {
                if(randomBotChoice == (int)Coup.CISEAUX)
                {
                    return MatchNul();
                }

                if(randomBotChoice == (int)Coup.FEUILLE)
                {
                    return JoueurGagne();
                }

                if (randomBotChoice == (int)Coup.PIERRE)
                {
                    return BotGagne();
                }
            }

            if (humanChoice == (int)Coup.PIERRE)
            {
                if (randomBotChoice == (int)Coup.CISEAUX)
                {
                    return JoueurGagne();
                }

                if (randomBotChoice == (int)Coup.FEUILLE)
                {
                    return BotGagne();
                }

                if (randomBotChoice == (int)Coup.PIERRE)
                {
                    return MatchNul();
                }
            }

            if (humanChoice == (int)Coup.FEUILLE)
            {
                if (randomBotChoice == (int)Coup.CISEAUX)
                {
                    return BotGagne();
                }

                if (randomBotChoice == (int)Coup.FEUILLE)
                {
                    return MatchNul();
                }

                if (randomBotChoice == (int)Coup.PIERRE)
                {
                    return JoueurGagne();
                }
            }

            return "Contactez le développeur de cette application défectueuse";
        }

        public void rand()
        {
            Random res = new Random();
            randomBotChoice = res.Next(3);
            if(randomBotChoice == (int)Coup.FEUILLE)
            {
                randomBotImage = "../Images/Feuille.bmp";
            }

            if (randomBotChoice == (int)Coup.CISEAUX)
            {
                randomBotImage = "../Images/Ciseau.bmp";
            }

            if (randomBotChoice == (int)Coup.PIERRE)
            {
                randomBotImage = "../Images/Pierre.bmp";
            }
        }

        public string MatchNul()
        {
            randomBotChoice = -1;
            randomBotImage = "";
            return "Match nul :|";
        }

        public string JoueurGagne()
        {
            randomBotChoice = -1;
            randomBotImage = "";
            return "Vous avez gagné :)";
        }

        public string BotGagne()
        {
            randomBotChoice = -1;
            randomBotImage = "";
            return "Vous avez perdu :(";
        }
    }
}

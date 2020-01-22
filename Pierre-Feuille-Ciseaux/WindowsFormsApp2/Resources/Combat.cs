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

        public Combat()
        {
            Random alea = new Random();
            aleatoire = alea.Next(1, 3);
        }
    }

}


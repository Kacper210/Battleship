using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Cruiser
    {
        public static List<int> cruiser = new List<int>();

        public static void Generate()
        {
            Random rnd = new Random();

            int C1, C2, C3;

            do
            {
                C1 = rnd.Next(0, 100);
                C2 = rnd.Next(0, 100);
                C3 = rnd.Next(0, 100);
            }
            while (((C1 - C3 != 20) || (C1 - C2 != 10) || (C2 - C3 != 10)) && ((C1 - C3 != -20) || (C1 - C2 != -10) || (C2 - C3 != -10)) &&
            ((C1 - C3 != 2) || (C1 - C2 != 1) || (C2 - C3 != 1)) && ((C1 - C3 != -2) || (C1 - C2 != -1) || (C2 - C3 != -1)));

            if (Player1.ships.Contains(C1) && Player1.ships.Contains(C2) && Player1.ships.Contains(C3))
            {
                cruiser.Clear();
                Generate();
            }
            else
            {
                cruiser.Clear();
                cruiser.Add(C1);
                cruiser.Add(C2);
                cruiser.Add(C3);
            }

            if (Player2.ships.Contains(C1) && Player2.ships.Contains(C2) && Player2.ships.Contains(C3))
            {
                cruiser.Clear();
                Generate();
            }
            else
            {
                cruiser.Clear();
                cruiser.Add(C1);
                cruiser.Add(C2);
                cruiser.Add(C3);
            }


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Carrier
    {
        public static List<int> carrier = new List<int>();

        public static void Generate()
        {
            Random rnd = new Random();

            int C1, C2, C3, C4, C5;

            do
            {
                C1 = rnd.Next(0, 100);
                C2 = rnd.Next(0, 100);
                C3 = rnd.Next(0, 100);
                C4 = rnd.Next(0, 100);
                C5 = rnd.Next(0, 100);
            }
            while (((C1 - C2 != -1) || (C1 - C3 != -2) || (C1 - C4 != -3) || (C1 - C5 != -4) || (C2 - C3 != -1) || (C2 - C4 != -2) || (C2 - C5 != -3) || (C3 - C4 != -1) || (C3 - C5 != -2) || (C4 - C5 != -1)) &&
            ((C1 - C2 != 1) || (C1 - C3 != 2) || (C1 - C4 != 3) || (C1 - C5 != 4) || (C2 - C3 != 1) || (C2 - C4 != 2) || (C2 - C5 != 3) || (C3 - C4 != 1) || (C3 - C5 != 2) || (C4 - C5 != 1)) &&
            ((C1 - C2 != -10) || (C1 - C3 != -20) || (C1 - C4 != -30) || (C1 - C5 != -40) || (C2 - C3 != -10) || (C2 - C4 != -20) || (C2 - C5 != -30) || (C3 - C4 != -10) || (C3 - C5 != -20) || (C4 - C5 != -10)) &&
            ((C1 - C2 != 10) || (C1 - C3 != 20) || (C1 - C4 != 30) || (C1 - C5 != 40) || (C2 - C3 != 10) || (C2 - C4 != 20) || (C2 - C5 != 30) || (C3 - C4 != 10) || (C3 - C5 != 20) || (C4 - C5 != 10)));




            if (Player1.ships.Contains(C1) && Player1.ships.Contains(C2) && Player1.ships.Contains(C3) && Player1.ships.Contains(C4) && Player1.ships.Contains(C5))
            {
                carrier.Clear();
                Generate();
            }
            else
            {
                carrier.Clear();
                carrier.Add(C1);
                carrier.Add(C2);
                carrier.Add(C3);
                carrier.Add(C4);
                carrier.Add(C5);
            }

            if (Player2.ships.Contains(C1) && Player2.ships.Contains(C2) && Player2.ships.Contains(C3) && Player2.ships.Contains(C4) && Player2.ships.Contains(C5))
            {
                carrier.Clear();
                Generate();
            }
            else
            {
                carrier.Clear();
                carrier.Add(C1);
                carrier.Add(C2);
                carrier.Add(C3);
                carrier.Add(C4);
                carrier.Add(C5);
            }


        }


    }
}

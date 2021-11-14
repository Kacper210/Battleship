using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Battleship
    {
        public static List<int> battleship = new List<int>();

        public static void Generate()
        {
            Random rnd = new Random();

            int B1, B2, B3, B4;

            do
            {
                B1 = rnd.Next(0, 100);
                B2 = rnd.Next(0, 100);
                B3 = rnd.Next(0, 100);
                B4 = rnd.Next(0, 100);
            }
            while (((B1 - B2 != -10) || (B1 - B3 != -20) || (B1 - B4 != -30) || (B2 - B3 != -10) || (B2 - B4 != -20) || (B3 - B4 != -10)) &&
            ((B1 - B2 != 10) || (B1 - B3 != 20) || (B1 - B4 != 30) || (B2 - B3 != 10) || (B2 - B4 != 20) || (B3 - B4 != 10)) &&
            ((B1 - B2 != -1) || (B1 - B3 != -2) || (B1 - B4 != -3) || (B2 - B3 != -1) || (B2 - B4 != -2) || (B3 - B4 != -1)) &&
            ((B1 - B2 != 1) || (B1 - B3 != 2) || (B1 - B4 != 3) || (B2 - B3 != 1) || (B2 - B4 != 2) || (B3 - B4 != 1)));

            if (Player1.ships.Contains(B1) && Player1.ships.Contains(B2) && Player1.ships.Contains(B3) && Player1.ships.Contains(B4))
            {
                battleship.Clear();
                Generate();
            }
            else
            {
                battleship.Clear();
                battleship.Add(B1);
                battleship.Add(B2);
                battleship.Add(B3);
                battleship.Add(B4);
            }

            if (Player2.ships.Contains(B1) && Player2.ships.Contains(B2) && Player2.ships.Contains(B3) && Player2.ships.Contains(B4))
            {
                battleship.Clear();
                Generate();
            }
            else
            {
                battleship.Clear();
                battleship.Add(B1);
                battleship.Add(B2);
                battleship.Add(B3);
                battleship.Add(B4);
            }


        }


    }
}

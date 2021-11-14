using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Submarine
    {
        public static List<int> submarine = new List<int>();

        public static void Generate()
        {
            Random rnd = new Random();

            int S1, S2, S3;

            do
            {
                S1 = rnd.Next(0, 100);
                S2 = rnd.Next(0, 100);
                S3 = rnd.Next(0, 100);
            }
            while (((S1 - S3 != 20) || (S1 - S2 != 10) || (S2 - S3 != 10)) && ((S1 - S3 != -20) || (S1 - S2 != -10) || (S2 - S3 != -10)) &&
            ((S1 - S3 != 2) || (S1 - S2 != 1) || (S2 - S3 != 1)) && ((S1 - S3 != -2) || (S1 - S2 != -1) || (S2 - S3 != -1)));

            if (Player1.ships.Contains(S1) && Player1.ships.Contains(S2) && Player1.ships.Contains(S3))
            {
                submarine.Clear();
                Generate();
            }
            else
            {
                submarine.Clear();
                submarine.Add(S1);
                submarine.Add(S2);
                submarine.Add(S3);
            }

            if (Player2.ships.Contains(S1) && Player2.ships.Contains(S2) && Player2.ships.Contains(S3))
            {
                submarine.Clear();
                Generate();
            }
            else
            {
                submarine.Clear();
                submarine.Add(S1);
                submarine.Add(S2);
                submarine.Add(S3);
            }


        }

        
    }
}

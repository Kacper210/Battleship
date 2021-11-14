using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
   public class Destroyer
    {
        public static List<int> destroyer = new List<int>();

        public static void Generate()
        {
            Random rnd = new Random();

            int D1, D2;

            do
            {
                D1 = rnd.Next(0, 100);
                D2 = rnd.Next(0, 100);
            }
            while ((D1 - D2 != 10) && (D1 - D2 != 1) && (D1 - D2 != -10) && (D1 - D2 != -1));

            if (Player1.ships.Contains(D1) && Player1.ships.Contains(D2))
            {
                destroyer.Clear();
                Generate();
            }
            else
            {
                destroyer.Clear();
                destroyer.Add(D1);
                destroyer.Add(D2);
            }

            if (Player2.ships.Contains(D1) && Player2.ships.Contains(D2))
            {
                destroyer.Clear();
                Generate();
            }
            else
            {
                destroyer.Clear();
                destroyer.Add(D1);
                destroyer.Add(D2);
            }



        }
    }
}

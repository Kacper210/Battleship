using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Player1
    {
        public static List<int> ships = new List<int>();

        public static void Gen_Ships()
        {
            Destroyer.Generate();
            ships.AddRange(Destroyer.destroyer);
            
            Submarine.Generate();
            ships.AddRange(Submarine.submarine);

            Cruiser.Generate();
            ships.AddRange(Cruiser.cruiser);

            Battleship.Generate();
            ships.AddRange(Battleship.battleship);

            Carrier.Generate();
            ships.AddRange(Carrier.carrier);
        }
       
}
}

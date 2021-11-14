using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
   public class Program
    {   

        public static void Main(string[] args)
        {

            Player1.Gen_Ships();
            Player2.Gen_Ships();
            Game.Start();
            
        }
    }
}

using System;
namespace Battleship
{
    public class Game
    {


        public static void Start()
        {
            int a;


            do
            {
                try
                {
                    Console.WriteLine("Player1 enter the number");
                    a = Convert.ToInt16(Console.ReadLine());
                    if (Player2.ships.Contains(a))
                    {
                        Console.WriteLine("Hit");
                        Player2.ships.Remove(a);
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                }
                catch
                {
                    Console.WriteLine("Input must be a number");
                }

                try
                {
                    Console.WriteLine("Player2 enter the number");
                    a = Convert.ToInt16(Console.ReadLine());
                    if (Player1.ships.Contains(a))
                    {
                        Console.WriteLine("Hit");
                        Player1.ships.Remove(a);
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                }
                catch
                {
                    Console.WriteLine("Input must be a number");
                }

            } while (Player1.ships.Count != 0 && Player2.ships.Count != 0);

            if (Player1.ships.Count == 0)
            {
                Console.WriteLine("PLAYER2 WIN");
            }
            else
            {
                Console.WriteLine("PLAYER1 WIN");
            }
        }
    }
}



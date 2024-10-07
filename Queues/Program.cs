using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            Queue<Player> waitingToJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "MMsix");
            Player p2 = new Player(100, "DogBruh");
            Player p3 = new Player(100, "Snaftt");
            Player p4 = new Player(100, "BroMom");

            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("Players in the queue:");
            foreach (Player p in waitingToJoinQ)
            {
                Console.WriteLine(p);
            }

            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);

            Console.WriteLine("\nPlayers in the queue after checking:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}

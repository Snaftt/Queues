using System;
using System.Collections.Generic;

namespace Queues
{
    internal class Player
    {
        public int Health { get; set; }
        public string GamerTag { get; }

        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        public void JoinGame(Game game, Queue<Player> queue)
        {
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
                Console.WriteLine($"{GamerTag} added to the queue.");
            }
            else
            {
                game.CurrentPlayers++;
                Console.WriteLine($"{GamerTag} joined the game. Current players: {game.CurrentPlayers}");
            }
        }

        public override string ToString()
        {
            return GamerTag;
        }
    }
}

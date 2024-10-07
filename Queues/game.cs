using System;
using System.Collections.Generic;

namespace Queues
{
    internal class Game
    {
        public int MaxPlayers { get; set; }
        public int CurrentPlayers { get; set; }

        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        public void KickPlayer()
        {
            if (CurrentPlayers > 0)
            {
                CurrentPlayers--;
                Console.WriteLine("Player kicked. Current players: " + CurrentPlayers);
            }
            else
            {
                Console.WriteLine("No players to kick.");
            }
        }

        public void CheckQueue(Queue<Player> playerQueue)
        {
            if (CurrentPlayers < MaxPlayers)
            {
                if (playerQueue.Count > 0)
                {
                    Player player = playerQueue.Dequeue();
                    CurrentPlayers++;
                    Console.WriteLine($"{player.GamerTag} joined the game. Current players: {CurrentPlayers}");
                }
                else
                {
                    Console.WriteLine("No players in the queue.");
                }
            }
        }
    }
}

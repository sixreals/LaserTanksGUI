using System;
using System.Collections.Generic;

namespace LaserTanksGUI.Models
{
    public class Game
    {
        /// <summary>
        /// All the players for this game
        /// </summary>
        /// <value></value>
        public List<Player> Players { get; set; }

        /// <summary>
        /// The total time spent on this game
        /// </summary>
        /// <value></value>
        public int GameTime { get; set; }   

        /// <summary>
        /// Hold's the count of rounds for this game
        /// </summary>
        /// <value></value>
        public int RoundNumber { get; set; }

        /// <summary>
        /// The number of round for this game before it ends
        /// </summary>
        /// <value></value>
        public int TotalRounds { get; set; }

        /// <summary>
        /// Store's the game's type
        /// </summary>
        public GameType Type { get; set; }

        /// <summary>
        /// Default ctor
        /// </summary>
        public Game() { }
        
        /// <summary>
        /// Construct with players instantiated.
        /// Gametype is deathmatch
        /// </summary>
        /// <param name="players"></param>
        public Game(List<Player> players)
        {
            Players = players;
            GameTime = 0;
            RoundNumber = 1;
            TotalRounds = 3;
            Type = GameType.Deathmatch;
        }
    }
}
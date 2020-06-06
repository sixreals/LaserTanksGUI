namespace LaserTanksGUI.Models
{
    /// <summary>
    /// Holds info for a a player
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Player's Name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// The player's current health level
        /// </summary>
        /// <value></value>
        public int Health { get; set; }
        /// <summary>
        /// The playser's maximum health
        /// </summary>
        /// <value></value>
        public int MaxHealth { get; set; }
        /// <summary>
        /// The plyer's score for this game
        /// </summary>
        /// <value></value>
        public int Score { get; set; }

        /// <summary>
        /// Number of this player's kills
        /// </summary>
        /// <value></value>
        public int Kills { get; set; }

        /// <summary>
        /// Number of this player's deaths
        /// </summary>
        /// <value></value>
        public int Deaths { get; set; }

        /// <summary>
        /// Construct a player using only a name
        /// </summary>
        /// <param name="name">The player's name</param>
        public Player(string name)
        {
            Name = name;
            MaxHealth = 100;
            Health = MaxHealth;
            Score = 0;
        }

    }
}
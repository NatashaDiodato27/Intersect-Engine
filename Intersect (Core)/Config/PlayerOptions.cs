﻿namespace Intersect.Config
{

    public class PlayerOptions
    {
        /// <summary>
        /// Intersect default for initial player bank slots
        /// </summary>
        public const int DefaultInitialBankSlots = 100;

        /// <summary>
        /// A percentage between 0 and 100 which determines the chance in which they will lose any given item in their inventory when killed.
        /// </summary>
        public int ItemDropChance = 0;

        /// <summary>
        /// Number of bank slots a player has.
        /// </summary>
        public int InitialBankslots { get; set; } = DefaultInitialBankSlots;

        /// <summary>
        /// Number of characters an account may create.
        /// </summary>
        public int MaxCharacters = 1;

        /// <summary>
        /// Number of inventory slots a player has.
        /// </summary>
        public int MaxInventory = 35;

        /// <summary>
        /// Max level a player can achieve.
        /// </summary>
        public int MaxLevel = 100;

        /// <summary>
        /// Number of spell slots a player has.
        /// </summary>
        public int MaxSpells = 35;

        /// <summary>
        /// The highest value a single stat can be for a player.
        /// </summary>
        public int MaxStat = 255;

        /// <summary>
        /// How long a player must wait before sending a trade/party/friend request after the first as been denied.
        /// </summary>
        public int RequestTimeout = 300000;

        /// <summary>
        /// Distance (in tiles) between players in which a trade offer can be sent and accepted.
        /// </summary>
        public int TradeRange = 6;

        /// <summary>
        /// Unlinks the timers for combat and movement to facilitate complex combat (e.g. kiting)
        /// </summary>
        public bool AllowCombatMovement = true;

        /// <summary>
        /// Configures whether or not the level of a player is shown next to their name.
        /// </summary>
        public bool ShowLevelByName = false;

        /// <summary>
        /// First thanks for letting me share an idea, of losing XP when dying <3
        /// </summary>
        public int ExpLossOnDeathPercent = 0;

        /// <summary>
        /// If true, it will remove the associated exp, otherwise you will lose the exp based on the exp required to level up.
        /// </summary>
        public bool ExpLossFromCurrentExp = true;

    }

}

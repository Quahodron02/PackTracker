using System;
using System.Collections.Generic;

namespace PackTracker.Entity
{
    public class Player
    {
        public string BattleTag { get; }
        public HearthDb.Enums.Region Region { get; }

        public Player(string battleTag, HearthDb.Enums.Region region)
        {
            this.BattleTag = battleTag;
            this.Region = region;
        }
    }
}

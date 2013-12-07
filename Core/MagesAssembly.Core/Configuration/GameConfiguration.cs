using MagesAssembly.Core.Players;
using System.Collections.Generic;

namespace MagesAssembly.Core.Configuration
{
    public class GameConfiguration
    {
        public int BestOfN { get { return 2 * MatchWinsToVictory + 1; } }
        public List<Team> Teams { get; set; }
        public int MatchWinsToVictory { get; set; }
    }
}

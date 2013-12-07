using System.Collections.Generic;

namespace MagesAssembly.Core.Players
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<IPlayer> Players { get; set; }
        public TeamColor Color { get; set; }
        public int MatchesWon { get; set; }
    }
}

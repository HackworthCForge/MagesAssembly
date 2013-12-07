using MagesAssembly.Core.EventSystem;
using MagesAssembly.Core.Players;

namespace MagesAssembly.Core
{
    public class MatchEndEvent : IEvent
    {
        public Objects.MtgObject Source { get; private set; }

        public bool Canceled { get; set; }

        public IEvent OriginalEvent { get; set; }

        public Game Game { get; set; }
        public Team Winner { get; set; }
    }
}

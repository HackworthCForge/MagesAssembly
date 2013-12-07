using MagesAssembly.Core.Configuration;

namespace MagesAssembly.Core
{
    public class Game
    {
        public GameConfiguration Configuration { get; private set; }
        private Match _currentMatch;
        private int _matchCounter;

        public Game(GameConfiguration config)
        {
            this.Configuration = config;
            _matchCounter = 0;
        }

        public void StartNextMatch()
        {
            Match match = new Match(this);
            match.StartMatch();
        }
    }
}

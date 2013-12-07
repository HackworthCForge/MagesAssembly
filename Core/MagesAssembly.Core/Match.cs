using MagesAssembly.Core.EventSystem;

namespace MagesAssembly.Core
{
    public class Match
    {
        Game _game;

        public Match(Game game)
        {
            _game = game;
        }

        public void StartMatch()
        {
            EventManager.Instance.Subscribe<MatchEndEvent>(HandleGameEnded);
        }

        private void HandleGameEnded(MatchEndEvent e)
        {
            e.Winner.MatchesWon++;
        }

    }
}

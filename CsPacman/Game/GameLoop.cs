using CsPacman.Characters;

namespace CsPacman.Game
{
    public class GameLoop
    {
        private readonly GameState state;
        private readonly StateSnapshot snapshot;

        public GameLoop(int seed, IPlayer player)
        {
            var random = new Random(seed);
            var ghosts = new Character[4];
            snapshot = new StateSnapshot(ghosts.Length);
            ghosts[0] = new HunterGhost(snapshot, new Point(9, 11));
            ghosts[1] = new AmbushGhost(snapshot, new Point(18, 17));
            ghosts[2] = new GuardGhost(snapshot, random, new Point(18, 11));
            ghosts[3] = new StrangerGhost(snapshot, random, new Point(9, 17));
            state = new GameState(new Pacman(snapshot, new Point(14, 23), player), ghosts);
        }

        public bool Step(IRender? render)
        {
            try
            {
                state.CopyTo(snapshot);
                state.Update();
                render?.Draw(state);
                return true;
            }
            catch (Exception ex)
            {
                render?.GameOver(ex);
                return false;
            }
        }
    }
}

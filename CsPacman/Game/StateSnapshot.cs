
namespace CsPacman.Game
{
    public class StateSnapshot
    {
        public readonly Level level = new Level();
        public readonly Point[] ghosts;
        public Point player;
        public int score;
        public int tick;

        public StateSnapshot(int ghosts)
        {
            this.ghosts = new Point[ghosts];
        }
    }
}

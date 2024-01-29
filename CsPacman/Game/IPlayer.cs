
namespace CsPacman.Game
{
    public static class Moves
    {
        public static readonly Point Up = new Point(0, -1);
        public static readonly Point Down = new Point(0, 1);
        public static readonly Point Left = new Point(-1, 0);
        public static readonly Point Right = new Point(1, 0);

        public static readonly Point[] All = new[] { Up, Down, Left, Right };
    }

    public interface IPlayer
    {
        Point Step(StateSnapshot state);
    }
}

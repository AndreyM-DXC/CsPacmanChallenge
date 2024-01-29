
namespace CsPacman.Game
{
    public static class Pathfind
    {
        public static Point Next(StateSnapshot snapshot, Point prev, Point current, Point target)
        {
            var distance = int.MaxValue;
            var result = current;

            foreach (var delta in Moves.All)
            {
                var next = new Point(current.X + delta.X, current.Y + delta.Y);
                if (next == prev || snapshot.level.IsWall(next))
                {
                    continue;
                }
                var dist = SqrDistance(next, target);
                if (dist < distance)
                {
                    distance = dist;
                    result = next;
                }
            }
            return result;
        }

        public static int SqrDistance(Point a, Point b)
        {
            return (a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y);
        }
    }
}

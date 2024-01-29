using CsPacman.Game;

namespace CsPacman.Characters
{
    public class GuardGhost : Character
    {
        private readonly Random random;

        public GuardGhost(StateSnapshot snapshot, Random random, Point position) : base(snapshot, position, 8)
        {
            this.random = random;
        }

        public override Animation GetAnimation()
        {
            return Animations.Ghost3[animation];
        }

        protected override Point NextTarget(Point prev, Point current)
        {
            var sx = random.Next(Level.Width);
            var sy = random.Next(Level.Height);
            var count = 1;

            for (var i = 0; i < Level.Height; i++)
            {
                for (var j = 0; j < Level.Width; j++)
                {
                    if (snapshot.level.GetCell(j, i) == 1)
                    {
                        sx += j;
                        sy += i;
                        count++;
                    }
                }
            }

            var target = new Point(sx / count, sy / count);

            return Pathfind.Next(snapshot, prev, current, target);
        }
    }
}

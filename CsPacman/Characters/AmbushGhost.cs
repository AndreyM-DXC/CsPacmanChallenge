using CsPacman.Game;

namespace CsPacman.Characters
{
    public class AmbushGhost : Character
    {
        public AmbushGhost(StateSnapshot snapshot, Point position) : base(snapshot, position, 7)
        {
        }

        public override Animation GetAnimation()
        {
            return Animations.Ghost4[animation];
        }

        protected override Point NextTarget(Point prev, Point current)
        {
            var target = new Point(
                snapshot.player.X * 2 - snapshot.ghosts[0].X,
                snapshot.player.Y * 2 - snapshot.ghosts[0].Y
            );
            return Pathfind.Next(snapshot, prev, current, target);
        }
    }
}

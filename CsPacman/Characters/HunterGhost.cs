using CsPacman.Game;

namespace CsPacman.Characters
{
    public class HunterGhost : Character
    {
        public HunterGhost(StateSnapshot snapshot, Point position) : base(snapshot, position, 9)
        {
        }

        public override Animation GetAnimation()
        {
            return Animations.Ghost1[animation];
        }

        protected override Point NextTarget(Point prev, Point current)
        {
            return Pathfind.Next(snapshot, prev, current, snapshot.player);
        }
    }
}

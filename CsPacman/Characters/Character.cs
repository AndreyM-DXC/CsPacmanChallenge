using CsPacman.Game;

namespace CsPacman.Characters
{
    public abstract class Character
    {
        protected readonly StateSnapshot snapshot;
        private Point source;
        private Point target;

        protected int animation;

        private int frame;
        private readonly int frames;

        public Point Tile => frame < frames / 2 ? source : target;
        public Point Pixel => new Point(
                source.X * 16 - 8 + (target.X - source.X) * 16 * frame / frames,
                source.Y * 16 - 8 + (target.Y - source.Y) * 16 * frame / frames
            );

        public abstract Animation GetAnimation();
        protected abstract Point NextTarget(Point prev, Point current);

        protected Character(StateSnapshot snapshot, Point position, int frames)
        {
            this.snapshot = snapshot;
            source = position;
            target = position;
            frame = frames;
            this.frames = frames;
        }

        public void Update()
        {
            if (++frame >= frames)
            {
                target = NextTarget(source, source = target);
                frame = 0;

                if (source.Y > target.Y)
                {
                    animation = Animations.Top;
                }
                if (source.X < target.X)
                {
                    animation = Animations.Right;
                }
                if (source.Y < target.Y)
                {
                    animation = Animations.Bottom;
                }
                if (source.X > target.X)
                {
                    animation = Animations.Left;
                }
            }
        }
    }
}

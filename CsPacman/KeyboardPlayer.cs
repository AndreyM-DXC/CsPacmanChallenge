using CsPacman.Game;

namespace CsPacman
{
    public class KeyboardPlayer : IPlayer
    {
        private readonly List<Keys> pressed = new List<Keys>();
        private Keys last;

        public KeyboardPlayer(Control ui)
        {
            ui.PreviewKeyDown += (s, e) => HandleKey(e.KeyData, true);
            ui.KeyUp += (s, e) => HandleKey(e.KeyData, false);
        }

        public Point Step(StateSnapshot state)
        {
            var delta = pressed.Count > 0 ? Direction(pressed[^1]) : Direction(last);
            last = Keys.None;
            return delta;
        }

        private void HandleKey(Keys key, bool press)
        {
            switch (key)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    if (press)
                    {
                        if (!pressed.Contains(key))
                        {
                            pressed.Add(last = key);
                        }
                    }
                    else
                    {
                        pressed.Remove(key);
                    }
                    break;
            }
        }

        private static Point Direction(Keys key)
        {
            switch (key)
            {
                case Keys.Left: return Moves.Left;
                case Keys.Right: return Moves.Right;
                case Keys.Up: return Moves.Up;
                case Keys.Down: return Moves.Down;
                default: return new Point();
            }
        }
    }
}

using CsPacman.Game;
using System.Diagnostics;

namespace CsPacman
{
    public class GameUI : Control, IRender
    {
        private readonly Image background = Image.FromFile("Assets/board.png");
        private readonly Image dot = Image.FromFile("Assets/dot.png");
        private readonly Pen grid = new Pen(Color.FromArgb(0x30, 0x30, 0x30));
        private string status = "Score: 0 Tick: 0";
        private GameState? state;

        public GameUI()
        {
            DoubleBuffered = true;
            Location = new Point(DefaultMargin.Left, DefaultMargin.Top);
            MinimumSize = new Size(Level.Width * 16, Level.Height * 16);
        }

        public void Draw(GameState state)
        {
            this.state = state;
            this.status = $"Score: {state.score} Tick: {state.tick}";
            Invalidate();
        }

        public void GameOver(Exception e)
        {
            status += " Game Over!";
            Debug.WriteLine(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (state != null)
            {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(background, 0, 0);

                for (int i = 0, idx = 0; i < Level.Height; i++)
                {
                    for (var j = 0; j < Level.Width; j++, idx++)
                    {
                        DrawTile(e.Graphics, j, i, state.level.data[idx]);
                    }
                }

                state.player.GetAnimation().Draw(e.Graphics, state.player.Pixel, state.tick);

                foreach (var ghost in state.ghosts)
                {
                    ghost.GetAnimation().Draw(e.Graphics, ghost.Pixel, state.tick);
                }

                e.Graphics.DrawString(status, SystemFonts.DefaultFont, Brushes.White, 5, Level.Height * 16 - 16);
            }
        }

        private void DrawTile(Graphics g, int x, int y, byte tile)
        {
            if (tile == 1)
            {
                g.DrawImage(dot, x * 16, y * 16);
            }

            // Draw Grid
            // g.DrawRectangle(grid, x * 16, y * 16, 16, 16);
        }
    }
}

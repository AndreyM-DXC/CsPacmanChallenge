using CsPacman.Game;
using Timer = System.Windows.Forms.Timer;

namespace CsPacman
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var ui = new GameUI();
            var player = new KeyboardPlayer(ui);
            var game = new GameLoop(0, player);

            var timer = new Timer
            {
                Interval = 1000 / 30
            };
            timer.Tick += (s, e) =>
            {
                if (!game.Step(ui))
                {
                    timer.Stop();
                }
            };
            timer.Start();

            Application.Run(new Form
            {
                Text = "C# Pacman Challenge",
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                Controls = { ui }
            });
        }
    }
}
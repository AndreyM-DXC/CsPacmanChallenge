using CsPacman.Game;

namespace CsPacman
{
    public class RandomPlayer : IPlayer
    {
        private readonly Random random = new Random();

        public Point Step(StateSnapshot state)
        {
            while (true)
            {
                var move = Moves.All[random.Next(Moves.All.Length)];
                var target = new Point(state.player.X + move.X, state.player.Y + move.Y);
                if (!state.level.IsWall(target))
                {
                    return move;
                }
            }
        }
    }
}

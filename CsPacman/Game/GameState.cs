
using CsPacman.Characters;

namespace CsPacman.Game
{
    public class GameState
    {
        public readonly Level level = new Level();
        public readonly Character player;
        public readonly Character[] ghosts;

        public int tick;
        public int score;

        public GameState(Character player, params Character[] ghosts)
        {
            this.player = player;
            this.ghosts = ghosts;
        }

        public void CopyTo(StateSnapshot snapshot)
        {
            for (var i = 0; i < ghosts.Length; i++)
            {
                snapshot.ghosts[i] = ghosts[i].Tile;
            }
            snapshot.tick = tick;
            snapshot.score = score;
            snapshot.player = player.Tile;
            snapshot.level.CopyFrom(level);
        }

        public void Update()
        {
            foreach (var ghost in ghosts)
            {
                ghost.Update();

                if (ghost.Tile == player.Tile)
                {
                    throw new GameOverException();
                }
            }

            player.Update();

            if (EatCell(player.Tile))
            {
                level.ReloadIfEmpty();
                score += 1;
            }
            tick++;
        }

        private bool EatCell(Point p)
        {
            if (level.GetCell(p) == 1)
            {
                level.GetCell(p) = 0;
                return true;
            }
            return false;
        }
    }
}


namespace CsPacman.Game
{
    public interface IRender
    {
        void Draw(GameState state);
        void GameOver(Exception e);
    }
}

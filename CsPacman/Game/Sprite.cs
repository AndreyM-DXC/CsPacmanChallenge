
namespace CsPacman.Game
{
    public class Sprite
    {
        public readonly Image image;
        public readonly Rectangle rect;

        public Sprite(Image image, int x, int y)
        {
            this.image = image;
            this.rect = new Rectangle(x * 32, y * 32, 32, 32);
        }
    }
}

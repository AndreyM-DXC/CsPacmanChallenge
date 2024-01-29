
namespace CsPacman.Game
{
    public class Animation
    {
        private readonly Sprite[] sprites;
        private readonly int rate;

        public Animation(int rate, params Sprite[] sprites)
        {
            this.rate = rate;
            this.sprites = sprites;
        }

        public void Draw(Graphics g, Point pixel, int tick)
        {
            var sprite = sprites[tick / rate % sprites.Length];
            var rect = new Rectangle(pixel.X, pixel.Y, sprite.rect.Width, sprite.rect.Height);
            g.DrawImage(sprite.image, rect, sprite.rect, GraphicsUnit.Pixel);
        }
    }
}

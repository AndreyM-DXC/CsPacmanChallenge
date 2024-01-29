
namespace CsPacman.Game
{
    public static class Animations
    {
        public const int Top = 0;
        public const int Right = 1;
        public const int Bottom = 2;
        public const int Left = 3;

        public static readonly Animation[] Pacman;
        public static readonly Animation[] Ghost1;
        public static readonly Animation[] Ghost2;
        public static readonly Animation[] Ghost3;
        public static readonly Animation[] Ghost4;

        static Animations()
        {
            var image = Image.FromFile("Assets/characters.png");
            var sprites = new Sprite[8, 8];

            for  (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    sprites[j, i] = new Sprite(image, j, i);
                }
            }

            var pr = 1;
            Pacman = new[]
            {
                new Animation(pr, sprites[0, 0], sprites[1, 0], sprites[2, 0], sprites[3, 0], sprites[2, 0], sprites[1, 0]),
                new Animation(pr, sprites[0, 1], sprites[1, 1], sprites[2, 1], sprites[3, 1], sprites[2, 1], sprites[1, 1]),
                new Animation(pr, sprites[0, 2], sprites[1, 2], sprites[2, 2], sprites[3, 2], sprites[2, 2], sprites[1, 2]),
                new Animation(pr, sprites[0, 3], sprites[1, 3], sprites[2, 3], sprites[3, 3], sprites[2, 3], sprites[1, 3]),
            };

            var gr = 4;
            Ghost1 = new[]
            {
                new Animation(gr, sprites[0, 4], sprites[1, 4]),
                new Animation(gr, sprites[2, 4], sprites[3, 4]),
                new Animation(gr, sprites[4, 4], sprites[5, 4]),
                new Animation(gr, sprites[6, 4], sprites[7, 4]),
            };
            Ghost2 = new[]
            {
                new Animation(gr, sprites[0, 5], sprites[1, 5]),
                new Animation(gr, sprites[2, 5], sprites[3, 5]),
                new Animation(gr, sprites[4, 5], sprites[5, 5]),
                new Animation(gr, sprites[6, 5], sprites[7, 5]),
            };
            Ghost3 = new[]
            {
                new Animation(gr, sprites[0, 6], sprites[1, 6]),
                new Animation(gr, sprites[2, 6], sprites[3, 6]),
                new Animation(gr, sprites[4, 6], sprites[5, 6]),
                new Animation(gr, sprites[6, 6], sprites[7, 6]),
            };
            Ghost4 = new[]
            {
                new Animation(gr, sprites[0, 7], sprites[1, 7]),
                new Animation(gr, sprites[2, 7], sprites[3, 7]),
                new Animation(gr, sprites[4, 7], sprites[5, 7]),
                new Animation(gr, sprites[6, 7], sprites[7, 7]),
            };
        }
    }
}

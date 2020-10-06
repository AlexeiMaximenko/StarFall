using System;
using System.Drawing;
using System.Windows.Forms;

namespace Star
    {
    public class Game
        {
        private Random random = new Random();
        private int resolution = 2;
        private Star[,] field;
        private int randomChance = 3;
        private PictureBox pictureBox;
        private Draw draw;
        public Game(PictureBox pictureBox)
            {
            this.pictureBox = pictureBox;
            draw = new Draw(pictureBox);
            }
        public void Start(int amountStarValue)
            {
            field = new Star[pictureBox.Width / resolution, pictureBox.Height / resolution];
            for (int x = 0; x < pictureBox.Width / resolution; x++)
                {
                for (int y = 0; y < pictureBox.Height / resolution; y++)
                    {
                    if (random.Next((randomChance * 1000) - (amountStarValue) * (randomChance * 1000 / 10 - 20)) == 0)
                        {
                        var star = new Star();
                        star.color = new SolidBrush(Color.FromArgb(random.Next(185, 255), random.Next(185, 255), random.Next(185, 255)));
                        star.x = x;
                        star.y = y;
                        field[x, y] = star;
                        }

                    }
                }

            RefreshGameField();
            }
        public void RefreshGameField()
            {
            Clear();
            var field2 = new Star[pictureBox.Width / resolution, pictureBox.Height / resolution];
            for (int x = 0; x < pictureBox.Width / resolution; x++)
                {
                for (int y = 0; y < pictureBox.Height / resolution; y++)
                    {
                    if (field[x, y] != null)
                        {
                        draw.Dot(field[x, y].color, x, y, resolution);
                        field[x, y].x++;
                        field[x, y].y++;
                        field2[x++, y++] = field[x, y];

                        }
                    }
                }
            field = field2;
            }
        private void Clear()
            {
            draw.Fill(Brushes.Black);
            }
        }
    }

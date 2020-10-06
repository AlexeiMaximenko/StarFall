using System;
using System.Drawing;
using System.Windows.Forms;

namespace Star
    {
    public class Game
        {
        private Random random = new Random();
        private int resolutionField = 5;
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
            field = new Star[pictureBox.Width / resolutionField, pictureBox.Height / resolutionField];
            for (int x = 0; x < pictureBox.Width / resolutionField; x++)
                {
                for (int y = 0; y < pictureBox.Height / resolutionField; y++)
                    {
                    if (random.Next((randomChance * 1000) - (amountStarValue) * (randomChance * 1000 / 10 - 20)) == 0)
                        {
                        var star = new Star();
                        star.color = new SolidBrush(Color.FromArgb(random.Next(185, 256), random.Next(185, 256), random.Next(185, 256)));
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
            for (int x = 0; x < pictureBox.Width / resolutionField; x++)
                {
                for (int y = 0; y < pictureBox.Height / resolutionField; y++)
                    {
                    if (field[x, y] != null)
                        draw.BrushDot(field[x, y].color, x, y, resolutionField);
                    }
                }
            }
        private void Clear()
            {
            draw.BrushFill(Brushes.Black);
            }
        }
    }

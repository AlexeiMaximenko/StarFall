using System.Drawing;
using System.Windows.Forms;

namespace Star
    {
    public class Draw
        {
        private Graphics graphics;
        private PictureBox pictureBox;
        public Draw(PictureBox pictureBox)
            {
            this.pictureBox = pictureBox;
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
            }
        public void BrushFill(Brush brush)
            {
            graphics.FillRectangle(brush, 0, 0, pictureBox.Width, pictureBox.Height);
            }
        public void BrushDot(Brush brush, int x, int y, int resolution)
            {
            graphics.FillRectangle(brush, x * resolution, y * resolution, 1, 1);
            }
        }
    }

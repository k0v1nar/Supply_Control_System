using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CaptchaGenerator
{
    public class CaptchaGenerator
    {
        static private Random _rnd = new Random();
        static private Brush[] _colors =
        {
            Brushes.Black,
            Brushes.Red,
            Brushes.RoyalBlue,
            Brushes.Green,
            Brushes.Yellow,
            Brushes.White,
            Brushes.Tomato,
            Brushes.Sienna,
            Brushes.Pink
        };
        static private Pen[] _pens = {
            Pens.Black,
            Pens.Red,
            Pens.RoyalBlue,
            Pens.Green,
            Pens.Yellow,
            Pens.White,
            Pens.Tomato,
            Pens.Sienna,
            Pens.Pink
        };
        static private FontStyle[] _fontStyle = {
            FontStyle.Bold,
            FontStyle.Italic,
            FontStyle.Regular,
            FontStyle.Strikeout,
            FontStyle.Underline
        };
        static private Int16[] _rotateText = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

        static public Bitmap GetCaptcha(int width, int height, string text, Color background)
        {
            float textSize = Math.Min(width, height) / 2;
            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(background);
            graphics.RotateTransform(_rotateText[_rnd.Next(_rotateText.Length)]);
            int posX = _rnd.Next(0, (int)(width / 2));
            int posY = _rnd.Next(0, (int)(height / 2));
            graphics.DrawString(text, new Font("Roboto", textSize, _fontStyle[_rnd.Next(_fontStyle.Length)]), _colors[_rnd.Next(_colors.Length)], new PointF(posX, posY));
            int countLines = _rnd.Next(5);
            for (int i = 0; i < countLines; i++)
            {
                Point begin = new Point(0, 0);
                Point end = new Point(0, 0);
                if (i % 2 == 0)
                {
                    begin = new Point(_rnd.Next(0, (int)textSize), _rnd.Next(0, (int)textSize));
                    end = new Point(_rnd.Next(width - (int)textSize, width), _rnd.Next(height - (int)textSize, height));
                }
                else
                {
                    begin = new Point(_rnd.Next(0, (int)textSize), _rnd.Next(height - (int)textSize, height));
                    end = new Point(_rnd.Next(width - (int)textSize, width), _rnd.Next(0, (int)textSize));
                }
                graphics.DrawLine(_pens[_rnd.Next(_pens.Length)], begin, end);
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (_rnd.Next() % 15 == 0)
                    {
                        bitmap.SetPixel(i, j, Color.White);
                    }
                }
            }
            return bitmap;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Supply_control_system.Components
{
    public partial class CustomDateTimePicker : DateTimePicker
    {
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;
        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.calendarWhite;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;

        public CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                if (skinColor.GetBrightness() >= 0.8F)
                    calendarIcon = Properties.Resources.calendarDark;
                else calendarIcon = Properties.Resources.calendarWhite;
                this.Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen penBorder = new Pen(borderColor, borderSize);
            SolidBrush skinBrush = new SolidBrush(skinColor);
            SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64));
            SolidBrush textBrush = new SolidBrush(textColor);
            StringFormat textFormat = new StringFormat();
            RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
            RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
            penBorder.Alignment = PenAlignment.Inset;
            textFormat.LineAlignment = StringAlignment.Center;
            graphics.FillRectangle(skinBrush, clientArea);
            graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
            if (droppedDown == true)
            {
                graphics.FillRectangle(openIconBrush, iconArea);
            }
            if (borderSize >= 1)
            {
                graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
            }
            graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);
            textFormat.Dispose();
            textBrush.Dispose();
            openIconBrush.Dispose();
            skinBrush.Dispose();
            penBorder.Dispose();
            graphics.Dispose();
        }
    }
}

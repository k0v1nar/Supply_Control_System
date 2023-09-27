using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShadowEffect
{
    public partial class ShadowEffect : Component
    {
        #region Fields

        private Control _sourceControl;
        private Color _shadowColor = Color.Black;
        private Padding _shadowPadding = new Padding(5);
        private bool _useShadowEffect = true;
        private int _depth = 30;
        private int _borderRadius = 6;
        private Bitmap _shadowImage;

        private Bitmap _bitmap;
        private Brush _brush;
        private Graphics _graphics;
        private Graphics _shadowGraphics;
        private Rectangle _rectangleWithShadow;
        private GraphicsPath _path;
        private int _maxPadding;

        #endregion 

        #region Properties

        public Control SourceControl
        {
            get { return _sourceControl; }
            set
            {
                _sourceControl = value;
                _sourceControl.Resize += SourceControl_Resize;
                if (_sourceControl?.Parent != null)
                {
                    _sourceControl.Parent.Paint += SourceControlParent_Paint;
                    return;
                }
                _sourceControl.ParentChanged += sourceControl_ParentChanged;
            }
        }

        public Color ShadowColor
        {
            get
            {
                return _shadowColor;
            }
            set
            {
                _shadowColor = value;
            }
        }

        public int Depth
        {
            get
            {
                return _depth;
            }
            set
            {
                if (value > byte.MaxValue)
                {
                    _depth = byte.MaxValue;
                    return;
                }
                if (value < 0)
                {
                    _depth = 0;
                    return;
                }
                _depth = value;
            }
        }

        public bool UseShadowEffect
        {
            get
            {
                return _useShadowEffect;
            }
            set
            {
                _useShadowEffect = value;
            }
        }

        public Padding ShadowPadding
        {
            get
            {
                return _shadowPadding;
            }
            set
            {
                _shadowPadding = value;
            }
        }

        public int ShadowRadius
        {
            get
            {
                return _borderRadius;
            }
            set
            {
                if (value < 0)
                {
                    _borderRadius = 0;
                    return;
                }
                _borderRadius = value;
            }
        }

        #endregion

        #region Methods

        private void UpdateRectangleWithShadow()
        {
            int locationX = SourceControl.Location.X - ShadowPadding.Left;
            int locationY = SourceControl.Location.Y - ShadowPadding.Top;
            int widthIncrease = ShadowPadding.Left + ShadowPadding.Right;
            int heightIncrease = ShadowPadding.Top + ShadowPadding.Bottom;
            int width = SourceControl.Width + widthIncrease;
            int height = SourceControl.Height + heightIncrease;
            _rectangleWithShadow = new Rectangle(locationX, locationY, width, height);
        }

        private void UpdateMaxSizePadding()
        {
            int maxHorizontalPadding = Math.Max(ShadowPadding.Left, ShadowPadding.Right);
            int maxVerticalPadding = Math.Max(ShadowPadding.Top, ShadowPadding.Bottom);
            _maxPadding = Math.Max(maxHorizontalPadding, maxVerticalPadding);
        }

        private void UpdateFigurePath(RectangleF rectangle, float radius)
        {
            _path = new GraphicsPath();
            float diametr = radius * 2f;
            _path.StartFigure();
            _path.AddArc(rectangle.X, rectangle.Y, diametr, diametr, 180, 90);
            _path.AddArc(rectangle.Right - diametr, rectangle.Y, diametr, diametr, 270, 90);
            _path.AddArc(rectangle.Right - diametr, rectangle.Bottom - diametr, diametr, diametr, 0, 90);
            _path.AddArc(rectangle.X, rectangle.Bottom - diametr, diametr, diametr, 90, 90);
            _path.CloseFigure();
        }

        private void SourceControlParent_Paint(object sender, PaintEventArgs e)
        {
            if (SourceControl.Visible == false) return;
            if (UseShadowEffect == false) return;
            if (DesignMode) return;
            UpdateRectangleWithShadow();
            if (_shadowImage == null)
            {
                _bitmap = new Bitmap(_rectangleWithShadow.Width / 2, _rectangleWithShadow.Height / 2);
                _brush = new SolidBrush(Color.FromArgb(Depth, ShadowColor));
                _graphics = Graphics.FromImage(_bitmap);
                RectangleF rectangle1 = new RectangleF(.0f, .0f, _bitmap.Width, _bitmap.Height);
                RectangleF rectangle2 = new RectangleF(rectangle1.X, rectangle1.Y, rectangle1.Width - 1f, rectangle1.Height - 1f);
                _graphics.SmoothingMode = SmoothingMode.AntiAlias;
                float radius = 0;
                if (ShadowRadius < 2)
                {
                    radius = 1f;
                }
                else
                {
                    radius = ShadowRadius / 2f;
                }
                UpdateFigurePath(rectangle2, radius);
                _graphics.FillPath(_brush, _path);
                _shadowImage = new Bitmap(_rectangleWithShadow.Width, _rectangleWithShadow.Height);
                _shadowGraphics = Graphics.FromImage(_shadowImage);
                _shadowGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                UpdateMaxSizePadding();
                if (_maxPadding > 10)
                {
                    _maxPadding = 10;
                }
                for (int i = 0; i <= _maxPadding; i++)
                {
                    int width = _rectangleWithShadow.Width - (i * 2);
                    int heigth = _rectangleWithShadow.Height - (i * 2);
                    Rectangle rect = new Rectangle(i, i, width, heigth);
                    _shadowGraphics.DrawImage(_bitmap, rect);
                }
            }
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.DrawImage(_shadowImage, _rectangleWithShadow.X, _rectangleWithShadow.Y);
        }

        private void sourceControl_ParentChanged(object sender, EventArgs e)
        {
            _sourceControl.Parent.Paint += SourceControlParent_Paint;
        }

        private void SourceControl_Resize(object sender, EventArgs e)
        {
            if (_shadowImage != null)
            {
                _shadowImage.Dispose();
                _shadowImage = null;
            }
            if (_graphics != null)
            {
                _graphics.Dispose();
                _graphics = null;
            }
            if (_shadowGraphics != null)
            {
                _shadowGraphics.Dispose();
                _shadowGraphics = null;
            }
            if (_bitmap != null)
            {
                _bitmap.Dispose();
                _bitmap = null;
            }
            if (_path != null)
            {
                _path.Dispose();
                _path = null;
            }
        }

        #endregion

        public ShadowEffect()
        {
            InitializeComponent();
        }

        public ShadowEffect(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

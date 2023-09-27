using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialFormLibrary
{
    public class AutoScalingForm
    {
        private List<Control> _allControls;
        private List<Rectangle> _originalRectangles;
        private float _originalFontSize;
        private Rectangle _originalFormSize;
        private Form _form;

        private AutoScalingForm()
        {
            _allControls = new List<Control>();
            _originalRectangles = new List<Rectangle>();
        }

        private void Init()
        {
            _originalFormSize = new Rectangle(_form.Location.X, _form.Location.Y, _form.Size.Width, _form.Size.Height);
            _originalFontSize = _form.Font.Size;
            for (int i = 0; i < _form.Controls.Count; i++)
            {
                AddElement(_form.Controls[i]);
            }
            ResizeAll();
        }

        private void AddElement(Control element)
        {
            _allControls.Add(element);
            Rectangle originalElement = new Rectangle(element.Location.X, element.Location.Y, element.Width, element.Height);
            _originalRectangles.Add(originalElement);
            for (int i = 0; i < element.Controls.Count; i++)
            {
                AddElement(element.Controls[i]);
            }
        }

        public void ResizeAll()
        {
            float xRatio = (float)(_form.Width) / (float)(_originalFormSize.Width);
            float yRatio = (float)(_form.Height) / (float)(_originalFormSize.Height);
            for (int i = 0; i < _allControls.Count; i++)
            {
                Rectangle rectangle = _originalRectangles[i];
                int newX = (int)(rectangle.X * xRatio);
                int newY = (int)(rectangle.Y * yRatio);
                int newWidth = (int)(rectangle.Width * xRatio);
                int newHeight = (int)(rectangle.Height * yRatio);
                Point newPoint = new Point(newX, newY);
                Size newSize = new Size(newWidth, newHeight);
                float newFontSize = _originalFontSize * Math.Min(yRatio, xRatio);
                _allControls[i].Location = newPoint;
                _allControls[i].Size = newSize;
                _allControls[i].Font = new Font("Robot", newFontSize, FontStyle.Regular);
            }
        }

        static public AutoScalingForm Init(Form form)
        {
            AutoScalingForm autoScalingForm = new AutoScalingForm();
            autoScalingForm._form = form;
            autoScalingForm.Init();
            return autoScalingForm;
        }
    }
}

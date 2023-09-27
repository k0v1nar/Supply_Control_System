using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_control_system.Components
{
    public partial class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color MenuStripGradientBegin
        {
            get
            {
                return Properties.Settings.Default.selectColor;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Properties.Settings.Default.selectColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Properties.Settings.Default.backgroundColor;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Properties.Settings.Default.backgroundColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Properties.Settings.Default.labelColor;
            }
        }
    }
}

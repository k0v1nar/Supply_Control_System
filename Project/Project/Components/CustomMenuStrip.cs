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
    public partial class CustomMenuStrip : MenuStrip
    {
        public CustomMenuStrip()
        {
            InitializeComponent();
            this.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }
    }
}

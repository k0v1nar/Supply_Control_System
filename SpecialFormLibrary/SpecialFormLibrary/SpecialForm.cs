using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialFormLibrary
{
    public partial class SpecialForm : Form
    {
        protected AutoScalingForm _autoScalingForm;
        protected SqlModule _sqlModule;

        public SpecialForm()
        {
            _finsih = true;
            _sqlModule = new SqlModule("");
            DoubleBuffered = true;
        }

        public SpecialForm(string connectionString)
        {
            _finsih = true;
            _sqlModule = new SqlModule(connectionString);
            DoubleBuffered = true;
        }

        protected bool _finsih; // Наследумое поле для автосохранения
        

        /// <summary>
        /// Свойство для получения статуса автосохранения
        /// </summary>
        public bool Finish
        {
            get { return _finsih; }
        }
    }
}

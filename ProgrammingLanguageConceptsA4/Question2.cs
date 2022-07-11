using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingLanguageConceptsA4
{
    public partial class Question2 : UserControl
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void pnlQ2_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool check()
        {
            if (!rdTrue.Checked && rdFalse.Checked)
            {
                return true;
            }
            else 
                return false;
        }
    }
}

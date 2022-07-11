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
    public partial class Question : UserControl
    {
        public Question()
        {
            InitializeComponent();
        }

        private void Question_Load(object sender, EventArgs e)
        {

        }

        private void pnlQ1_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool check()
        {
            if(!rdA.Checked && !rdB.Checked && !rdD.Checked && !rdE.Checked && rdC.Checked) 
            {
                return true;
            }

            else 
                return false;
        }
    }
}

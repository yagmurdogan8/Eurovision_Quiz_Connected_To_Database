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
    public partial class Question3 : UserControl
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void Question3_Load(object sender, EventArgs e)
        {

        }
        public bool check()
        {
            if (txtQ3.Text.Equals("1975"))
            {
                return true;
            }

            else 
                return false;
        }
    }
}

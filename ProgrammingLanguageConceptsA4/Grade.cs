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
    public partial class Grade : UserControl
    {
        public Grade()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {

        }
        public void gradeOfAll(int i)
        {
            lblGrade2.Text = i.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePLCDataSet);

        }

        private void gradesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePLCDataSet);

        }
    }
}

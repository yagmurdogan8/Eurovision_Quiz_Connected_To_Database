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
    public partial class Tables : UserControl
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          //  this.studentsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.databasePLCDataSet1);

        }

        private void pnlTables_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Tables_Load(object sender, EventArgs e)
        {
            
        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePLCDataSet);

        }
    }
}

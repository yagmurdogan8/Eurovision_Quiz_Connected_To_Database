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
    public partial class Login : UserControl
    {

        Form1 form = new Form1();
       
        public Login()
        {
            InitializeComponent();            
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {            
            if (!txtName.Text.Equals(""))
            {
                form.btnOK.Enabled = true;
            }
            else
            {
                form.btnOK.Enabled = false;
            }
        }

        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void gradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePLCDataSet);

        }
    }
}

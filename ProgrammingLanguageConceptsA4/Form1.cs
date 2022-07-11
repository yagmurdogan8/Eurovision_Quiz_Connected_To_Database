using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace ProgrammingLanguageConceptsA4
{
    public partial class Form1 : Form
    {
        EventLog eventLog1 = new EventLog();

        ArrayList questionRow = new ArrayList();
        Grade popUp = new Grade();
        int grade;
        Login objLog;

        public Form1()
        {
            InitializeComponent();
            btnHomePage.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePLCDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.databasePLCDataSet.Students);
            // TODO: This line of code loads data into the 'databasePLCDataSet.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.databasePLCDataSet.Questions);
            // TODO: This line of code loads data into the 'databasePLCDataSet.Grades' table. You can move, or remove it, as needed.
            this.gradesTableAdapter.Fill(this.databasePLCDataSet.Grades);
            objLog = new Login();
            Question q1 = new Question();
            Question2 q2 = new Question2();
            Question3 q3 = new Question3();

            questionRow.Add(q1);
            questionRow.Add(q2);
            questionRow.Add(q3);

            pnlHome.Controls.Add(objLog);
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.RemoveAt(0);
            pnlHome.Controls.Add(objLog);

            btnHomePage.Visible = false;
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            Tables table = new Tables();
            table.studentsTableAdapter.Fill(table.databasePLCDataSet.Students);
            table.gradesTableAdapter.Fill(table.databasePLCDataSet.Grades);
            pnlHome.Controls.RemoveAt(0);
            pnlHome.Controls.Add(table);

            btnHomePage.Visible = true;
            btnDB.Visible = false;
        }

        public void randomQuestion(ArrayList questionRow)
        {
            Random rndm = new Random();
            int random = rndm.Next(0, (questionRow.Count));

            if (questionRow.Count == 0)
            {
                this.Close();
            }
            else
            {
                pnlHome.Controls.Add((Control)questionRow[random]);
                questionRow.RemoveAt(random);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Type questionType = pnlHome.Controls[0].GetType();
            bool answer;
            btnDB.Visible = false;

            if (btnOK.Text.Equals("Start"))
            {
                studentsTableAdapter.Insert(objLog.txtName.Text);
            }

            if (questionType == typeof(Question))
            {
                Question q1 = (Question)pnlHome.Controls[0];
                answer = q1.check();

                if (answer) grade += 30;
            }
            else if (questionType == typeof(Question2))
            {
                Question2 q2 = (Question2)pnlHome.Controls[0];
                answer = q2.check();

                if (answer) grade += 30;
            }
            else if (questionType == typeof(Question3))
            {
                Question3 q3 = (Question3)pnlHome.Controls[0];
                answer = q3.check();

                if (answer) grade += 40;
            }

            pnlHome.Controls.RemoveAt(0);

            if (questionRow.Count > 1)
            {
                btnOK.Text = "OK";
                randomQuestion(questionRow);
            }
            else if (questionRow.Count == 1)
            {
                btnOK.Text = "End";
                randomQuestion(questionRow);
            }
            else if (questionRow.Count == 0)
            {
                gradesTableAdapter.Insert(grade.ToString());
                popUp.gradeOfAll(grade);
                pnlHome.Controls.Add(popUp);

                btnDB.Visible = false;
                btnOK.Visible = false;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pnlHome_MouseEnter(object sender, EventArgs e)
        {
            lblLog.Text = "";
        }

        private void pnlHome_MouseLeave(object sender, EventArgs e)
        {
            lblLog.Text = "";
        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
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
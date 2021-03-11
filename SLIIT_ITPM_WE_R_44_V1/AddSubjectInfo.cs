using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SLIIT_ITPM_WE_R_44_V1
{
    public partial class AddSubjectInfo : Form
    {

        public string offeredSemester;
        public AddSubjectInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");

        public void cleanInputFields()
        {
            subjectID.Text = "";
            offeredYearComboBox.Text = "";
            textSubjectName.Text = "";
            textSubjectCode.Text = "";
            noLectureHours.Value = 0;
            noTutorialHours.Value = 0;
            noLabHours.Value = 0;
            noEvaluationHours.Value = 0;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void generateSubjecCode_Click(object sender, EventArgs e)
        {
            textSubjectCode.Text = subjectID.Text + "." + offeredYearComboBox.Text + "." + offeredSemester;
        }

        private void semester1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            offeredSemester = "1";
        }

        private void semester2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            offeredSemester = "2";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddSubject values ('" + int.Parse(subjectID.Text) + "' , '" + offeredYearComboBox.Text + "' , '" + offeredSemester + "' , '" + textSubjectName.Text + "' , '" + textSubjectCode.Text + "' , '" + noLectureHours.Text + "' , '" + noTutorialHours.Text + "' , '" + noLabHours.Text + "' , '" + noEvaluationHours.Text + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            cleanInputFields();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AddSubjectInfoDisplay addSubjectInfoDisplay = new AddSubjectInfoDisplay();
            addSubjectInfoDisplay.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update AddSubject set OfferedYear = '" + offeredYearComboBox.Text + "' , OfferedSemester = '" + offeredSemester + "' , SubjectName = '" + textSubjectName.Text + "' , SubjectCode = '" + textSubjectCode.Text + "' , NoOfLecHours = '" + noLectureHours.Text + "' , NoOfTuteHours = '" + noTutorialHours.Text + "' , NoOfLabHours = '" + noLabHours.Text + "' , NoOfEvHours = '" + noEvaluationHours.Text + "' , UpdateDate = getdate() where SubjectID = '" + int.Parse(subjectID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            cleanInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (subjectID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");

                }


            }
            else
            {
                MessageBox.Show("Enter The Subject ID here...!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanInputFields();
        }
    }
}

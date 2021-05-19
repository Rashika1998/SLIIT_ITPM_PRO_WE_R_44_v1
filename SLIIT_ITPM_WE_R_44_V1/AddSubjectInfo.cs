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

        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");


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


        private void toUpdate_Click(object sender, EventArgs e)
        {

            if (subjectID.Text != "")
            {

                con.Open();
                SqlCommand command1 = new SqlCommand("select OfferedYear from AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "' ", con);
                SqlCommand command2 = new SqlCommand("select OfferedSemester from AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "' ", con);
                SqlCommand command3 = new SqlCommand("select SubjectName from AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "' ", con);
                SqlCommand command4 = new SqlCommand("select SubjectCode from AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "' ", con);
                SqlCommand command5 = new SqlCommand("select NoOfLecHours from AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "' ", con);
                SqlCommand command6 = new SqlCommand("select NoOfTuteHours from AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "' ", con);
                SqlCommand command7 = new SqlCommand("select NoOfLabHours from AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "' ", con);
                SqlCommand command8 = new SqlCommand("select NoOfEvHours from AddSubject where SubjectID = '" + int.Parse(subjectID.Text) + "' ", con);



                String offered_year = command1.ExecuteScalar().ToString();
                String offered_semester = command2.ExecuteScalar().ToString();
                String subject_name = command3.ExecuteScalar().ToString();
                String subject_code = command4.ExecuteScalar().ToString();
                String no_of_lec_hours = command5.ExecuteScalar().ToString();
                String no_of_tute_hours = command6.ExecuteScalar().ToString();
                String no_of_lab_hours = command7.ExecuteScalar().ToString();
                String no_of_ev_hours = command8.ExecuteScalar().ToString();


                offeredYearComboBox.Text = offered_year;

                if (offered_semester == "1")
                {
                    semester1RadioButton.Checked = true;
                }
                else
                {
                    semester2RadioButton.Checked = true;
                }

                textSubjectName.Text = subject_name;
                textSubjectCode.Text = subject_code;
                noLectureHours.Value = int.Parse(no_of_lec_hours);
                noTutorialHours.Value = int.Parse(no_of_tute_hours);
                noLabHours.Value = int.Parse(no_of_lab_hours);
                noEvaluationHours.Value = int.Parse(no_of_ev_hours);


                con.Close();

            }
            
            {
                MessageBox.Show("Enter the Subject ID");
            }

        }

        private void AddSubjectInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

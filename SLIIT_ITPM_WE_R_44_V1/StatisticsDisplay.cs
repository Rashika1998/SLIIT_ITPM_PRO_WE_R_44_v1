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

namespace SLIIT_ITPM_WE_R_44_V1
{
    public partial class StatisticsDisplay : Form
    {

        public StatisticsDisplay()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void StatisticsDisplay_Load(object sender, EventArgs e)
        {
            getRegisteredLecturerCount();
            getRegisteredStudentCount();
            getRegisteredSubjectCount();
            getRegisteredRoomCount();
        }


        public void getRegisteredLecturerCount()
        {

            con.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(EmpID) FROM AddLecturer;", con);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            textRegisteredLecturer.Text = Convert.ToString(count.ToString());
            con.Close();
          
        }


        public void getRegisteredStudentCount()
        {

            con.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(StudentGroupID) FROM AddStudentGroup;", con);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            textRegisteredStudent.Text = Convert.ToString(count.ToString());
            con.Close();

        }


        public void getRegisteredSubjectCount()
        {

            con.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(SubjectID) FROM AddSubject;", con);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            textRegisteredSubject.Text = Convert.ToString(count.ToString());
            con.Close();

        }


        public void getRegisteredRoomCount()
        {

            con.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(LocationID) FROM AddLocation;", con);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            textRegisteredRoom.Text = Convert.ToString(count.ToString());
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddLecturerInfoDisplay addLecturerInfoDisplay = new AddLecturerInfoDisplay();
            addLecturerInfoDisplay.ShowDialog();
        }

        private void textRegisteredLecturer_Click(object sender, EventArgs e)
        {
            AddLecturerInfoDisplay addLecturerInfoDisplay = new AddLecturerInfoDisplay();
            addLecturerInfoDisplay.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddStudentGroupInfoDisplay addStudentGroupInfoDisplay = new AddStudentGroupInfoDisplay();
            addStudentGroupInfoDisplay.ShowDialog();
        }

        private void textRegisteredStudent_Click(object sender, EventArgs e)
        {
            AddStudentGroupInfoDisplay addStudentGroupInfoDisplay = new AddStudentGroupInfoDisplay();
            addStudentGroupInfoDisplay.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddSubjectInfoDisplay addSubjectInfoDisplay = new AddSubjectInfoDisplay();
            addSubjectInfoDisplay.ShowDialog();
        }

        private void textRegisteredSubject_Click(object sender, EventArgs e)
        {
            AddSubjectInfoDisplay addSubjectInfoDisplay = new AddSubjectInfoDisplay();
            addSubjectInfoDisplay.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AddLocationInfoDisplay addLocationInfoDisplay = new AddLocationInfoDisplay();
            addLocationInfoDisplay.ShowDialog();
        }

        private void textRegisteredRoom_Click(object sender, EventArgs e)
        {
            AddLocationInfoDisplay addLocationInfoDisplay = new AddLocationInfoDisplay();
            addLocationInfoDisplay.ShowDialog();
        }

     
    }
}

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
    public partial class AddSessionInfo : Form
    {
        public AddSessionInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        public void cleanInputFields()
        {
            sessionID.Text = "";
            selectTagcomboBox.Text = "";
            selectLecturercomboBox1.Text = "";
            selectLecturercomboBox2.Text = "";
            selectedLecturers.Text = "";
            addHour.Text = "";
            addMin.Text = "";
            noOfStudent.Text = "";
            selectSubjectComboBox.Text = "";
            selectGroupComboBox.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddSession values ('" + int.Parse(sessionID.Text) + "' , '" + selectTagcomboBox.Text + "' , '" + selectLecturercomboBox1.Text + "' , '" + selectLecturercomboBox2.Text + "' , '" + addHour.Text + "' , '" + addMin.Text + "' , '" + noOfStudent.Text + "' , '" + selectSubjectComboBox.Text + "' , '" + selectGroupComboBox.Text + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            cleanInputFields();
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AddSessionInfoDisplay addSessionInfoDisplay = new AddSessionInfoDisplay();
            addSessionInfoDisplay.ShowDialog();
        }

        private void AddSessionInfo_Load(object sender, EventArgs e)
        {
            setLectureComboBoxValues();
            setTagComboBoxValues();
        }


        private void btnShowSelectedLecturers_Click(object sender, EventArgs e)
        {
            selectedLecturers.Text = selectLecturercomboBox1.Text + " , " + selectLecturercomboBox2.Text;
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            sessionID.Text = "";
            selectTagcomboBox.Text = "";
            selectLecturercomboBox1.Text = "";
            selectLecturercomboBox2.Text = "";
            selectedLecturers.Text = "";
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            addHour.Text = "";
            addMin.Text = "";
            noOfStudent.Text = "";
            selectSubjectComboBox.Text = "";
            selectGroupComboBox.Text = "";
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update AddSession set Tag = '" + selectTagcomboBox.Text + "' , Lecturer1 = '" + selectLecturercomboBox1.Text + "' , Lecturer2 = '" + selectLecturercomboBox2.Text + "' , Hrs = '" + addHour.Text + "' , Min = '" + addMin.Text + "' , NoOfStudents = '" + noOfStudent.Text + "' , Subject = '" + selectSubjectComboBox.Text + "' , StudentGroup = '" + selectGroupComboBox.Text + "' , UpdateDate = getdate() where SessionID = '" + int.Parse(sessionID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            cleanInputFields();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (sessionID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddSession where SessionID = '" + int.Parse(sessionID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    cleanInputFields();

                }

            }
            else
            {
                MessageBox.Show("Enter The Session ID here...!");
            }
        }

        private void toUpdate_Click(object sender, EventArgs e)
        {

            if (sessionID.Text != "")
            {

                con.Open();
                SqlCommand command1 = new SqlCommand("select Tag from AddSession where SessionID = '" + int.Parse(sessionID.Text) + "' ", con);
                SqlCommand command2 = new SqlCommand("select Lecturer1 from AddSession where SessionID = '" + int.Parse(sessionID.Text) + "' ", con);
                SqlCommand command3 = new SqlCommand("select Lecturer2 from AddSession where SessionID = '" + int.Parse(sessionID.Text) + "' ", con);
                SqlCommand command4 = new SqlCommand("select Hrs from AddSession where SessionID = '" + int.Parse(sessionID.Text) + "' ", con);
                SqlCommand command5 = new SqlCommand("select Min from AddSession where SessionID = '" + int.Parse(sessionID.Text) + "' ", con);
                SqlCommand command6 = new SqlCommand("select NoOfStudents from AddSession where SessionID = '" + int.Parse(sessionID.Text) + "' ", con);
                SqlCommand command7 = new SqlCommand("select Subject from AddSession where SessionID = '" + int.Parse(sessionID.Text) + "' ", con);
                SqlCommand command8 = new SqlCommand("select StudentGroup from AddSession where SessionID = '" + int.Parse(sessionID.Text) + "' ", con);


                String tag = command1.ExecuteScalar().ToString();
                String lecturer1 = command2.ExecuteScalar().ToString();
                String lecturer2 = command3.ExecuteScalar().ToString();
                String hrs = command4.ExecuteScalar().ToString();
                String min = command5.ExecuteScalar().ToString();
                String no_of_student = command6.ExecuteScalar().ToString();
                String subject = command7.ExecuteScalar().ToString();
                String student_group = command8.ExecuteScalar().ToString();


                selectTagcomboBox.Text = tag;
                selectLecturercomboBox1.Text = lecturer1;
                selectLecturercomboBox2.Text = lecturer2;
                addHour.Text = hrs;
                addMin.Text = min;
                noOfStudent.Text = no_of_student;
                selectSubjectComboBox.Text = subject;
                selectGroupComboBox.Text = student_group;


                con.Close();

            }
            else
            {
                MessageBox.Show("Enter the Employee ID");
            }
        }






        //Newly added into the system
        string lecturer_name = string.Empty;
        void setLectureComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select LecturerName from AddLecturer";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        lecturer_name = (read["LecturerName"].ToString());
                        selectLecturercomboBox1.Items.Add(lecturer_name);
                        selectLecturercomboBox2.Items.Add(lecturer_name);


                    }
                }
            }
            finally
            {
                con.Close();
            }
        }




        //Newly added into the system
        string tag_name = string.Empty;
        void setTagComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select TagName from AddTag";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        tag_name = (read["TagName"].ToString());
                        selectTagcomboBox.Items.Add(tag_name);

                    }
                }
            }
            finally
            {
                con.Close();
            }
        }






    }
}

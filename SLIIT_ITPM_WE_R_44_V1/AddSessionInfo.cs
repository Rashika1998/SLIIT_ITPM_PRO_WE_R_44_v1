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
    }
}

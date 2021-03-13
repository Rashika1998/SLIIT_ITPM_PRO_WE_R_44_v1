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
    public partial class AddStudentGroupInfo : Form
    {
        public AddStudentGroupInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        public void cleanInputFields()
        {
            studentGroupID.Text = "";
            yearComboBox.Text = "";
            semesterComboBox.Text = "";
            programComboBox.Text = "";
            groupNumber.Value = 0;
            subGroupNumber.Value = 0;
            groupID.Text = "";
            subGroupID.Text = "";
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddStudentGroup values ('" + int.Parse(studentGroupID.Text) + "' , '" + yearComboBox.Text + "' , '" + semesterComboBox.Text + "' , '" + programComboBox.Text + "' , '" + groupNumber.Text + "' , '" + subGroupNumber.Text + "' , '" + groupID.Text + "' , '" + subGroupID.Text + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            cleanInputFields();
            
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanInputFields();
        }


        private void AddStudentGroupInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update AddStudentGroup set AcademicYear = '" + yearComboBox.Text + "' , AcademicSemester = '" + semesterComboBox.Text + "' , Program = '" + programComboBox.Text + "' , GroupNo = '" + groupNumber.Text + "' , SubGroupNo = '" + subGroupNumber.Text + "' , GroupID = '" + groupID.Text + "' , SubGroupID = '" + subGroupID.Text + "' , UpdateDate = getdate() where StudentGroupID = '" + int.Parse(studentGroupID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            cleanInputFields();
            
        }

        private void generateIDs_Click(object sender, EventArgs e)
        {
            groupID.Text = yearComboBox.Text + "." + semesterComboBox.Text + "." + groupNumber.Value;
            subGroupID.Text = yearComboBox.Text + "." + semesterComboBox.Text + "." + groupNumber.Value + "." + subGroupNumber.Value;

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentGroupID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete this student group ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddStudentGroup where StudentGroupID = '" + int.Parse(studentGroupID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    cleanInputFields();
                    

                }

            }
            else
            {
                MessageBox.Show("Enter The Student Group ID here...!");
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AddStudentGroupInfoDisplay addStudentGroupInfoDisplay = new AddStudentGroupInfoDisplay();
            addStudentGroupInfoDisplay.ShowDialog();
        }

        private void toUpdate_Click(object sender, EventArgs e)
        {
            if (studentGroupID.Text != "")
            {
                con.Open();
                SqlCommand command1 = new SqlCommand("select AcademicYear from AddStudentGroup where StudentGroupID = '" + int.Parse(studentGroupID.Text) + "' ", con);
                SqlCommand command2 = new SqlCommand("select AcademicSemester from AddStudentGroup where StudentGroupID = '" + int.Parse(studentGroupID.Text) + "' ", con);
                SqlCommand command3 = new SqlCommand("select Program from AddStudentGroup where StudentGroupID = '" + int.Parse(studentGroupID.Text) + "' ", con);
                SqlCommand command4 = new SqlCommand("select GroupNo from AddStudentGroup where StudentGroupID = '" + int.Parse(studentGroupID.Text) + "' ", con);
                SqlCommand command5 = new SqlCommand("select SubGroupNo from AddStudentGroup where StudentGroupID = '" + int.Parse(studentGroupID.Text) + "' ", con);
                


                String academic_year = command1.ExecuteScalar().ToString();
                String academic_semester = command2.ExecuteScalar().ToString();
                String program = command3.ExecuteScalar().ToString();
                String group_no = command4.ExecuteScalar().ToString();
                String sub_group_no = command5.ExecuteScalar().ToString();


                yearComboBox.Text = academic_year;
                semesterComboBox.Text = academic_semester;
                programComboBox.Text = program;
                groupNumber.Value = int.Parse(group_no);
                subGroupNumber.Value = int.Parse(sub_group_no);


                con.Close();

            }
            else
            {
                MessageBox.Show("Enter the Student Group ID");
            }


        }
    }
}

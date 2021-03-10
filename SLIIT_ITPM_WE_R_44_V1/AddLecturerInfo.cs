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
    public partial class AddLecturerInfo : Form
    {
        public AddLecturerInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        public void cleanInputFields()
        {
            empID.Text = "";
            txtLecturerName.Text = "";
            facultyComboBox.Text = "";
            departmentComboBox.Text = "";
            centerComboBox.Text = "";
            buildingComboBox.Text = "";
            levelComboBox.Text = "";
            textRank.Text = "";

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void btnGenerateRank_Click(object sender, EventArgs e)
        {
            textRank.Text = levelComboBox.Text + "." + empID.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddLecturer values ('" + int.Parse(empID.Text) + "' , '" + txtLecturerName.Text + "' , '" + facultyComboBox.Text + "' , '" + departmentComboBox.Text + "' , '" + centerComboBox.Text + "', '" + buildingComboBox.Text + "', '" + levelComboBox.Text + "' , '" + textRank.Text + "', getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            cleanInputFields();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update AddLecturer set LecturerName = '" + txtLecturerName.Text + "' , Faculty = '" + facultyComboBox.Text + "' , Department = '" + departmentComboBox.Text + "' , Center = '" + centerComboBox.Text + "' , Building = '" + buildingComboBox.Text + "' , LecturerLevel = '" + levelComboBox.Text + "' , Rank = '" + textRank.Text + "' , UpdateDate = getdate() where EmpID = '" + int.Parse(empID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            cleanInputFields();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AddLecturerInfoDisplay addLecturerInfoDisplay = new AddLecturerInfoDisplay();
            addLecturerInfoDisplay.ShowDialog();
        }

        private void AddLecturerInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (empID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddLecturer where EmpID = '" + int.Parse(empID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");

                }

            }
            else
            {
                MessageBox.Show("Enter The Employee ID here...!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanInputFields();
        }
    }
}

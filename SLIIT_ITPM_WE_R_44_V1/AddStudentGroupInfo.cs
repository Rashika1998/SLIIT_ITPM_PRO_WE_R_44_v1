using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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



        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddStudentGroup values ('" + int.Parse(recordID.Text) + "' , '" + yearComboBox.Text + "' , '" + semesterComboBox.Text + "' , '" + programComboBox.Text + "' , '" + groupNumber.Text + "' , '" + subGroupNumber.Text + "' , '" + groupID.Text + "' , '" + subGroupID.Text + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();

            //Display data on gridview
            BindData();
        }



        //Bind data to a gridview
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddStudentGroup", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            addStudentGroupGridView.DataSource = dt;
            
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            recordID.Text = "";
            yearComboBox.Text = "";
            semesterComboBox.Text = "";
            programComboBox.Text = "";
            groupNumber.Value = 0;
            subGroupNumber.Value = 0;

        }


        private void AddStudentGroupInfo_Load(object sender, EventArgs e)
        {
            BindData();
            addStudentGroupGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update AddStudentGroup set AcademicYear = '" + yearComboBox.Text + "' , AcademicSemester = '" + semesterComboBox.Text + "' , Program = '" + programComboBox.Text + "' , GroupNo = '" + groupNumber.Text + "' , SubGroupNo = '" + subGroupNumber.Text + "' , GroupID = '" + groupID.Text + "' , SubGroupID = '" + subGroupID.Text + "' , UpdateDate = getdate() where RecordID = '" + int.Parse(recordID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");

            BindData();
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
            if (recordID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete this student group ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddStudentGroup where RecordID = '" + int.Parse(recordID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    BindData();

                }

            }
            else
            {
                MessageBox.Show("Enter the Record ID here...!");
            }

        }
    }
}

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
    public partial class AddTagInfo : Form
    {
        public AddTagInfo()
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
            recordID.Text = "";
            tagName.Text = "";
            tagCode.Text = "";
            relatedTagComboBox.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddTag values ('" + int.Parse(recordID.Text) + "' , '" + tagName.Text + "' , '" + tagCode.Text + "' , '" + relatedTagComboBox.Text + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            cleanInputFields();
            //Display data on gridview
            BindData();
        }


        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddTag", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            addTagGridView.DataSource = dt;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update AddTag set TagName = '" + tagName.Text + "' , TagCode = '" + tagCode.Text + "' , RelatedTag = '" + relatedTagComboBox.Text + "' , UpdateDate = getdate() where RecordID = '" + int.Parse(recordID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            cleanInputFields();
            BindData();
        }

        private void AddTagInfo_Load(object sender, EventArgs e)
        {
            addTagGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (recordID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddTag where RecordID = '" + int.Parse(recordID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    BindData();

                }


            }
            else
            {
                MessageBox.Show("Enter The Record ID here...!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanInputFields();
        }
    }
}

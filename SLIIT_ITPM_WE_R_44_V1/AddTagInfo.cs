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
            tagID.Text = "";
            tagName.Text = "";
            tagCode.Text = "";
            relatedTagComboBox.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddTag values ('" + int.Parse(tagID.Text) + "' , '" + tagName.Text + "' , '" + tagCode.Text + "' , '" + relatedTagComboBox.Text + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            cleanInputFields();

            
        }


        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update AddTag set TagName = '" + tagName.Text + "' , TagCode = '" + tagCode.Text + "' , RelatedTag = '" + relatedTagComboBox.Text + "' , UpdateDate = getdate() where TagID = '" + int.Parse(tagID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            cleanInputFields();
           
        }

        private void AddTagInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tagID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddTag where TagID = '" + int.Parse(tagID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    

                }


            }
            else
            {
                MessageBox.Show("Enter The Tag ID here...!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanInputFields();
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            tagCode.Text = tagID.Text + "." + tagName.Text;
        }

        private void toUpdate_Click(object sender, EventArgs e)
        {
            if(tagID.Text != "")
            {
                con.Open();
                SqlCommand command1 = new SqlCommand("select TagName from AddTag where TagID = '" + int.Parse(tagID.Text) + "' ", con);
                SqlCommand command2 = new SqlCommand("select TagCode from AddTag where TagID = '" + int.Parse(tagID.Text) + "' ", con);
                SqlCommand command3 = new SqlCommand("select RelatedTag from AddTag where TagID = '" + int.Parse(tagID.Text) + "' ", con);

                String tag_name = command1.ExecuteScalar().ToString();
                String tag_code = command2.ExecuteScalar().ToString();
                String related_tag = command3.ExecuteScalar().ToString();


                tagName.Text = tag_name;
                tagCode.Text = tag_code;
                relatedTagComboBox.Text = related_tag;

                con.Close();
            }
            else
            {
                MessageBox.Show("Enter the Tag ID");
            }
  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AddTagInfoDisplay addTagInfoDisplay = new AddTagInfoDisplay();
            addTagInfoDisplay.ShowDialog();
        }
    }
}

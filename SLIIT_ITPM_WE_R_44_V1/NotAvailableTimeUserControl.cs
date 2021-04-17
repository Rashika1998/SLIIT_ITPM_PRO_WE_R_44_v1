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
    public partial class NotAvailableTimeUserControl : UserControl
    {
        public NotAvailableTimeUserControl()
        {
            InitializeComponent();
        }

        private void NotAvailableTimeUserControl_Load(object sender, EventArgs e)
        {
            setLecturerNameComboBoxValues();
            setGroupComboBoxValues();
            setSubGroupComboBoxValues();
            setSessionIDComboBoxValues();
        }

        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");


        public void cleanInputFields()
        {
            allocationID.Text = "";
            selectLecturerComboBox.Text = "";
            selectGroupComboBox.Text = "";
            selectSubGroupComboBox.Text = "";
            selectSessionComboBox.Text = "";
            textTime.Text = "";
        }


        string select_lecturer = string.Empty;
        void setLecturerNameComboBoxValues()
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

                        select_lecturer = (read["LecturerName"].ToString());
                        selectLecturerComboBox.Items.Add(select_lecturer);

                    }
                }
            }
            finally
            {
                con.Close();
            }
        }




        string select_group = string.Empty;
        void setGroupComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select GroupID from AddStudentGroup";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        select_group = (read["GroupID"].ToString());
                        selectGroupComboBox.Items.Add(select_group);

                    }
                }
            }
            finally
            {
                con.Close();
            }
        }



        string select_sub_group = string.Empty;
        void setSubGroupComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select SubGroupID from AddStudentGroup";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        select_sub_group = (read["SubGroupID"].ToString());
                        selectSubGroupComboBox.Items.Add(select_sub_group);

                    }
                }
            }
            finally
            {
                con.Close();
            }
        }




        string session_id = string.Empty;
        void setSessionIDComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select SessionID from AddSession";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        session_id = (read["SessionID"].ToString());
                        selectSessionComboBox.Items.Add(session_id);

                    }
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddNotAvailableTime values ('" + int.Parse(allocationID.Text) + "' , '" + selectLecturerComboBox.Text + "' , '" + selectGroupComboBox.Text + "' , '" + selectSubGroupComboBox.Text + "' , '" + selectSessionComboBox.Text + "' , '" + textTime.Text + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            cleanInputFields();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DisplayNotAvailableTime displayNotAvailableTime = new DisplayNotAvailableTime();
            displayNotAvailableTime.ShowDialog();
        }
    }
}

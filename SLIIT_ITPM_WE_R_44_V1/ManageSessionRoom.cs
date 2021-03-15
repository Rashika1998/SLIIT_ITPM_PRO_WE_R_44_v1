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
    public partial class ManageSessionRoom : Form
    {
        public ManageSessionRoom()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        private void ManageSessionRoom_Load(object sender, EventArgs e)
        {
            setSessionComboBoxValues();
            setRoomComboBoxValues();


        }






        string sessionID = string.Empty;
        void setSessionComboBoxValues()
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

                        sessionID = (read["SessionID"].ToString());
                        selectSessionComboBox.Items.Add(sessionID);


                    }
                }
            }
            finally
            {
                con.Close();
            }



        }


        string roomID = string.Empty;
        void setRoomComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box

            string selectSql1 = "select LocationID from AddLocation";
            SqlCommand com1 = new SqlCommand(selectSql1, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com1.ExecuteReader())
                {
                    while (read.Read())
                    {

                        roomID = (read["LocationID"].ToString());
                        selectRoomComboBox.Items.Add(roomID);


                    }
                }
            }
            finally
            {
                con.Close();
            }

        }




        

        public void clearFormData()
        {
            sessionRoomID.Text = "";
            selectSessionComboBox.Text = "";
            selectRoomComboBox.Text = "";
            selectedSessions.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            clearFormData();

        }


        string s_tag, s_l1, s_l2, s_hrs, s_min, s_no_std, s_sub, s_grp = string.Empty;
        void showSelectedSessionDetails()
        {
            string selectSql1 = "select Tag , Lecturer1 , Lecturer2 , Hrs , Min , NoOfStudents , Subject , StudentGroup from AddSession where SessionID = '" + selectSessionComboBox.Text + "'";
            SqlCommand com1 = new SqlCommand(selectSql1, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com1.ExecuteReader())
                {
                    while (read.Read())
                    {


                        s_tag = (read["Tag"].ToString());
                        s_l1 = (read["Lecturer1"].ToString());
                        s_l2 = (read["Lecturer2"].ToString());
                        s_hrs = (read["Hrs"].ToString());
                        s_min = (read["Min"].ToString());
                        s_no_std = (read["NoOfStudents"].ToString());
                        s_sub = (read["Subject"].ToString());
                        s_grp = (read["StudentGroup"].ToString());


                    }


                    selectedSessions.Text = "Session ID: " + selectSessionComboBox.Text + "\n" + "Tag: " + s_tag + "\n" + "Lecturer 1: " + s_l1 + "\n" + "Lecturer 2" + s_l2 + "\n" + "Duration :" + s_hrs + "Hrs " + s_min + "min" + "\n" + "No Of Students: " + s_no_std + "\n" + "Subject :" + s_sub + "\n" + "Student Group: " + s_grp + "\n";

                }
            }
            finally
            {
                con.Close();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            showSelectedSessionDetails();

            con.Open();
            SqlCommand command = new SqlCommand("insert into ManageSessionRoom values ('" + int.Parse(sessionRoomID.Text) + "' , '" + selectSessionComboBox.Text + "' , '" + s_tag + "' , '" + s_l1 + "',  '" + s_l2 + "', '" + s_hrs + "Hrs" + s_min + "min" + "', '" + s_no_std + "', '" + s_sub + "', '" + s_grp + "', '" + selectRoomComboBox.Text + "', getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            clearFormData();

        }

        private void btnSelectedSession_Click(object sender, EventArgs e)
        {

            showSelectedSessionDetails();
            
        }

    }
}

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
    public partial class DisplayConsecutive_Parallel_NonOverlappingSessions : Form
    {
        public DisplayConsecutive_Parallel_NonOverlappingSessions()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        void BindDataConsecutiveSession()
        {
            SqlCommand command = new SqlCommand("select * from AddConsecutiveSession", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            consecutiveSessionsDataGridView.DataSource = dt;
        }

        void BindDataParallelSession()
        {
            SqlCommand command = new SqlCommand("select * from AddParallelSession", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            parallelSessionsDataGridView.DataSource = dt;
        }

        void BindDataNonOverlappingSession()
        {
            SqlCommand command = new SqlCommand("select * from AddNonOverlappingSession", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            nonOverlappingSessionDataGridView.DataSource = dt;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void DisplayConsecutive_Parallel_NonOverlappingSessions_Load(object sender, EventArgs e)
        {
            BindDataConsecutiveSession();
            BindDataParallelSession();
            BindDataNonOverlappingSession();
        }


        string s_tag, s_l1, s_l2, s_hrs, s_min, s_no_std, s_sub, s_grp = string.Empty;

        private void btnShowSessionDetails_Click(object sender, EventArgs e)
        {
            showSelectedSessionDetails();
        }

        void showSelectedSessionDetails()
        {
            string selectSql1 = "select Tag , Lecturer1 , Lecturer2 , Hrs , Min , NoOfStudents , Subject , StudentGroup from AddSession where SessionID = '" + textSessionID.Text + "'";
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


                    showSessionDetailsBox.Text = "Session ID: " + textSessionID.Text + "\n" + "Tag: " + s_tag + "\n" + "Lecturer 1: " + s_l1 + "\n" + "Lecturer 2" + s_l2 + "\n" + "Duration :" + s_hrs + "Hrs " + s_min + "min" + "\n" + "No Of Students: " + s_no_std + "\n" + "Subject :" + s_sub + "\n" + "Student Group: " + s_grp + "\n";

                }
            }
            finally
            {
                con.Close();
            }
        }


    }
}

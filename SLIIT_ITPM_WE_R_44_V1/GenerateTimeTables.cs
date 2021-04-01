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
    public partial class GenerateTimeTables : Form
    {
        public GenerateTimeTables()
        {
            InitializeComponent();
        }



        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");


        //Get session details 
        //check starting time of the session
        //check date that lecturer is working
        //use if else and a switch to addign values to lables
        private void GenerateTimeTables_Load(object sender, EventArgs e)
        {
            getSessionDetails();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            
        }


        public void getSessionDetails()
        {

            String getStartingTime;
            String getLecturers;
            String getSubject;
            String getStudentGroup;

            //Get session details : Program, Lecturer 1 & 2, starting and ending time, Room

            con.Open();
            SqlCommand command1 = new SqlCommand("select Lecturer1 , Lecturer2 from AddSession", con);
            SqlCommand command2 = new SqlCommand("select Lecturer2 from AddSession", con);
            SqlCommand command3 = new SqlCommand("select Hrs from AddSession", con);
            SqlCommand command4 = new SqlCommand("select Min from AddSession", con);
            SqlCommand command5 = new SqlCommand("select Subject from AddSession", con);
            SqlCommand command6 = new SqlCommand("select StudentGroup from AddSession", con);
            con.Close();


            try
            {
                con.Open();

                using (SqlDataReader read = command1.ExecuteReader())
                {
                    while (read.Read())
                    {

                        getLecturers = (read["Lecturer1"].ToString()) + " " + (read["Lecturer2"].ToString());
                        getStartingTime = (read["Hrs"].ToString());
                        getSubject = (read["Subject"].ToString());
                        getStudentGroup = (read["StudentGroup"].ToString());

                        

                        //MessageBox.Show("Lecturer 1: " + getLecturer1and2);
                        //lecturer_name = (read["LecturerName"].ToString());
                        //selectLecturercomboBox1.Items.Add(lecturer_name);
                        //selectLecturercomboBox2.Items.Add(lecturer_name);



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

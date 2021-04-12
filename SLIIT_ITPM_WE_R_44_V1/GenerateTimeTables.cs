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
            String getDay;
            String getRoom;
            String sessionDetails;

            //Get session details : Program, Lecturer 1 & 2, starting and ending time, Room

            con.Open();
            SqlCommand command1 = new SqlCommand("SELECT AddSession.Lecturer1 , AddSession.Lecturer2 , AddSession.Hrs , AddSession.Min , AddSession.Subject , AddSession.StudentGroup , ManageSessionRoom.SessionRoom FROM AddSession, ManageSessionRoom WHERE AddSession.SessionID = ManageSessionRoom.SessionID", con);
            
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
                        getDay = (read["Min"].ToString());
                        getRoom = (read["SessionRoom"].ToString());


                        sessionDetails = getLecturers + "\n" + getSubject + "-" + getStudentGroup + " " + getRoom;
                        //    Consider Min as Day
                        //    Consider Hrs as Starting Time

                        if (getDay == "Monday")
                        {
                            //Switch for each day 
                            //Check Starting time

                            switch (getStartingTime)
                            {
                                case "8.30":
                                    l1.Text = sessionDetails;
                                    break;

                                case "9.30":
                                    l2.Text = sessionDetails;
                                    break;

                                case "10.30":
                                    l3.Text = sessionDetails;
                                    break;

                                case "11.30":
                                    l4.Text = sessionDetails;
                                    break;

                                case "12.30":
                                    l5.Text = sessionDetails;
                                    break;

                                case "13.30":
                                    l6.Text = sessionDetails;
                                    break;

                                case "14.30":
                                    l7.Text = sessionDetails;
                                    break;

                                case "15.30":
                                    l8.Text = sessionDetails;
                                    break;

                                case "16.30":
                                    l9.Text = sessionDetails;
                                    break;

                                default:
                                    // code block
                                    break;
                            }


                        }
                        else if(getDay == "Tuesday")
                        {

                        }
                        else if(getDay == "Wednesday")
                        {

                        }
                        else if(getDay == "Thursday")
                        {
                            
                        }
                        else if(getDay == "Friday")
                        {

                        }
                        else if(getDay == "Saturday")
                        {

                        }
                        else if(getDay == "Sunday")
                        {

                        }
                        else
                        {
                            //No processes are running...!
                        } 



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

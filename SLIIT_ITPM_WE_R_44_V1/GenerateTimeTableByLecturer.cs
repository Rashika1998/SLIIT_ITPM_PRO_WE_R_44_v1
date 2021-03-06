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
    public partial class GenerateTimeTableByLecturer : Form
    {
        public GenerateTimeTableByLecturer()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");



        private void GenerateTimeTableByLecturer_Load(object sender, EventArgs e)
        {
            //getSessionDetails();
            setLecturerNameComboBoxValues();
        }

        //Newly added into the system
        public string lecturerName = string.Empty;
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

                        lecturerName = (read["LecturerName"].ToString());
                        selectLecturerComboBox.Items.Add(lecturerName);

                    }
                }
            }
            finally
            {
                con.Close();
            }
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
            SqlCommand command1 = new SqlCommand("SELECT AddSession.Lecturer1 , AddSession.Lecturer2 , AddSession.Hrs , AddSession.Min , AddSession.Subject , AddSession.StudentGroup , ManageSessionRoom.SessionRoom FROM AddSession, ManageSessionRoom WHERE AddSession.SessionID = ManageSessionRoom.SessionID and AddSession.Lecturer1 = " + lecturerName+"", con);

            
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
                        else if (getDay == "Tuesday")
                        {
                            switch (getStartingTime)
                            {
                                case "8.30":
                                    l10.Text = sessionDetails;
                                    break;

                                case "9.30":
                                    l11.Text = sessionDetails;
                                    break;

                                case "10.30":
                                    l12.Text = sessionDetails;
                                    break;

                                case "11.30":
                                    l13.Text = sessionDetails;
                                    break;

                                case "12.30":
                                    l14.Text = sessionDetails;
                                    break;

                                case "13.30":
                                    l15.Text = sessionDetails;
                                    break;

                                case "14.30":
                                    l16.Text = sessionDetails;
                                    break;

                                case "15.30":
                                    l17.Text = sessionDetails;
                                    break;

                                case "16.30":
                                    l18.Text = sessionDetails;
                                    break;

                                default:
                                    // code block
                                    break;
                            }
                        }
                        else if (getDay == "Wednesday")
                        {
                            switch (getStartingTime)
                            {
                                case "8.30":
                                    l19.Text = sessionDetails;
                                    break;

                                case "9.30":
                                    l20.Text = sessionDetails;
                                    break;

                                case "10.30":
                                    l21.Text = sessionDetails;
                                    break;

                                case "11.30":
                                    l22.Text = sessionDetails;
                                    break;

                                case "12.30":
                                    l23.Text = sessionDetails;
                                    break;

                                case "13.30":
                                    l24.Text = sessionDetails;
                                    break;

                                case "14.30":
                                    l25.Text = sessionDetails;
                                    break;

                                case "15.30":
                                    l26.Text = sessionDetails;
                                    break;

                                case "16.30":
                                    l27.Text = sessionDetails;
                                    break;

                                default:
                                    // code block
                                    break;
                            }
                        }
                        else if (getDay == "Thursday")
                        {
                            switch (getStartingTime)
                            {
                                case "8.30":
                                    l28.Text = sessionDetails;
                                    break;

                                case "9.30":
                                    l29.Text = sessionDetails;
                                    break;

                                case "10.30":
                                    l30.Text = sessionDetails;
                                    break;

                                case "11.30":
                                    l31.Text = sessionDetails;
                                    break;

                                case "12.30":
                                    l32.Text = sessionDetails;
                                    break;

                                case "13.30":
                                    l33.Text = sessionDetails;
                                    break;

                                case "14.30":
                                    l34.Text = sessionDetails;
                                    break;

                                case "15.30":
                                    l35.Text = sessionDetails;
                                    break;

                                case "16.30":
                                    l36.Text = sessionDetails;
                                    break;

                                default:
                                    // code block
                                    break;
                            }
                        }
                        else if (getDay == "Friday")
                        {
                            switch (getStartingTime)
                            {
                                case "8.30":
                                    l37.Text = sessionDetails;
                                    break;

                                case "9.30":
                                    l38.Text = sessionDetails;
                                    break;

                                case "10.30":
                                    l39.Text = sessionDetails;
                                    break;

                                case "11.30":
                                    l40.Text = sessionDetails;
                                    break;

                                case "12.30":
                                    l41.Text = sessionDetails;
                                    break;

                                case "13.30":
                                    l42.Text = sessionDetails;
                                    break;

                                case "14.30":
                                    l43.Text = sessionDetails;
                                    break;

                                case "15.30":
                                    l44.Text = sessionDetails;
                                    break;

                                case "16.30":
                                    l45.Text = sessionDetails;
                                    break;

                                default:
                                    // code block
                                    break;
                            }
                        }
                        else if (getDay == "Saturday")
                        {
                            switch (getStartingTime)
                            {
                                case "8.30":
                                    l46.Text = sessionDetails;
                                    break;

                                case "9.30":
                                    l47.Text = sessionDetails;
                                    break;

                                case "10.30":
                                    l48.Text = sessionDetails;
                                    break;

                                case "11.30":
                                    l49.Text = sessionDetails;
                                    break;

                                case "12.30":
                                    l50.Text = sessionDetails;
                                    break;

                                case "13.30":
                                    l51.Text = sessionDetails;
                                    break;

                                case "14.30":
                                    l52.Text = sessionDetails;
                                    break;

                                case "15.30":
                                    l53.Text = sessionDetails;
                                    break;

                                case "16.30":
                                    l54.Text = sessionDetails;
                                    break;

                                default:
                                    // code block
                                    break;
                            }
                        }
                        else if (getDay == "Sunday")
                        {
                            switch (getStartingTime)
                            {
                                case "8.30":
                                    l55.Text = sessionDetails;
                                    break;

                                case "9.30":
                                    l56.Text = sessionDetails;
                                    break;

                                case "10.30":
                                    l57.Text = sessionDetails;
                                    break;

                                case "11.30":
                                    l58.Text = sessionDetails;
                                    break;

                                case "12.30":
                                    l59.Text = sessionDetails;
                                    break;

                                case "13.30":
                                    l60.Text = sessionDetails;
                                    break;

                                case "14.30":
                                    l61.Text = sessionDetails;
                                    break;

                                case "15.30":
                                    l62.Text = sessionDetails;
                                    break;

                                case "16.30":
                                    l63.Text = sessionDetails;
                                    break;

                                default:
                                    // code block
                                    break;
                            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getSessionDetails();
        }
    }
}

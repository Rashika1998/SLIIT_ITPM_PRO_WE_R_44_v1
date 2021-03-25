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
    public partial class GuideLines : Form
    {
        public GuideLines()
        {
            InitializeComponent();
        }

        private void GuideLines_Load(object sender, EventArgs e)
        {
            getWorkingDaysRecordCount();
            getAddStudentGroupRecordCount();
            getAddLecturerRecordCount();
            getAddLocationRecordCount();
            getAddSubjectRecordCount();
        }



        //Add default details
        private void addWorkingDaysAndHours()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand command = new SqlCommand("insert into AddWorkingDaysAndHours values ('" + 111 + "' , '" + "7" + "' , '" + "monday" + "' , '" + "tuesday" + "' , '" + "wednesday" + "' , '" + "thursday" + "' , '" + "friday" + "' , '" + "saturday" + "' , '" + "sunday" + "' , '" + "12" + "' , '" + "00" + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            con.Close();

        }

        private void addStudentGroup()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand command = new SqlCommand("insert into AddStudentGroup values ('" + 100 + "' , '" + "Y1" + "' , '" + "S1" + "' , '" + "IT" + "' , '" + "1" + "' , '" + "2" + "' , '" + "Y1.1" + "' , '" + "Y1.1.2" + "', getdate() , getdate())", con);
            command.ExecuteNonQuery();
            con.Close();

        }

        private void addLecturer()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand command = new SqlCommand("insert into AddLecturer values ('" + 100 + "' , '" + "Rathnayaka R.M.R.M." + "' , '" + "Computing" + "' , '" + "IT" + "' , '" + "Malabe" + "', '" + "A502" + "', '" + "1" + "' , '" + "100.1" + "', getdate() , getdate())", con);
            command.ExecuteNonQuery();
            con.Close();

        }

        private void addLocation()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand command = new SqlCommand("insert into AddLocation values ('" + 1000 + "' , '" + "Computing" + "' , '" + "A502" + "' , '" + "120" + "' , '" + "Laboratory" + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            con.Close();

        }


        private void addSubject()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            con.Open();
            SqlCommand command = new SqlCommand("insert into AddSubject values ('" + 1000 + "' , '" + "Y1" + "' , '" + "S1" + "' , '" + "ITPM" + "' , '" + "Y1.S2.ITPM" + "' , '" + "2" + "' , '" + "1" + "' , '" + "1" + "' , '" + "2" + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            con.Close();

        }















        //Check row counts
        public void getWorkingDaysRecordCount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(RecordID) FROM AddWorkingDaysAndHours;", con);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                con.Close();


                if (count == 0)
                {
                    addWorkingDaysAndHours();
                }

                else
                {
                    //MessageBox.Show("welcome");
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }

            con.Close();
        }






        public void getAddStudentGroupRecordCount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(StudentGroupID) FROM AddStudentGroup;", con);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                con.Close();


                if (count == 0)
                {
                    addStudentGroup();
                }

                else
                {
                    //MessageBox.Show("welcome");
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }

            con.Close();
        }




        public void getAddLecturerRecordCount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(EmpID) FROM AddLecturer;", con);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                con.Close();


                if (count == 0)
                {
                    addLecturer();
                }

                else
                {
                    //MessageBox.Show("welcome");
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }

            con.Close();
        }





        public void getAddLocationRecordCount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(LocationID) FROM AddLocation;", con);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                con.Close();


                if (count == 0)
                {
                    addLocation();
                }

                else
                {
                    //MessageBox.Show("welcome");
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }

            con.Close();
        }




        public void getAddSubjectRecordCount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(SubjectID) FROM AddSubject;", con);
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                con.Close();


                if (count == 0)
                {
                    addSubject();
                }

                else
                {
                    //MessageBox.Show("welcome");
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }

            con.Close();
        }
    }
}

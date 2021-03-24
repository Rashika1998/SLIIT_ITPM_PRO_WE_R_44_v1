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
        }

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
                    MessageBox.Show("welcome");
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
                    MessageBox.Show("welcome");
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

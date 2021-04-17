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
    public partial class RoomsWithNotAvailableTimeUserControl : UserControl
    {
        public RoomsWithNotAvailableTimeUserControl()
        {
            InitializeComponent();
        }



        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");



        private void RoomsWithNotAvailableTimeUserControl_Load(object sender, EventArgs e)
        {
            setRoomComboBoxValues();
            setDayComboBoxValues();
            BindData();
        }



        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddNotAvailableTimeAndRoom", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            notAvailableRoomTimeDataGridView.DataSource = dt;

        }




        //Newly added into the system
        string select_room = string.Empty;
        void setRoomComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select RoomName from AddLocation";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        select_room = (read["RoomName"].ToString());
                        selectRoomNoComboBox.Items.Add(select_room);

                    }
                }
            }
            finally
            {
                con.Close();
            }
        }




        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO AddNotAvailableTimeAndRoom VALUES ('" + int.Parse(textAllocationID.Text) + "' , '" + selectRoomNoComboBox.Text + "' , '" + selectDayComboBox.Text + "' , '" + textStartTime.Text + "' , '" + textEndTime.Text + "', getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            cleanInputFields();
            BindData();
        }


        void cleanInputFields()
        {
            textAllocationID.Text = "";
            selectDayComboBox.Text = "";
            selectRoomNoComboBox.Text = "";
            textStartTime.Text = "";
            textEndTime.Text = "";
        }



        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE AddNotAvailableTimeAndRoom SET SelectRoom = '" + selectRoomNoComboBox.Text + "' , SelectDay = '" + selectDayComboBox.Text + "' , StartTime = '" + textStartTime.Text + "' , EndTime = '" + textEndTime.Text + "' , UpdateDate = getdate() where AllocationID = '" + int.Parse(textAllocationID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            cleanInputFields();
            BindData();
        }


        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textAllocationID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddNotAvailableTimeAndRoom where AllocationID = '" + int.Parse(textAllocationID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    cleanInputFields();
                    BindData();

                }

            }
            else
            {
                MessageBox.Show("Enter The Allocation ID here...!");
            }
        }

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanInputFields();
        }


        //Newly added into the system
        string day_monday, day_tuesday, day_wednesday, day_thursday, day_friday, day_saturday, day_sunday = string.Empty;

        private void btnUpdateFill_Click(object sender, EventArgs e)
        {
            setValuesComboBoxValues();
        }

        void setDayComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "SELECT Monday , Tuesday , Wednesday , Thursday , Friday , Saturday , Sunday from AddWorkingDaysAndHours WHERE RecordID = 100";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        day_monday = (read["Monday"].ToString());
                        day_tuesday = (read["Tuesday"].ToString());
                        day_wednesday = (read["Wednesday"].ToString());
                        day_thursday = (read["Thursday"].ToString());
                        day_friday = (read["Friday"].ToString());
                        day_saturday = (read["Saturday"].ToString());
                        day_sunday = (read["Sunday"].ToString());


                        if(day_monday == "Monday")
                        {
                            selectDayComboBox.Items.Add(day_monday);
                        }
                        if (day_tuesday == "Tuesday")
                        {
                            selectDayComboBox.Items.Add(day_tuesday);
                        }
                        if (day_wednesday == "Wednesday")
                        {
                            selectDayComboBox.Items.Add(day_wednesday);
                        }
                        if (day_thursday == "Thursday")
                        {
                            selectDayComboBox.Items.Add(day_thursday);
                        }
                        if (day_friday == "Friday")
                        {
                            selectDayComboBox.Items.Add(day_friday);
                        }
                        if (day_saturday == "Saturday")
                        {
                            selectDayComboBox.Items.Add(day_saturday);
                        }
                        if (day_sunday == "Sunday")
                        {
                            selectDayComboBox.Items.Add(day_sunday);
                        }


                    }
                }
            }
            finally
            {
                con.Close();
            }
        }



        //Newly added into the system
        string s_room , s_day , s_s_time , s_e_time = string.Empty;
        void setValuesComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select SelectRoom , SelectDay , StartTime , EndTime from AddNotAvailableTimeAndRoom WHERE AllocationID = '"+ textAllocationID.Text +"'";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        s_room = (read["SelectRoom"].ToString());
                        s_day = (read["SelectDay"].ToString());
                        s_s_time = (read["StartTime"].ToString());
                        s_e_time = (read["EndTime"].ToString());


                        selectRoomNoComboBox.Text = s_room;
                        selectDayComboBox.Text = s_day;
                        textStartTime.Text = s_s_time;
                        textEndTime.Text =  s_e_time;

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

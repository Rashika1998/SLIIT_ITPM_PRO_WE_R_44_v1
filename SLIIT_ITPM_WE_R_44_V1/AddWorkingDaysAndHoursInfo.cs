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
    public partial class AddWorkingDaysAndHoursInfo : Form
    {

        public string monday , tuesday , wednesday , thursday , friday , saturday , sunday;
        public int getOnlyReccordIDValue;

        private void thursdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (thursdayCheckBox.Checked)
            {
                thursday = "Thursday";
            }
            else
            {
                thursday = "not Working";
            }
        }

        private void fridayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fridayCheckBox.Checked)
            {
                friday = "Friday";
            }
            else
            {
                friday = "not Working";
            }
        }

        private void saturdayheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (saturdayheckBox.Checked)
            {
                saturday = "Saturday";
            }
            else
            {
                tuesday = "not Working";
            }
        }

        private void sundayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sundayCheckBox.Checked)
            {
                sunday = "Sunday";
            }
            else
            {
                sunday = "not Working";
            }
        }

        

        private void wednesdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wednesdayCheckBox.Checked)
            {
                wednesday = "Wednesday";
            }
            else
            {
                wednesday = "not Working";
            }
        }


        private void tuesdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tuesdayCheckBox.Checked)
            {
                tuesday = "Tuesday";
            }
            else
            {
                tuesday = "not Working";
            }
        }

        private void mondayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mondayCheckBox.Checked)
            {
                monday = "Monday";
            }
            else
            {
                monday = "not Working";
            }

        }

        private void AddWorkingDaysAndHoursInfo_Load(object sender, EventArgs e)
        {
            getWorkingDaysRecordCount();
            getRecordID();
            workingDaysGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        public AddWorkingDaysAndHoursInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddWorkingDaysAndHours values ('" + int.Parse(recordID.Text) + "' , '" + noOfWorkingDays.Text + "' , '" + monday + "' , '" + tuesday + "' , '" + wednesday + "' , '" + thursday + "' , '" + friday + "' , '" + saturday + "' , '" + sunday + "' , '" + addHrs.Text + "' , '" + addMin.Text + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();

            //Display data on gridview
            BindData();
            getWorkingDaysRecordCount();
        }


        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddWorkingDaysAndHours", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            workingDaysGridView.DataSource = dt;
            getWorkingDaysRecordCount();
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure to Delete All The Data ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("update AddWorkingDaysAndHours set NoOfWorkingDays = '' , Monday = '' , Tuesday = '' , Wednesday = '' , Thursday = '' , Friday = '' , Saturday = '' , Sunday = '' , Hrs = '' , Min = '' , UpdateDate = getdate() where RecordID = 100", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted All The Data..");
                BindData();
                getWorkingDaysRecordCount();
            }

        }


        public void getRecordID()
        {
            con.Open();
            SqlCommand commandGetRecordID = new SqlCommand("SELECT RecordID from AddWorkingDaysAndHours", con);
            getOnlyReccordIDValue = (int)commandGetRecordID.ExecuteScalar();
            con.Close();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //SqlCommand commandGetRecordID = new SqlCommand("SELECT RecordID from AddWorkingDaysAndHours", con);
            //String recordID = (String)command.ExecuteScalar();


            con.Open();
            SqlCommand command = new SqlCommand("update AddWorkingDaysAndHours set NoOfWorkingDays = '" + noOfWorkingDays.Text + "' , Monday = '" + monday + "' , Tuesday = '" + tuesday + "' , Wednesday = '" + wednesday + "' , Thursday = '" + thursday + "' , Friday = '" + friday + "' , Saturday = '" + saturday + "' , Sunday = '" + sunday + "' , Hrs = '" + addHrs.Text + "' , Min = '" + addMin.Text + "' , UpdateDate = getdate() where RecordID = '" + getOnlyReccordIDValue + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            BindData();
            getWorkingDaysRecordCount();
        }



        public void getWorkingDaysRecordCount()
        {

            con.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(RecordID) FROM AddWorkingDaysAndHours;", con);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            con.Close();


            if (count == 0)
            {
                btnSave.Enabled = true;
                recordID.Enabled = true;
            }
            else if(count == 1)
            {
                btnSave.Enabled = false;
                recordID.Enabled = false;

            }
            else
            {
                btnSave.Enabled = false;
                recordID.Enabled = false;
            }
            
            
            //textRegisteredSubject.Text = Convert.ToString(count.ToString());
            

        }

    }
}

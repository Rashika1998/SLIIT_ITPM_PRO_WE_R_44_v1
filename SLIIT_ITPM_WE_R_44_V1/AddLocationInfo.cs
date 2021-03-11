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
    public partial class AddLocationInfo : Form
    {

        public string roomType;


        public AddLocationInfo()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");



        public void cleanInputFields()
        {
            locationID.Text = "";
            buildingNameComboBox.Text = "";
            textRoomName.Text = "";
            capacityComboBox.Text = "";
            lectureHallRadioButton.Checked = false;
            laboratoryRadioButton.Checked = false;
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            AddLocationInfoDisplay addLocationInfoDisplay = new AddLocationInfoDisplay();
            addLocationInfoDisplay.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into AddLocation values ('" + int.Parse(locationID.Text) + "' , '" + buildingNameComboBox.Text + "' , '" + textRoomName.Text + "' , '" + capacityComboBox.Text + "' , '" + roomType + "' , getdate() , getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            cleanInputFields();
            con.Close();
        }

        private void lectureHallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Lecture Hall";
        }

        private void laboratoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Laboratory";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update AddLocation set BuildingName = '" + buildingNameComboBox.Text + "' , RoomName = '" + textRoomName.Text + "' , Capacity = '" + capacityComboBox.Text + "' , RoomType = '" + roomType + "' , UpdateDate = getdate() where LocationID = '" + int.Parse(locationID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            cleanInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (locationID.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete AddLocation where LocationID = '" + int.Parse(locationID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    cleanInputFields();

                }

            }
            else
            {
                MessageBox.Show("Enter The Location ID here...!");
            }
        }
    }
}

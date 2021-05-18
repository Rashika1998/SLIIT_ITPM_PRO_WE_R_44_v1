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


        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");



        


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

        private void toUpdate_Click(object sender, EventArgs e)
        {
            if (locationID.Text != "")
            {

                con.Open();
                SqlCommand command1 = new SqlCommand("select BuildingName from AddLocation where LocationID = '" + int.Parse(locationID.Text) + "' ", con);
                SqlCommand command2 = new SqlCommand("select RoomName from AddLocation where LocationID = '" + int.Parse(locationID.Text) + "' ", con);
                SqlCommand command3 = new SqlCommand("select Capacity from AddLocation where LocationID = '" + int.Parse(locationID.Text) + "' ", con);
                SqlCommand command4 = new SqlCommand("select RoomType from AddLocation where LocationID = '" + int.Parse(locationID.Text) + "' ", con);
                


                String building_name = command1.ExecuteScalar().ToString();
                String room_name = command2.ExecuteScalar().ToString();
                String capacity = command3.ExecuteScalar().ToString();
                String room_type = command4.ExecuteScalar().ToString();



                buildingNameComboBox.Text = building_name;
                textRoomName.Text = room_name;
                capacityComboBox.Text = capacity;
                

                if(room_type == "Lecture Hall")
                {
                    lectureHallRadioButton.Checked = true;
                }
                else
                {
                    laboratoryRadioButton.Checked = true;
                }


                con.Close();

            }
            else
            {
                MessageBox.Show("Enter the Tag ID");
            }
        }

        private void AddLocationInfo_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

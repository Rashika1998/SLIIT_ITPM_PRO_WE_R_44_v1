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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");

       
        private void btnSave_Click(object sender, EventArgs e)
        {
      
            con.Open();
            SqlCommand command = new SqlCommand("insert into ProductInfo_Tab values ('"+int.Parse(textBox1.Text)+ "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + comboBox1.Text + "' , getdate() , getdate())" , con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();

            //Display data on gridview
            BindData();

        }


        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from ProductInfo_Tab" , con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update ProductInfo_Tab set ItemName = '"+textBox2.Text+ "' , Design = '" + textBox3.Text + "' , Color = '" + comboBox1.Text + "' , UpdateDate = '"+DateTime.Parse(dateTimePicker1.Text) +"' where ProductID = '"+int.Parse(textBox1.Text)+"'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {

                if (MessageBox.Show("Are you sure to delete ..?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete ProductInfo_Tab where ProductID = '" + int.Parse(textBox1.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted.");
                    BindData();

                }

            }
            else
            {
                MessageBox.Show("Enter a product ID here...!");
            }


            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
           
        }
    }
}

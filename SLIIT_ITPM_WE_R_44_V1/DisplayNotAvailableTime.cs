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
    public partial class DisplayNotAvailableTime : Form
    {
        public DisplayNotAvailableTime()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SessionsAndNotAvailableTimeAllocations sessionsAndNotAvailableTimeAllocations = new SessionsAndNotAvailableTimeAllocations();
            sessionsAndNotAvailableTimeAllocations.ShowDialog();
        }

        private void DisplayNotAvailableTime_Load(object sender, EventArgs e)
        {
            allocationTimeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddNotAvailableTime", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            allocationTimeDataGridView.DataSource = dt;

        }

        void SearchBindData()
        {
            SqlCommand command = new SqlCommand("select * from AddNotAvailableTime where " + selectColumnComboBox.Text + " like '" + textSearchBox.Text + "%'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            allocationTimeDataGridView.DataSource = dt;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBindData();
        }
    }
}

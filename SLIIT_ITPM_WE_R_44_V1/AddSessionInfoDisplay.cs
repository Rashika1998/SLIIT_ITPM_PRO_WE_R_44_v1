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
    public partial class AddSessionInfoDisplay : Form
    {

        
        public AddSessionInfoDisplay()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        //Bind data to a gridview
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddSession", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            sessionDataGridView.DataSource = dt;

        }

        //Bind data to a gridview by searching
        void SearchBindData()
        {
            SqlCommand command = new SqlCommand("select * from AddSession where "+selectColumnComboBox.Text+" like '" +textSearchBox.Text+"%'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            sessionDataGridView.DataSource = dt;

        }


        private void sessionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddSessionInfoDisplay_Load(object sender, EventArgs e)
        {
            sessionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        private void btnAddNewSession_Click(object sender, EventArgs e)
        {
            AddSessionInfo addSessionInfo = new AddSessionInfo();
            addSessionInfo.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBindData();
        }
    }
}

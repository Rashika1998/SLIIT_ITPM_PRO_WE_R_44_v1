
namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class AddLocationInfoDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.addStudentGroupLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.locationDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.selectColumnComboBox = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.addStudentGroupLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 88);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(817, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Developed by WE_R_44";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(854, 26);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(110, 34);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // addStudentGroupLabel
            // 
            this.addStudentGroupLabel.AutoSize = true;
            this.addStudentGroupLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentGroupLabel.ForeColor = System.Drawing.Color.White;
            this.addStudentGroupLabel.Location = new System.Drawing.Point(12, 23);
            this.addStudentGroupLabel.Name = "addStudentGroupLabel";
            this.addStudentGroupLabel.Size = new System.Drawing.Size(258, 32);
            this.addStudentGroupLabel.TabIndex = 0;
            this.addStudentGroupLabel.Text = "Location Information";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.locationDataGridView);
            this.panel2.Location = new System.Drawing.Point(36, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 381);
            this.panel2.TabIndex = 27;
            // 
            // locationDataGridView
            // 
            this.locationDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.locationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationDataGridView.GridColor = System.Drawing.Color.White;
            this.locationDataGridView.Location = new System.Drawing.Point(17, 23);
            this.locationDataGridView.Name = "locationDataGridView";
            this.locationDataGridView.Size = new System.Drawing.Size(879, 337);
            this.locationDataGridView.TabIndex = 0;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddLocation.BackColor = System.Drawing.Color.Teal;
            this.btnAddLocation.FlatAppearance.BorderSize = 0;
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.ForeColor = System.Drawing.Color.White;
            this.btnAddLocation.Location = new System.Drawing.Point(53, 118);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(119, 44);
            this.btnAddLocation.TabIndex = 39;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = false;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // selectColumnComboBox
            // 
            this.selectColumnComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectColumnComboBox.FormattingEnabled = true;
            this.selectColumnComboBox.Items.AddRange(new object[] {
            "RoomType",
            "Capacity"});
            this.selectColumnComboBox.Location = new System.Drawing.Point(705, 133);
            this.selectColumnComboBox.Name = "selectColumnComboBox";
            this.selectColumnComboBox.Size = new System.Drawing.Size(146, 21);
            this.selectColumnComboBox.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(857, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearchBox
            // 
            this.textSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSearchBox.Location = new System.Drawing.Point(468, 133);
            this.textSearchBox.Multiline = true;
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(231, 21);
            this.textSearchBox.TabIndex = 40;
            // 
            // AddLocationInfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.selectColumnComboBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddLocationInfoDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLocationInfoDisplay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddLocationInfoDisplay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label addStudentGroupLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView locationDataGridView;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.ComboBox selectColumnComboBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearchBox;
    }
}

namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class AddStudentGroupInfoDisplay
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
            this.selectColumnComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddNewSession = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.studentGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.addSessionInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectColumnComboBox
            // 
            this.selectColumnComboBox.FormattingEnabled = true;
            this.selectColumnComboBox.Items.AddRange(new object[] {
            "AcademicYear",
            "AcademicSemester",
            "Program"});
            this.selectColumnComboBox.Location = new System.Drawing.Point(722, 157);
            this.selectColumnComboBox.Name = "selectColumnComboBox";
            this.selectColumnComboBox.Size = new System.Drawing.Size(146, 21);
            this.selectColumnComboBox.TabIndex = 13;
            // 
            // btnAddNewSession
            // 
            this.btnAddNewSession.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewSession.FlatAppearance.BorderSize = 0;
            this.btnAddNewSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSession.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSession.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSession.Location = new System.Drawing.Point(32, 146);
            this.btnAddNewSession.Name = "btnAddNewSession";
            this.btnAddNewSession.Size = new System.Drawing.Size(199, 34);
            this.btnAddNewSession.TabIndex = 12;
            this.btnAddNewSession.Text = "Add New Student Group";
            this.btnAddNewSession.UseVisualStyleBackColor = false;
            this.btnAddNewSession.Click += new System.EventHandler(this.btnAddNewSession_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(874, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearchBox
            // 
            this.textSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchBox.Location = new System.Drawing.Point(485, 157);
            this.textSearchBox.Multiline = true;
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(231, 21);
            this.textSearchBox.TabIndex = 10;
            // 
            // studentGroupDataGridView
            // 
            this.studentGroupDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGroupDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGroupDataGridView.GridColor = System.Drawing.Color.White;
            this.studentGroupDataGridView.Location = new System.Drawing.Point(32, 232);
            this.studentGroupDataGridView.Name = "studentGroupDataGridView";
            this.studentGroupDataGridView.Size = new System.Drawing.Size(917, 407);
            this.studentGroupDataGridView.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.addSessionInfoLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 88);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(812, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Developed by WE_R_44";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(845, 25);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(113, 34);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // addSessionInfoLabel
            // 
            this.addSessionInfoLabel.AutoSize = true;
            this.addSessionInfoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSessionInfoLabel.ForeColor = System.Drawing.Color.White;
            this.addSessionInfoLabel.Location = new System.Drawing.Point(12, 23);
            this.addSessionInfoLabel.Name = "addSessionInfoLabel";
            this.addSessionInfoLabel.Size = new System.Drawing.Size(394, 32);
            this.addSessionInfoLabel.TabIndex = 0;
            this.addSessionInfoLabel.Text = "Student Group Information Table";
            // 
            // AddStudentGroupInfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.selectColumnComboBox);
            this.Controls.Add(this.btnAddNewSession);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.studentGroupDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudentGroupInfoDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentGroupInfoDisplay";
            this.Load += new System.EventHandler(this.AddStudentGroupInfoDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectColumnComboBox;
        private System.Windows.Forms.Button btnAddNewSession;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearchBox;
        private System.Windows.Forms.DataGridView studentGroupDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label addSessionInfoLabel;
    }
}
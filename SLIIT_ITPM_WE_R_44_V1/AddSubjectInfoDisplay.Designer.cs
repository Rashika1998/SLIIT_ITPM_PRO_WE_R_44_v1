
namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class AddSubjectInfoDisplay
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
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addSubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.addStudentGroupLabel = new System.Windows.Forms.Label();
            this.selectColumnComboBox = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSubjectDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddSubject.FlatAppearance.BorderSize = 0;
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject.Location = new System.Drawing.Point(33, 113);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(136, 32);
            this.btnAddSubject.TabIndex = 30;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.addSubjectDataGridView);
            this.panel2.Location = new System.Drawing.Point(13, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 466);
            this.panel2.TabIndex = 29;
            // 
            // addSubjectDataGridView
            // 
            this.addSubjectDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.addSubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addSubjectDataGridView.GridColor = System.Drawing.Color.White;
            this.addSubjectDataGridView.Location = new System.Drawing.Point(20, 30);
            this.addSubjectDataGridView.Name = "addSubjectDataGridView";
            this.addSubjectDataGridView.Size = new System.Drawing.Size(921, 415);
            this.addSubjectDataGridView.TabIndex = 0;
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
            this.panel1.TabIndex = 28;
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
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // addStudentGroupLabel
            // 
            this.addStudentGroupLabel.AutoSize = true;
            this.addStudentGroupLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentGroupLabel.ForeColor = System.Drawing.Color.White;
            this.addStudentGroupLabel.Location = new System.Drawing.Point(12, 23);
            this.addStudentGroupLabel.Name = "addStudentGroupLabel";
            this.addStudentGroupLabel.Size = new System.Drawing.Size(389, 32);
            this.addStudentGroupLabel.TabIndex = 0;
            this.addStudentGroupLabel.Text = "Add Subject Information Display";
            // 
            // selectColumnComboBox
            // 
            this.selectColumnComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectColumnComboBox.FormattingEnabled = true;
            this.selectColumnComboBox.Items.AddRange(new object[] {
            "OfferedYear",
            "OfferedSemester"});
            this.selectColumnComboBox.Location = new System.Drawing.Point(723, 122);
            this.selectColumnComboBox.Name = "selectColumnComboBox";
            this.selectColumnComboBox.Size = new System.Drawing.Size(146, 21);
            this.selectColumnComboBox.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(875, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearchBox
            // 
            this.textSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSearchBox.Location = new System.Drawing.Point(486, 122);
            this.textSearchBox.Multiline = true;
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(231, 21);
            this.textSearchBox.TabIndex = 31;
            // 
            // AddSubjectInfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.selectColumnComboBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSubjectInfoDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubjectInfoDisplay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddSubjectInfoDisplay_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addSubjectDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView addSubjectDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label addStudentGroupLabel;
        private System.Windows.Forms.ComboBox selectColumnComboBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearchBox;
    }
}

namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class ManageSessionRoom
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewManagedSessions = new System.Windows.Forms.Button();
            this.btnSelectedSession = new System.Windows.Forms.Button();
            this.selectedSessions = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectRoomComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sessionRoomID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectSessionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.addStudentGroupLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnViewManagedSessions);
            this.panel2.Controls.Add(this.btnSelectedSession);
            this.panel2.Controls.Add(this.selectedSessions);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.selectRoomComboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.sessionRoomID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.selectSessionComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 468);
            this.panel2.TabIndex = 28;
            // 
            // btnViewManagedSessions
            // 
            this.btnViewManagedSessions.BackColor = System.Drawing.Color.Teal;
            this.btnViewManagedSessions.FlatAppearance.BorderSize = 0;
            this.btnViewManagedSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewManagedSessions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewManagedSessions.ForeColor = System.Drawing.Color.White;
            this.btnViewManagedSessions.Location = new System.Drawing.Point(116, 241);
            this.btnViewManagedSessions.Name = "btnViewManagedSessions";
            this.btnViewManagedSessions.Size = new System.Drawing.Size(362, 32);
            this.btnViewManagedSessions.TabIndex = 49;
            this.btnViewManagedSessions.Text = "View Sessions with Rooms";
            this.btnViewManagedSessions.UseVisualStyleBackColor = false;
            this.btnViewManagedSessions.Click += new System.EventHandler(this.btnViewManagedSessions_Click);
            // 
            // btnSelectedSession
            // 
            this.btnSelectedSession.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectedSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedSession.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSelectedSession.Location = new System.Drawing.Point(736, 250);
            this.btnSelectedSession.Name = "btnSelectedSession";
            this.btnSelectedSession.Size = new System.Drawing.Size(162, 23);
            this.btnSelectedSession.TabIndex = 48;
            this.btnSelectedSession.Text = "See Selected Session...?";
            this.btnSelectedSession.UseVisualStyleBackColor = true;
            this.btnSelectedSession.Click += new System.EventHandler(this.btnSelectedSession_Click);
            // 
            // selectedSessions
            // 
            this.selectedSessions.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.selectedSessions.Location = new System.Drawing.Point(684, 115);
            this.selectedSessions.Name = "selectedSessions";
            this.selectedSessions.Size = new System.Drawing.Size(214, 129);
            this.selectedSessions.TabIndex = 47;
            this.selectedSessions.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(545, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Selected Session";
            // 
            // selectRoomComboBox
            // 
            this.selectRoomComboBox.FormattingEnabled = true;
            this.selectRoomComboBox.Location = new System.Drawing.Point(265, 118);
            this.selectRoomComboBox.Name = "selectRoomComboBox";
            this.selectRoomComboBox.Size = new System.Drawing.Size(214, 21);
            this.selectRoomComboBox.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(261, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "ex : 1001";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(311, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 32);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(117, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 32);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(113, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Select Room";
            // 
            // sessionRoomID
            // 
            this.sessionRoomID.Location = new System.Drawing.Point(264, 53);
            this.sessionRoomID.Name = "sessionRoomID";
            this.sessionRoomID.Size = new System.Drawing.Size(214, 20);
            this.sessionRoomID.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(112, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Session Room ID";
            // 
            // selectSessionComboBox
            // 
            this.selectSessionComboBox.FormattingEnabled = true;
            this.selectSessionComboBox.Location = new System.Drawing.Point(674, 50);
            this.selectSessionComboBox.Name = "selectSessionComboBox";
            this.selectSessionComboBox.Size = new System.Drawing.Size(214, 21);
            this.selectSessionComboBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(544, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select Session";
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
            this.panel1.TabIndex = 27;
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
            this.addStudentGroupLabel.Size = new System.Drawing.Size(284, 32);
            this.addStudentGroupLabel.TabIndex = 0;
            this.addStudentGroupLabel.Text = "Manage Session Rooms";
            // 
            // ManageSessionRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSessionRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSessionRoom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageSessionRoom_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox selectedSessions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectRoomComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sessionRoomID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectSessionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label addStudentGroupLabel;
        private System.Windows.Forms.Button btnSelectedSession;
        private System.Windows.Forms.Button btnViewManagedSessions;
    }
}
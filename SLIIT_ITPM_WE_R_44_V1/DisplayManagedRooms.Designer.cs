
namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class DisplayManagedRooms
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
            this.userControlType = new System.Windows.Forms.Label();
            this.btnNotAvailableTimeAllocation = new System.Windows.Forms.Button();
            this.btnShowConsecutiveSession = new System.Windows.Forms.Button();
            this.btnShowSessionWithRoom = new System.Windows.Forms.Button();
            this.displayConsecutiveSessionWithRoom1 = new SLIIT_ITPM_WE_R_44_V1.DisplayConsecutiveSessionWithRoom();
            this.displaySessionsWithRooms1 = new SLIIT_ITPM_WE_R_44_V1.DisplaySessionsWithRooms();
            this.panel1.SuspendLayout();
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
            this.addStudentGroupLabel.Size = new System.Drawing.Size(338, 32);
            this.addStudentGroupLabel.TabIndex = 0;
            this.addStudentGroupLabel.Text = "Manage Session Rooms Info";
            // 
            // userControlType
            // 
            this.userControlType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userControlType.AutoSize = true;
            this.userControlType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlType.ForeColor = System.Drawing.Color.Gray;
            this.userControlType.Location = new System.Drawing.Point(416, 139);
            this.userControlType.Name = "userControlType";
            this.userControlType.Size = new System.Drawing.Size(138, 17);
            this.userControlType.TabIndex = 38;
            this.userControlType.Text = "Sessions With Rooms";
            // 
            // btnNotAvailableTimeAllocation
            // 
            this.btnNotAvailableTimeAllocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNotAvailableTimeAllocation.BackColor = System.Drawing.Color.DimGray;
            this.btnNotAvailableTimeAllocation.FlatAppearance.BorderSize = 0;
            this.btnNotAvailableTimeAllocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotAvailableTimeAllocation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAvailableTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.btnNotAvailableTimeAllocation.Location = new System.Drawing.Point(287, 94);
            this.btnNotAvailableTimeAllocation.Name = "btnNotAvailableTimeAllocation";
            this.btnNotAvailableTimeAllocation.Size = new System.Drawing.Size(163, 32);
            this.btnNotAvailableTimeAllocation.TabIndex = 37;
            this.btnNotAvailableTimeAllocation.Text = "Not Available Time";
            this.btnNotAvailableTimeAllocation.UseVisualStyleBackColor = false;
            // 
            // btnShowConsecutiveSession
            // 
            this.btnShowConsecutiveSession.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowConsecutiveSession.BackColor = System.Drawing.Color.DimGray;
            this.btnShowConsecutiveSession.FlatAppearance.BorderSize = 0;
            this.btnShowConsecutiveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConsecutiveSession.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowConsecutiveSession.ForeColor = System.Drawing.Color.White;
            this.btnShowConsecutiveSession.Location = new System.Drawing.Point(170, 94);
            this.btnShowConsecutiveSession.Name = "btnShowConsecutiveSession";
            this.btnShowConsecutiveSession.Size = new System.Drawing.Size(111, 32);
            this.btnShowConsecutiveSession.TabIndex = 36;
            this.btnShowConsecutiveSession.Text = "Consecutive";
            this.btnShowConsecutiveSession.UseVisualStyleBackColor = false;
            this.btnShowConsecutiveSession.Click += new System.EventHandler(this.btnShowConsecutiveSession_Click);
            // 
            // btnShowSessionWithRoom
            // 
            this.btnShowSessionWithRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowSessionWithRoom.BackColor = System.Drawing.Color.DimGray;
            this.btnShowSessionWithRoom.FlatAppearance.BorderSize = 0;
            this.btnShowSessionWithRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSessionWithRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSessionWithRoom.ForeColor = System.Drawing.Color.White;
            this.btnShowSessionWithRoom.Location = new System.Drawing.Point(52, 94);
            this.btnShowSessionWithRoom.Name = "btnShowSessionWithRoom";
            this.btnShowSessionWithRoom.Size = new System.Drawing.Size(112, 32);
            this.btnShowSessionWithRoom.TabIndex = 35;
            this.btnShowSessionWithRoom.Text = "Sessions";
            this.btnShowSessionWithRoom.UseVisualStyleBackColor = false;
            this.btnShowSessionWithRoom.Click += new System.EventHandler(this.btnShowSessionWithRoom_Click);
            // 
            // displayConsecutiveSessionWithRoom1
            // 
            this.displayConsecutiveSessionWithRoom1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.displayConsecutiveSessionWithRoom1.BackColor = System.Drawing.Color.White;
            this.displayConsecutiveSessionWithRoom1.Location = new System.Drawing.Point(35, 159);
            this.displayConsecutiveSessionWithRoom1.Name = "displayConsecutiveSessionWithRoom1";
            this.displayConsecutiveSessionWithRoom1.Size = new System.Drawing.Size(900, 490);
            this.displayConsecutiveSessionWithRoom1.TabIndex = 40;
            // 
            // displaySessionsWithRooms1
            // 
            this.displaySessionsWithRooms1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.displaySessionsWithRooms1.BackColor = System.Drawing.Color.White;
            this.displaySessionsWithRooms1.Location = new System.Drawing.Point(35, 159);
            this.displaySessionsWithRooms1.Name = "displaySessionsWithRooms1";
            this.displaySessionsWithRooms1.Size = new System.Drawing.Size(900, 490);
            this.displaySessionsWithRooms1.TabIndex = 39;
            // 
            // DisplayManagedRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.displayConsecutiveSessionWithRoom1);
            this.Controls.Add(this.displaySessionsWithRooms1);
            this.Controls.Add(this.userControlType);
            this.Controls.Add(this.btnNotAvailableTimeAllocation);
            this.Controls.Add(this.btnShowConsecutiveSession);
            this.Controls.Add(this.btnShowSessionWithRoom);
            this.Controls.Add(this.panel1);
            this.Name = "DisplayManagedRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayManagedRooms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisplayManagedRooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label addStudentGroupLabel;
        private System.Windows.Forms.Label userControlType;
        private System.Windows.Forms.Button btnNotAvailableTimeAllocation;
        private System.Windows.Forms.Button btnShowConsecutiveSession;
        private System.Windows.Forms.Button btnShowSessionWithRoom;
        private DisplaySessionsWithRooms displaySessionsWithRooms1;
        private DisplayConsecutiveSessionWithRoom displayConsecutiveSessionWithRoom1;
    }
}
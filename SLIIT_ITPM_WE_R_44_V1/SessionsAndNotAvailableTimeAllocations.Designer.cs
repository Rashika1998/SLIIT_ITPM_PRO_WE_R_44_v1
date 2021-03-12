
namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class SessionsAndNotAvailableTimeAllocations
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
            this.btnAddConsecutiveSession = new System.Windows.Forms.Button();
            this.btnParallel = new System.Windows.Forms.Button();
            this.btnNonOverlapping = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.parallelSessionUserControl1 = new SLIIT_ITPM_WE_R_44_V1.ParallelSessionUserControl();
            this.consecutiveSessionUserControl1 = new SLIIT_ITPM_WE_R_44_V1.ConsecutiveSessionUserControl();
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
            this.panel1.Size = new System.Drawing.Size(984, 87);
            this.panel1.TabIndex = 25;
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
            this.addStudentGroupLabel.Size = new System.Drawing.Size(513, 32);
            this.addStudentGroupLabel.TabIndex = 0;
            this.addStudentGroupLabel.Text = "Sessions And Not Available Time Allocation";
            // 
            // btnAddConsecutiveSession
            // 
            this.btnAddConsecutiveSession.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddConsecutiveSession.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddConsecutiveSession.FlatAppearance.BorderSize = 0;
            this.btnAddConsecutiveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConsecutiveSession.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConsecutiveSession.ForeColor = System.Drawing.Color.White;
            this.btnAddConsecutiveSession.Location = new System.Drawing.Point(95, 102);
            this.btnAddConsecutiveSession.Name = "btnAddConsecutiveSession";
            this.btnAddConsecutiveSession.Size = new System.Drawing.Size(173, 32);
            this.btnAddConsecutiveSession.TabIndex = 26;
            this.btnAddConsecutiveSession.Text = "Consecutive";
            this.btnAddConsecutiveSession.UseVisualStyleBackColor = false;
            this.btnAddConsecutiveSession.Click += new System.EventHandler(this.btnAddConsecutiveSession_Click);
            // 
            // btnParallel
            // 
            this.btnParallel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnParallel.BackColor = System.Drawing.Color.DarkGray;
            this.btnParallel.FlatAppearance.BorderSize = 0;
            this.btnParallel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParallel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParallel.ForeColor = System.Drawing.Color.White;
            this.btnParallel.Location = new System.Drawing.Point(289, 102);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(178, 32);
            this.btnParallel.TabIndex = 28;
            this.btnParallel.Text = "Parallel";
            this.btnParallel.UseVisualStyleBackColor = false;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // btnNonOverlapping
            // 
            this.btnNonOverlapping.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNonOverlapping.BackColor = System.Drawing.Color.DarkGray;
            this.btnNonOverlapping.FlatAppearance.BorderSize = 0;
            this.btnNonOverlapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonOverlapping.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonOverlapping.ForeColor = System.Drawing.Color.White;
            this.btnNonOverlapping.Location = new System.Drawing.Point(484, 102);
            this.btnNonOverlapping.Name = "btnNonOverlapping";
            this.btnNonOverlapping.Size = new System.Drawing.Size(191, 32);
            this.btnNonOverlapping.TabIndex = 29;
            this.btnNonOverlapping.Text = "Non Overlapping";
            this.btnNonOverlapping.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(691, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Not Available Time";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // parallelSessionUserControl1
            // 
            this.parallelSessionUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.parallelSessionUserControl1.BackColor = System.Drawing.Color.White;
            this.parallelSessionUserControl1.Location = new System.Drawing.Point(18, 149);
            this.parallelSessionUserControl1.Name = "parallelSessionUserControl1";
            this.parallelSessionUserControl1.Size = new System.Drawing.Size(946, 500);
            this.parallelSessionUserControl1.TabIndex = 32;
            // 
            // consecutiveSessionUserControl1
            // 
            this.consecutiveSessionUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.consecutiveSessionUserControl1.BackColor = System.Drawing.Color.White;
            this.consecutiveSessionUserControl1.Location = new System.Drawing.Point(18, 149);
            this.consecutiveSessionUserControl1.Name = "consecutiveSessionUserControl1";
            this.consecutiveSessionUserControl1.Size = new System.Drawing.Size(946, 500);
            this.consecutiveSessionUserControl1.TabIndex = 31;
            // 
            // SessionsAndNotAvailableTimeAllocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.parallelSessionUserControl1);
            this.Controls.Add(this.consecutiveSessionUserControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNonOverlapping);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.btnAddConsecutiveSession);
            this.Controls.Add(this.panel1);
            this.Name = "SessionsAndNotAvailableTimeAllocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SessionsAndNotAvailableTimeAllocations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SessionsAndNotAvailableTimeAllocations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label addStudentGroupLabel;
        private System.Windows.Forms.Button btnAddConsecutiveSession;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Button btnNonOverlapping;
        private System.Windows.Forms.Button button1;
        private ConsecutiveSessionUserControl consecutiveSessionUserControl1;
        private ParallelSessionUserControl parallelSessionUserControl1;
    }
}
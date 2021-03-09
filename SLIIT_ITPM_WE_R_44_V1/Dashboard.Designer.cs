
namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class Dashboard
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
            this.dashBoardPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addStudentGroup = new System.Windows.Forms.Button();
            this.btnSampleCrud = new System.Windows.Forms.Button();
            this.dashBoardPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashBoardPanel
            // 
            this.dashBoardPanel.BackColor = System.Drawing.Color.Teal;
            this.dashBoardPanel.Controls.Add(this.label1);
            this.dashBoardPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.Size = new System.Drawing.Size(984, 94);
            this.dashBoardPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Table Management Application";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addStudentGroup);
            this.panel1.Controls.Add(this.btnSampleCrud);
            this.panel1.Location = new System.Drawing.Point(34, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 541);
            this.panel1.TabIndex = 1;
            // 
            // addStudentGroup
            // 
            this.addStudentGroup.BackColor = System.Drawing.Color.Teal;
            this.addStudentGroup.FlatAppearance.BorderSize = 0;
            this.addStudentGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentGroup.ForeColor = System.Drawing.Color.White;
            this.addStudentGroup.Location = new System.Drawing.Point(16, 62);
            this.addStudentGroup.Name = "addStudentGroup";
            this.addStudentGroup.Size = new System.Drawing.Size(153, 34);
            this.addStudentGroup.TabIndex = 4;
            this.addStudentGroup.Text = "Add Student Group";
            this.addStudentGroup.UseVisualStyleBackColor = false;
            this.addStudentGroup.Click += new System.EventHandler(this.addStudentGroup_Click);
            // 
            // btnSampleCrud
            // 
            this.btnSampleCrud.BackColor = System.Drawing.Color.Teal;
            this.btnSampleCrud.FlatAppearance.BorderSize = 0;
            this.btnSampleCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSampleCrud.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSampleCrud.ForeColor = System.Drawing.Color.White;
            this.btnSampleCrud.Location = new System.Drawing.Point(16, 13);
            this.btnSampleCrud.Name = "btnSampleCrud";
            this.btnSampleCrud.Size = new System.Drawing.Size(153, 34);
            this.btnSampleCrud.TabIndex = 3;
            this.btnSampleCrud.Text = "Sample Crud Form";
            this.btnSampleCrud.UseVisualStyleBackColor = false;
            this.btnSampleCrud.Click += new System.EventHandler(this.btnSampleCrud_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashBoardPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.dashBoardPanel.ResumeLayout(false);
            this.dashBoardPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashBoardPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addStudentGroup;
        private System.Windows.Forms.Button btnSampleCrud;
    }
}
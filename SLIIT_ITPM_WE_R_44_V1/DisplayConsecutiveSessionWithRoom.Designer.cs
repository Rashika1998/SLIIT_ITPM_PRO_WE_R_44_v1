
namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class DisplayConsecutiveSessionWithRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.consecutiveSessionWithRoomGridView = new System.Windows.Forms.DataGridView();
            this.selectSubjectColumnComboBox = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consecutiveSessionWithRoomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(765, 423);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 30);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddRoom.BackColor = System.Drawing.Color.Green;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(653, 423);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(106, 30);
            this.btnAddRoom.TabIndex = 13;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // consecutiveSessionWithRoomGridView
            // 
            this.consecutiveSessionWithRoomGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.consecutiveSessionWithRoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consecutiveSessionWithRoomGridView.BackgroundColor = System.Drawing.Color.White;
            this.consecutiveSessionWithRoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consecutiveSessionWithRoomGridView.GridColor = System.Drawing.Color.White;
            this.consecutiveSessionWithRoomGridView.Location = new System.Drawing.Point(13, 86);
            this.consecutiveSessionWithRoomGridView.Name = "consecutiveSessionWithRoomGridView";
            this.consecutiveSessionWithRoomGridView.Size = new System.Drawing.Size(874, 318);
            this.consecutiveSessionWithRoomGridView.TabIndex = 12;
            // 
            // selectSubjectColumnComboBox
            // 
            this.selectSubjectColumnComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSubjectColumnComboBox.FormattingEnabled = true;
            this.selectSubjectColumnComboBox.Location = new System.Drawing.Point(658, 45);
            this.selectSubjectColumnComboBox.Name = "selectSubjectColumnComboBox";
            this.selectSubjectColumnComboBox.Size = new System.Drawing.Size(146, 21);
            this.selectSubjectColumnComboBox.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(810, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DisplayConsecutiveSessionWithRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.selectSubjectColumnComboBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.consecutiveSessionWithRoomGridView);
            this.Name = "DisplayConsecutiveSessionWithRoom";
            this.Size = new System.Drawing.Size(900, 474);
            this.Load += new System.EventHandler(this.DisplayConsecutiveSessionWithRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consecutiveSessionWithRoomGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridView consecutiveSessionWithRoomGridView;
        private System.Windows.Forms.ComboBox selectSubjectColumnComboBox;
        private System.Windows.Forms.Button btnSearch;
    }
}

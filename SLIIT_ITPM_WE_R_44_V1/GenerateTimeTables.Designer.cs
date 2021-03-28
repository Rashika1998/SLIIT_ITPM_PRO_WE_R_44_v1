
namespace SLIIT_ITPM_WE_R_44_V1
{
    partial class GenerateTimeTables
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
            this.tableLayoutPanelGenerateTimeTable = new System.Windows.Forms.TableLayoutPanel();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanelGenerateTimeTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGenerateTimeTable
            // 
            this.tableLayoutPanelGenerateTimeTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelGenerateTimeTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelGenerateTimeTable.ColumnCount = 7;
            this.tableLayoutPanelGenerateTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelGenerateTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelGenerateTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelGenerateTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelGenerateTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelGenerateTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelGenerateTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelGenerateTimeTable.Controls.Add(this.mondayLabel, 0, 0);
            this.tableLayoutPanelGenerateTimeTable.Location = new System.Drawing.Point(96, 116);
            this.tableLayoutPanelGenerateTimeTable.Name = "tableLayoutPanelGenerateTimeTable";
            this.tableLayoutPanelGenerateTimeTable.RowCount = 2;
            this.tableLayoutPanelGenerateTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGenerateTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGenerateTimeTable.Size = new System.Drawing.Size(784, 221);
            this.tableLayoutPanelGenerateTimeTable.TabIndex = 0;
            // 
            // mondayLabel
            // 
            this.mondayLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Location = new System.Drawing.Point(41, 1);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(29, 13);
            this.mondayLabel.TabIndex = 1;
            this.mondayLabel.Text = "label";
            // 
            // GenerateTimeTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanelGenerateTimeTable);
            this.Name = "GenerateTimeTables";
            this.Text = "GenerateTimeTables";
            this.Load += new System.EventHandler(this.GenerateTimeTables_Load);
            this.tableLayoutPanelGenerateTimeTable.ResumeLayout(false);
            this.tableLayoutPanelGenerateTimeTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGenerateTimeTable;
        private System.Windows.Forms.Label mondayLabel;
    }
}
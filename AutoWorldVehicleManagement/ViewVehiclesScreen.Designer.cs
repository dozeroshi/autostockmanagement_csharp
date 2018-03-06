namespace AutoWorldVehicleManagement
{
    partial class ViewVehiclesScreen
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
            this.SearchVehiclesInput = new System.Windows.Forms.TextBox();
            this.SearchAttrTypeBox = new System.Windows.Forms.ComboBox();
            this.SearchVehiclesBtn = new System.Windows.Forms.Button();
            this.SearchResultsLabel = new System.Windows.Forms.Label();
            this.SearchVehiclesResultsPanel = new System.Windows.Forms.Panel();
            this.SearchVehiclesResultTable = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchVehiclesResultsPanel.SuspendLayout();
            this.SearchVehiclesResultTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchVehiclesInput
            // 
            this.SearchVehiclesInput.Location = new System.Drawing.Point(106, 13);
            this.SearchVehiclesInput.Name = "SearchVehiclesInput";
            this.SearchVehiclesInput.Size = new System.Drawing.Size(335, 27);
            this.SearchVehiclesInput.TabIndex = 0;
            // 
            // SearchAttrTypeBox
            // 
            this.SearchAttrTypeBox.FormattingEnabled = true;
            this.SearchAttrTypeBox.Location = new System.Drawing.Point(494, 13);
            this.SearchAttrTypeBox.Name = "SearchAttrTypeBox";
            this.SearchAttrTypeBox.Size = new System.Drawing.Size(262, 26);
            this.SearchAttrTypeBox.TabIndex = 1;
            // 
            // SearchVehiclesBtn
            // 
            this.SearchVehiclesBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchVehiclesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchVehiclesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchVehiclesBtn.Location = new System.Drawing.Point(807, 13);
            this.SearchVehiclesBtn.Name = "SearchVehiclesBtn";
            this.SearchVehiclesBtn.Size = new System.Drawing.Size(195, 27);
            this.SearchVehiclesBtn.TabIndex = 2;
            this.SearchVehiclesBtn.Text = "Search";
            this.SearchVehiclesBtn.UseVisualStyleBackColor = false;
            this.SearchVehiclesBtn.Click += new System.EventHandler(this.SearchVehiclesBtn_Click);
            // 
            // SearchResultsLabel
            // 
            this.SearchResultsLabel.AutoSize = true;
            this.SearchResultsLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResultsLabel.Location = new System.Drawing.Point(13, 76);
            this.SearchResultsLabel.Name = "SearchResultsLabel";
            this.SearchResultsLabel.Size = new System.Drawing.Size(238, 32);
            this.SearchResultsLabel.TabIndex = 3;
            this.SearchResultsLabel.Text = "Search Results";
            // 
            // SearchVehiclesResultsPanel
            // 
            this.SearchVehiclesResultsPanel.AutoScroll = true;
            this.SearchVehiclesResultsPanel.Controls.Add(this.SearchVehiclesResultTable);
            this.SearchVehiclesResultsPanel.Location = new System.Drawing.Point(19, 177);
            this.SearchVehiclesResultsPanel.Name = "SearchVehiclesResultsPanel";
            this.SearchVehiclesResultsPanel.Size = new System.Drawing.Size(1079, 418);
            this.SearchVehiclesResultsPanel.TabIndex = 4;
            // 
            // SearchVehiclesResultTable
            // 
            this.SearchVehiclesResultTable.AutoScroll = true;
            this.SearchVehiclesResultTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.SearchVehiclesResultTable.ColumnCount = 3;
            this.SearchVehiclesResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SearchVehiclesResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.SearchVehiclesResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchVehiclesResultTable.Controls.Add(this.label3, 2, 0);
            this.SearchVehiclesResultTable.Controls.Add(this.label2, 1, 0);
            this.SearchVehiclesResultTable.Controls.Add(this.label1, 0, 0);
            this.SearchVehiclesResultTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchVehiclesResultTable.Location = new System.Drawing.Point(0, 0);
            this.SearchVehiclesResultTable.Name = "SearchVehiclesResultTable";
            this.SearchVehiclesResultTable.RowCount = 1;
            this.SearchVehiclesResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchVehiclesResultTable.Size = new System.Drawing.Size(1079, 418);
            this.SearchVehiclesResultTable.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(862, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 416);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(749, 416);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 416);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1079, 50);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(862, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 46);
            this.label4.TabIndex = 2;
            this.label4.Text = "Actions";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(749, 46);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "VID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search:";
            // 
            // ViewVehiclesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1130, 607);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SearchVehiclesResultsPanel);
            this.Controls.Add(this.SearchResultsLabel);
            this.Controls.Add(this.SearchVehiclesBtn);
            this.Controls.Add(this.SearchAttrTypeBox);
            this.Controls.Add(this.SearchVehiclesInput);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ViewVehiclesScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ViewVehiclesScreen";
            this.Load += new System.EventHandler(this.ViewVehiclesScreen_Load);
            this.SearchVehiclesResultsPanel.ResumeLayout(false);
            this.SearchVehiclesResultTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchVehiclesInput;
        private System.Windows.Forms.ComboBox SearchAttrTypeBox;
        private System.Windows.Forms.Button SearchVehiclesBtn;
        private System.Windows.Forms.Label SearchResultsLabel;
        private System.Windows.Forms.Panel SearchVehiclesResultsPanel;
        private System.Windows.Forms.TableLayoutPanel SearchVehiclesResultTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
namespace AutoWorldVehicleManagement
{
    partial class ViewSingleVehicleScreen
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
            this.AddVehicleRefreshPanel = new System.Windows.Forms.Panel();
            this.VehicleImageViewer = new System.Windows.Forms.PictureBox();
            this.EditVehicleSaveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleColourInput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.VehicleMakeLabel = new System.Windows.Forms.Label();
            this.VehicleModelLabel = new System.Windows.Forms.Label();
            this.VehicleColourLabel = new System.Windows.Forms.Label();
            this.VehiclePriceRangeLabel = new System.Windows.Forms.Label();
            this.VehicleKilometersLabel = new System.Windows.Forms.Label();
            this.VehicleSoldStatusLabel = new System.Windows.Forms.Label();
            this.VehicleSoldDateLabel = new System.Windows.Forms.Label();
            this.VehicleRatedLoadLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.VehicleIDLabel = new System.Windows.Forms.Label();
            this.AddVehicleRefreshPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleImageViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddVehicleRefreshPanel
            // 
            this.AddVehicleRefreshPanel.Controls.Add(this.VehicleImageViewer);
            this.AddVehicleRefreshPanel.Controls.Add(this.EditVehicleSaveBtn);
            this.AddVehicleRefreshPanel.Controls.Add(this.panel1);
            this.AddVehicleRefreshPanel.Controls.Add(this.label6);
            this.AddVehicleRefreshPanel.Location = new System.Drawing.Point(30, 25);
            this.AddVehicleRefreshPanel.Name = "AddVehicleRefreshPanel";
            this.AddVehicleRefreshPanel.Size = new System.Drawing.Size(1075, 560);
            this.AddVehicleRefreshPanel.TabIndex = 21;
            // 
            // VehicleImageViewer
            // 
            this.VehicleImageViewer.BackColor = System.Drawing.Color.LightCyan;
            this.VehicleImageViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VehicleImageViewer.Location = new System.Drawing.Point(535, 54);
            this.VehicleImageViewer.Name = "VehicleImageViewer";
            this.VehicleImageViewer.Size = new System.Drawing.Size(491, 444);
            this.VehicleImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VehicleImageViewer.TabIndex = 18;
            this.VehicleImageViewer.TabStop = false;
            // 
            // EditVehicleSaveBtn
            // 
            this.EditVehicleSaveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.EditVehicleSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditVehicleSaveBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.EditVehicleSaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditVehicleSaveBtn.Location = new System.Drawing.Point(842, 513);
            this.EditVehicleSaveBtn.Name = "EditVehicleSaveBtn";
            this.EditVehicleSaveBtn.Size = new System.Drawing.Size(184, 32);
            this.EditVehicleSaveBtn.TabIndex = 19;
            this.EditVehicleSaveBtn.Text = "Edit";
            this.EditVehicleSaveBtn.UseVisualStyleBackColor = false;
            this.EditVehicleSaveBtn.Click += new System.EventHandler(this.EditVehicleSaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.VehicleIDLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.VehicleRatedLoadLabel);
            this.panel1.Controls.Add(this.VehicleSoldDateLabel);
            this.panel1.Controls.Add(this.VehicleSoldStatusLabel);
            this.panel1.Controls.Add(this.VehicleKilometersLabel);
            this.panel1.Controls.Add(this.VehiclePriceRangeLabel);
            this.panel1.Controls.Add(this.VehicleColourLabel);
            this.panel1.Controls.Add(this.VehicleModelLabel);
            this.panel1.Controls.Add(this.VehicleMakeLabel);
            this.panel1.Controls.Add(this.VehicleTypeLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.VehicleColourInput);
            this.panel1.Location = new System.Drawing.Point(29, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 444);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(15, 390);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rated Load";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(15, 268);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kilometers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Make";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 226);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price Range";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleColourInput
            // 
            this.VehicleColourInput.BackColor = System.Drawing.Color.DarkSlateGray;
            this.VehicleColourInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehicleColourInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VehicleColourInput.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleColourInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleColourInput.Location = new System.Drawing.Point(15, 184);
            this.VehicleColourInput.Name = "VehicleColourInput";
            this.VehicleColourInput.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.VehicleColourInput.Size = new System.Drawing.Size(113, 24);
            this.VehicleColourInput.TabIndex = 6;
            this.VehicleColourInput.Text = "Colour";
            this.VehicleColourInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vehicle Details";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(15, 351);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sold Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(15, 310);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label9.Size = new System.Drawing.Size(113, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sold Status";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleTypeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeLabel.Location = new System.Drawing.Point(137, 62);
            this.VehicleTypeLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleTypeLabel.TabIndex = 15;
            // 
            // VehicleMakeLabel
            // 
            this.VehicleMakeLabel.AutoSize = true;
            this.VehicleMakeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleMakeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleMakeLabel.Location = new System.Drawing.Point(137, 102);
            this.VehicleMakeLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleMakeLabel.Name = "VehicleMakeLabel";
            this.VehicleMakeLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleMakeLabel.TabIndex = 16;
            // 
            // VehicleModelLabel
            // 
            this.VehicleModelLabel.AutoSize = true;
            this.VehicleModelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleModelLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleModelLabel.Location = new System.Drawing.Point(137, 142);
            this.VehicleModelLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleModelLabel.Name = "VehicleModelLabel";
            this.VehicleModelLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleModelLabel.TabIndex = 17;
            // 
            // VehicleColourLabel
            // 
            this.VehicleColourLabel.AutoSize = true;
            this.VehicleColourLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleColourLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleColourLabel.Location = new System.Drawing.Point(137, 184);
            this.VehicleColourLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleColourLabel.Name = "VehicleColourLabel";
            this.VehicleColourLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleColourLabel.TabIndex = 18;
            // 
            // VehiclePriceRangeLabel
            // 
            this.VehiclePriceRangeLabel.AutoSize = true;
            this.VehiclePriceRangeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehiclePriceRangeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiclePriceRangeLabel.Location = new System.Drawing.Point(137, 226);
            this.VehiclePriceRangeLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehiclePriceRangeLabel.Name = "VehiclePriceRangeLabel";
            this.VehiclePriceRangeLabel.Size = new System.Drawing.Size(260, 23);
            this.VehiclePriceRangeLabel.TabIndex = 19;
            // 
            // VehicleKilometersLabel
            // 
            this.VehicleKilometersLabel.AutoSize = true;
            this.VehicleKilometersLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleKilometersLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleKilometersLabel.Location = new System.Drawing.Point(137, 268);
            this.VehicleKilometersLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleKilometersLabel.Name = "VehicleKilometersLabel";
            this.VehicleKilometersLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleKilometersLabel.TabIndex = 20;
            // 
            // VehicleSoldStatusLabel
            // 
            this.VehicleSoldStatusLabel.AutoSize = true;
            this.VehicleSoldStatusLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleSoldStatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleSoldStatusLabel.Location = new System.Drawing.Point(137, 310);
            this.VehicleSoldStatusLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleSoldStatusLabel.Name = "VehicleSoldStatusLabel";
            this.VehicleSoldStatusLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleSoldStatusLabel.TabIndex = 21;
            // 
            // VehicleSoldDateLabel
            // 
            this.VehicleSoldDateLabel.AutoSize = true;
            this.VehicleSoldDateLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleSoldDateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleSoldDateLabel.Location = new System.Drawing.Point(137, 351);
            this.VehicleSoldDateLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleSoldDateLabel.Name = "VehicleSoldDateLabel";
            this.VehicleSoldDateLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleSoldDateLabel.TabIndex = 22;
            // 
            // VehicleRatedLoadLabel
            // 
            this.VehicleRatedLoadLabel.AutoSize = true;
            this.VehicleRatedLoadLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleRatedLoadLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleRatedLoadLabel.Location = new System.Drawing.Point(137, 391);
            this.VehicleRatedLoadLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleRatedLoadLabel.Name = "VehicleRatedLoadLabel";
            this.VehicleRatedLoadLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleRatedLoadLabel.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(15, 20);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label10.Size = new System.Drawing.Size(113, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Vehicle ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleIDLabel
            // 
            this.VehicleIDLabel.AutoSize = true;
            this.VehicleIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleIDLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleIDLabel.Location = new System.Drawing.Point(137, 20);
            this.VehicleIDLabel.MinimumSize = new System.Drawing.Size(260, 23);
            this.VehicleIDLabel.Name = "VehicleIDLabel";
            this.VehicleIDLabel.Size = new System.Drawing.Size(260, 23);
            this.VehicleIDLabel.TabIndex = 25;
            // 
            // ViewSingleVehicleScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.AddVehicleRefreshPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewSingleVehicleScreen";
            this.Text = "ViewSingleVehicleScreen";
            this.Load += new System.EventHandler(this.ViewSingleVehicleScreen_Load);
            this.AddVehicleRefreshPanel.ResumeLayout(false);
            this.AddVehicleRefreshPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleImageViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddVehicleRefreshPanel;
        private System.Windows.Forms.PictureBox VehicleImageViewer;
        private System.Windows.Forms.Button EditVehicleSaveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VehicleColourInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label VehicleRatedLoadLabel;
        private System.Windows.Forms.Label VehicleSoldDateLabel;
        private System.Windows.Forms.Label VehicleSoldStatusLabel;
        private System.Windows.Forms.Label VehicleKilometersLabel;
        private System.Windows.Forms.Label VehiclePriceRangeLabel;
        private System.Windows.Forms.Label VehicleColourLabel;
        private System.Windows.Forms.Label VehicleModelLabel;
        private System.Windows.Forms.Label VehicleMakeLabel;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label VehicleIDLabel;
        private System.Windows.Forms.Label label10;
    }
}
namespace AutoWorldVehicleManagement
{
    partial class EditVehicleScreen
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
            this.VehicleIDLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleColourInput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VehicleModelInput = new System.Windows.Forms.TextBox();
            this.VehicleMakeInput = new System.Windows.Forms.TextBox();
            this.VehicleColorInput = new System.Windows.Forms.TextBox();
            this.VehiclePriceRangeInput = new System.Windows.Forms.TextBox();
            this.VehicleKilometersInput = new System.Windows.Forms.TextBox();
            this.VehicleRatedLoadInput = new System.Windows.Forms.TextBox();
            this.VehicleTypeInput = new System.Windows.Forms.ComboBox();
            this.VehicleSoldStatusInput = new System.Windows.Forms.ComboBox();
            this.VehicleSoldDateInput = new System.Windows.Forms.DateTimePicker();
            this.EditVehicleCancelBtn = new System.Windows.Forms.Button();
            this.ChangeImageBtn = new System.Windows.Forms.Button();
            this.AddVehicleRefreshPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleImageViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddVehicleRefreshPanel
            // 
            this.AddVehicleRefreshPanel.Controls.Add(this.ChangeImageBtn);
            this.AddVehicleRefreshPanel.Controls.Add(this.EditVehicleCancelBtn);
            this.AddVehicleRefreshPanel.Controls.Add(this.VehicleImageViewer);
            this.AddVehicleRefreshPanel.Controls.Add(this.EditVehicleSaveBtn);
            this.AddVehicleRefreshPanel.Controls.Add(this.panel1);
            this.AddVehicleRefreshPanel.Controls.Add(this.label6);
            this.AddVehicleRefreshPanel.Location = new System.Drawing.Point(30, 25);
            this.AddVehicleRefreshPanel.Name = "AddVehicleRefreshPanel";
            this.AddVehicleRefreshPanel.Size = new System.Drawing.Size(1075, 560);
            this.AddVehicleRefreshPanel.TabIndex = 22;
            // 
            // VehicleImageViewer
            // 
            this.VehicleImageViewer.BackColor = System.Drawing.SystemColors.Info;
            this.VehicleImageViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VehicleImageViewer.Location = new System.Drawing.Point(535, 54);
            this.VehicleImageViewer.Name = "VehicleImageViewer";
            this.VehicleImageViewer.Size = new System.Drawing.Size(491, 395);
            this.VehicleImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.EditVehicleSaveBtn.Text = "Save";
            this.EditVehicleSaveBtn.UseVisualStyleBackColor = false;
            this.EditVehicleSaveBtn.Click += new System.EventHandler(this.EditVehicleSaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.VehicleSoldDateInput);
            this.panel1.Controls.Add(this.VehicleSoldStatusInput);
            this.panel1.Controls.Add(this.VehicleTypeInput);
            this.panel1.Controls.Add(this.VehicleRatedLoadInput);
            this.panel1.Controls.Add(this.VehicleKilometersInput);
            this.panel1.Controls.Add(this.VehiclePriceRangeInput);
            this.panel1.Controls.Add(this.VehicleColorInput);
            this.panel1.Controls.Add(this.VehicleMakeInput);
            this.panel1.Controls.Add(this.VehicleModelInput);
            this.panel1.Controls.Add(this.VehicleIDLabel);
            this.panel1.Controls.Add(this.label10);
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
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.VehicleColourInput.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            // VehicleModelInput
            // 
            this.VehicleModelInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleModelInput.Location = new System.Drawing.Point(135, 145);
            this.VehicleModelInput.Name = "VehicleModelInput";
            this.VehicleModelInput.Size = new System.Drawing.Size(260, 22);
            this.VehicleModelInput.TabIndex = 26;
            // 
            // VehicleMakeInput
            // 
            this.VehicleMakeInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleMakeInput.Location = new System.Drawing.Point(137, 104);
            this.VehicleMakeInput.Name = "VehicleMakeInput";
            this.VehicleMakeInput.Size = new System.Drawing.Size(260, 22);
            this.VehicleMakeInput.TabIndex = 27;
            // 
            // VehicleColorInput
            // 
            this.VehicleColorInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleColorInput.Location = new System.Drawing.Point(134, 187);
            this.VehicleColorInput.Name = "VehicleColorInput";
            this.VehicleColorInput.Size = new System.Drawing.Size(260, 22);
            this.VehicleColorInput.TabIndex = 28;
            // 
            // VehiclePriceRangeInput
            // 
            this.VehiclePriceRangeInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehiclePriceRangeInput.Location = new System.Drawing.Point(134, 228);
            this.VehiclePriceRangeInput.Name = "VehiclePriceRangeInput";
            this.VehiclePriceRangeInput.Size = new System.Drawing.Size(260, 22);
            this.VehiclePriceRangeInput.TabIndex = 29;
            // 
            // VehicleKilometersInput
            // 
            this.VehicleKilometersInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleKilometersInput.Location = new System.Drawing.Point(134, 270);
            this.VehicleKilometersInput.Name = "VehicleKilometersInput";
            this.VehicleKilometersInput.Size = new System.Drawing.Size(260, 22);
            this.VehicleKilometersInput.TabIndex = 30;
            // 
            // VehicleRatedLoadInput
            // 
            this.VehicleRatedLoadInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleRatedLoadInput.Location = new System.Drawing.Point(134, 392);
            this.VehicleRatedLoadInput.Name = "VehicleRatedLoadInput";
            this.VehicleRatedLoadInput.Size = new System.Drawing.Size(260, 22);
            this.VehicleRatedLoadInput.TabIndex = 31;
            // 
            // VehicleTypeInput
            // 
            this.VehicleTypeInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleTypeInput.FormattingEnabled = true;
            this.VehicleTypeInput.Items.AddRange(new object[] {
            "Car",
            "Light Truck"});
            this.VehicleTypeInput.Location = new System.Drawing.Point(137, 65);
            this.VehicleTypeInput.Name = "VehicleTypeInput";
            this.VehicleTypeInput.Size = new System.Drawing.Size(260, 22);
            this.VehicleTypeInput.TabIndex = 32;
            // 
            // VehicleSoldStatusInput
            // 
            this.VehicleSoldStatusInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleSoldStatusInput.FormattingEnabled = true;
            this.VehicleSoldStatusInput.Items.AddRange(new object[] {
            "False",
            "True"});
            this.VehicleSoldStatusInput.Location = new System.Drawing.Point(134, 312);
            this.VehicleSoldStatusInput.Name = "VehicleSoldStatusInput";
            this.VehicleSoldStatusInput.Size = new System.Drawing.Size(260, 22);
            this.VehicleSoldStatusInput.TabIndex = 33;
            // 
            // VehicleSoldDateInput
            // 
            this.VehicleSoldDateInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleSoldDateInput.Location = new System.Drawing.Point(134, 351);
            this.VehicleSoldDateInput.Name = "VehicleSoldDateInput";
            this.VehicleSoldDateInput.Size = new System.Drawing.Size(260, 22);
            this.VehicleSoldDateInput.TabIndex = 34;
            // 
            // EditVehicleCancelBtn
            // 
            this.EditVehicleCancelBtn.BackColor = System.Drawing.Color.Red;
            this.EditVehicleCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditVehicleCancelBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.EditVehicleCancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditVehicleCancelBtn.Location = new System.Drawing.Point(634, 513);
            this.EditVehicleCancelBtn.Name = "EditVehicleCancelBtn";
            this.EditVehicleCancelBtn.Size = new System.Drawing.Size(184, 32);
            this.EditVehicleCancelBtn.TabIndex = 20;
            this.EditVehicleCancelBtn.Text = "Cancel";
            this.EditVehicleCancelBtn.UseVisualStyleBackColor = false;
            this.EditVehicleCancelBtn.Click += new System.EventHandler(this.EditVehicleCancelBtn_Click);
            // 
            // ChangeImageBtn
            // 
            this.ChangeImageBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChangeImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeImageBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.ChangeImageBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeImageBtn.Location = new System.Drawing.Point(882, 455);
            this.ChangeImageBtn.Name = "ChangeImageBtn";
            this.ChangeImageBtn.Size = new System.Drawing.Size(144, 27);
            this.ChangeImageBtn.TabIndex = 21;
            this.ChangeImageBtn.Text = "Change Image";
            this.ChangeImageBtn.UseVisualStyleBackColor = false;
            this.ChangeImageBtn.Click += new System.EventHandler(this.ChangeImageBtn_Click);
            // 
            // EditVehicleScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.AddVehicleRefreshPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditVehicleScreen";
            this.Text = "EditVehicleScreen";
            this.Load += new System.EventHandler(this.EditVehicleScreen_Load);
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
        private System.Windows.Forms.TextBox VehicleRatedLoadInput;
        private System.Windows.Forms.TextBox VehicleKilometersInput;
        private System.Windows.Forms.TextBox VehiclePriceRangeInput;
        private System.Windows.Forms.TextBox VehicleColorInput;
        private System.Windows.Forms.TextBox VehicleMakeInput;
        private System.Windows.Forms.TextBox VehicleModelInput;
        private System.Windows.Forms.Label VehicleIDLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VehicleColourInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditVehicleCancelBtn;
        private System.Windows.Forms.DateTimePicker VehicleSoldDateInput;
        private System.Windows.Forms.ComboBox VehicleSoldStatusInput;
        private System.Windows.Forms.ComboBox VehicleTypeInput;
        private System.Windows.Forms.Button ChangeImageBtn;
    }
}
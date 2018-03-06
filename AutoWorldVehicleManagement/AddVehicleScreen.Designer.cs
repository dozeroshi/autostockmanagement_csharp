namespace AutoWorldVehicleManagement
{
    partial class AddVehicleScreen
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
            this.VehicleTypeSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VehicleMakeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleModelInput = new System.Windows.Forms.TextBox();
            this.VehicleColourInput = new System.Windows.Forms.Label();
            this.VehicleColorInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VehiclePriceRangeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VehicleKilometersInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VehicleRatedLoadInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UploadImageBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PreviewImageUpload = new System.Windows.Forms.PictureBox();
            this.AddVehicleSaveBtn = new System.Windows.Forms.Button();
            this.AddVehicleRefreshPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImageUpload)).BeginInit();
            this.AddVehicleRefreshPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleTypeSelector
            // 
            this.VehicleTypeSelector.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeSelector.FormattingEnabled = true;
            this.VehicleTypeSelector.Items.AddRange(new object[] {
            "Car",
            "Light Truck"});
            this.VehicleTypeSelector.Location = new System.Drawing.Point(152, 35);
            this.VehicleTypeSelector.Name = "VehicleTypeSelector";
            this.VehicleTypeSelector.Size = new System.Drawing.Size(250, 26);
            this.VehicleTypeSelector.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Make";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleMakeInput
            // 
            this.VehicleMakeInput.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleMakeInput.Location = new System.Drawing.Point(152, 75);
            this.VehicleMakeInput.Name = "VehicleMakeInput";
            this.VehicleMakeInput.Size = new System.Drawing.Size(250, 25);
            this.VehicleMakeInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleModelInput
            // 
            this.VehicleModelInput.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleModelInput.Location = new System.Drawing.Point(152, 116);
            this.VehicleModelInput.Name = "VehicleModelInput";
            this.VehicleModelInput.Size = new System.Drawing.Size(250, 25);
            this.VehicleModelInput.TabIndex = 5;
            // 
            // VehicleColourInput
            // 
            this.VehicleColourInput.BackColor = System.Drawing.Color.DarkSlateGray;
            this.VehicleColourInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehicleColourInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VehicleColourInput.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleColourInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VehicleColourInput.Location = new System.Drawing.Point(13, 157);
            this.VehicleColourInput.Name = "VehicleColourInput";
            this.VehicleColourInput.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.VehicleColourInput.Size = new System.Drawing.Size(113, 24);
            this.VehicleColourInput.TabIndex = 6;
            this.VehicleColourInput.Text = "Colour";
            this.VehicleColourInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleColorInput
            // 
            this.VehicleColorInput.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleColorInput.Location = new System.Drawing.Point(152, 156);
            this.VehicleColorInput.Name = "VehicleColorInput";
            this.VehicleColorInput.Size = new System.Drawing.Size(250, 25);
            this.VehicleColorInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price Range";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehiclePriceRangeInput
            // 
            this.VehiclePriceRangeInput.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehiclePriceRangeInput.Location = new System.Drawing.Point(152, 200);
            this.VehiclePriceRangeInput.Name = "VehiclePriceRangeInput";
            this.VehiclePriceRangeInput.Size = new System.Drawing.Size(250, 25);
            this.VehiclePriceRangeInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 241);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kilometers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleKilometersInput
            // 
            this.VehicleKilometersInput.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleKilometersInput.Location = new System.Drawing.Point(152, 240);
            this.VehicleKilometersInput.Name = "VehicleKilometersInput";
            this.VehicleKilometersInput.Size = new System.Drawing.Size(250, 25);
            this.VehicleKilometersInput.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.VehicleRatedLoadInput);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VehicleKilometersInput);
            this.panel1.Controls.Add(this.VehicleTypeSelector);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.VehiclePriceRangeInput);
            this.panel1.Controls.Add(this.VehicleMakeInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.VehicleColorInput);
            this.panel1.Controls.Add(this.VehicleModelInput);
            this.panel1.Controls.Add(this.VehicleColourInput);
            this.panel1.Location = new System.Drawing.Point(29, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 336);
            this.panel1.TabIndex = 12;
            // 
            // VehicleRatedLoadInput
            // 
            this.VehicleRatedLoadInput.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleRatedLoadInput.Location = new System.Drawing.Point(152, 279);
            this.VehicleRatedLoadInput.Name = "VehicleRatedLoadInput";
            this.VehicleRatedLoadInput.Size = new System.Drawing.Size(250, 25);
            this.VehicleRatedLoadInput.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(13, 279);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rated Load";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "*All fields are required. Rated load for Light Trucks only";
            // 
            // UploadImageBtn
            // 
            this.UploadImageBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UploadImageBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.UploadImageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.UploadImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadImageBtn.Font = new System.Drawing.Font("Verdana", 10F);
            this.UploadImageBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadImageBtn.Location = new System.Drawing.Point(891, 396);
            this.UploadImageBtn.Name = "UploadImageBtn";
            this.UploadImageBtn.Size = new System.Drawing.Size(135, 32);
            this.UploadImageBtn.TabIndex = 17;
            this.UploadImageBtn.Text = "Upload Image";
            this.UploadImageBtn.UseVisualStyleBackColor = false;
            this.UploadImageBtn.Click += new System.EventHandler(this.UploadImageBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PreviewImageUpload
            // 
            this.PreviewImageUpload.BackColor = System.Drawing.Color.LightCyan;
            this.PreviewImageUpload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreviewImageUpload.Location = new System.Drawing.Point(535, 54);
            this.PreviewImageUpload.Name = "PreviewImageUpload";
            this.PreviewImageUpload.Size = new System.Drawing.Size(491, 336);
            this.PreviewImageUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewImageUpload.TabIndex = 18;
            this.PreviewImageUpload.TabStop = false;
            // 
            // AddVehicleSaveBtn
            // 
            this.AddVehicleSaveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddVehicleSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddVehicleSaveBtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.AddVehicleSaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddVehicleSaveBtn.Location = new System.Drawing.Point(842, 504);
            this.AddVehicleSaveBtn.Name = "AddVehicleSaveBtn";
            this.AddVehicleSaveBtn.Size = new System.Drawing.Size(184, 32);
            this.AddVehicleSaveBtn.TabIndex = 19;
            this.AddVehicleSaveBtn.Text = "Save";
            this.AddVehicleSaveBtn.UseVisualStyleBackColor = false;
            this.AddVehicleSaveBtn.Click += new System.EventHandler(this.SaveAddVehicleBtn_Click);
            // 
            // AddVehicleRefreshPanel
            // 
            this.AddVehicleRefreshPanel.Controls.Add(this.PreviewImageUpload);
            this.AddVehicleRefreshPanel.Controls.Add(this.AddVehicleSaveBtn);
            this.AddVehicleRefreshPanel.Controls.Add(this.label7);
            this.AddVehicleRefreshPanel.Controls.Add(this.panel1);
            this.AddVehicleRefreshPanel.Controls.Add(this.UploadImageBtn);
            this.AddVehicleRefreshPanel.Controls.Add(this.label6);
            this.AddVehicleRefreshPanel.Location = new System.Drawing.Point(22, 12);
            this.AddVehicleRefreshPanel.Name = "AddVehicleRefreshPanel";
            this.AddVehicleRefreshPanel.Size = new System.Drawing.Size(1075, 560);
            this.AddVehicleRefreshPanel.TabIndex = 20;
            // 
            // AddVehicleScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.AddVehicleRefreshPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddVehicleScreen";
            this.Text = "AddVehicleScreen";
            this.Load += new System.EventHandler(this.AddVehicleScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImageUpload)).EndInit();
            this.AddVehicleRefreshPanel.ResumeLayout(false);
            this.AddVehicleRefreshPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox VehicleTypeSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VehicleMakeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VehicleModelInput;
        private System.Windows.Forms.Label VehicleColourInput;
        private System.Windows.Forms.TextBox VehicleColorInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VehiclePriceRangeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VehicleKilometersInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox VehicleRatedLoadInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UploadImageBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PreviewImageUpload;
        private System.Windows.Forms.Button AddVehicleSaveBtn;
        private System.Windows.Forms.Panel AddVehicleRefreshPanel;
    }
}
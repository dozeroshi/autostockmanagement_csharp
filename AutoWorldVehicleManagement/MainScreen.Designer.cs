namespace AutoWorldVehicleManagement
{
    partial class MainScreen
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.ViewVehicleButton = new System.Windows.Forms.Button();
            this.UsersMenuButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.Controls.Add(this.AddVehicleButton);
            this.flowLayoutPanel1.Controls.Add(this.ViewVehicleButton);
            this.flowLayoutPanel1.Controls.Add(this.UsersMenuButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(373, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(573, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddVehicleButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVehicleButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVehicleButton.Location = new System.Drawing.Point(3, 3);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(188, 46);
            this.AddVehicleButton.TabIndex = 0;
            this.AddVehicleButton.Text = "Add Vehicle";
            this.AddVehicleButton.UseVisualStyleBackColor = false;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleBtn_Click);
            // 
            // ViewVehicleButton
            // 
            this.ViewVehicleButton.BackColor = System.Drawing.Color.LightGreen;
            this.ViewVehicleButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.ViewVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewVehicleButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewVehicleButton.Location = new System.Drawing.Point(197, 3);
            this.ViewVehicleButton.Name = "ViewVehicleButton";
            this.ViewVehicleButton.Size = new System.Drawing.Size(191, 46);
            this.ViewVehicleButton.TabIndex = 2;
            this.ViewVehicleButton.Text = "View Vehicles";
            this.ViewVehicleButton.UseVisualStyleBackColor = false;
            this.ViewVehicleButton.Click += new System.EventHandler(this.ViewVehicleBtn_Click);
            // 
            // UsersMenuButton
            // 
            this.UsersMenuButton.BackColor = System.Drawing.Color.MistyRose;
            this.UsersMenuButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.UsersMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UsersMenuButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersMenuButton.Location = new System.Drawing.Point(394, 3);
            this.UsersMenuButton.Name = "UsersMenuButton";
            this.UsersMenuButton.Size = new System.Drawing.Size(174, 46);
            this.UsersMenuButton.TabIndex = 3;
            this.UsersMenuButton.Text = "Users";
            this.UsersMenuButton.UseVisualStyleBackColor = false;
            this.UsersMenuButton.Click += new System.EventHandler(this.UsersMenuBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContentPanel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentPanel.Location = new System.Drawing.Point(98, 53);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1153, 677);
            this.ContentPanel.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainScreen";
            this.Text = "Auto World Vehicle Management";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button ViewVehicleButton;
        private System.Windows.Forms.Button UsersMenuButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}


namespace AutoWorldVehicleManagement
{
    partial class CreateUserScreen
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
            this.UserFullNameInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.UserPasswordInput = new System.Windows.Forms.TextBox();
            this.UserRoleInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CancelNewUserBtn = new System.Windows.Forms.Button();
            this.SaveNewUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserFullNameInput
            // 
            this.UserFullNameInput.Location = new System.Drawing.Point(40, 117);
            this.UserFullNameInput.Name = "UserFullNameInput";
            this.UserFullNameInput.Size = new System.Drawing.Size(502, 27);
            this.UserFullNameInput.TabIndex = 0;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(40, 230);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(502, 27);
            this.UsernameInput.TabIndex = 1;
            // 
            // UserPasswordInput
            // 
            this.UserPasswordInput.Location = new System.Drawing.Point(40, 355);
            this.UserPasswordInput.Name = "UserPasswordInput";
            this.UserPasswordInput.Size = new System.Drawing.Size(502, 27);
            this.UserPasswordInput.TabIndex = 2;
            // 
            // UserRoleInput
            // 
            this.UserRoleInput.FormattingEnabled = true;
            this.UserRoleInput.Items.AddRange(new object[] {
            "Sales",
            "Staff"});
            this.UserRoleInput.Location = new System.Drawing.Point(40, 473);
            this.UserRoleInput.Name = "UserRoleInput";
            this.UserRoleInput.Size = new System.Drawing.Size(289, 26);
            this.UserRoleInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 20F);
            this.label5.Location = new System.Drawing.Point(34, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Create New User";
            // 
            // CancelNewUserBtn
            // 
            this.CancelNewUserBtn.BackColor = System.Drawing.Color.Red;
            this.CancelNewUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelNewUserBtn.Location = new System.Drawing.Point(40, 541);
            this.CancelNewUserBtn.Name = "CancelNewUserBtn";
            this.CancelNewUserBtn.Size = new System.Drawing.Size(144, 37);
            this.CancelNewUserBtn.TabIndex = 9;
            this.CancelNewUserBtn.Text = "Cancel";
            this.CancelNewUserBtn.UseVisualStyleBackColor = false;
            this.CancelNewUserBtn.Click += new System.EventHandler(this.CancelNewUserBtn_Click);
            // 
            // SaveNewUserBtn
            // 
            this.SaveNewUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveNewUserBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveNewUserBtn.Location = new System.Drawing.Point(248, 541);
            this.SaveNewUserBtn.Name = "SaveNewUserBtn";
            this.SaveNewUserBtn.Size = new System.Drawing.Size(144, 37);
            this.SaveNewUserBtn.TabIndex = 10;
            this.SaveNewUserBtn.Text = "Save User";
            this.SaveNewUserBtn.UseVisualStyleBackColor = false;
            this.SaveNewUserBtn.Click += new System.EventHandler(this.SaveNewUserBtn_Click);
            // 
            // CreateUserScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.SaveNewUserBtn);
            this.Controls.Add(this.CancelNewUserBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserRoleInput);
            this.Controls.Add(this.UserPasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.UserFullNameInput);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CreateUserScreen";
            this.Text = "CreateUserScreen";
            this.Load += new System.EventHandler(this.CreateUserScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserFullNameInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox UserPasswordInput;
        private System.Windows.Forms.ComboBox UserRoleInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CancelNewUserBtn;
        private System.Windows.Forms.Button SaveNewUserBtn;
    }
}
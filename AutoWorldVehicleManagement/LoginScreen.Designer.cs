namespace AutoWorldVehicleManagement
{
    partial class LoginScreen
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
            this.loginForm = new System.Windows.Forms.Panel();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.loginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginForm
            // 
            this.loginForm.BackColor = System.Drawing.SystemColors.Control;
            this.loginForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginForm.Controls.Add(this.SignInButton);
            this.loginForm.Controls.Add(this.label1);
            this.loginForm.Controls.Add(this.UserNameLabel);
            this.loginForm.Controls.Add(this.PasswordInput);
            this.loginForm.Controls.Add(this.UserNameInput);
            this.loginForm.Controls.Add(this.SignInLabel);
            this.loginForm.Location = new System.Drawing.Point(433, 206);
            this.loginForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.loginForm.Name = "loginForm";
            this.loginForm.Size = new System.Drawing.Size(484, 316);
            this.loginForm.TabIndex = 0;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignInButton.Location = new System.Drawing.Point(19, 237);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(102, 35);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "SIGN IN";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(16, 72);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(105, 18);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "User Name:";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(19, 175);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(419, 27);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(19, 93);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(419, 27);
            this.UserNameInput.TabIndex = 1;
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.Location = new System.Drawing.Point(16, 19);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(69, 18);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "Sign In";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.loginForm);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LoginScreen";
            this.Text = "Auto World Vehicle Management";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.loginForm.ResumeLayout(false);
            this.loginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginForm;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label SignInLabel;
    }
}
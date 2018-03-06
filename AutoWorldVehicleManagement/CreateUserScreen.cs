using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWorldVehicleManagement
{
    public partial class CreateUserScreen : Form
    {
        public MainScreen ParentForm { get; set; }
        public VehicleManagement VehicleManagement { get; set; }
        public UserManagement UserManagement { get; set; }

        public CreateUserScreen()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void CreateUserScreen_Load(object sender, EventArgs e) {}

        private void SaveNewUserBtn_Click(object sender, EventArgs e)
        {
            string errors = "";
            bool missingFields = false;

            if (UserFullNameInput.Text == "")
            {
                errors += "- User Full Name";
                missingFields = true;
            }

            if (UsernameInput.Text == "")
            {
                errors += "- System Username";
                missingFields = true;
            }

            if (UserPasswordInput.Text == "")
            {
                errors += "- System Password";
                missingFields = true;
            }

            if(UserRoleInput.SelectedIndex < 0)
            {
                errors += "- System Role";
                missingFields = true;
            }

            if(UserManagement.createUser(UserFullNameInput.Text, UserRoleInput.SelectedItem.ToString(), UsernameInput.Text, UserPasswordInput.Text))
            {
                MessageBox.Show("New user created successfully.");
            }
            else
            {
                MessageBox.Show("Failed to save new users");
            }

            this.clear();
        }//end SaveNewUserBtn_Click()


        private void CancelNewUserBtn_Click(object sender, EventArgs e)
        {
            this.clear();
        }


        /// <summary>
        /// Clears the form
        /// </summary>
        private void clear()
        {
            UserFullNameInput.Text = "";
            UsernameInput.Text = "";
            UserPasswordInput.Text = "";
            UserRoleInput.SelectedIndex = -1;
        }//end clear()
    }
}

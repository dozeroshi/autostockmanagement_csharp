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
    public partial class LoginScreen : Form
    {
        //store the usermanagement object in the class scope
        public UserManagement UserManagement { get; set; }
        public VehicleManagement VehicleManagement { get; set; }

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string username = UserNameInput.Text;
            string password = PasswordInput.Text;

            if(UserManagement.loginUser(username, password))
            {
                //we are good to proceed to main screen window
                this.Hide();

               
                ViewVehiclesScreen NewScreen = new ViewVehiclesScreen();
                NewScreen.VehicleManagement = VehicleManagement;
                NewScreen.UserManagement = UserManagement;
                

                NewScreen.Tag = this;
                MainScreen MainScreen = new MainScreen(NewScreen);
                NewScreen.SetParentForm(MainScreen);

                //pass the order and customer objects to the new window
                MainScreen.UserManagement = UserManagement;
                MainScreen.VehicleManagement = VehicleManagement;
                MainScreen.Show(this);
            }
            else
            {
                MessageBox.Show("Sorry, either the username or password are not correct.");
            }
        }
    }
}

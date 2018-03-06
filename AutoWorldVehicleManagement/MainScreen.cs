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
    public partial class MainScreen : Form
    {
        public UserManagement UserManagement;
        public VehicleManagement VehicleManagement;
        public Form childForm;

        public MainScreen()
        {
            InitializeComponent();
        }

        public MainScreen(Form InnerForm)
        {
            InitializeComponent();

            childForm = InnerForm;
            childForm.TopLevel = false;
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }//end MainScreen()

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }//end MainScreen_Load()

        private void AddVehicleBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Remove(childForm);
            childForm.Dispose();

            AddVehicleScreen AddVehicleChild = new AddVehicleScreen();
            AddVehicleChild.SetParentForm(this);
            AddVehicleChild.VehicleManagement = VehicleManagement;
            AddVehicleChild.UserManagement = UserManagement;
            childForm = AddVehicleChild;
            childForm.TopLevel = false;
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }

        private void EditVehicleBtn_Click(object sender, EventArgs e)
        {
            childForm.Dispose();
            ContentPanel.Controls.Remove(childForm);

            EditVehicleScreen EditVehicleChild = new EditVehicleScreen();
            EditVehicleChild.SetParentForm(this);
            EditVehicleChild.VehicleManagement = VehicleManagement;
            EditVehicleChild.UserManagement = UserManagement;
            childForm = EditVehicleChild;
            childForm.TopLevel = false;
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }

        private void ViewVehicleBtn_Click(object sender, EventArgs e)
        {
            childForm.Dispose();
            ContentPanel.Controls.Remove(childForm);
       
            ViewVehiclesScreen ViewVehicleChild = new ViewVehiclesScreen();
            ViewVehicleChild.SetParentForm(this);
            ViewVehicleChild.VehicleManagement = VehicleManagement;
            ViewVehicleChild.UserManagement = UserManagement;
            childForm = ViewVehicleChild;
            childForm.TopLevel = false;
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }

        private void UsersMenuBtn_Click(object sender, EventArgs e)
        {
            childForm.Dispose();
            ContentPanel.Controls.Remove(childForm);

            ViewUsersScreen ViewUsersChild = new ViewUsersScreen();
            ViewUsersChild.SetParentForm(this);
            ViewUsersChild.VehicleManagement = VehicleManagement;
            ViewUsersChild.UserManagement = UserManagement;
            childForm = ViewUsersChild;
            childForm.TopLevel = false;
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }

        public void LoadViewSingleVehicleScreen(Vehicle ViewVehicle)
        {
            childForm.Dispose();
            ContentPanel.Controls.Remove(childForm);

            ViewSingleVehicleScreen ViewSingleVehicleChild = new ViewSingleVehicleScreen();
            ViewSingleVehicleChild.ParentForm = this;
            ViewSingleVehicleChild.VehicleManagement = VehicleManagement;
            ViewSingleVehicleChild.UserManagement = UserManagement;
            ViewSingleVehicleChild.CurrentVehicle = ViewVehicle;
            childForm = ViewSingleVehicleChild;
            childForm.TopLevel = false;
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }//end LoadViewSingleVehicleScreen()

        public void LoadEditSingleVehicleScreen(Vehicle ViewVehicle)
        {
            childForm.Dispose();
            ContentPanel.Controls.Remove(childForm);

            EditVehicleScreen EditVehicleChild = new EditVehicleScreen();
            EditVehicleChild.ParentForm = this;
            EditVehicleChild.VehicleManagement = VehicleManagement;
            EditVehicleChild.UserManagement = UserManagement;
            EditVehicleChild.CurrentVehicle = ViewVehicle;
            childForm = EditVehicleChild;
            childForm.TopLevel = false;
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }//end LoadEditSingleVehicleScreen()

        public void LoadCreateUserScreen()
        {
            childForm.Dispose();
            ContentPanel.Controls.Remove(childForm);

            CreateUserScreen CreateUserChild = new CreateUserScreen();
            CreateUserChild.ParentForm = this;
            CreateUserChild.VehicleManagement = VehicleManagement;
            CreateUserChild.UserManagement = UserManagement;
            childForm = CreateUserChild;
            childForm.TopLevel = false;
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }//end LoadCreateUserScreen()

    }
}

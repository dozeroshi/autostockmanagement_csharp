using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWorldVehicleManagement
{
    public partial class ViewSingleVehicleScreen : Form
    {
        public MainScreen ParentForm { get; set; }
        public VehicleManagement VehicleManagement { get; set; }
        public UserManagement UserManagement { get; set; }
        public Vehicle CurrentVehicle { get; set; }


        //constructor
        public ViewSingleVehicleScreen()
        {
            InitializeComponent();
            this.ControlBox = false;
        }//ViewSingleVehicleScreen()


        /// <summary>
        /// Load the view vehicle screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewSingleVehicleScreen_Load(object sender, EventArgs e)
        {
            string type = CurrentVehicle.GetVehicleType();
            string loadRating = CurrentVehicle.GetVehicleLoadRating();
            string imagePath = CurrentVehicle.GetImagePath();

            if(type == "Car")
            {
                loadRating = "N/A";
            }

            VehicleIDLabel.Text = CurrentVehicle.GetVehicleID().ToString();
            VehicleTypeLabel.Text = type;
            VehicleMakeLabel.Text = CurrentVehicle.GetVehicleMake();
            VehicleModelLabel.Text = CurrentVehicle.GetVehicleModel();
            VehicleColourLabel.Text = CurrentVehicle.GetVehicleColour();
            VehiclePriceRangeLabel.Text = CurrentVehicle.GetVehiclePriceRange();
            VehicleKilometersLabel.Text = CurrentVehicle.GetVehicleKilometers().ToString();
            VehicleSoldStatusLabel.Text = CurrentVehicle.GetVehicleSoldStatus().ToString();
            VehicleSoldDateLabel.Text = CurrentVehicle.GetVehicleSoldDate().ToString();
            VehicleRatedLoadLabel.Text = loadRating;

            if(imagePath != "")
            {
                try
                {
                    Image VehicleImage = Image.FromFile(imagePath);
                    VehicleImageViewer.Image = VehicleImage;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to load image");
                }
            }

        }//end ViewSingleVehicleScreen_Load()


        /// <summary>
        /// click event handler for switching to edit vehicle screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditVehicleSaveBtn_Click(object sender, EventArgs e)
        {
            ParentForm.LoadEditSingleVehicleScreen(this.CurrentVehicle);
        }//end EditVehicleSaveBtn_Click()

    }//end class ViewSingleVehicleScreen
}

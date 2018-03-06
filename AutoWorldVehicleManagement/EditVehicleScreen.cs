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
    public partial class EditVehicleScreen : Form
    {
        public MainScreen ParentForm;
        public VehicleManagement VehicleManagement { get; set; }
        public UserManagement UserManagement { get; set; }
        public Vehicle CurrentVehicle { get; set; }
        Image FileImage;

        //constructor
        public EditVehicleScreen()
        {
            InitializeComponent();
            this.ControlBox = false;
        }//end EditVehicleScreen()


        //set the parent form
        public void SetParentForm(MainScreen Form)
        {
            this.ParentForm = Form;
        }//end SetParentForm()


        /// <summary>
        /// Load the edit vehicle screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditVehicleScreen_Load(object sender, EventArgs e)
        {
            string type = CurrentVehicle.GetVehicleType();
            string loadRating = CurrentVehicle.GetVehicleLoadRating();
            string imagePath = CurrentVehicle.GetImagePath();

            if (type == "Car")
            {
                loadRating = "N/A";
                VehicleTypeInput.SelectedIndex = 0;
            } else
            {
                VehicleTypeInput.SelectedIndex = 1;
            }

            VehicleIDLabel.Text = CurrentVehicle.GetVehicleID().ToString();
            
            VehicleMakeInput.Text = CurrentVehicle.GetVehicleMake();
            VehicleModelInput.Text = CurrentVehicle.GetVehicleModel();
            VehicleColorInput.Text = CurrentVehicle.GetVehicleColour();
            VehiclePriceRangeInput.Text = CurrentVehicle.GetVehiclePriceRange();
            VehicleKilometersInput.Text = CurrentVehicle.GetVehicleKilometers().ToString();
            VehicleRatedLoadInput.Text = loadRating;
            DateTime ? soldDate = CurrentVehicle.GetVehicleSoldDate();

            if(soldDate != null)
            {
                VehicleSoldDateInput.Value = (DateTime) soldDate;
            }

            if(CurrentVehicle.GetVehicleSoldStatus().ToString() == "False")
            {
                VehicleSoldStatusInput.SelectedIndex = 0;
            } else
            {
                VehicleSoldStatusInput.SelectedIndex = 1;
            }
            

            if (imagePath != "")
            {
                try
                {
                    Image VehicleImage = Image.FromFile(imagePath);
                    VehicleImageViewer.Image = VehicleImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to load image");
                }
            }
        }//end EditVehicleScreen_Load()


        /// <summary>
        /// Click event handler for the cancel button. Returns to View vehicle screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditVehicleCancelBtn_Click(object sender, EventArgs e)
        {
            ParentForm.LoadViewSingleVehicleScreen(this.CurrentVehicle);
        }//end EditVehicleCancelBtn_Click()


        /// <summary>
        /// Click event handler for save button. Saves the vehicle details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditVehicleSaveBtn_Click(object sender, EventArgs e)
        {        
            int VID = CurrentVehicle.GetVehicleID();

            string errors = "";
            bool missingRequired = false;
            string loadRating = "0";

            //make sure we have all the required fields
            if (VehicleTypeInput.SelectedIndex < 0)
            {
                missingRequired = true;
                errors += "- Vehicle Type\n";
            }
            else
            {
                if (VehicleTypeInput.SelectedItem.ToString() == "Light Truck" && VehicleRatedLoadInput.Text == "")
                {
                    missingRequired = true;
                    errors += "- Vehicle Load Rating\n";
                }
            }

            if (VehicleMakeInput.Text == "")
            {
                missingRequired = true;
                errors += "- Vehicle Make\n";
            }

            if (VehicleModelInput.Text == "")
            {
                missingRequired = true;
                errors += "- Vehicle Model\n";
            }

            if (VehicleColorInput.Text == "")
            {
                missingRequired = true;
                errors += "- Vehicle Colour\n";
            }

            if (VehiclePriceRangeInput.Text == "")
            {
                missingRequired = true;
                errors += "- Vehicle Price Range\n";
            }

            int enteredKilometers = 0;
            if (VehicleKilometersInput.Text == "" || int.TryParse(VehicleKilometersInput.Text, out enteredKilometers) == false)
            {
                missingRequired = true;
                errors += "- Vehicle Kilometers\n";
            }

            if (missingRequired)
            {
                MessageBox.Show("You need the following fields to add this vehicle: \n" + errors);
            }
            else
            {
                string type = VehicleTypeInput.SelectedItem.ToString();
                string make = VehicleMakeInput.Text;
                string model = VehicleModelInput.Text;
                string colour = VehicleColorInput.Text;
                string priceRange = VehiclePriceRangeInput.Text;
                int kilometers = enteredKilometers;
                bool soldStatus = false;
                DateTime? soldDate = VehicleSoldDateInput.Value;

                if (VehicleSoldStatusInput.Text == "True")
                {
                    soldStatus = true;
                } else
                {
                    soldDate = null;
                }

                string imagePath = CurrentVehicle.GetImagePath();

                if (FileImage != null)
                {
                    try
                    {
                        Random rnd = new Random();
                        string hashName = type + make + model + colour + priceRange + rnd.Next(0, 999999999);
                        string programDir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                        imagePath = programDir + VehicleManagement.GetImageDir() + String.Format($@"\vehicle{hashName.GetHashCode()}.jpeg");

                        FileImage.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to upload that image due to error: " + ex.Message);
                    }
                }

                if (type == "Light Truck")
                {
                    loadRating = VehicleRatedLoadInput.Text;
                }
                else
                {
                    loadRating = "0";
                }

                Vehicle tempVehicle = new Vehicle(VID, type, make, model, colour, priceRange, kilometers, soldStatus, soldDate, imagePath, loadRating);

                if (VehicleManagement.EditVehicle(VID, this.CurrentVehicle, tempVehicle, UserManagement.getCurrentUserName()))
                {
                    this.CurrentVehicle = VehicleManagement.GetVehicle(VID);
                    MessageBox.Show("Successfully Saved Changes to Vehicle!");
                    ParentForm.LoadViewSingleVehicleScreen(this.CurrentVehicle);
                }
                else
                {
                    MessageBox.Show("Sorry, something went wrong and the changes were not saved");
                }
            }


        }//EditVehicleSaveBtn_Click()


        /// <summary>
        /// Click event handler for uploading a new vehicle image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPG(*.JPG)|*.jpg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileImage = Image.FromFile(openFile.FileName);
                VehicleImageViewer.Image = FileImage;
            }
        }//end ChangeImageBtn_Click()
    }
}

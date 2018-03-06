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
    public partial class AddVehicleScreen : Form
    {
        Image File;
        public MainScreen ParentForm;
        public VehicleManagement VehicleManagement { get; set; }
        public UserManagement UserManagement { get; set; }

        public AddVehicleScreen()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void AddVehicleScreen_Load(object sender, EventArgs e)
        {

        }

        public void SetParentForm(MainScreen Form)
        {
            this.ParentForm = Form;
        }

        private void UploadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPG(*.JPG)|*.jpg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(openFile.FileName);
                PreviewImageUpload.Image = File;
            }

        }

        private void SaveAddVehicleBtn_Click(object sender, EventArgs e)
        {
            string errors = "";
            bool missingRequired = false;
            string loadRating = "0";

            //make sure we have all the required fields
            if (VehicleTypeSelector.SelectedIndex < 0)
            {
                missingRequired = true;
                errors += "- Vehicle Type\n";
            } else
            {
                if(VehicleTypeSelector.SelectedItem.ToString() == "Light Truck" && VehicleRatedLoadInput.Text == "")
                {
                    missingRequired = true;
                    errors += "- Vehicle Load Rating\n";
                }
            }

            if(VehicleMakeInput.Text == "")
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

            if(missingRequired)
            {
                MessageBox.Show("You need the following fields to add this vehicle: \n" + errors);
            } else
            {
                string type = VehicleTypeSelector.SelectedItem.ToString();
                string make = VehicleMakeInput.Text;
                string model = VehicleModelInput.Text;
                string colour = VehicleColorInput.Text;
                string priceRange = VehiclePriceRangeInput.Text;
                int kilometers = enteredKilometers;
                ;

                string imagePath = "";

                if (File != null)
                {
                    Random rnd = new Random();
                    string hashName = type + make + model + colour + priceRange + rnd.Next(0, 999999999);
                    string programDir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                    imagePath = programDir + VehicleManagement.GetImageDir() + String.Format($@"\vehicle{hashName.GetHashCode()}.jpeg");

                    try
                    {
                        File.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to upload that image due to error: " + ex.Message);
                    }
                } 

                if (type == "Light Truck")
                {
                    loadRating = VehicleRatedLoadInput.Text;  
                } else
                {
                    loadRating = "0";
                }

                if(VehicleManagement.AddVehicle(type, make, model, colour, priceRange, kilometers, imagePath, loadRating, UserManagement.getCurrentUserName()))
                {
                    MessageBox.Show("Successfully Added New Vehicle!");
                    this.clear();

                } else
                {
                    MessageBox.Show("Sorry, something went wrong and the new vehicle was not saved");
                }
            }

        }//end SaveAddVehicleBtn_Click()


        /// <summary>
        /// Clears the form
        /// </summary>
        private void clear()
        {
            VehicleTypeSelector.SelectedIndex = -1;
            VehicleMakeInput.Text = "";
            VehicleModelInput.Text = "";
            VehicleColorInput.Text = "";
            VehiclePriceRangeInput.Text = "";
            VehicleKilometersInput.Text = "";
            VehicleRatedLoadInput.Text = "";
            File = null;
            PreviewImageUpload.Image = File;
        }//end clear()
    }
}

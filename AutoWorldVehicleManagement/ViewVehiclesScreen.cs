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
using System.Xml.Serialization;

namespace AutoWorldVehicleManagement
{
    public partial class ViewVehiclesScreen : Form
    {
        public MainScreen ParentForm;
        public VehicleManagement VehicleManagement { get; set; }
        public UserManagement UserManagement { get; set; }


        //constructor
        public ViewVehiclesScreen()
        {
            InitializeComponent();
            this.ControlBox = false;
        }//end ViewVehiclesScreen()

        public void SetParentForm(MainScreen Form)
        {
            this.ParentForm = Form;
        }


        //loading the screen
        private void ViewVehiclesScreen_Load(object sender, EventArgs e)
        {
            List<string> searchableAttrs = new List<string> { "VID", "Type", "Make", "Model", "Colour", "Price-Range", "Kilometers", "Load-Rating", "Sold Status" };
            foreach(string item in searchableAttrs)
            {
                SearchAttrTypeBox.Items.Add(item);
            }

            SortedDictionary<int, Entity> allCars = VehicleManagement.GetSortedDictionary();
            loadSearchResults(allCars);
        }//end ViewVehiclesScreen_Load()


        /// <summary>
        /// Click event handler for search button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchVehiclesBtn_Click(object sender, EventArgs e)
        {
            //make sure we have an attribute to search by
            if(SearchAttrTypeBox.SelectedIndex < 0)
            {
                MessageBox.Show("You need to enter an attribute to search by");
            }
            else if(SearchVehiclesInput.Text == "")
            {
                MessageBox.Show("You need to enter an search term");
            }
            else
            {

                //all the cars we have
                SortedDictionary<int, Entity> allCars = VehicleManagement.GetSortedDictionary();
                //the cars to show
                SortedDictionary<int, Entity> resultSet = new SortedDictionary<int, Entity>();
                //the string we are searching on
                string searchOn = SearchVehiclesInput.Text;

                foreach (KeyValuePair<int, Entity> entry in allCars)
                {
                    Vehicle vehicle = (Vehicle)entry.Value;
                    if (vehicle.FindAttribute(SearchAttrTypeBox.SelectedItem.ToString(), searchOn))
                    {
                        resultSet.Add(entry.Key, vehicle);
                    }

                }

                if (resultSet.Count() > 0)
                {
                    loadSearchResults(resultSet);
                }
                else
                {
                    MessageBox.Show("Sorry, no vehicles matched your search terms");
                }

            }//end if
        }//end SearchVehiclesBtn_Click()


        /// <summary>
        /// Load the search results in the vehicle table
        /// </summary>
        /// <param name="resultSet"></param>
        private void loadSearchResults(SortedDictionary<int, Entity> resultSet)
        {
            while (SearchVehiclesResultTable.Controls.Count > 0)
            {
                SearchVehiclesResultTable.Controls[0].Dispose();
                SearchVehiclesResultTable.RowCount = 0;
            }

            foreach (KeyValuePair<int, Entity> vehicleSet in resultSet)
            {
                string labelText = "";
                Vehicle t = (Vehicle) vehicleSet.Value;

                //we cant downcast implicitly, so we need to just instantiate new vehicle type objects
                if (vehicleSet.Value.GetEntityType() == "Light Truck")
                {
                    LightTruck currentVehicle = new LightTruck(t.GetVehicleID(), 
                        t.GetVehicleType(), 
                        t.GetVehicleMake(), 
                        t.GetVehicleModel(), 
                        t.GetVehicleColour(), 
                        t.GetVehiclePriceRange(),
                        t.GetVehicleKilometers(), 
                        t.GetVehicleSoldStatus(), 
                        t.GetVehicleSoldDate(), 
                        t.GetImagePath(), 
                        t.GetVehicleLoadRating()
                    );
                    labelText = currentVehicle.GetVehicleDetails();

                }
                else if (vehicleSet.Value.GetEntityType() == "Car")
                {
                    Car currentVehicle = new Car(t.GetVehicleID(),
                       t.GetVehicleType(),
                       t.GetVehicleMake(),
                       t.GetVehicleModel(),
                       t.GetVehicleColour(),
                       t.GetVehiclePriceRange(),
                       t.GetVehicleKilometers(),
                       t.GetVehicleSoldStatus(),
                       t.GetVehicleSoldDate(),
                       t.GetImagePath(),
                       "0"
                    );
                    labelText = currentVehicle.GetVehicleDetails();
                }

                //get a reference to the previous existent 
               // RowStyle temp = SearchVehiclesResultTable.RowStyles[SearchVehiclesResultTable.RowCount - 1];
                //increase panel rows count by one
                SearchVehiclesResultTable.RowCount++;
                //add a new RowStyle as a copy of the previous one
                SearchVehiclesResultTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
                //add your three controls
                SearchVehiclesResultTable.Controls.Add(new Label() { Text = vehicleSet.Key.ToString() }, 0, SearchVehiclesResultTable.RowCount - 1);
                SearchVehiclesResultTable.Controls.Add(new Label() { Text = labelText, AutoSize = true, AutoEllipsis = true }, 1, SearchVehiclesResultTable.RowCount - 1);

                //Button panel
                Panel buttonPanel = new FlowLayoutPanel() { Dock = DockStyle.Fill };

                //view button
                Button ViewButton = new Button() { Text = "View", Name = vehicleSet.Key.ToString(), BackColor = Color.DodgerBlue, FlatStyle = FlatStyle.Standard };
                ViewButton.Click += ViewVehicleButton_Click;

                //edit button
                Button EditButton = new Button() { Text = "Edit", Name = vehicleSet.Key.ToString(), BackColor = Color.Aquamarine, FlatStyle = FlatStyle.Standard };
                EditButton.Click += EditVehicleButton_Click;

                buttonPanel.Controls.Add(ViewButton);
                buttonPanel.Controls.Add(EditButton);

                SearchVehiclesResultTable.Controls.Add(buttonPanel, 2, SearchVehiclesResultTable.RowCount - 1);
            }
        }//end loadSearchResults()


        private void ViewVehicleButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int vehicleVID = Int32.Parse(clickedButton.Name);
            Vehicle ViewVehicle = VehicleManagement.GetVehicle(vehicleVID);
            ParentForm.LoadViewSingleVehicleScreen(ViewVehicle);

        }//end ViewVehicleButton_Click()


        private void EditVehicleButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int vehicleVID = Int32.Parse(clickedButton.Name);
            Vehicle ViewVehicle = VehicleManagement.GetVehicle(vehicleVID);
            ParentForm.LoadEditSingleVehicleScreen(ViewVehicle);
        }//end EditVehicleButton_Click()

    }//end class ViewVehiclesScreen()


}

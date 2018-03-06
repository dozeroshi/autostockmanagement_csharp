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
    public partial class ViewUsersScreen : Form
    {
        public MainScreen ParentForm;
        public VehicleManagement VehicleManagement { get; set; }
        public UserManagement UserManagement { get; set; }


        public ViewUsersScreen()
        {
            InitializeComponent();
            this.ControlBox = false;
        }


        public void SetParentForm(MainScreen Form)
        {
            this.ParentForm = Form;
        }


        private void ViewUsersScreen_Load(object sender, EventArgs e)
        {
            SortedDictionary<int, Entity> allUsers = UserManagement.GetSortedDictionary();
            loadSearchResults(allUsers);

            if(UserManagement.getCurrentUserID() != 100000)
            {
                CreateNewUserBtn.Hide();
            }
        }


        /// <summary>
        /// Click event handler for search button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchUsersBtn_Click(object sender, EventArgs e)
        {
            //make sure we have an attribute to search by
            if (SearchAttrTypeBox.SelectedIndex < 0)
            {
                MessageBox.Show("You need to enter an attribute to search by");
            }
            else if (SearchUsersInput.Text == "")
            {
                MessageBox.Show("You need to enter an search term");
            }
            else
            {

                //all the cars we have
                SortedDictionary<int, Entity> allUsers = UserManagement.GetSortedDictionary();
                //the cars to show
                SortedDictionary<int, Entity> resultSet = new SortedDictionary<int, Entity>();
                //the string we are searching on
                string searchOn = SearchUsersInput.Text;

                foreach (KeyValuePair<int, Entity> entry in allUsers)
                {
                    User user = (User)entry.Value;
                    if (user.FindAttribute(SearchAttrTypeBox.SelectedItem.ToString(), searchOn))
                    {
                        resultSet.Add(entry.Key, user);
                    }

                }

                if (resultSet.Count() > 0)
                {
                    loadSearchResults(resultSet);
                }
                else
                {
                    MessageBox.Show("Sorry, no users matched your search terms");
                }

            }//end if
        }//end SearchUsersBtn_Click()


        /// <summary>
        /// Load the search results and add it to the result table
        /// </summary>
        /// <param name="resultSet"></param>
        private void loadSearchResults(SortedDictionary<int, Entity> resultSet)
        {
            while (SearchUsersResultTable.Controls.Count > 0)
            {
                SearchUsersResultTable.Controls[0].Dispose();
                SearchUsersResultTable.RowCount = 0;
            }

            foreach (KeyValuePair<int, Entity> userSet in resultSet)
            {
                string labelText = "";
                User currentUser = (User)userSet.Value;
                labelText = currentUser.GetUserDetails();


                //get a reference to the previous existent 
                // RowStyle temp = SearchVehiclesResultTable.RowStyles[SearchVehiclesResultTable.RowCount - 1];
                //increase panel rows count by one
                SearchUsersResultTable.RowCount++;
                //add a new RowStyle as a copy of the previous one
                SearchUsersResultTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
                //add your three controls
                SearchUsersResultTable.Controls.Add(new Label() { Text = userSet.Key.ToString() }, 0, SearchUsersResultTable.RowCount - 1);
                SearchUsersResultTable.Controls.Add(new Label() { Text = labelText, AutoSize = true, AutoEllipsis = true }, 1, SearchUsersResultTable.RowCount - 1);

                //Button panel
                Panel buttonPanel = new FlowLayoutPanel() { Dock = DockStyle.Fill };

                //delete button
                if(UserManagement.getCurrentUserID() == 100000 && userSet.Key != 100000)
                {
                    Button DeleteButton = new Button() { Text = "Delete", Name = userSet.Key.ToString(), BackColor = Color.Red };
                    DeleteButton.Click += DeleteUserButton_Click;
                    buttonPanel.Controls.Add(DeleteButton);
                    SearchUsersResultTable.Controls.Add(buttonPanel, 2, SearchUsersResultTable.RowCount - 1);
                }

            }

        }//end loadSearchResults()


        /// <summary>
        /// Click event handler for delete user button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int UID = Int32.Parse(clickedButton.Name);
            MessageBox.Show("Are you sure you want to delete this user?");
            UserManagement.deleteUser(UID, UserManagement.getCurrentUserID());
            SortedDictionary<int, Entity> allUsers = UserManagement.GetSortedDictionary();
            loadSearchResults(allUsers);
        }//end ViewVehicleButton_Click()


        /// <summary>
        /// Click event handler for create new user button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewUserBtn_Click(object sender, EventArgs e)
        {
            ParentForm.LoadCreateUserScreen();
        }//end CreateNewUserBtn_Click()
    }
}

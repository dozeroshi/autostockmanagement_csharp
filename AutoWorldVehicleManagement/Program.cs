using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWorldVehicleManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginScreen LoginScreen = new LoginScreen();
            LoginScreen.VehicleManagement = new VehicleManagement();
            LoginScreen.UserManagement = new UserManagement();

            Application.Run(LoginScreen);
        }
    }

    /// <summary>
    /// Super class for any object that we are saving to serialized file
    /// </summary>
    [Serializable]
    public abstract class Entity{
        //holds what type of entity we are looking at
        protected string type;


        //return what type of entity this is
        public string GetEntityType()
        {
            return this.type;
        }//end GetEntityType()
    }

    /// <summary>
    /// The super class for Users. Should never be instantiated
    /// </summary>
    [Serializable]
    class User : Entity
    {
        protected int UID;
        protected string name, role, username, password;
        protected DateTime creationDate;
        

        //constructor. All fields required to instantiate a derived class
        public User(int userID, string userFullName, string userName, string userPassword)
        {
            this.UID = userID;
            this.name = userFullName;
            this.username = userName;
            this.password = userPassword;
            this.creationDate = DateTime.Now;
        }//end constructor


        //getter for UID
        public int getUID()
        {
            return this.UID;
        }//end getUID()

        //getter for user fullname
        public string getFullName()
        {
            return this.name;
        }//end getFullName()


        //getter for username
        public string getUserName()
        {
            return this.username;
        }//end getUserName()


        //getter for username
        public string getUserPassword()
        {
            return this.password;
        }//end getUserPassword()


        //getter method for role
        public string getUserRole()
        {
            return this.role;
        }//end getUserRole()


        //getter for creation date
        public DateTime getCreationDate()
        {
            return this.creationDate;
        }//end getCreationDate()


        //get the user details
        public string GetUserDetails()
        {
           // string formattedDate = String.Format($"{this.getCreationDate():dd/MM/yyyy}");
            string formattedDate = this.getCreationDate().ToString("dd/MM/yyyy");
            return String.Format($"{this.getUserRole()}: {this.getFullName()} | Username: {this.getUserName()} | Creation Date: {formattedDate}");
        }//end GetUserDetails()


        /// <summary>
        /// Search this user for the given attribute and value
        /// </summary>
        /// <param name="searchKey"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public bool FindAttribute(string searchKey, string searchValue)
        {
            Dictionary<string, string> searchableDetails = new Dictionary<string, string>();
            searchableDetails.Add("UID", this.UID.ToString());
            searchableDetails.Add("Role", this.type);
            searchableDetails.Add("Full Name", this.name);
            searchableDetails.Add("Username", this.username);

            if (searchableDetails.ContainsKey(searchKey) && searchableDetails[searchKey] == searchValue)
            {
                return true;
            }

            return false;
        }

    }//end class User()


    /// <summary>
    /// Base class for SystemManagers such as UserManager and VehicleManager
    /// Holds serialization methods
    /// </summary>
    public abstract class SystemManager
    {
        protected string programDir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

        /// <summary>
        /// Writes a SortedDictionary of Users or Vehicles into a serialized file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="dir"></param>
        /// <param name="inputDictionary"></param>
        /// <returns></returns>
        protected bool WriteSerializedFile(string filePath, string dir, SortedDictionary<int, Entity> inputDictionary)
        {
            try
            {
                //doesnt matter if we just use directory create here
                System.IO.Directory.CreateDirectory(this.programDir + dir);

                //use a create on the filestream so we just overwrite everything
                FileStream inputFileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                BinaryFormatter writer = new BinaryFormatter();
                writer.Serialize(inputFileStream, inputDictionary);
                inputFileStream.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Encounterd exception during serialized file write: ", ex);
            }

            return false;
        }//end WriteSerializedFile()


        /// <summary>
        /// Reads from a serialized file into a SortedDictionary
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        protected SortedDictionary<int, Entity> ReadSerializedFile(string filePath, string dir)
        {
            SortedDictionary<int, Entity> dataSet = new SortedDictionary<int, Entity>();
            try
            {
                if (File.Exists(filePath))
                {
                    //doesnt matter if we just use directory create here
                    System.IO.Directory.CreateDirectory(this.programDir + dir);

                    FileStream outputFileStream = File.OpenRead(filePath);
                    BinaryFormatter reader = new BinaryFormatter();
                    if(outputFileStream.Length > 0)
                    {
                        dataSet = (SortedDictionary<int, Entity>)reader.Deserialize(outputFileStream);
                    }
                    outputFileStream.Close();
                    return dataSet;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Encounterd exception during serialized file read: ", ex);
            }

            //returning empty dictionary
            return dataSet;

        }//end ReadSerializedFile()


        /// <summary>
        /// Writes a log file entry
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="dir"></param>
        /// <param name="inputDictionary"></param>
        /// <returns></returns>
        protected bool WriteLogFile(string filePath, string dir, string logFile)
        {
            try
            {
                //doesnt matter if we just use directory create here
                System.IO.Directory.CreateDirectory(this.programDir + dir);
                System.IO.File.WriteAllText(filePath, logFile);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Encounterd exception during log file write: ", ex);
            }

            return false;
        }//end WriteLogFile()

    }//end class SystemManager()


    /// <summary>
    /// Administrator User class derived from user
    /// </summary>
    [Serializable]
    class AdminUser : User
    {
        //constructor. Calls base class and sets role
        public AdminUser(int userID, string userFullName, string userName, string userPassword) : base(userID, userFullName, userName, userPassword)
        {
            this.role = "Administrator";
        }
    }//end class AdminUser


    /// <summary>
    /// Sales User class derived from user
    /// </summary>
    [Serializable]
    class SalesUser : User
    {
        //constructor. Calls base class and sets role
        public SalesUser(int userID, string userFullName, string userName, string userPassword) : base(userID, userFullName, userName, userPassword)
        {
            this.role = "Sales";
        }
    }//end class SalesUser


    /// <summary>
    /// Staff User class derived from user
    /// </summary>
    [Serializable]
    class StaffUser : User
    {
        //constructor. Calls base class and sets role
        public StaffUser(int userID, string userFullName, string userName, string userPassword) : base(userID, userFullName, userName, userPassword)
        {
            this.role = "Staff";
        }
    }//end class SalesUser


    public class UserManagement : SystemManager
    {
        //whether we a user is authenticated
        private bool loggedIn = false;
        //the user id of the authenticated user
        private int loggedUser = 0;
        //stores all the system users available for fast retrieval
        public SortedDictionary<int, Entity> systemUsers = new SortedDictionary<int, Entity>();
        //our fileDirectory
        private string fileDir = @"\users";
        //our user data filename
        private string fileName = @"\Users.ser";
        //our full filepath
        private string filePath;


        //constructor. Loads the user data from file and saves it 
        //to the systemUsers dictionary
        public UserManagement()
        {
            //add the program directory to our filepath
            this.filePath = programDir + this.fileDir + this.fileName;

            this.systemUsers = ReadSerializedFile(this.filePath, this.fileDir);

            //if we dont have anything, we might be loading for the first
            //time and need to get the admin account up and running
            if(this.systemUsers.Count == 0)
            {
                //in a real implementation we would have this set up by a sys admin
                //and never add passwords into the code
                this.createUser("Admin User", "Administrator", "admin", "rootoor");
            }

        }//end constructor


        //method for handling login requests
        public bool loginUser(string username, string password)
        {
            //we have to iterate over the user dictionary to 
            //check for the username of each user
            foreach(KeyValuePair<int, Entity> entry in systemUsers)
            {
                User user = (User) entry.Value;
                int UID = entry.Key;

                //if username and password match we can login
                if(user.getUserName() == username && user.getUserPassword() == password)
                {
                    this.loggedUser = UID;
                    this.loggedIn = true;
                    return true;
                }
               
            }

            //either we didnt have a password match, or couldnt find the user
            //return false so the GUI can tell the user
            return false;

        }//end loginUser()


        //method for handling logout requests
        public void logoutUser()
        {
            this.loggedIn = false;
            this.loggedUser = 0;
        }//end logoutUser()


        //method for creating a new user
        public bool createUser(string userFullName, string userRole, string userName, string userPassword)
        {
            try
            {
                int newUID;

                //shouldnt happen, but if we dont have an admin
                //we can give them the first id
                if(systemUsers.Count == 0)
                {
                    newUID = 100000;
                } else
                {
                    newUID = (int)systemUsers.Keys.Last();
                    while (systemUsers.ContainsKey(newUID))
                    {
                        newUID++;
                    }
                }

                //put new user in local scope
                User newUser;

                //check what user type we are creating
                if(userRole == "Administrator")
                {
                    newUser = new AdminUser(newUID, userFullName, userName, userPassword);
                }
                else if(userRole == "Sales")
                {
                    newUser = new SalesUser(newUID, userFullName, userName, userPassword);
                }
                //otherwise just make a staff user
                else
                {
                    newUser = new StaffUser(newUID, userFullName, userName, userPassword);
                }

                //add the new user to our systemsUser dictionary
                systemUsers.Add(newUID, newUser);

                //resave the users file
                if (WriteSerializedFile(this.filePath, this.fileDir, systemUsers))
                {
                    //all good return true
                    return true;
                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("{0} Argument Null Exception caught: ", ex);
                return false;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("{0} Arguement Exception caught: ", ex);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} An unknown exception was caught: ", ex);
                return false;
            }//end try/catch

    
            //we shouldnt be here, so something went wrong
            return false;

        }//end createUser()


        public bool deleteUser(int targetUID, int userID)
        {
            //check that the current user is the adminUser
            if (systemUsers.ContainsKey(userID))
            {
                User adminUser = (User)systemUsers[userID];

                if ( adminUser.getUserRole() != "Administrator")
                {
                    Console.WriteLine("Not an admin");
                    return false;
                }

                //okay, we know that an administrator is doing this, proceed
                //check that the user we want to delete does exist
                if (systemUsers.ContainsKey(targetUID))
                {
                    //remove the user from the systemUsers dictionary
                    systemUsers.Remove(targetUID);

                    //resave the users file
                    if(WriteSerializedFile(this.filePath, this.fileDir, systemUsers))
                    {
                        //we have been successful
                        return true;
                    }
                   
                }

                Console.WriteLine("Not found and all that");
            }

            Console.WriteLine("Dunnot");

            //something went wrong
            return false;

        }//end deleteUser()


        //get the currently logged in users name
        public string getCurrentUserName()
        {
            User currentUser = (User) this.systemUsers[this.loggedUser];
            return currentUser.getFullName();
        }//end getCurrentUserName()


        //get the id of the currently logged in user
        public int getCurrentUserID()
        {
            return this.loggedUser;
        }//end getCurrentUserID()

        //get the system users dictionary
        public SortedDictionary<int, Entity> GetSortedDictionary()
        {
            return this.systemUsers;
        }//end GetSortedDictionary()


    }//end class UserManagement()

    [Serializable]
    public class Vehicle : Entity
    {
        protected int VID, kilometers;
        protected string make, model, colour, priceRange, imagePath, loadRating;
        protected bool soldStatus;
        protected DateTime? soldDate = null;

        //no-arg constructor
        public Vehicle() { }

        //constructor
        public Vehicle(int VID, string type, string make, string model, string colour, string priceRange, int kilometers, bool soldStatus, DateTime? soldDate, string imagePath, string loadRating)
        {
            this.VID = VID;
            this.type = type;
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.priceRange = priceRange;
            this.kilometers = kilometers;
            this.soldStatus = soldStatus;
            this.soldDate = soldDate;
            this.imagePath = imagePath;
            this.loadRating = loadRating;
        }//end constructor


        //get this vehicles details
        public string GetVehicleDetails()
        {
            return String.Format($"Type: {this.type}, Make: {this.make}, Model: {this.model}, Colour: {this.colour}, Price-Range: {this.priceRange}, Kilometers: {this.kilometers}");
        }//end GetVehicleDetails()


        //get the vehicle VID
        public int GetVehicleID()
        {
            return this.VID;
        }//end GetVehicleID()


        //get the vehicle type
        public string GetVehicleType()
        {
            return this.type;
        }//end GetVehicleType()


        //get the vehicle make
        public string GetVehicleMake()
        {
            return this.make;
        }//end GetVehicleMake()


        //get the vehicle model
        public string GetVehicleModel()
        {
            return this.model;
        }//end GetVehicleModel()


        //get the vehicle colour
        public string GetVehicleColour()
        {
            return this.colour;
        }//end GetVehicleColour()


        //get the vehicle price range
        public string GetVehiclePriceRange()
        {
            return this.priceRange;
        }//end GetVehiclePriceRange()


        //get the vehicle kilometers
        public int GetVehicleKilometers()
        {
            return this.kilometers;
        }//end GetVehicleKilometers()


        //get the vehicle sold status
        public bool GetVehicleSoldStatus()
        {
            return this.soldStatus;
        }//end GetVehicleSoldStatus()


        //get the vehicle sold date
        public DateTime? GetVehicleSoldDate()
        {
            return this.soldDate;
        }//end GetVehicleSoldDate()


        //get the vehicle rated load
        public string GetVehicleLoadRating()
        {
            return this.loadRating;
        }//end GetVehicleLoadRating()


        //get the image path
        public string GetImagePath()
        {
            return this.imagePath;
        }//end  GetImagePath()


        /// <summary>
        /// Search this vehicle for the given attribute and value
        /// </summary>
        /// <param name="searchKey"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public bool FindAttribute(string searchKey, string searchValue)
        {
            Dictionary<string, string> searchableDetails = new Dictionary<string, string>();
            searchableDetails.Add("VID", this.VID.ToString());
            searchableDetails.Add("Type", this.type);
            searchableDetails.Add("Make", this.make);
            searchableDetails.Add("Model", this.model);
            searchableDetails.Add("Colour", this.colour);
            searchableDetails.Add("Price-Range", this.priceRange);
            searchableDetails.Add("Kilometers", this.kilometers.ToString());
            searchableDetails.Add("Sold Status", this.soldStatus.ToString());

            //add load rating for light trucks
            if(this.GetType().GetProperty("loadRating") != null)
            {
                searchableDetails.Add("Load-Rating", this.loadRating);
            }

            if(searchableDetails.ContainsKey(searchKey) && searchableDetails[searchKey] == searchValue)
            {
                return true;
            }

            return false;
        }

    }//end class Vehicle


    /// <summary>
    /// Car class derived from Vehicle
    /// </summary>
    [Serializable]
    public class Car : Vehicle
    {
        //no-op constructor
        public Car(int VID, string vehicleType, string make, string model, string colour, string priceRange, int kilometers, bool soldStatus, DateTime? soldDate, string imagePath, string loadRating) : base(VID, vehicleType, make, model, colour, priceRange, kilometers, soldStatus, soldDate, imagePath, loadRating) {}

    }//end class Car()


    /// <summary>
    /// Light Truck class derived from Vehicle
    /// </summary>
    [Serializable]
    public class LightTruck : Vehicle
    {
        //contructor. Takes extra loadRating parameter
        public LightTruck(int VID, string vehicleType, string make, string model, string colour, string priceRange, int kilometers, bool soldStatus, DateTime? soldDate, string imagePath, string loadRating) : base(VID, vehicleType, make, model, colour, priceRange, kilometers, soldStatus, soldDate, imagePath, loadRating)
        {
            this.loadRating = loadRating;
        }//end constructor

        //get this vehicles details
        public new string GetVehicleDetails()
        {
            return String.Format($"Type: {this.type}, Make: {this.make}, Model: {this.model}, Colour: {this.colour}, Price-Range: {this.priceRange}, Kilometers: {this.kilometers}, Load-Rating: {this.loadRating}");
        }//end GetVehicleDetails()

    }//end class LightTruck()



    public class VehicleManagement : SystemManager
    {

        //whether we a user is authenticated
        private int vehicleCount = 0;
        //stores all the system vehicles available for fast retrieval
        private SortedDictionary<int, Entity> systemVehicles = new SortedDictionary<int, Entity>();
        //our fileDirectory
        private string fileDir = @"\vehicles";
        //our user data filename
        private string fileName = @"\Vehicles.ser";
        //our full filepath
        private string filePath;
        //the location of our vehicle images
        private string imageDir = @"\images";


        //constructor. Loads the vehicle data from file and saves it 
        //to the systemVehicles dictionary
        public VehicleManagement()
        {
            //add the program directory to our filepath
            this.filePath = programDir + this.fileDir + this.fileName;

            this.systemVehicles = ReadSerializedFile(this.filePath, this.fileDir);

            //make sure we have an image directory
            System.IO.Directory.CreateDirectory(this.programDir + this.imageDir);

        }//end constructor


        /// <summary>
        /// creates a new vehicle and adds it to systemVehicles
        /// </summary>
        /// <param name="type"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="colour"></param>
        /// <param name="priceRange"></param>
        /// <param name="kilometers"></param>
        /// <param name="imagePath"></param>
        /// <param name="loadRating"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddVehicle(string type, string make, string model, string colour, string priceRange, int kilometers, string imagePath, string loadRating, string user)
        {
            try
            {
                int newVID;

                //shouldnt happen, but if we dont have an admin
                //we can give them the first id
                if (systemVehicles.Count == 0)
                {
                    newVID = 100000;
                }
                else
                {
                    newVID = (int)systemVehicles.Keys.Last();
                    while (systemVehicles.ContainsKey(newVID))
                    {
                        newVID++;
                    }
                }

                //put new user in local scope
                Vehicle newVehicle;

                //check what user type we are creating
                if (type == "Light Truck")
                {
                    newVehicle = new LightTruck(newVID, type, make, model, colour, priceRange, kilometers, false, null, imagePath, loadRating);
                }
                //otherwise we have a car
                else
                {
                    newVehicle = new Car(newVID, type, make, model, colour, priceRange, kilometers, false, null, imagePath, "0");
                }

                string logFile = new DateTime().ToLongDateString() + " - New " + type + " created by " + user + ": " + newVehicle.ToString();

                //add the new vehicle to our systemVehicles dictionary
                systemVehicles.Add(newVID, newVehicle);

                //resave the vehicles file
                if (WriteSerializedFile(this.filePath, this.fileDir, systemVehicles))
                {
                    WriteLogFile(this.programDir + @"\logs\log.txt", this.programDir + @"\logs\", logFile);
                    //all good return true
                    return true;
                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("{0} Argument Null Exception caught: ", ex);
                return false;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("{0} Arguement Exception caught: ", ex);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} An unknown exception was caught: ", ex);
                return false;
            }//end try/catch


            //we shouldnt be here, so something went wrong
            return false;

        }//end AddVehicle()


        /// <summary>
        /// Updated a vehicle in the systemVehicles and on file
        /// </summary>
        /// <param name="VID"></param>
        /// <param name="existingVehicle"></param>
        /// <param name="tempVehicle"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool EditVehicle(int VID, Vehicle existingVehicle, Vehicle tempVehicle, string user)
        {
            //if these objects are equal there is nothing to do
            if(!existingVehicle.Equals(tempVehicle))
            {
                string logFile = new DateTime().ToLongDateString() + " - " + user + " edited Vehicle #" + VID + ". The following changes were made: "; 

                var oType = existingVehicle.GetType();
                int count = 1;

                //iterate over the properties and compare them
                foreach (var oProperty in oType.GetProperties())
                {
                    var originalValue = oProperty.GetValue(existingVehicle, null);
                    var newValue = oProperty.GetValue(tempVehicle, null);

                    if (!object.Equals(originalValue, newValue))
                    {
                        logFile += "(" + count + ") - " + oProperty.ToString() + " to " + newValue + " ";
                    }
                }

                //replace the existing vehicle with the new vehicle
                systemVehicles[VID] = tempVehicle;

                //resave the vehicles file
                if (WriteSerializedFile(this.filePath, this.fileDir, systemVehicles))
                {
                    //save the log file
                    WriteLogFile(this.programDir + @"\logs\log.txt", this.programDir + @"\logs\", logFile);

                    //all good return true
                    return true;
                }

            }

            return false;

        }//end EditVehicle()


        /// <summary>
        /// Gets the vehicle belonging to the passed VID
        /// </summary>
        /// <param name="VID"></param>
        /// <returns></returns>
        public Vehicle GetVehicle(int VID)
        {
            return (Vehicle) this.systemVehicles[VID];
        }//GetVehicle()


        //getter for the image directory
        public string GetImageDir()
        {
            return imageDir;
        }//end GetImageDir()


        public SortedDictionary<int, Entity> GetSortedDictionary()
        {
            return this.systemVehicles;
        }//end GetSortedDictionary()


    }//end class VehicleManagement()


}

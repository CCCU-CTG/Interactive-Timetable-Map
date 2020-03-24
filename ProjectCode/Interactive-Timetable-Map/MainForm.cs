using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Interactive_Timetable_Map
{
    public partial class MainForm : Form
    {
        // List containing Module Timetable Class objects + User Class objects
        List<User> usersList = new List<User>();
        User currentUser;

        List<Module_Timetable> moduleTimetableList = new List<Module_Timetable>();

        // DEBUG, is has the login function worked?
        public static bool loggedIn = false;
        public static bool adminLoggedIn = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserXMLReader();
            ModuleTimetableXMLReader();
            LoginCheck(loggedIn, adminLoggedIn, currentUser);  
            
            editDatabaseButton.Enabled = false;
            editUsersButton.Enabled = false;
        }

        private void UserXMLReader()
        {
            XmlDocument Users = new XmlDocument();

            // List containing user information
            List<string> userID = new List<string>();
            List<string> name = new List<string>();
            List<string> surname = new List<string>();
            List<string> username = new List<string>();
            List<string> password = new List<string>();
            List<string> group = new List<string>();
            List<bool> admin = new List<bool>();

            string directory = Directory.GetCurrentDirectory() + "/Databases";
            Users.Load(directory + @"\User_Database.xml");

            foreach(XmlNode uID in Users.DocumentElement.SelectNodes("//ID"))
            {
                userID.Add(uID.InnerText);
            }

            foreach (XmlNode uName in Users.DocumentElement.SelectNodes("//Name"))
            {
                name.Add(uName.InnerText);
            }

            foreach (XmlNode sName in Users.DocumentElement.SelectNodes("//Surname"))
            {
                surname.Add(sName.InnerText);
            }

            foreach (XmlNode userName in Users.DocumentElement.SelectNodes("//Username"))
            {
                username.Add(userName.InnerText);
            }

            foreach (XmlNode pass in Users.DocumentElement.SelectNodes("//Password"))
            {
                password.Add(pass.InnerText);
            }

            foreach (XmlNode uGroup in Users.DocumentElement.SelectNodes("//Group"))
            {
                group.Add(uGroup.InnerText);
            }

            foreach (XmlNode Admin in Users.DocumentElement.SelectNodes("//Admin"))
            {
                if(Admin.InnerText == "Y") { admin.Add(true); }
                else { admin.Add(false); }
            }

            for (int i = 0; i < userID.Count; i++)
            {
                usersList.Add(new User(userID[i], name[i], surname[i], username[i], password[i], group[i], admin[i]));
            }
        }

        private void ModuleTimetableXMLReader()
        {
            XmlDocument Modules = new XmlDocument();

            // Lists containing Module names + schedules on each day
            List<string> modulesList = new List<string>();
            List<string> tempMonday = new List<string>();
            List<string> tempTuesday = new List<string>();
            List<string> tempWednesday = new List<string>();
            List<string> tempThursday = new List<string>();
            List<string> tempFriday = new List<string>();

            string directory = Directory.GetCurrentDirectory() + "/Databases";
            Modules.Load(directory + @"\Module_Timetable_Database.xml");

            foreach (XmlNode moduleNames in Modules.DocumentElement.SelectNodes("//Name"))
            {
                modulesList.Add(moduleNames.InnerText);
            }

            for (int i = 0; i < modulesList.Count; i++)
            {
                tempMonday.Clear(); tempTuesday.Clear(); tempWednesday.Clear(); tempThursday.Clear(); tempFriday.Clear();

                foreach (XmlNode monday in Modules.DocumentElement.SelectNodes(modulesList[i] + "/Monday/Time"))
                {
                    tempMonday.Add(monday.InnerText);
                }

                foreach (XmlNode tuesday in Modules.DocumentElement.SelectNodes(modulesList[i] + "/Tuesday/Time"))
                {
                    tempTuesday.Add(tuesday.InnerText);
                }

                foreach (XmlNode wednesday in Modules.DocumentElement.SelectNodes(modulesList[i] + "/Wednesday/Time"))
                {
                    tempWednesday.Add(wednesday.InnerText);
                }

                foreach (XmlNode thursday in Modules.DocumentElement.SelectNodes(modulesList[i] + "/Thursday/Time"))
                {
                    tempThursday.Add(thursday.InnerText);
                }

                foreach (XmlNode friday in Modules.DocumentElement.SelectNodes(modulesList[i] + "/Friday/Time"))
                {
                    tempFriday.Add(friday.InnerText);
                }

                moduleTimetableList.Add(new Module_Timetable(modulesList[i], tempMonday, tempTuesday, tempWednesday, tempThursday, tempFriday));
            }
        }

        /// Opens Login Form
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Checks to see if a Login Form is already open, if so, close that and open a new one
            if (Application.OpenForms.OfType<loginForm>().Count() > 0) { Application.OpenForms.OfType<loginForm>().First().Close(); }
            var loginForm = new loginForm(usersList);
            loginForm.Show();
        }

        /// For testing purposes, tells you if you are logged in or not
        public void LoginCheck(bool loggedInTemp, bool adminLoggedInTemp, User currentUserTemp)
        {
            loggedIn = loggedInTemp;
            adminLoggedIn = adminLoggedInTemp;

            if (loggedIn) {loginButton.Enabled = false; logoutButton.Enabled = true; testingLoggedInTextBox.Text = "User Logged In"; }
            else { loginButton.Enabled = true; logoutButton.Enabled = false; testingLoggedInTextBox.Text = "User Logged Out"; }

            if (adminLoggedIn) { testingLoggedInTextBox.Text = "Admin Logged In"; editDatabaseButton.Enabled = true; editUsersButton.Enabled = true; }
            else { editDatabaseButton.Enabled = false; editUsersButton.Enabled = false; }

            currentUser = currentUserTemp;
            TimetableDataGridLoad();
        }

        private void TimetableDataGridLoad()
        {
            timetableDataGrid.AllowUserToAddRows = false;
            int selectedModule = 0;
            string[] timetableTimes = new string[] { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00"};

            if (loggedIn)
            {
                for (int i = 0; i < moduleTimetableList.Count; i++)
                {
                    if (currentUser.GetModule == moduleTimetableList[i].GetModuleName) { selectedModule = i; }
                }

                //Resets table
                timetableDataGrid.Rows.Clear();
                //Creates 11 empty rows
                for (int i = 0; i < timetableTimes.Length; i++)
                {
                    timetableDataGrid.Rows.Add
                        (moduleTimetableList[selectedModule].GetMonday[i],
                        moduleTimetableList[selectedModule].GetTuesday[i],
                        moduleTimetableList[selectedModule].GetWednesday[i],
                        moduleTimetableList[selectedModule].GetThursday[i],
                        moduleTimetableList[selectedModule].GetFriday[i]);
                    timetableDataGrid.Rows[i].HeaderCell.Value = timetableTimes[i];
                }

                foreach (DataGridViewRow r in timetableDataGrid.Rows)
                {
                    DataGridViewLinkCell Monday = new DataGridViewLinkCell();
                    if(r.Cells[0].Value.ToString() != "None")
                    {
                        Monday.Value = r.Cells[0].Value;
                        timetableDataGrid[0, r.Index] = Monday;
                    }

                    DataGridViewLinkCell Tuesday = new DataGridViewLinkCell();
                    if (r.Cells[1].Value.ToString() != "None")
                    {
                        Tuesday.Value = r.Cells[1].Value;
                        timetableDataGrid[1, r.Index] = Tuesday;
                    }

                    DataGridViewLinkCell Wednesday = new DataGridViewLinkCell();
                    if (r.Cells[2].Value.ToString() != "None")
                    {
                        Wednesday.Value = r.Cells[2].Value;
                        timetableDataGrid[2, r.Index] = Wednesday;
                    }

                    DataGridViewLinkCell Thursday = new DataGridViewLinkCell();
                    if (r.Cells[3].Value.ToString() != "None")
                    {
                        Thursday.Value = r.Cells[3].Value;
                        timetableDataGrid[3, r.Index] = Thursday;
                    }

                    DataGridViewLinkCell Friday = new DataGridViewLinkCell();
                    if (r.Cells[4].Value.ToString() != "None")
                    {
                        Friday.Value = r.Cells[4].Value;
                        timetableDataGrid[4, r.Index] = Friday;
                    }
                }
            }
            else
            {
                timetableDataGrid.Rows.Clear();
                for (int i = 0; i < timetableTimes.Length; i++) { timetableDataGrid.Rows.Add(); timetableDataGrid.Rows[i].HeaderCell.Value = timetableTimes[i]; }
                //Displays time for each cell
            }
        }

        private void timetableDataGrid_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex < 0) { return; }
            if (e.RowIndex < 0) { return; }
            switch (timetableDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
            {
                case "Lf13":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/fa0c4599c02c468f90b2613a/");
                break;
                case "Ng07":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/3f97499b02244a6b8320852e/");
                break;
                case "If02":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/0e32e2d035c84cfd8f3ce7c7/");
                break;
                case "Ng03":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/0b8dbbf97e4e44b3af2780ee/");
                break;
                case "Ig02":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/2ae42057860e4f719e06dc9a/");
               break;
                case "OS.0.03":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/89418a349156467b941e428e/");
                break;
                case "Pg06":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/1a6730c77c8548f78b3f389c/");
                break;
                case "Lg27":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/18587695b38a4d8380e2ccd9/");
                break;
                case "If03":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/86973e61c0d34a85b732371f/");
                break;
                case "Lunchtime":
                    Process.Start("https://www.canterbury.ac.uk/campusmaps/#/2ea30af3d92c45ee851a1e01/details/c06b8595bcbd43bba93b340d/");
                break;
            }
        }

        private void EditDatabaseButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EditDatabaseForm>().Count() > 0) { Application.OpenForms.OfType<EditDatabaseForm>().First().Close(); }
            var DataForm = new EditDatabaseForm();
            DataForm.ShowDialog();
        }

        // reload the timetable from the file
        public void UpdateDataForm()
        {
            moduleTimetableList.Clear();
            ModuleTimetableXMLReader();
            TimetableDataGridLoad();
        }

        private void EditUsersButton_Click(object sender, EventArgs e)
        {
            // open users form and use a callback when closed to update the users list
            if (Application.OpenForms.OfType<EditUsersForm>().Count() > 0) { Application.OpenForms.OfType<EditUsersForm>().First().Close(); }
            var UserForm = new EditUsersForm(usersList, this, currentUser);
            UserForm.ShowDialog();
        }

        // reload the users from the file
        public void UpdateUserForm()
        {
            // called when user details are changed
            // clear the list and re read the details
            usersList.Clear();
            UserXMLReader();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<HelpForm>().Count() > 0) { Application.OpenForms.OfType<HelpForm>().First().Close(); }
            var HelpForm = new HelpForm();
            HelpForm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loggedIn = false;
            adminLoggedIn = false;
            currentUser = null;
            LoginCheck(loggedIn, adminLoggedIn, currentUser);
        }
    }
}

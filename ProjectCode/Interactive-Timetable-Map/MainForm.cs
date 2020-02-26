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
using System.Xml;
using System.Xml.Linq;

namespace Interactive_Timetable_Map
{
    public partial class MainForm : Form
    {
        // List containing Module Timetable Class objects + User Class objects
        List<User> usersList = new List<User>();
        List<Module_Timetable> moduleTimetableList = new List<Module_Timetable>();

        // DEBUG, is has the login function worked?
        bool loggedIn = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserXMLReader();
            ModuleTimetableXMLReader();
            TimetableDataGridLoad();
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

            for (int i = 0; i < userID.Count; i++)
            {
                usersList.Add(new User(userID[i], name[i], surname[i], username[i], password[i], group[i]));
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
        public void LoginCheck(bool loggedInTemp)
        {
            if (loggedInTemp) { loggedIn = true; }
            if (loggedIn) { testingLoggedInTextBox.Text = "Debug: You Are Logged In."; }
            else { testingLoggedInTextBox.Text = "Debug: You Are Not Logged In."; }
        }

        private void TimetableDataGridLoad()
        {
            //Resets table
            timetableDataGrid.Rows.Clear();
            //Creates 10 empty rows
            for (int i = 0; i < 10; i++)
            {
                timetableDataGrid.Rows.Add();
            }
            //Displays time for each cell
            timetableDataGrid.Rows[0].HeaderCell.Value = "09:00";
            timetableDataGrid.Rows[1].HeaderCell.Value = "10:00";
            timetableDataGrid.Rows[2].HeaderCell.Value = "11:00";
            timetableDataGrid.Rows[3].HeaderCell.Value = "12:00";
            timetableDataGrid.Rows[4].HeaderCell.Value = "13:00";
            timetableDataGrid.Rows[5].HeaderCell.Value = "14:00";
            timetableDataGrid.Rows[6].HeaderCell.Value = "15:00";
            timetableDataGrid.Rows[7].HeaderCell.Value = "16:00";
            timetableDataGrid.Rows[8].HeaderCell.Value = "17:00";
            timetableDataGrid.Rows[9].HeaderCell.Value = "18:00";
            timetableDataGrid.Rows[10].HeaderCell.Value = "19:00";

        }

        private void EditDatabaseButton_Click(object sender, EventArgs e)
        {
            EditDatabaseForm DataForm = new EditDatabaseForm();
            this.Hide();
            DataForm.ShowDialog();
        }

        private void EditUsersButton_Click(object sender, EventArgs e)
        {
            EditUsersForm UserForm = new EditUsersForm();
            this.Hide();
            UserForm.ShowDialog();
        }
    }
}

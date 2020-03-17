using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactive_Timetable_Map
{
    public partial class HelpForm : Form
    {
        int helpIndex = 1;
        string[] userHelp = {"",
                            "This is the main screen of the program. Your timetable is visible on the left.",
                            "You can view your timetabled sessions, see how long they last for, which room you will be in and who is your lecturer.",
                            "If you don't recognise the room name or don't know where it is located, click on the room name and it will open up in a new browser window!",
                            "Once you are done using this program, you may either close it, or log out.",
                            "Enjoy your time at CCCU!"};
        string[] adminHelp = {"",
                             "This is the main screen of the program. Your timetable is visible on the left.",
                             "You can view your timetabled sessions, see how long they last for, which room you will be in and who is your lecturer.",
                             "If you don't recognise the room name or don't know where it is located, click on the room name and it will open up in a new browser window!",
                             "Once you are done using this program, you may either close it, or log out.",
                             "To edit the module database, click the Edit Database button!",
                             "Once the form has opened, you can select the module name and view the time slots per day. You can also add new modules, remove modules by first selecting them and then clicking Remove Module as well as changing time slots for each module.",
                             "In order to go back to the main screen, click the Back button in the top right corner.",
                             "If you would like to edit the User database, click Edit Users button.",
                             "Once the user editing screen has opened, you can select the user ID that you want to edit or add a new user by clicking the Add User button on the right. If you would like to remove a specific user, first select the user by their ID and then click the Remove User button. Alternatively, you can also change the selected user's password. To exit this screen, just click the Back button in the top right corner.",
                             "There you go, you're now all set to manage the module and database system!"};
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            HelpIndexChanged();
        }
        public void HelpIndexChanged()
        {
            if(MainForm.loggedIn != true) { helpTextBox.Text = "Welcome to the CCCU Interactive Timetable Map! To get started, you will need to log in using your login details that your administrator/module leader has provided. Click the Login button to the side and enter those in."; }
            else if(MainForm.adminLoggedIn != true)
            {
                helpTextBox.Text = userHelp[helpIndex];
                helpIndexTextBox.Text = helpIndex + " / " + (userHelp.Length - 1);
            }
            else
            {
                helpTextBox.Text = adminHelp[helpIndex];
                helpIndexTextBox.Text = helpIndex + " / " + (adminHelp.Length - 1);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(MainForm.loggedIn != true) { }
            else if(MainForm.adminLoggedIn != true)
            {
                if (helpIndex >= 5) { }
                else { helpIndex++; HelpIndexChanged(); }
            }
            else
            {
                if (helpIndex >= 10) { }
                else { helpIndex++; HelpIndexChanged(); }
            }
            
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (helpIndex <= 1) { }
            else { helpIndex--; HelpIndexChanged(); }
        }
    }
}

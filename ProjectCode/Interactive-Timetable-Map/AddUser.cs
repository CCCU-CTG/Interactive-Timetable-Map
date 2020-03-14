using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AesEncDec;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace Interactive_Timetable_Map
{
    public partial class AddUser : Form
    {
        string newUsername = null;
        string newPassword = null;
        string newFirstname = null;
        string newSurname = null;
        string newGroup = null;
        string newAdmin = null;
        private EditUsersForm pForm;
        private List<User> users;

        XmlDocument xtr = new XmlDocument();
        string directory = Directory.GetCurrentDirectory() + "/Databases";

        public AddUser(EditUsersForm parent, List<User> userList)
        {
            InitializeComponent();
            pForm = parent;

            xtr.Load(directory + @"\Module_Timetable_Database.xml");
            int i = 0;

            foreach (XmlNode uID in xtr.DocumentElement.SelectNodes("//Name"))
            {
                comboBoxGroup.Items.Insert(i, uID.InnerText);
                i++;
            }

            comboBoxGroup.SelectedIndex = 0;
            users = userList;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {

            newUsername = textBoxUsername.Text;
            newPassword = textBoxPassword.Text;
            newFirstname = textBoxFirstName.Text;
            newSurname = textBoxLastName.Text;
            newGroup = comboBoxGroup.SelectedItem.ToString();

            bool validuser = true;
            if (String.IsNullOrWhiteSpace(newGroup) || String.IsNullOrWhiteSpace(newFirstname) || String.IsNullOrWhiteSpace(newSurname)) { validuser = false; }
            if (newUsername.Length < 3 || String.IsNullOrWhiteSpace(newUsername) || newPassword.Length < 5 || String.IsNullOrWhiteSpace(newPassword)) { validuser = false; }

            int tempID = 0;
            foreach (User user in users)
            {
                if (int.Parse(user.GetPatientID) > tempID)
                {
                    tempID = int.Parse(user.GetPatientID);
                }
                if (newUsername == user.GetUsername)
                {
                    validuser = false;
                    MessageBox.Show("A user with this username already exists in our system, please choose a different username", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (validuser)
            {
                tempID++;
                pForm.newID = tempID.ToString();
                pForm.sentUser = true;
                // set the parents attributes
                pForm.newFirstname = newFirstname;
                pForm.newSurname = newSurname;
                pForm.newUsername = newUsername;
                pForm.newPassword = newPassword;
                pForm.newGroup = newGroup;
                if (checkBoxAdmin.Checked) { pForm.newAdmin = "Y"; }
                else { pForm.newAdmin = "N"; }
                Application.OpenForms.OfType<EditUsersForm>().First().AddUserFunction();
                Application.OpenForms.OfType<EditUsersForm>().First().AddUsersUI();
                this.Close();
            }
            else
            {
                // display validity error message
                MessageBox.Show("Invalid entry, ensure a group, the username is longer than 3 characters and the password is longer than 5 characters", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
    public partial class EditUsersForm : Form
    {

        List<User> user = new List<User>();
        User currentUser;
        XmlDocument xtr = new XmlDocument();

        string directory = Directory.GetCurrentDirectory() + "/Databases";
        //XmlTextReader xtr = new XmlTextReader(@"..\Debug\Databases\User_Database.xml");

        // List containing user information
        List<string> userID = new List<string>();
        List<string> name = new List<string>();
        List<string> surname = new List<string>();
        List<string> username = new List<string>();
        List<string> password = new List<string>();
        List<string> group = new List<string>();
        List<bool> admin = new List<bool>();

        public string newUsername = null;
        public string newPassword = null;
        public string newFirstname = null;
        public string newSurname = null;
        public string newGroup = null;
        public string newAdmin = null;
        public string newID = null;
        public bool sentUser = false;
        User loginUser;

        public EditUsersForm(List<User> usersList, MainForm parent, User loggedInAs)
        {
            xtr.Load(directory + @"\User_Database.xml");

            MainForm parentForm = parent;
            loginUser = loggedInAs;
            user = usersList;
            InitializeComponent();
            CreateUsers();
            AddUsersUI();
        }

        public void AddUsersUI()
        {
            int i = 0;
            comboBoxID.Items.Clear();
            foreach (User user in user)
            {
                comboBoxID.Items.Insert(i, user.GetPatientID);
                i++;
            }
        }

        private void CreateUsers()
        {
            for (int i = 0; i < user.Count; i++)
            {
                string dir = user[i].GetUsername;
                // Checks to see if the username already exists, if so, abort registration
                if (!Directory.Exists("data\\" + dir))
                {
                    Directory.CreateDirectory("data\\" + dir);
                    var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                    string encryptedusername = AesCryp.Encrypt(user[i].GetUsername);
                    string encryptedpassword = AesCryp.Encrypt(user[i].GetPassword);

                    sw.WriteLine(encryptedusername);
                    sw.WriteLine(encryptedpassword);
                    sw.Close();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<MainForm>().First().Show();
            this.Close();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            sentUser = false;
            // create new user form and add call back function to it
            if (Application.OpenForms.OfType<AddUser>().Count() > 0) { Application.OpenForms.OfType<AddUser>().First().Close(); }
            var adduserForm = new AddUser(this, user);
            adduserForm.ShowDialog();
        }

        public void AddUserFunction()
        {
            if (sentUser)
            {
                XmlNode headerNode = xtr.DocumentElement.SelectSingleNode("//Users");
                XmlNode finalChild = xtr.DocumentElement.LastChild;

                XmlNode parentNode = xtr.CreateElement("User");
                headerNode.AppendChild(parentNode);

                XmlNode infoNode = xtr.CreateElement("ID");
                infoNode.InnerText = newID;
                parentNode.AppendChild(infoNode);

                infoNode = xtr.CreateElement("Name");
                infoNode.InnerText = newFirstname;
                parentNode.AppendChild(infoNode);

                infoNode = xtr.CreateElement("Surname");
                infoNode.InnerText = newSurname;
                parentNode.AppendChild(infoNode);

                infoNode = xtr.CreateElement("Username");
                infoNode.InnerText = newUsername;
                parentNode.AppendChild(infoNode);

                infoNode = xtr.CreateElement("Password");
                infoNode.InnerText = newPassword;
                parentNode.AppendChild(infoNode);

                infoNode = xtr.CreateElement("Group");
                infoNode.InnerText = newGroup;
                parentNode.AppendChild(infoNode);

                infoNode = xtr.CreateElement("Admin");
                infoNode.InnerText = newAdmin;
                parentNode.AppendChild(infoNode);

                xtr.Save(directory + @"\User_Database.xml");
                MessageBox.Show("User: " + newUsername + "succesfully added", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms.OfType<MainForm>().First().UpdateUserForm();
            }
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            if(currentUser != null)
            {
                if (currentUser.GetUsername == loginUser.GetUsername) { MessageBox.Show("You cannot remove yourself from the users list", "User Cannot Be Removed", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    DialogResult removeUser = MessageBox.Show("Do you want to remove the currently selected user? this action cannot be undone.", "Remove User", MessageBoxButtons.YesNo);
                    if (removeUser == DialogResult.Yes)
                    {
                        string removeName = currentUser.GetUsername;
                        foreach (XmlNode userName in xtr.DocumentElement.SelectNodes("//Username"))
                        {
                            if (removeName == userName.FirstChild.Value)
                            {
                                XmlNode parent = userName.ParentNode;
                                //userName.ParentNode.RemoveAll();
                                parent.ParentNode.RemoveChild(parent);

                                xtr.Save(directory + @"\User_Database.xml");

                            }

                        }
                        MessageBox.Show("User: " + removeName + "succesfully removed", "User Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.OpenForms.OfType<MainForm>().First().UpdateUserForm();
                        AddUsersUI();
                    }
                    else if (removeUser == DialogResult.No) { }
                }
            }
            else
            {
                MessageBox.Show("User must be selected.");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if(currentUser != null)
            {
                // input for new data
                string newPassword = Interaction.InputBox("Enter the new password for User: " + currentUser.GetUsername + Environment.NewLine + "Must be 5 characters or longer", "Enter New Password");
                if(newPassword.Length == 0) { return; }
                if (newPassword.Length < 5) { MessageBox.Show("Password must be 5 characters or longer."); }
                else
                {
                    // search for user and change detail
                    foreach (XmlNode userName in xtr.DocumentElement.SelectNodes("//Username"))
                    {
                        if (currentUser.GetUsername == userName.FirstChild.Value)
                        {
                            XmlNode parent = userName.ParentNode;
                            foreach (XmlNode node in parent)
                            {
                                if (node.Name == "Password") { node.InnerText = newPassword; }
                            }
                        }
                    }
                    xtr.Save(directory + @"\User_Database.xml");
                    MessageBox.Show("User: " + currentUser + "has had their password changed", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.OpenForms.OfType<MainForm>().First().UpdateUserForm();
                }
            }
            else
            {
                MessageBox.Show("User not selected.");
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxID.SelectedIndex;
            currentUser = user[index];
            textBoxFirstName.Text = user[index].GetFirstName;
            textBoxLastName.Text = user[index].GetSurname;
            textBoxUsername.Text = user[index].GetUsername;
            textBoxGroup.Text = user[index].GetModule;
        }
    }
}

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

namespace Interactive_Timetable_Map
{
    public partial class loginForm : Form
    {
        bool loggedInTemp = false;
        List<User> user = new List<User>();

        public loginForm(List<User> usersList)
        {
            user = usersList;
            InitializeComponent();
            CreateUsers();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool usernameFound = false;

            if (usernameTextBox.Text.Length < 3 || passwordTextBox.Text.Length < 5)
            {
                MessageBox.Show("Username or Password is invaled or too short!");
                return;
            }

            for(int i = 0; i < user.Count; i++)
            {
                if (user[i].GetUsername == usernameTextBox.Text) { usernameFound = true; }
            }

            if (usernameFound)
            {
                string dir = usernameTextBox.Text;
                if (!Directory.Exists("data\\" + dir))
                {
                    MessageBox.Show("User " + dir + " was not found!");
                    return;
                }
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encryptedusername = sr.ReadLine();
                    string encryptedpassword = sr.ReadLine();
                    sr.Close();

                    string decusr = AesCryp.Decrypt(encryptedusername);
                    string decpass = AesCryp.Decrypt(encryptedpassword);

                    if (decusr == usernameTextBox.Text && decpass == passwordTextBox.Text)
                    {
                        MessageBox.Show("Welcome " + dir + " to the private area!");
                        loggedInTemp = true;
                        // Returns loggedInTemp to LoginCheck in MainForm
                        Application.OpenForms.OfType<MainForm>().First().LoginCheck(loggedInTemp);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error user or password is wrong!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Username Not Found");
                return;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 3 || passwordTextBox.Text.Length < 5)
            {
                MessageBox.Show("Username or Password is invaled or too short!");
            }
            else
            {
                string dir = usernameTextBox.Text;
                // Checks to see if the username already exists, if so, abort registration
                if(Directory.Exists("data\\" + dir))
                {
                    MessageBox.Show("This Username Is Taken");
                    return;
                }
                Directory.CreateDirectory("data\\" + dir);
                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string encryptedusername = AesCryp.Encrypt(usernameTextBox.Text);
                string encryptedpassword = AesCryp.Encrypt(passwordTextBox.Text);

                sw.WriteLine(encryptedusername);
                sw.WriteLine(encryptedpassword);
                sw.Close();

                MessageBox.Show("User " + dir + " was successfully created.");
            }
        }

        private void CreateUsers()
        {
            for(int i = 0; i < user.Count; i++)
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
    }
}

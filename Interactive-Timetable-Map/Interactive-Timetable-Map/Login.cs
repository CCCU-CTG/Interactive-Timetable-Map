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

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 3 || passwordTextBox.Text.Length < 5)
            {
                MessageBox.Show("Username or Password is invaled or too short!");
            }
            else
            {
                string dir = usernameTextBox.Text;
                if (!Directory.Exists("data\\" + dir))
                    MessageBox.Show("User {0} was not found!", dir);
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
                        MessageBox.Show("Welcome {0} to the private area!", decusr);
                        loggedInTemp = true;
                        // Returns loggedInTemp to LoginCheck in MainForm
                        Application.OpenForms.OfType<MainForm>().First().LoginCheck(loggedInTemp);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error user or password is wrong!");
                    }

                }
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

                MessageBox.Show("User {0} was successfully created.", usernameTextBox.Text);
            }
        }
    }
}

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

namespace Login_System_Tut_ecnrypted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegForm rf = new RegForm();
            rf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usrTxt.Text.Length < 3 || passTxt.Text.Length < 5)
            {
                MessageBox.Show("Username or Password is invaled or too short!");
            }
            else
            {
                string dir = usrTxt.Text;
                if (!Directory.Exists("data\\" + dir))
                    MessageBox.Show("User {0} was not found!", dir);
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpass = sr.ReadLine();
                    sr.Close();

                    string decusr = AesCryp.Decrypt(encusr);
                    string decpass = AesCryp.Decrypt(encpass);

                    if (decusr == usrTxt.Text && decpass == passTxt.Text)
                    {
                        MessageBox.Show("Welcome {0} to the private area!", decusr);
                    }
                    else
                    {
                        MessageBox.Show("Error user or password is wrong!");
                    }

                }
            }
        }
    }
}

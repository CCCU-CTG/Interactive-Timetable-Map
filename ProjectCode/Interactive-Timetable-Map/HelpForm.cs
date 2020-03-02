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
            switch(helpIndex)
            {
                case 1:
                    helpTextBox.Text = "Welcome to the CCCU Interactive Timetable Map!";
                    helpIndexTextBox.Text = helpIndex + " / 8";
                    break;
                case 2:
                    helpTextBox.Text = "To get started, you will need to first log in with your universities login details.";
                    helpIndexTextBox.Text = helpIndex + " / 8";
                    break;
                case 3:
                    helpTextBox.Text = "Click the 'Login' button in the top right and enter your username and password!";
                    helpIndexTextBox.Text = helpIndex + " / 8";
                    break;
                case 4:
                    helpTextBox.Text = "Once you have logged in successfully, your timetable will be shown in full.";
                    helpIndexTextBox.Text = helpIndex + " / 8";
                    break;
                case 5:
                    helpTextBox.Text = "You can view your timetabled sessions, see how long they last for, which room you will be in and who is your lecturer.";
                    helpIndexTextBox.Text = helpIndex + " / 8";
                    break;
                case 6:
                    helpTextBox.Text = "If you don't recognise the room name or don't know where it is located,"
                                        + Environment.NewLine + 
                                        "just click on the room name and you will be directed to the location of the room.";
                    helpIndexTextBox.Text = helpIndex + " / 8";
                    break;
                case 7:
                    helpTextBox.Text = "Once you are done using this program, you may either close it, or log out.";
                    helpIndexTextBox.Text = helpIndex + " / 8";
                    break;
                case 8:
                    helpTextBox.Text = "Enjoy your time at CCCU!";
                    helpIndexTextBox.Text = helpIndex + " / 8";
                    break;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (helpIndex >= 8) { }
            else { helpIndex++; HelpIndexChanged(); }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (helpIndex <= 1) { }
            else { helpIndex--; HelpIndexChanged(); }
        }
    }
}

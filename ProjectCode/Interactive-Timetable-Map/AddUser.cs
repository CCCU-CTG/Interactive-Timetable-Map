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
		public string newUsername = null;
		public string newPassword = null;
		public string newFirstname = null;
		public string newSurname = null;
		public string newGroup = null;
		public string newAdmin = null;
		private EditUsersForm pForm = null;
		private List<User> users = null;

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

			//comboBoxGroup.Items.Insert(0, "Computer_Science_A");
			//comboBoxGroup.Items.Insert(0, "Computer_Science_B");
			//comboBoxGroup.Items.Insert(0, "Computing_A");
			//comboBoxGroup.Items.Insert(0, "Computing_B");
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
			if (newGroup == null) validuser = false;
			if (newFirstname == null) validuser = false;
			if (newSurname == null) validuser = false;
			if (newUsername.Length < 3) validuser = false;
			if (newPassword.Length < 5) validuser = false;

			int tempID = 0; 
			foreach (User user in users){
				if (int.Parse(user.GetPatientID) > tempID)
					tempID = int.Parse(user.GetPatientID);
				if (newUsername == user.GetUsername){
					validuser = false;
					MessageBox.Show("A user with this username already exists in our system, please choose a different username",
				"Invalid entry",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning);
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
				if (checkBoxAdmin.Checked){ pForm.newAdmin = "Y"; } else { pForm.newAdmin = "N"; }
				this.Close();

			} else {

				// display validity error message
				MessageBox.Show("Invalid entry, ensure a group, the username is longer than 3 characters and the password is longer than 5 characters",
				"Invalid entry",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning); }
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            XMLReaderToUserList();
            ///<summary>
            ///Test for the XMLReader
            ///</summary>
            //int index = 3;
            //listView1.Items.Add(userList[index].Id.ToString());
            //listView1.Items.Add(userList[index].Name.ToString());
            //listView1.Items.Add(userList[index].Surname.ToString());
            //listView1.Items.Add(userList[index].Username.ToString());
            //listView1.Items.Add(userList[index].Password.ToString());
            //listView1.Items.Add(userList[index].PasswordEncrypted.ToString());
            //listView1.Items.Add(userList[index].Group.ToString());
        }

        /// <summary>
        /// Reads the User Database.xml file and outputs to the User class. 
        /// </summary>
        /// <returns>userList</returns>
        private List<User> XMLReaderToUserList()
        {
            XElement userDBXMLFile = XElement.Load(@"User Database.xml");
            List<User> userList = (from users in userDBXMLFile.Descendants("User")
                                   select new User
                                   {
                                       Id = users.Element("Id").Value,
                                       Name = users.Element("Name").Value,
                                       Surname = users.Element("Surname").Value,
                                       Username = users.Element("Username").Value,
                                       Password = users.Element("Password").Value,
                                       PasswordEncrypted = users.Element("PasswordEncrypted").Value,
                                       Group = users.Element("Group").Value
                                   }).ToList();
            return userList;
        }
    }
}

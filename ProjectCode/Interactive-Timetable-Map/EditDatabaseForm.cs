﻿using System;
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
    public partial class EditDatabaseForm : Form
    {
        XmlDocument xtr = new XmlDocument();
        string directory = Directory.GetCurrentDirectory() + "/Databases";

        // global holding variables
        List<string> monday = new List<string>();
        List<string> tuesday = new List<string>();
        List<string> wednesday = new List<string>();
        List<string> thursday = new List<string>();
        List<string> friday = new List<string>();
        string selectedTimeSlot = "";
        int groupIndex = 0;
        string timeSlotDate;
        string selectedModule;

        public EditDatabaseForm()
        {
            InitializeComponent();

            xtr.Load(directory + @"\Module_Timetable_Database.xml");

            refreshDropDowns();
        }

        //refresh all drop downs to match new data added/removed
        private void refreshDropDowns()
        {
            xtr.Load(directory + @"\Module_Timetable_Database.xml");

            monday.Clear(); tuesday.Clear(); wednesday.Clear(); thursday.Clear(); friday.Clear(); moduleNameComboBox.Items.Clear();
            comboBoxMon.Text = ""; comboBoxTues.Text = ""; comboBoxWeds.Text = ""; comboBoxThurs.Text = ""; comboBoxFri.Text = "";

            // load in all store loops of modules with corresponding dates
            // create all counter variables
            int i = 0; int time = 9; int tc = 0; string dt;
            foreach (XmlNode uID in xtr.DocumentElement.SelectNodes("//Monday"))
            {
                time = 9; tc = 0;
                foreach (XmlNode slot in uID)
                {
                    dt = string.Format("{0:00.00}", time + tc);
                    dt += ": ";
                    monday.Insert(i, dt + slot.InnerText); i++; tc++;
                }
            }

            i = 0; tc = 0;
            foreach (XmlNode uID in xtr.DocumentElement.SelectNodes("//Tuesday"))
            {
                time = 9; tc = 0;
                foreach (XmlNode slot in uID)
                {
                    dt = string.Format("{0:00.00}", time + tc);
                    dt += ": ";
                    tuesday.Insert(i, dt + slot.InnerText); i++; tc++;
                }
            }

            i = 0; tc = 0;
            foreach (XmlNode uID in xtr.DocumentElement.SelectNodes("//Wednesday"))
            {
                time = 9; tc = 0;
                foreach (XmlNode slot in uID)
                {
                    dt = string.Format("{0:00.00}", time + tc);
                    dt += ": ";
                    wednesday.Insert(i, dt + slot.InnerText); i++; tc++;
                }
            }

            i = 0; tc = 0;
            foreach (XmlNode uID in xtr.DocumentElement.SelectNodes("//Thursday"))
            {
                time = 9; tc = 0;
                foreach (XmlNode slot in uID)
                {
                    dt = string.Format("{0:00.00}", time + tc);
                    dt += ": ";
                    thursday.Insert(i, dt + slot.InnerText); i++; tc++;
                }
            }

            i = 0; tc = 0;
            foreach (XmlNode uID in xtr.DocumentElement.SelectNodes("//Friday"))
            {
                time = 9; tc = 0;
                foreach (XmlNode slot in uID)
                {
                    dt = string.Format("{0:00.00}", time + tc);
                    dt += ": ";
                    friday.Insert(i, dt + slot.InnerText); i++; tc++;
                }
            }

            i = 0;
            moduleNameComboBox.Items.Clear();
            foreach (XmlNode uID in xtr.DocumentElement.SelectNodes("//Name"))
            {
                moduleNameComboBox.Items.Insert(i, uID.InnerText);
                i++;
            }

            comboBoxMon.Items.Clear();
            comboBoxTues.Items.Clear();
            comboBoxWeds.Items.Clear();
            comboBoxThurs.Items.Clear();
            comboBoxFri.Items.Clear();

            // add data to boxes
            selectedModule = "";
            selectedTimeSlot = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<MainForm>().First().Show();
            this.Close();
        }

        private void addModuleButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string newModuleName = Interaction.InputBox("Enter the name of the new module: ", "New Module Name", "New Module Name");
            // if module allready exists dont create and show warning message
            foreach (XmlNode uID in xtr.DocumentElement.SelectNodes("//Name"))
            {
                if (uID.InnerText == newModuleName) { valid = false; }
            }
            if (!valid) { MessageBox.Show("Module " + newModuleName + "Already exists", "Module Allready Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                //create module and set it blank
                XmlNode headerNode = xtr.DocumentElement.SelectSingleNode("//Modules");

                XmlNode parentNode = xtr.CreateElement(newModuleName);
                headerNode.AppendChild(parentNode);

                XmlNode nameNode = xtr.CreateElement("Name");
                nameNode.InnerText = newModuleName;
                parentNode.AppendChild(nameNode);

                // set all dates and times to None
                XmlNode DateNode = xtr.CreateElement("Monday");
                parentNode.AppendChild(DateNode);
                // create all time slots and attatch to corresponding date
                for (int i = 0; i < 11; i++)
                {
                    XmlNode timeNode = xtr.CreateElement("Time");
                    timeNode.InnerText = "None";
                    DateNode.AppendChild(timeNode);
                }
                // repeat for tues-fri
                DateNode = xtr.CreateElement("Tuesday");
                parentNode.AppendChild(DateNode);
                for (int i = 0; i < 11; i++) { XmlNode timeNode = xtr.CreateElement("Time"); timeNode.InnerText = "None"; DateNode.AppendChild(timeNode); }

                DateNode = xtr.CreateElement("Wednesday");
                parentNode.AppendChild(DateNode);
                for (int i = 0; i < 11; i++) { XmlNode timeNode = xtr.CreateElement("Time"); timeNode.InnerText = "None"; DateNode.AppendChild(timeNode); }

                DateNode = xtr.CreateElement("Thursday");
                parentNode.AppendChild(DateNode);
                for (int i = 0; i < 11; i++) { XmlNode timeNode = xtr.CreateElement("Time"); timeNode.InnerText = "None"; DateNode.AppendChild(timeNode); }

                DateNode = xtr.CreateElement("Friday");
                parentNode.AppendChild(DateNode);
                for (int i = 0; i < 11; i++) { XmlNode timeNode = xtr.CreateElement("Time"); timeNode.InnerText = "None"; DateNode.AppendChild(timeNode); }

                xtr.Save(directory + @"\Module_Timetable_Database.xml");
                MessageBox.Show("Module: " + newModuleName + "succesfully added", "Module Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshDropDowns();
            }
        }

        private void moduleNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // feed data from dateLists into respective drop downs
            // is not separated by module
            // 11 per module so can be found at pos 
            // ( index * 11) + i

            // reset all drop downs
            comboBoxMon.Items.Clear();
            comboBoxTues.Items.Clear();
            comboBoxWeds.Items.Clear();
            comboBoxThurs.Items.Clear();
            comboBoxFri.Items.Clear();

            // add data to boxes
            groupIndex = moduleNameComboBox.SelectedIndex * 11;
            for (int i = 0; i < 11; i++)
            {
                comboBoxMon.Items.Add(monday[(groupIndex + i)]);
                comboBoxTues.Items.Add(tuesday[(groupIndex + i)]);
                comboBoxWeds.Items.Add(wednesday[(groupIndex + i)]);
                comboBoxThurs.Items.Add(thursday[(groupIndex + i)]);
                comboBoxFri.Items.Add(friday[(groupIndex + i)]);
            }

            selectedModule = moduleNameComboBox.Text;
        }

        private void buttonTimeSlot_Click(object sender, EventArgs e)
        {
            if (selectedTimeSlot == "") { MessageBox.Show("No time slot selected", "No Time Slot Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                // propmt the user to add a new time for the slot and update the list
                string newTimeSlot = Interaction.InputBox("Enter the new content for timeslot: " + timeSlotDate + ": " + selectedTimeSlot, "Alter Time Slot", "Alter Time Slot");
                string datestub = selectedTimeSlot.Substring(0, 6);
                int writeIndex = 0;
                if (timeSlotDate == "Monday")
                {
                    monday[(groupIndex + comboBoxMon.SelectedIndex)] = datestub + newTimeSlot;
                    writeIndex = comboBoxMon.SelectedIndex;
                }

                if (timeSlotDate == "Tuesday")
                {
                    tuesday[(groupIndex + comboBoxTues.SelectedIndex)] = datestub + newTimeSlot;
                    writeIndex = comboBoxTues.SelectedIndex;
                }

                if (timeSlotDate == "Wednesday")
                {
                    wednesday[(groupIndex + comboBoxWeds.SelectedIndex)] = datestub + newTimeSlot;
                    writeIndex = comboBoxWeds.SelectedIndex;
                }

                if (timeSlotDate == "Thursday")
                {
                    thursday[(groupIndex + comboBoxThurs.SelectedIndex)] = datestub + newTimeSlot;
                    writeIndex = comboBoxThurs.SelectedIndex;
                }

                if (timeSlotDate == "Friday")
                {
                    friday[(groupIndex + comboBoxFri.SelectedIndex)] = datestub + newTimeSlot;
                    writeIndex = comboBoxFri.SelectedIndex;
                }

                // use set variables from dropdowns to build path
                XmlNode slot = xtr.SelectNodes("//" + selectedModule + "/" + timeSlotDate + "/Time")[writeIndex];

                // alter text and save to path, providing a callback message for clarity
                slot.InnerText = newTimeSlot;
                xtr.Save(directory + @"\Module_Timetable_Database.xml");
                MessageBox.Show("timeslot changed", "Timeslot Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.OpenForms.OfType<MainForm>().First().UpdateDataForm();
                refreshDropDowns();
            }
        }

        // when any combo box is selected change the drop down path variable and the date in the information box
        private void comboBoxMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTimeSlot = monday[(groupIndex + comboBoxMon.SelectedIndex)];
            textBoxTimeSlot.Text = "Monday:\n " + selectedTimeSlot;
            timeSlotDate = "Monday";
        }

        private void comboBoxTues_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTimeSlot = tuesday[(groupIndex + comboBoxTues.SelectedIndex)];
            textBoxTimeSlot.Text = "Tuesday:\n " + selectedTimeSlot;
            timeSlotDate = "Tuesday";
        }

        private void comboBoxWeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTimeSlot = wednesday[(groupIndex + comboBoxWeds.SelectedIndex)];
            textBoxTimeSlot.Text = "Wednesday:\n " + selectedTimeSlot;
            timeSlotDate = "Wednesday";
        }

        private void comboBoxThurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTimeSlot = thursday[(groupIndex + comboBoxThurs.SelectedIndex)];
            textBoxTimeSlot.Text = "Thursday:\n " + selectedTimeSlot;
            timeSlotDate = "Thursday";
        }

        private void comboBoxFri_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTimeSlot = monday[(groupIndex + comboBoxFri.SelectedIndex)];
            textBoxTimeSlot.Text = "Friday:\n " + selectedTimeSlot;
            timeSlotDate = "Friday";
        }

        private void removeModuleButton_Click(object sender, EventArgs e)
        {
            string moduleToDelete = Interaction.InputBox("Enter the name of the module to remove, note any users in this module will need to be manually changed to other modules ", "Remove Module", "Remove Module");

            DialogResult removeModule = MessageBox.Show("Do you want to remove the currently selected module? this action cannot be undone.", "Remove User", MessageBoxButtons.YesNo);
            if (removeModule == DialogResult.Yes)
            {
                foreach (XmlNode module in xtr.DocumentElement.SelectNodes("//Modules/*"))
                {
                    if (moduleToDelete == module.FirstChild.InnerText)
                    {
                        XmlNode parent = module.ParentNode;
                        //userName.ParentNode.RemoveAll();
                        parent.RemoveChild(module);

                        xtr.Save(directory + @"\Module_Timetable_Database.xml");

                    }

                }
                MessageBox.Show("User: " + moduleToDelete + "succesfully removed", "User Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (removeModule == DialogResult.No) { }
            refreshDropDowns();
        }
    }
}

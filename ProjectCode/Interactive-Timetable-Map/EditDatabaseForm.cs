﻿using System;
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
    public partial class EditDatabaseForm : Form
    {
        public EditDatabaseForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<MainForm>().First().Show();
            this.Close();
        }
    }
}

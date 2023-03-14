﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public Form Parent { get; set; }
        public MainForm(User user, Form form)
        {
            InitializeComponent();
            User = user;
            Parent = form;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AdminUsersControl adminUsersControl= new AdminUsersControl();
            adminUsersControl.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Close();
        }
    }
}

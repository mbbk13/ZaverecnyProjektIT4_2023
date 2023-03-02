﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class LoginForm : Form
    {
        SqlRepository sqlRepository;
        public LoginForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbPassword.Text != "")
            {
                User user = sqlRepository.GetUser(tbUserName.Text);
                if (user != null)
                {
                    if(user.VerifyPassword(tbPassword.Text))
                    {
                        MainForm mainForm= new MainForm(user);
                        mainForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Uživatel neexistuje!");
                }
            }
            else
            {
                MessageBox.Show("Nevyplnil jste heslo nebo uživatelské jméno!");
            }
        }

        /*private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbPassword.Text != "")
            {
                sqlRepository.Register(tbUserName.Text, tbPassword.Text);
            }
            else
            {
                MessageBox.Show("Nevyplnil jste heslo nebo uživatelské jméno!");
            }
        }*/
    }
}

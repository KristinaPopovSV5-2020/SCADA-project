﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScadaModel;

namespace DatabaseManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.error.Text = "Wrong username or password";
            this.error.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User zor = new User("zorica", "sifra123");
            User masa = new User("pera", "sifra123");
            List<User> users = new List<User>();
            users.Add(zor);
            users.Add(masa);
            

            foreach (User u in users)
            {
                if (u.username == username.Text && u.password == password.Text && username.Text == "pera") { 
                    DbManagerForm newForm = new DbManagerForm();
                    newForm.Show();
                }
                else
                {
                    this.error.Visible = true;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

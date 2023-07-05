using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<User> users = new List<User>();
            //ovde treba dodati ucitane korisnike

            if (usernameRegister.Text == "" ||  passwordRegister.Text == "" || confirmPasswordRegister.Text == "")
            {
                this.errorRegister.Text = "Fill in all the fields";

            }else if (passwordRegister.Text != confirmPasswordRegister.Text)
            {
                this.errorRegister.Text = "Passwords do not match!";
            }
            this.errorRegister.Text = "";


            foreach (User u in users)
            {
                if (u.username == usernameRegister.Text)
                {
                    this.errorRegister.Text = "User already exist!";
                }
                
            }
            this.errorRegister.Text = "";

            User user = new User(usernameRegister.Text, passwordRegister.Text);
            //ovde treba dodati ovo u onu ucitanu listu
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace DatabaseManager
{
    public partial class Login : Form
    {
        static ServiceReference1.DbManagerClient service = new ServiceReference1.DbManagerClient();
        public Login()
        {
            InitializeComponent();
            this.error.Text = "Wrong username or password";
            this.error.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            List<User> users = service.GetAllUsers();
            bool userFound = false;


            foreach (User u in users)
            {
                if (u.username == username.Text && u.password == password.Text && username.Text == "pera")
                {
                    DbManagerForm newForm = new DbManagerForm();
                    userFound = true;
                    newForm.Show();
                }
                
            }
            if(!userFound)
            {
                this.error.Visible = true;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool saved = service.Register(username.Text, password.Text);
            
        }
    }
}

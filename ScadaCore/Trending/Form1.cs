using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trending
{
    public partial class Form1 : Form
    {
        static ServiceReference1.DbManagerClient service = new ServiceReference1.DbManagerClient();
        public Form1()
        {
            InitializeComponent();
            this.error.Text = "Wrong username or password";
            this.error.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            List<User> users = service.GetAllUsers();
            bool userFound = false;

            foreach (User u in users)
            {
                if (u.username == username.Text && u.password == password.Text && username.Text != "pera")
                {
                    TrendingForm newForm = new TrendingForm();
                    userFound = true;
                    newForm.Show();
                }
                
            }
            if(!userFound)
            {
                this.error.Visible = true;
            }
        }
    }
}
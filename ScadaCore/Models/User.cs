using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class User
    {
        public string username;
        public string password;
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
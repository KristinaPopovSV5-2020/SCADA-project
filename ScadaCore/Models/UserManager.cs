using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Models
{
    public class UserManager
    {
        public List<User> users;

        public UserManager()
        {
            LoadUsersFromFile();
        }

        public void LoadUsersFromFile()
        {
            users = new List<User>();
            string[] lines = File.ReadAllLines("../Database/users.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                users.Add(new User(parts[0], parts[1]));
            }
        }


        public void SaveUsersToFile()
        {
            using (StreamWriter writer = new StreamWriter("..Database/users.txt"))
            {
                foreach (User user in users)
                {
                    writer.WriteLine(user.username + "|" + user.password);
                }
            }
        }

    }
}
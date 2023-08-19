using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string username;
        [DataMember]
        public string password;
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
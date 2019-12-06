using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaetStore
{
    public class User
    {
        string username;
        string password;
        string salt;



        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Salt { get => salt; set => salt = value; }
    }
}
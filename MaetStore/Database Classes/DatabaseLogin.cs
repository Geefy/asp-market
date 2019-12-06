using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaetStore.Database_Classes
{
    public class DatabaseLogin
    {
        DatabaseCon db = new DatabaseCon();
        Encryption encrypt = new Encryption();

        public bool Login(string username, string password)
        {
            User user = db.GetUser(username);
            string hashedPassword = encrypt.MD5Hash(password, user.Salt);

            if (hashedPassword == user.Password)
            {

                return true;
            }

            return false;

        }

        public void Register(string username, string password)
        {
            User user = new User();
            user.Username = username;
            user.Salt = encrypt.GetSalt();
            user.Password = encrypt.MD5Hash(password, user.Salt);

            db.CheckUser(user);



        }
    }
}
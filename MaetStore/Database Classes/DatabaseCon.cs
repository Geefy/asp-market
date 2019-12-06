using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MaetStore.Database_Classes
{
    public class DatabaseCon
    {
        static SqlConnection dbCon = new SqlConnection("Server=ZBC-EMA-1617;Database=MaetMarket;Trusted_Connection=True");
        SqlDataReader reader;
        public User GetUser(string username)
        {


            User user = new User();
            try
            {
                dbCon.Open();

                SqlCommand cmd = new SqlCommand("Select * from Users WHERE username = @username", dbCon);
                cmd.Parameters.AddWithValue("@username", username);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user.Username = reader["username"].ToString();
                    user.Password = reader["pass"].ToString();
                    user.Salt = reader["salt"].ToString();
                }

                dbCon.Close();

                return user;
            }


            catch (Exception)
            {
                dbCon.Close();
                return user;
            }





        }
        public void CreateUser(User user)
        {

            try
            {
                dbCon.Open();

                SqlCommand cmd = new SqlCommand("Insert into Users([username], [pass], [salt]) values (@username, @pass, @salt)", dbCon);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@pass", user.Password);
                cmd.Parameters.AddWithValue("@salt", user.Salt);

                cmd.ExecuteNonQuery();
                dbCon.Close();
            }

            catch (Exception)
            {

                dbCon.Close();
                return;
            }


        }

        public void CheckUser(User newUser)
        {
            User existingUser = new User();
            try
            {
                existingUser = GetUser(newUser.Username);
                if (existingUser.Username != newUser.Username)
                {
                    CreateUser(newUser);
                }

            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
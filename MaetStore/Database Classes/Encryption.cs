using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace MaetStore.Database_Classes
{
    public class Encryption
    {
        private string salt;
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        public string Salt { get => salt; set => salt = value; }

        public string GetSalt()
        {

            byte[] buffer = new byte[24];

            rng.GetBytes(buffer);
            Salt = BitConverter.ToString(buffer);
            return Salt;
         }

        public string MD5Hash(string text, string userSalt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string hashText = text + userSalt;
            md5.ComputeHash(Encoding.ASCII.GetBytes(hashText));

            byte[] result = md5.Hash;

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                builder.Append(result[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
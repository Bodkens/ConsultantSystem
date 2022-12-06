using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace DataLayer
{
    public class PasswordEncryptor
    {
        //MD5 Hash password Encryption
        public static string Encrypt(string text)
        {
            StringBuilder hash = new StringBuilder();
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(new UTF8Encoding().GetBytes(text));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}

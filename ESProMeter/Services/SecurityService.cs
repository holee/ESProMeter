using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Services
{
    public  class SecurityService
    {
        public static string TextEncrypt(string input)
        {
            // step 1, calculate MD5 hash from input

            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString());
            }
            return sb.ToString();
        }

        public static bool Verify(string input,string hash)
        {
            return TextEncrypt(input).Equals(hash);
        }

    }
}

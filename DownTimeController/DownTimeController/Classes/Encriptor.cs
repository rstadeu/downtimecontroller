using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Security.Cryptography;

namespace DownTimeController.Classes
{
    class Encriptor
    {
        private static string key = "rcwy19!#%@$*&()R#ESFGHJMNBV)(*&¨$%¨¨¨&#@!¨%$)(*&$%#$#@!#$%%";
        /// <summary>
        /// This method encrypt a string using a known key to do that 
        /// </summary>
        /// <param name="password">The string set as password and need to be codificade before you save it anywere</param>
        /// <returns>return the string encrypted</returns>
        public string stringEncryptor(string password)
        {
            TripleDESCryptoServiceProvider TDC = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] hash, text;

            hash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            text = ASCIIEncoding.ASCII.GetBytes(password);

            md5.Clear();

            TDC.Key = hash;

            TDC.Mode = CipherMode.ECB;

            return Convert.ToBase64String(TDC.CreateEncryptor().TransformFinalBlock(text, 0, text.Length));
        }


        /// <summary>
        /// Descrypt a string encrypted using stringEncrypt Method
        /// </summary>
        /// <param name="password">String to be decrypted</param>
        /// <returns></returns>
        public string stringDecryptor(string password)
        {
            TripleDESCryptoServiceProvider TDC = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] hash, text;

            hash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            text = Convert.FromBase64String(password);

            md5.Clear();

            TDC.Key = hash;

            TDC.Mode = CipherMode.ECB;

            return ASCIIEncoding.ASCII.GetString(TDC.CreateDecryptor().TransformFinalBlock(text, 0, text.Length));
        }

        internal object stringEncryptor()
        {
            throw new NotImplementedException();
        }
    }
}

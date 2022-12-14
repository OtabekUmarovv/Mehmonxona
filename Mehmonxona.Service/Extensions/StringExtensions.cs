using System;
using System.Security.Cryptography;
using System.Text;

namespace Mehmonxona.Service.Extensions
{
    public static class StringExtensions
    {
        public static string HashPassword(this string password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] sourceBytes = Encoding.UTF32.GetBytes(password);

                byte[] hashBytes = md5Hash.ComputeHash(sourceBytes);

                return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
        }
    }
}

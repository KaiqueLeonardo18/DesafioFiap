using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public static class Hash
    {
        public static string MontarHash(string senha)
        {
            byte[] salt = GerarSalt();

            byte[] hashedPassword = HashPassword(senha, salt);

            return Convert.ToBase64String(hashedPassword);
        }

        public static byte[] GerarSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        public static byte[] HashPassword(string senha, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] senhaBytes = Encoding.UTF8.GetBytes(senha);
                byte[] senhaComSalt = new byte[senhaBytes.Length + salt.Length];
                Array.Copy(senhaBytes, senhaComSalt, senhaBytes.Length);
                Array.Copy(salt, 0, senhaComSalt, senhaBytes.Length, salt.Length);

                return sha256.ComputeHash(senhaComSalt);
            }
        }
    }
}

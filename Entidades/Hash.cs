using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hash
    {
        public static string GetHash(string password)
        {
            //var salt = BCrypt.Net.BCrypt.GenerateSalt(13);

            //var hash1 = BCrypt.Net.BCrypt.HashPassword(input, salt);

            var hash2 = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);

            return hash2;
        }

        public static bool ValidatePassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hash);
        }
    }
}

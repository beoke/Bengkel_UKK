using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengkel_UKK
{
        public class PasswordHash
        {
            public enum StrengthArgon
            {
                Interactive = 2,
                Moderate = 3,
                Secure = 4
            }

            public static string ArgonHashString(string password, StrengthArgon strength)
            {
                using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password)))
                {
                    argon2.Salt = Encoding.UTF8.GetBytes("somesaltvalue");
                    argon2.DegreeOfParallelism = 4;
                    argon2.MemorySize = 65536;
                    argon2.Iterations = (int)strength;

                    return Convert.ToBase64String(argon2.GetBytes(16));
                }
            }
            public static bool ArgonHashStringVerify(string hash, string password)
            {
                string hashedPassword = ArgonHashString(password, StrengthArgon.Secure);
                return hash == hashedPassword;
            }   

    }
}

using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ShuftiPro.Utils
{
    public static class ShuftiProUtils
    {
        public static string Sha256Hash(string value)
        {
            using (var hash = SHA256.Create())
            {
                var bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(value));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }
    }
}
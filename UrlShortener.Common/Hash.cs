
using System.Security.Cryptography;
using System.Text;

namespace UrlShortener.Common
{
    public class Hash
    {
        public static string GetSha256HashString(string rawData)
        {
            if (string.IsNullOrEmpty(rawData))
                return string.Empty;

            // ComputeHash - returns byte array  
            byte[] bytes = GetSha256Hash(rawData);

            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
                builder.Append(bytes[i].ToString("x2"));

            return builder.ToString();
        }
        public static byte[] GetSha256Hash(string rawData)
        {
            if (string.IsNullOrEmpty(rawData))
                return null;

            using (SHA256 sha256Hash = SHA256.Create())
                return sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
        }
    }
}

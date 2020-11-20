using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Common;

namespace UrlShortener.Domain
{
    public class Link
    {
        public string URL { get; set; }
        public string ComputeShortenedUrl()
        {
            var hashed = Hash.GetSha256Hash(URL);

            if (hashed != null)
            {
                var base64 = Convert.ToBase64String(hashed);

                /*
                 * Accordingly to https://www.educative.io/courses/grokking-the-system-design-interview/m2ygV4E81AR article
                 * Using base64 encoding for SHA256 hashing mechanism strings, 
                 * a 6 letters long key would result in 64 ^ 6 = ~68.7 billion possible strings.
                 * I believe this will be enought for our requirements
                */

                return base64.Substring(0, 6);
            }

            return string.Empty;
        }
    }
}

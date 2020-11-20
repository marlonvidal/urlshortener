using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;
using UrlShortener.Common;

namespace UrlShortener.Domain
{
    public class Link
    {
        public string URL { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ComputeShortenedUrl()
        {
            var hashed = Hash.GetSha256Hash(URL);
            return Convert.ToBase64String(hashed);
        }
    }
}

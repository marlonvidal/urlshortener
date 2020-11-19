using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace UrlShortener.Domain
{
    public class Link
    {
        public string URL { get; set; }

        public DateTime CreatedDate { get; set; }

        public string GetUrlHash()
        {
            return "";
        }
    }
}

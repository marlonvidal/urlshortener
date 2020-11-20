using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace UrlShortener.Model
{
    public class Link : EntityBase
    {
        public string URL { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

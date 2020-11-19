using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UrlShortener.Domain
{
    public abstract class EntityBase
    {
        [Key]
        public int ID { get; set; }
    }
}

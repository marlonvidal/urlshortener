﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UrlShortener.Model
{
    public abstract class EntityBase
    {
        [Key]
        public int ID { get; set; }
    }
}

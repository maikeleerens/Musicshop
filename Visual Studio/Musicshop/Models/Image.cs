﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicshop.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public Product Product { get; set; }
    }
}

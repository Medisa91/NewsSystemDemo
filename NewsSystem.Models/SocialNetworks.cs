﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Models
{
    public class SocialNetwork
    {
        public int Id { get; set; }
        public string SnName { get; set; }
        public string SnUrl { get; set; }
        //Relations - Navigation Properties
        public virtual ICollection<MediaFile> Media { get; set; }
    }
}

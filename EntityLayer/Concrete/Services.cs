﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Services
    {
        [Key]
        public int ServicesID { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
    }
}

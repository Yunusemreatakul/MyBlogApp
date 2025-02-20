﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Domain.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

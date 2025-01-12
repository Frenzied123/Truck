﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckData.Data.Entities
{
    internal class Driver
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string DriverPassword { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}

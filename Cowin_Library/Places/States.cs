﻿using System.ComponentModel.DataAnnotations;

namespace Cowin_Library.Users
{
    public class States
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}

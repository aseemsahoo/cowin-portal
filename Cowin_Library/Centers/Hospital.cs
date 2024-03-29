﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cowin_Library.Users
{
    public class Hospital
    {
        [Browsable(false)]
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string vaccine { get; set; }
    }
}
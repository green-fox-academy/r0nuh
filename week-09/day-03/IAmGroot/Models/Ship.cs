﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmGroot.Models
{
    public class Ship
    {
        public int Caliber25 { get; set; }
        public int Caliber30 { get; set; }
        public int Caliber50 { get; set; }
        public string Shipstatus { get; set; } = "empty";
        public bool Ready { get; set; } = false;
    }
}

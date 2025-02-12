﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWProject
{
    public class Droid : BaseEntity
    {
        public string? Model { get; set; }
        public Base? Base { get; set; }
        public int? BaseId { get; set; }
        public BaseFleet? Fleet { get; set; }
        public int FleetId { get; set; }
        public string? Equipment { get; set; }
    }
}

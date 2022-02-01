﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWProject
{
    public class Base : BaseEntity
    {
        public BaseFleet? AttachedFleet { get; set; }
        public List<Droid>? DroidList { get; set; }
        public List<Clone>? CloneList { get; set; }
        public Supply? AmmoSupply { get; set; }
        
    }
}
﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Usa.chili.Domain
{
    public partial class MobileusaPublicPerf
    {
        [Key]
        public DateTime CollectTs { get; set; }
        public DateTime ArriveTs { get; set; }
    }
}

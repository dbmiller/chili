﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Usa.chili.Domain
{
    public partial class BayminettePublicPerf
    {
        [Key]
        public DateTime CollectTs { get; set; }
        public DateTime ArriveTs { get; set; }
    }
}

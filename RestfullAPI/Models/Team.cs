﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfullAPI.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int PMID { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;

namespace RazorPagesVizyoneks2.Models
{
    public partial class Territories
    {
        public Territories()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
        }

        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public Region Region { get; set; }
        public ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}

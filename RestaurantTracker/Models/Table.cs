﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int WaiterId { get; set; }

        public Waiter waiter { get; set; }
    }
}

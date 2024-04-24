﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDomain
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ?Status { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal interface IOrderable
    {
        public void PlaceOrder();
        public void ProcessPayment();
        public void DeliveryOrder();
    }
}

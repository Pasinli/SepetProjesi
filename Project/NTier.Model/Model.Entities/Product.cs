﻿using NTier.Core.Core.Entity;
using System;
using System.Collections.Generic;

namespace NTier.Model.Model.Entities
{
    public class Product:CoreEntity
    {
        public Product()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public decimal Price { get; set; }
        public short UnitsInStock { get; set; }
        public string Quantity { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
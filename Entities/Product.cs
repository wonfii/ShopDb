﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_ShopDb.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public float Discount { get; set; }


        public Category? Category { get; set; }
        public int? CategoryId { get; set; }


        public int Quantity { get; set; }
        public bool IsInStock { get; set; }
    }
}

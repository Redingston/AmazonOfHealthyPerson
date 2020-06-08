using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class BasketToProduct
    {
        public long BasketId { get; set; }
        public Basket Basket { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}

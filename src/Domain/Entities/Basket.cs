using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Basket
    {
        public Basket()
        {
            Products = new HashSet<BasketToProduct>();
        }
        public long Id { get; set; }
        public decimal ToPay { get; set; }
        public Order Order { get; set; }
        public ICollection<BasketToProduct> Products { get; set; }
    }
}

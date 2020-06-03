using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Basket
    {
        public Basket()
        {
            Products = new HashSet<Product>();
        }
        public long Id { get; set; }
        public decimal ToPay { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

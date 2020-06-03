using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Order
    {
        public long Id { get; set; }

        public long BasketId { get; set; }
        public Basket Basket { get; set; }

        public long PaymentId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public long ShippingId { get; set; }
        public ShippingFirm ShippingFirm { get; set; }

        public long ClientId { get; set; }
        public User User { get; set; }
    }
}

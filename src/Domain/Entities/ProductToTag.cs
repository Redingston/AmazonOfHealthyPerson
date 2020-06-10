using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ProductToTag
    {
        public long TagId { get; set; }
        public PTag Tag { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}

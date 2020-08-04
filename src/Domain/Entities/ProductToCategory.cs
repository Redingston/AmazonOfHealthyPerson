using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ProductToCategory
    {
        public long CategoryId { get; set; }
        public PCategory Category { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}

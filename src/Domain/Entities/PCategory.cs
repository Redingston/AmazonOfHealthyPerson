using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PCategory
    {
        public PCategory()
        {
            Products = new HashSet<ProductToCategory>();
        }
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductToCategory> Products { get; set; }
    }
}
